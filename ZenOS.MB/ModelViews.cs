using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using ZenOS.DAL.Models;

namespace ZenOS.MB
{
    #region Model database

    public partial class AppointmentModel : Appointment
    {

    }

    public partial class ApprovalActionModel : ApprovalAction
    {

    }

    public partial class ApprovalFlowModel : ApprovalFlow
    {

    }

    public partial class ApprovalRequestModel : ApprovalRequest
    {

    }

    public partial class ApprovalStepModel : ApprovalStep
    {

    }

    public partial class ApprovalStepAssignmentModel : ApprovalStepAssignment
    {

    }

    public partial class CatContractTypeModel : CatContractType
    {

    }

    public partial class CatCountryModel : CatCountry
    {

    }

    public partial class CatDepartmentModel : CatDepartment
    {

    }

    public partial class CatIngredientCategoryModel : CatIngredientCategory
    {

    }

    public partial class CatJobTitleModel : CatJobTitle
    {

    }

    public partial class CatLeaveTypeModel : CatLeaveType
    {

    }

    public partial class CatMembershipLevelModel : CatMembershipLevel
    {

    }

    public partial class CatProductCategoryModel : CatProductCategory
    {

    }

    public partial class CatProvinceModel : CatProvince
    {

    }

    public partial class CatSupplierCategoryModel : CatSupplierCategory
    {

    }

    public partial class CatUnitModel : CatUnit
    {

    }

    public partial class CatWardModel : CatWard
    {

    }

    public partial class CodeSequenceModel : CodeSequence
    {

    }

    public partial class ComboModel : Combo
    {

    }

    public partial class ComboItemModel : ComboItem
    {

    }

    public partial class ContractModel : Contract
    {

    }

    public partial class CustomerModel : Customer
    {

    }

    public partial class EmployeeModel : Employee
    {

    }

    public partial class IngredientModel : Ingredient
    {

    }

    public partial class InventoryStockModel : InventoryStock
    {

    }

    public partial class InventoryTransactionModel : InventoryTransaction
    {

    }

    public partial class InvoiceModel : Invoice
    {

    }

    public partial class LeaveRequestModel : LeaveRequest
    {

    }

    public partial class MailHistoryModel : MailHistory
    {

    }

    public partial class MailTemplateModel : MailTemplate
    {

    }

    public partial class NotificationHistoryModel : NotificationHistory
    {

    }

    public partial class NotificationTemplateModel : NotificationTemplate
    {

    }

    public partial class OrderModel : Order
    {

    }

    public partial class OrderItemModel : OrderItem
    {

    }

    public partial class OrderItemToppingModel : OrderItemTopping
    {

    }

    public partial class PaymentModel : Payment
    {

    }

    public partial class PayrollModel : Payroll
    {

    }

    public partial class PayrollItemModel : PayrollItem
    {

    }

    public partial class ProductModel : Product
    {

    }

    public partial class PromotionModel : Promotion
    {

    }

    public partial class PurchaseOrderModel : PurchaseOrder
    {

    }

    public partial class PurchaseOrderItemModel : PurchaseOrderItem
    {

    }

    public partial class RecipeModel : Recipe
    {

    }

    public partial class RecipeItemModel : RecipeItem
    {

    }

    public partial class RefundModel : Refund
    {

    }

    public partial class RoleModel : Role
    {

    }

    public partial class RolePermissionModel : RolePermission
    {

    }

    public partial class RosterModel : Roster
    {

    }

    public partial class SalaryStructureModel : SalaryStructure
    {

    }

    public partial class ShiftModel : Shift
    {

    }

    public partial class StoreModel : Store
    {

    }

    public partial class StoreSettingModel : StoreSetting
    {

    }

    public partial class SupplierModel : Supplier
    {

    }

    public partial class SystemSettingModel : SystemSetting
    {

    }

    public partial class TableModel : Table
    {

    }

    public partial class TimeLogModel : TimeLog
    {

    }

    public partial class ToppingModel : Topping
    {

    }

    public partial class UserModel : User
    {
        public bool Remember { get; set; } = false;
        [Required]
        public string? Password { get; set; }
        public string? RoleIds { get; set; }
    }

    public partial class UserRoleModel : UserRole
    {

    }

    #endregion

    #region Model chart

    public class DataChartNumericModel
    {
        public List<NumericSeriesModel>? Values { get; set; }
        public string[]? Labels { get; set; }
    }

    public class NumericSeriesModel
    {
        public string? Name { get; set; }
        public int[]? Data { get; set; }
    }

    public class DataChartSingleModel
    {
        public int[]? Values { get; set; }
        public string[]? Labels { get; set; }
    }

    public class DataChartTreeModel
    {
        public string? Id { get; set; }
        public NodeData Data { get; set; } = new NodeData();
        public List<DataChartTreeModel>? Children { get; set; } = new List<DataChartTreeModel>();
    }

    public class NodeData
    {
        public string? Name { get; set; }
        public string? ImageURL { get; set; }
        public string? BorderColor { get; set; }
    }

    public class DataChartXYModel
    {
        public List<XYSeriesModel>? Values { get; set; }
        public string[]? Labels { get; set; }
    }

    public class XYSeriesModel
    {
        public string? Name { get; set; }
        public List<XYPointModel>? Data { get; set; }
    }

    public class XYPointModel
    {
        public string? X { get; set; }
        public int Y { get; set; }
    }

    public class DashboardModel
    {
        public decimal StatisticsProfit { get; set; } = 0;
        public decimal StatisticsRevenue { get; set; } = 0;
        public decimal StatisticsSpending { get; set; } = 0;
        public int StatisticsCustomer { get; set; } = 0;
        public List<string> StatisticsService { get; set; } = new List<string>();
    }

    #endregion

    public class MailModel
    {
        [Required]
        public string? To { get; set; }
        [Required]
        public string? Subject { get; set; }
        [Required]
        public string? Body { get; set; }
        public List<string> CC { get; set; } = new List<string>();
        public List<string> BCC { get; set; } = new List<string>();
        public List<IFormFile>? Attachments { get; set; }
    }

    public class FilterModel
    {
        public bool AllowPaging { get; set; } = true;
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public Guid? IdMain { get; set; }
        public List<FilterItemModel> Filters { get; set; } = new List<FilterItemModel>();
    }

    public class FilterItemModel
    {
        public string? FilterName { get; set; }
        public string? FilterValue { get; set; }
        public string? FilterType { get; set; }
        public string? FilterOperator { get; set; }
    }
}
