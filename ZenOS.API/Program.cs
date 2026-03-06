using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using ZenOS.BLL.Interfaces;
using ZenOS.BLL.Services;
using ZenOS.DAL.Models;
using ZenOS.Util;

var builder = WebApplication.CreateBuilder(args);

#region DI & Database

#region DI

builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IAppointmentService, AppointmentService>();
builder.Services.AddScoped<IApprovalActionService, ApprovalActionService>();
builder.Services.AddScoped<IApprovalFlowService, ApprovalFlowService>();
builder.Services.AddScoped<IApprovalRequestService, ApprovalRequestService>();
builder.Services.AddScoped<IApprovalStepService, ApprovalStepService>();
builder.Services.AddScoped<IApprovalStepAssignmentService, ApprovalStepAssignmentService>();
builder.Services.AddScoped<ICurrentUserService, CurrentUserService>();
builder.Services.AddScoped<ICatContractTypeService, CatContractTypeService>();
builder.Services.AddScoped<ICatCountryService, CatCountryService>();
builder.Services.AddScoped<ICatDepartmentService, CatDepartmentService>();
builder.Services.AddScoped<ICatIngredientCategoryService, CatIngredientCategoryService>();
builder.Services.AddScoped<ICatJobTitleService, CatJobTitleService>();
builder.Services.AddScoped<ICatLeaveTypeService, CatLeaveTypeService>();
builder.Services.AddScoped<ICatMembershipLevelService, CatMembershipLevelService>();
builder.Services.AddScoped<ICatProductCategoryService, CatProductCategoryService>();
builder.Services.AddScoped<ICatProvinceService, CatProvinceService>();
builder.Services.AddScoped<ICatSupplierCategoryService, CatSupplierCategoryService>();
builder.Services.AddScoped<ICatUnitService, CatUnitService>();
builder.Services.AddScoped<ICatWardService, CatWardService>();
builder.Services.AddScoped<ICodeSequenceService, CodeSequenceService>();
builder.Services.AddScoped<IComboService, ComboService>();
builder.Services.AddScoped<IComboItemService, ComboItemService>();
builder.Services.AddScoped<IContractService, ContractService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IIngredientService, IngredientService>();
builder.Services.AddScoped<IInventoryStockService, InventoryStockService>();
builder.Services.AddScoped<IInventoryTransactionService, InventoryTransactionService>();
builder.Services.AddScoped<IInvoiceService, InvoiceService>();
builder.Services.AddScoped<ILeaveRequestService, LeaveRequestService>();
builder.Services.AddScoped<IMailHistoryService, MailHistoryService>();
builder.Services.AddScoped<IMailTemplateService, MailTemplateService>();
builder.Services.AddScoped<INotificationHistoryService, NotificationHistoryService>();
builder.Services.AddScoped<INotificationTemplateService, NotificationTemplateService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderItemService, OrderItemService>();
builder.Services.AddScoped<IOrderItemToppingService, OrderItemToppingService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddScoped<IPayrollService, PayrollService>();
builder.Services.AddScoped<IPayrollItemService, PayrollItemService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IPromotionService, PromotionService>();
builder.Services.AddScoped<IPurchaseOrderService, PurchaseOrderService>();
builder.Services.AddScoped<IPurchaseOrderItemService, PurchaseOrderItemService>();
builder.Services.AddScoped<IRecipeService, RecipeService>();
builder.Services.AddScoped<IRecipeItemService, RecipeItemService>();
builder.Services.AddScoped<IRefundService, RefundService>();
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<IRolePermissionService, RolePermissionService>();
builder.Services.AddScoped<IRosterService, RosterService>();
builder.Services.AddScoped<ISalaryStructureService, SalaryStructureService>();
builder.Services.AddScoped<IShiftService, ShiftService>();
builder.Services.AddScoped<IStoreService, StoreService>();
builder.Services.AddScoped<IStoreSettingService, StoreSettingService>();
builder.Services.AddScoped<ISupplierService, SupplierService>();
builder.Services.AddScoped<ISystemSettingService, SystemSettingService>();
builder.Services.AddScoped<ITableService, TableService>();
builder.Services.AddScoped<ITimeLogService, TimeLogService>();
builder.Services.AddScoped<IToppingService, ToppingService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRoleService, UserRoleService>();
builder.Services.AddScoped<DevUserSeeder>();

#endregion

// Cung cấp khả năng truy cập thông tin HTTP Context
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddSingleton<MailHelpers>(new MailHelpers(builder.Configuration));

// Cấu hình kết nối cơ sở dữ liệu SQL Server thông qua Entity Framework Core
builder.Services.AddDbContext<ZenOsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString(Constants.Context)));

