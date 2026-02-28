using AutoMapper;
using ZenOS.DAL.Models;
using ZenOS.MB;

namespace ZenOS.Util
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<Appointment, AppointmentModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.AppointmentCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 3 field)
            CreateMap<ApprovalAction, ApprovalActionModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 3 field)
            CreateMap<ApprovalFlow, ApprovalFlowModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 3 field)
            CreateMap<ApprovalRequest, ApprovalRequestModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 3 field)
            CreateMap<ApprovalStep, ApprovalStepModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 3 field)
            CreateMap<ApprovalStepAssignment, ApprovalStepAssignmentModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<CatContractType, CatContractTypeModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.ContractTypeCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<CatCountry, CatCountryModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CountryCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<CatDepartment, CatDepartmentModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.DepartmentCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<CatIngredientCategory, CatIngredientCategoryModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IngredientCateCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<CatJobTitle, CatJobTitleModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.JobTitleCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<CatLeaveType, CatLeaveTypeModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.LeaveTypeCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<CatMembershipLevel, CatMembershipLevelModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.LevelCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<CatProductCategory, CatProductCategoryModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.ProductCateCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<CatProvince, CatProvinceModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.ProvinceCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<CatSupplierCategory, CatSupplierCategoryModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.SupplierCateCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<CatUnit, CatUnitModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.UnitCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<CatWard, CatWardModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.WardCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<Combo, ComboModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.ComboCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 3 field)
            CreateMap<ComboItem, ComboItemModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<Contract, ContractModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.ContractCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<Customer, CustomerModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CustomerCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<Employee, EmployeeModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.EmployeeCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<Ingredient, IngredientModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IngredientCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 3 field)
            CreateMap<InventoryStock, InventoryStockModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 3 field)
            CreateMap<InventoryTransaction, InventoryTransactionModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<Invoice, InvoiceModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.InvoiceCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<LeaveRequest, LeaveRequestModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.LeaveRequestCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 3 field)
            CreateMap<MailHistory, MailHistoryModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<MailTemplate, MailTemplateModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.MailTemplateCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 3 field)
            CreateMap<NotificationHistory, NotificationHistoryModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<NotificationTemplate, NotificationTemplateModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.NotificationTemplateCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<Order, OrderModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.OrderCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 3 field)
            CreateMap<OrderItem, OrderItemModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 3 field)
            CreateMap<OrderItemTopping, OrderItemToppingModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 3 field)
            CreateMap<Payment, PaymentModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<Payroll, PayrollModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.PayrollCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 3 field)
            CreateMap<PayrollItem, PayrollItemModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<Product, ProductModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.ProductCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<Promotion, PromotionModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.PromotionCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<PurchaseOrder, PurchaseOrderModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.PurchaseOrderCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 3 field)
            CreateMap<PurchaseOrderItem, PurchaseOrderItemModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<Recipe, RecipeModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.RecipeCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 3 field)
            CreateMap<RecipeItem, RecipeItemModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 3 field)
            CreateMap<Refund, RefundModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<Role, RoleModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.RoleCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<RolePermission, RolePermissionModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.PermissionCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<Roster, RosterModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.RosterCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<SalaryStructure, SalaryStructureModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.StructureCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<Shift, ShiftModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.ShiftCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<Store, StoreModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.StoreCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<StoreSetting, StoreSettingModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.StoreSettingCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<Supplier, SupplierModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.SupplierCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<SystemSetting, SystemSettingModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.SystemSettingCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 3 field)
            CreateMap<TimeLog, TimeLogModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<Topping, ToppingModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.ToppingCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 4 field)
            CreateMap<User, UserModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.UserCode, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));

            // Khi cập nhật (map từ model → entity nhưng bỏ 3 field)
            CreateMap<UserRole, UserRoleModel>().ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.CreatedAt, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true))
                .ForMember(dest => dest.IsDelete, opt => opt.Condition((src, dest, srcMember, destMember, context) => !context.Items.TryGetValue("IgnoreAuditFields", out var ignore) || ignore is not true));
        }
    }
}
