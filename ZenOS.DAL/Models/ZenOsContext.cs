using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class ZenOsContext : DbContext
{
    public ZenOsContext()
    {
    }

    public ZenOsContext(DbContextOptions<ZenOsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<ApprovalAction> ApprovalActions { get; set; }

    public virtual DbSet<ApprovalFlow> ApprovalFlows { get; set; }

    public virtual DbSet<ApprovalRequest> ApprovalRequests { get; set; }

    public virtual DbSet<ApprovalStep> ApprovalSteps { get; set; }

    public virtual DbSet<ApprovalStepAssignment> ApprovalStepAssignments { get; set; }

    public virtual DbSet<CatContractType> CatContractTypes { get; set; }

    public virtual DbSet<CatCountry> CatCountries { get; set; }

    public virtual DbSet<CatDepartment> CatDepartments { get; set; }

    public virtual DbSet<CatIngredientCategory> CatIngredientCategories { get; set; }

    public virtual DbSet<CatJobTitle> CatJobTitles { get; set; }

    public virtual DbSet<CatLeaveType> CatLeaveTypes { get; set; }

    public virtual DbSet<CatMembershipLevel> CatMembershipLevels { get; set; }

    public virtual DbSet<CatProductCategory> CatProductCategories { get; set; }

    public virtual DbSet<CatProvince> CatProvinces { get; set; }

    public virtual DbSet<CatSupplierCategory> CatSupplierCategories { get; set; }

    public virtual DbSet<CatUnit> CatUnits { get; set; }

    public virtual DbSet<CatWard> CatWards { get; set; }

    public virtual DbSet<CodeSequence> CodeSequences { get; set; }

    public virtual DbSet<Combo> Combos { get; set; }

    public virtual DbSet<ComboItem> ComboItems { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Ingredient> Ingredients { get; set; }

    public virtual DbSet<InventoryStock> InventoryStocks { get; set; }

    public virtual DbSet<InventoryTransaction> InventoryTransactions { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<LeaveRequest> LeaveRequests { get; set; }

    public virtual DbSet<MailHistory> MailHistories { get; set; }

    public virtual DbSet<MailTemplate> MailTemplates { get; set; }

    public virtual DbSet<NotificationHistory> NotificationHistories { get; set; }

    public virtual DbSet<NotificationTemplate> NotificationTemplates { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<OrderItemTopping> OrderItemToppings { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Payroll> Payrolls { get; set; }

    public virtual DbSet<PayrollItem> PayrollItems { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Promotion> Promotions { get; set; }

    public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }

    public virtual DbSet<PurchaseOrderItem> PurchaseOrderItems { get; set; }

    public virtual DbSet<Recipe> Recipes { get; set; }

    public virtual DbSet<RecipeItem> RecipeItems { get; set; }

    public virtual DbSet<Refund> Refunds { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RolePermission> RolePermissions { get; set; }

    public virtual DbSet<Roster> Rosters { get; set; }

    public virtual DbSet<SalaryStructure> SalaryStructures { get; set; }

    public virtual DbSet<Shift> Shifts { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<StoreSetting> StoreSettings { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<SystemSetting> SystemSettings { get; set; }

    public virtual DbSet<Table> Tables { get; set; }

    public virtual DbSet<TimeLog> TimeLogs { get; set; }

    public virtual DbSet<Topping> Toppings { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ASUS;Initial Catalog=ZenOS;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Customer).WithMany(p => p.Appointments).HasConstraintName("FK_Appointments_Customers");

            entity.HasOne(d => d.Employee).WithMany(p => p.Appointments).HasConstraintName("FK_Appointments_Employees");

            entity.HasOne(d => d.Store).WithMany(p => p.Appointments).HasConstraintName("FK_Appointments_Stores");
        });

        modelBuilder.Entity<ApprovalAction>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.ActionBy).WithMany(p => p.ApprovalActions).HasConstraintName("FK_ApprovalActions_Employees");

            entity.HasOne(d => d.ApprovalRequest).WithMany(p => p.ApprovalActions).HasConstraintName("FK_ApprovalActions_ApprovalRequests");

            entity.HasOne(d => d.ApprovalStep).WithMany(p => p.ApprovalActions).HasConstraintName("FK_ApprovalActions_ApprovalSteps");
        });

        modelBuilder.Entity<ApprovalFlow>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Store).WithMany(p => p.ApprovalFlows).HasConstraintName("FK_ApprovalFlows_Stores");
        });

        modelBuilder.Entity<ApprovalRequest>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.ApprovalFlow).WithMany(p => p.ApprovalRequests).HasConstraintName("FK_ApprovalRequests_ApprovalFlows");

            entity.HasOne(d => d.RequestedBy).WithMany(p => p.ApprovalRequests).HasConstraintName("FK_ApprovalRequests_Employees");
        });

        modelBuilder.Entity<ApprovalStep>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.ApprovalFlow).WithMany(p => p.ApprovalSteps).HasConstraintName("FK_ApprovalSteps_ApprovalFlows");
        });

        modelBuilder.Entity<ApprovalStepAssignment>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.ApprovalRequest).WithMany(p => p.ApprovalStepAssignments).HasConstraintName("FK_ApprovalStepAssignments_ApprovalRequests");

            entity.HasOne(d => d.ApprovalStep).WithMany(p => p.ApprovalStepAssignments).HasConstraintName("FK_ApprovalStepAssignments_ApprovalSteps");

            entity.HasOne(d => d.Approver).WithMany(p => p.ApprovalStepAssignmentApprovers).HasConstraintName("FK_ApprovalStepAssignments_Employees");

            entity.HasOne(d => d.DelegatedFrom).WithMany(p => p.ApprovalStepAssignmentDelegatedFroms).HasConstraintName("FK_ApprovalStepAssignments_Employees1");
        });

        modelBuilder.Entity<CatContractType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<CatCountry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Countries");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<CatDepartment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DepartmentCategories");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<CatIngredientCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_IngredientCategories");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<CatJobTitle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_JobTitleCategories");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<CatLeaveType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_LeaveTypes");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<CatMembershipLevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MembershipLevels");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<CatProductCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ProductCategories");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<CatProvince>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Provinces");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.CountryCat).WithMany(p => p.CatProvinces).HasConstraintName("FK_Cat_Provinces_Cat_Countries");
        });

        modelBuilder.Entity<CatSupplierCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SupplierCategories");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<CatUnit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Units");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<CatWard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Wards");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.ProvinceCat).WithMany(p => p.CatWards).HasConstraintName("FK_Cat_Wards_Cat_Provinces");
        });

        modelBuilder.Entity<CodeSequence>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Combo>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Store).WithMany(p => p.Combos).HasConstraintName("FK_Combos_Stores");
        });

        modelBuilder.Entity<ComboItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Combo).WithMany(p => p.ComboItems).HasConstraintName("FK_ComboItems_Combos");

            entity.HasOne(d => d.Product).WithMany(p => p.ComboItems).HasConstraintName("FK_ComboItems_Products");
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.ContractTypeCat).WithMany(p => p.Contracts).HasConstraintName("FK_Contracts_Cat_ ContractTypes");

            entity.HasOne(d => d.Employee).WithMany(p => p.Contracts).HasConstraintName("FK_Contracts_Employees");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.MembershipLevelCat).WithMany(p => p.Customers).HasConstraintName("FK_Customers_MembershipLevels");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.CountryCat).WithMany(p => p.Employees).HasConstraintName("FK_Employees_Cat_Countries");

            entity.HasOne(d => d.DepartmentCat).WithMany(p => p.Employees).HasConstraintName("FK_Employees_Cat_Department");

            entity.HasOne(d => d.JobTitleCat).WithMany(p => p.Employees).HasConstraintName("FK_Employees_Cat_JobTitle");

            entity.HasOne(d => d.ProvinceCat).WithMany(p => p.Employees).HasConstraintName("FK_Employees_Cat_Provinces");

            entity.HasOne(d => d.Store).WithMany(p => p.Employees).HasConstraintName("FK_Employees_Stores");

            entity.HasOne(d => d.WardCat).WithMany(p => p.Employees).HasConstraintName("FK_Employees_Cat_Wards");
        });

        modelBuilder.Entity<Ingredient>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IngredientCat).WithMany(p => p.Ingredients).HasConstraintName("FK_Ingredients_Cat_IngredientCategories");

            entity.HasOne(d => d.Store).WithMany(p => p.Ingredients).HasConstraintName("FK_Ingredients_Stores");

            entity.HasOne(d => d.UnitCat).WithMany(p => p.Ingredients).HasConstraintName("FK_Ingredients_Cat_Units");
        });

        modelBuilder.Entity<InventoryStock>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.RowVersion)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.Ingredient).WithMany(p => p.InventoryStocks).HasConstraintName("FK_InventoryStocks_Ingredients");

            entity.HasOne(d => d.Store).WithMany(p => p.InventoryStocks).HasConstraintName("FK_InventoryStocks_Stores");
        });

        modelBuilder.Entity<InventoryTransaction>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Ingredient).WithMany(p => p.InventoryTransactions).HasConstraintName("FK_InventoryTransactions_Ingredients");

            entity.HasOne(d => d.Store).WithMany(p => p.InventoryTransactions).HasConstraintName("FK_InventoryTransactions_Stores");
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Order).WithMany(p => p.Invoices).HasConstraintName("FK_Invoices_Orders");

            entity.HasOne(d => d.Store).WithMany(p => p.Invoices).HasConstraintName("FK_Invoices_Stores");
        });

        modelBuilder.Entity<LeaveRequest>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Employee).WithMany(p => p.LeaveRequests).HasConstraintName("FK_LeaveRequests_Employees");

            entity.HasOne(d => d.LeaveTypeCat).WithMany(p => p.LeaveRequests).HasConstraintName("FK_LeaveRequests_Cat_LeaveTypes");
        });

        modelBuilder.Entity<MailHistory>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.MailTemplate).WithMany(p => p.MailHistories).HasConstraintName("FK_MailHistories_MailTemplates");
        });

        modelBuilder.Entity<MailTemplate>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<NotificationHistory>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Entity).WithMany(p => p.NotificationHistories).HasConstraintName("FK_NotificationHistories_Stores");

            entity.HasOne(d => d.NotificationTemplate).WithMany(p => p.NotificationHistories).HasConstraintName("FK_NotificationHistories_NotificationTemplates");

            entity.HasOne(d => d.Receiver).WithMany(p => p.NotificationHistories).HasConstraintName("FK_NotificationHistories_Users");
        });

        modelBuilder.Entity<NotificationTemplate>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders).HasConstraintName("FK_Orders_Customers");

            entity.HasOne(d => d.Store).WithMany(p => p.Orders).HasConstraintName("FK_Orders_Stores");

            entity.HasOne(d => d.Table).WithMany(p => p.Orders).HasConstraintName("FK_Orders_Tables");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems).HasConstraintName("FK_OrderItems_Orders");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderItems).HasConstraintName("FK_OrderItems_Products");
        });

        modelBuilder.Entity<OrderItemTopping>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.OrderItem).WithMany(p => p.OrderItemToppings).HasConstraintName("FK_OrderItemToppings_OrderItems");

            entity.HasOne(d => d.Topping).WithMany(p => p.OrderItemToppings).HasConstraintName("FK_OrderItemToppings_Toppings");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Invoice).WithMany(p => p.Payments).HasConstraintName("FK_Payments_Invoices");

            entity.HasOne(d => d.Order).WithMany(p => p.Payments).HasConstraintName("FK_Payments_Orders");

            entity.HasOne(d => d.ReceivedByNavigation).WithMany(p => p.Payments).HasConstraintName("FK_Payments_Employees");

            entity.HasOne(d => d.Store).WithMany(p => p.Payments).HasConstraintName("FK_Payments_Stores");
        });

        modelBuilder.Entity<Payroll>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Store).WithMany(p => p.Payrolls).HasConstraintName("FK_Payrolls_Stores");
        });

        modelBuilder.Entity<PayrollItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Employee).WithMany(p => p.PayrollItems).HasConstraintName("FK_PayrollItems_Employees");

            entity.HasOne(d => d.Payroll).WithMany(p => p.PayrollItems).HasConstraintName("FK_PayrollItems_Payrolls");

            entity.HasOne(d => d.SalaryStructure).WithMany(p => p.PayrollItems).HasConstraintName("FK_PayrollItems_SalaryStructures");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.ProductCat).WithMany(p => p.Products).HasConstraintName("FK_Products_Cat_ProductCategories");

            entity.HasOne(d => d.Store).WithMany(p => p.Products).HasConstraintName("FK_Products_Stores");

            entity.HasOne(d => d.UnitCat).WithMany(p => p.Products).HasConstraintName("FK_Products_Cat_Units");
        });

        modelBuilder.Entity<Promotion>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Store).WithMany(p => p.Promotions).HasConstraintName("FK_Promotions_Stores");
        });

        modelBuilder.Entity<PurchaseOrder>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Store).WithMany(p => p.PurchaseOrders).HasConstraintName("FK_PurchaseOrders_Stores");

            entity.HasOne(d => d.Supplier).WithMany(p => p.PurchaseOrders).HasConstraintName("FK_PurchaseOrders_Suppliers");
        });

        modelBuilder.Entity<PurchaseOrderItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Ingredient).WithMany(p => p.PurchaseOrderItems).HasConstraintName("FK_PurchaseOrderItems_Ingredients");

            entity.HasOne(d => d.PurchaseOrder).WithMany(p => p.PurchaseOrderItems).HasConstraintName("FK_PurchaseOrderItems_PurchaseOrders");
        });

        modelBuilder.Entity<Recipe>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Product).WithMany(p => p.Recipes).HasConstraintName("FK_Recipes_Products");

            entity.HasOne(d => d.Store).WithMany(p => p.Recipes).HasConstraintName("FK_Recipes_Stores");

            entity.HasOne(d => d.Unit).WithMany(p => p.Recipes).HasConstraintName("FK_Recipes_Cat_Units");
        });

        modelBuilder.Entity<RecipeItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Ingredient).WithMany(p => p.RecipeItems).HasConstraintName("FK_RecipeItems_Ingredients");

            entity.HasOne(d => d.Recipe).WithMany(p => p.RecipeItems).HasConstraintName("FK_RecipeItems_Recipes");
        });

        modelBuilder.Entity<Refund>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Order).WithMany(p => p.Refunds).HasConstraintName("FK_Refunds_Orders");

            entity.HasOne(d => d.Payment).WithMany(p => p.Refunds).HasConstraintName("FK_Refunds_Payments");

            entity.HasOne(d => d.ProcessedByNavigation).WithMany(p => p.Refunds).HasConstraintName("FK_Refunds_Employees");

            entity.HasOne(d => d.Store).WithMany(p => p.Refunds).HasConstraintName("FK_Refunds_Stores");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<RolePermission>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Role).WithMany(p => p.RolePermissions).HasConstraintName("FK_RolePermissions_Roles");
        });

        modelBuilder.Entity<Roster>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Employee).WithMany(p => p.Rosters).HasConstraintName("FK_Rosters_Employees");

            entity.HasOne(d => d.Shift).WithMany(p => p.Rosters).HasConstraintName("FK_Rosters_Shifts");

            entity.HasOne(d => d.Store).WithMany(p => p.Rosters).HasConstraintName("FK_Rosters_Stores");
        });

        modelBuilder.Entity<SalaryStructure>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Shift>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Store).WithMany(p => p.Shifts).HasConstraintName("FK_Shifts_Stores");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Manager).WithMany(p => p.Stores).HasConstraintName("FK_Stores_Employees");
        });

        modelBuilder.Entity<StoreSetting>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Store).WithMany(p => p.StoreSettings).HasConstraintName("FK_StoreSettings_Stores");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.CountryCat).WithMany(p => p.Suppliers).HasConstraintName("FK_Suppliers_Cat_Countries");

            entity.HasOne(d => d.ProvinceCat).WithMany(p => p.Suppliers).HasConstraintName("FK_Suppliers_Cat_Provinces");

            entity.HasOne(d => d.SupplierCat).WithMany(p => p.Suppliers).HasConstraintName("FK_Suppliers_Cat_SupplierCategories");

            entity.HasOne(d => d.WardCat).WithMany(p => p.Suppliers).HasConstraintName("FK_Suppliers_Cat_Wards");
        });

        modelBuilder.Entity<SystemSetting>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Table>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Store).WithMany(p => p.Tables).HasConstraintName("FK_Tables_Stores");
        });

        modelBuilder.Entity<TimeLog>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Employee).WithMany(p => p.TimeLogs).HasConstraintName("FK_TimeLogs_Employees");

            entity.HasOne(d => d.Store).WithMany(p => p.TimeLogs).HasConstraintName("FK_TimeLogs_Stores");
        });

        modelBuilder.Entity<Topping>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Product).WithMany(p => p.Toppings).HasConstraintName("FK_Toppings_Products");

            entity.HasOne(d => d.Recipe).WithMany(p => p.Toppings).HasConstraintName("FK_Toppings_Recipes");

            entity.HasOne(d => d.Store).WithMany(p => p.Toppings).HasConstraintName("FK_Toppings_Stores");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Employee).WithMany(p => p.Users).HasConstraintName("FK_Users_Employees");

            entity.HasOne(d => d.Store).WithMany(p => p.Users).HasConstraintName("FK_Users_Stores");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Role).WithMany(p => p.UserRoles).HasConstraintName("FK_UserRoles_Roles");

            entity.HasOne(d => d.Store).WithMany(p => p.UserRoles).HasConstraintName("FK_UserRoles_Stores");

            entity.HasOne(d => d.User).WithMany(p => p.UserRoles).HasConstraintName("FK_UserRoles_Users");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