#endregion

#region Base

// Cấu hình chính sách CORS: Cho phép các ứng dụng Frontend từ danh sách origins cụ thể
builder.Services.AddCors(p => p.AddPolicy("FrontendCorsPolicy", build =>
{
    build.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
}));

// Cấu hình giới hạn kích thước dữ liệu gửi lên (Body Size) cho Multipart (thường là Upload file)
builder.Services.Configure<FormOptions>(options =>
{
    options.MultipartBodyLengthLimit = 209715200; // 200 MB
});

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

// Cấu hình giới hạn kích thước nhận dữ liệu ở tầng Web Server (Kestrel)
builder.WebHost.ConfigureKestrel(options =>
{
    options.Limits.MaxRequestBodySize = 209715200; // 200 MB
});

// Thiết lập hệ thống nạp cấu hình đa tầng cho ứng dụng
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();

#endregion

#region JWT Auth + Swagger

// Cấu hình bộ tạo tài liệu Swagger (Swagger Generator)
builder.Services.AddSwaggerGen(options =>
{
    // 1. Định nghĩa thông tin cơ bản của tài liệu API
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "ZenOS Solution API Swagger", Version = "v1" });

    // 2. Cấu hình định nghĩa cơ chế bảo mật (Security Scheme)
    var scheme = new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Nhập mã JWT Access Token để xác thực hệ thống.\n\n" +
                      "**Lưu ý:**\n" +
                      "- Chỉ nhập chuỗi Token (Ví dụ: `eyJhbGci...`)\n" +
                      "- **KHÔNG** gõ thêm chữ 'Bearer' ở phía trước (hệ thống tự thêm).\n\n"
    };

    // Đăng ký định nghĩa trên vào Swagger với ID là "Bearer"
    options.AddSecurityDefinition("Bearer", scheme);

    // 3. Thiết lập yêu cầu bảo mật (Security Requirement) cho toàn bộ API
    // Trong Microsoft.OpenApi 3.x, AddSecurityRequirement yêu cầu một Lambda (doc => ...)
    options.AddSecurityRequirement(doc =>
    {
        // Tạo một tham chiếu (Reference) tới định nghĩa "Bearer" đã tạo ở bước 2
        // 'doc' giúp tham chiếu này liên kết đúng với cấu trúc của toàn bộ tài liệu OpenAPI
        var schemeReference = new OpenApiSecuritySchemeReference("Bearer", doc);

        return new OpenApiSecurityRequirement
        {
            {
                schemeReference, // Khóa là đối tượng tham chiếu (Reference)
                new List<string>()
            }
        };
    });

    // 4. Loại bỏ các Navigation Property (toàn hệ thống)
    options.SchemaFilter<HideNavigationPropertiesSchemaFilter>();
});

string issuer = builder.Configuration.GetValue<string>("Tokens:Issuer");
string signingKey = builder.Configuration.GetValue<string>("Tokens:Key");
byte[] signingKeyBytes = System.Text.Encoding.UTF8.GetBytes(signingKey);

// Cấu hình hệ thống xác thực (Authentication)
builder.Services.AddAuthentication(opt =>
{
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
// Cấu hình chi tiết các quy tắc kiểm tra Token
.AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidIssuer = issuer,
        ValidateAudience = true,
        ValidAudience = issuer,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ClockSkew = System.TimeSpan.Zero,
        IssuerSigningKey = new SymmetricSecurityKey(signingKeyBytes)
    };
});

// Cấu hình các thiết lập cho hệ thống định danh (Identity)
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 8;
    options.Password.RequiredUniqueChars = 5;
});

#endregion

#region Packages

// Cấu hình AutoMapper bằng cách đăng ký trực tiếp lớp MappingProfiles vào hệ thống Dependency Injection.
builder.Services.AddAutoMapper(cfg => cfg.AddProfile<MappingProfiles>());

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI();

    // Tạo user mặc định cho dev
    using (var scope = app.Services.CreateScope())
    {
        var seeder = scope.ServiceProvider.GetRequiredService<DevUserSeeder>();
        seeder.Seed();
    }
}

var mapper = app.Services.GetRequiredService<IMapper>();
DataHelpers.ConfigureMapper(mapper);

app.UseAuthentication();// 🔑 Xác thực

app.UseHttpsRedirection();// 🔐 Chuyển hướng HTTPS

app.UseCors("FrontendCorsPolicy");// 🌐 CORS cho phép truy cập từ frontend

app.UseAuthorization();// 🔐 Phân quyền

app.MapControllers();

app.Run();
