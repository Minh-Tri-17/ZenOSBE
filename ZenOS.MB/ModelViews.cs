using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ZenOS.DAL.Models;

namespace ZenOS.MB
{
    #region Model Database

    public partial class AppointmentModel : Appointment
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class ApprovalActionModel : ApprovalAction
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class ApprovalFlowModel : ApprovalFlow
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class ApprovalRequestModel : ApprovalRequest
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class ApprovalStepModel : ApprovalStep
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class ApprovalStepAssignmentModel : ApprovalStepAssignment
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class CatContractTypeModel : CatContractType
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class CatCountryModel : CatCountry
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class CatDepartmentModel : CatDepartment
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class CatIngredientCategoryModel : CatIngredientCategory
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class CatJobTitleModel : CatJobTitle
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class CatLeaveTypeModel : CatLeaveType
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class CatMembershipLevelModel : CatMembershipLevel
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class CatProductCategoryModel : CatProductCategory
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class CatProvinceModel : CatProvince
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class CatSupplierCategoryModel : CatSupplierCategory
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class CatUnitModel : CatUnit
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class CatWardModel : CatWard
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class CodeSequenceModel : CodeSequence
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class ComboModel : Combo
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class ComboItemModel : ComboItem
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class ContractModel : Contract
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class CustomerModel : Customer
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class EmployeeModel : Employee
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class IngredientModel : Ingredient
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class InventoryStockModel : InventoryStock
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class InventoryTransactionModel : InventoryTransaction
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class InvoiceModel : Invoice
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class LeaveRequestModel : LeaveRequest
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class MailHistoryModel : MailHistory
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class MailTemplateModel : MailTemplate
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class NotificationHistoryModel : NotificationHistory
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class NotificationTemplateModel : NotificationTemplate
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class OrderModel : Order
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class OrderItemModel : OrderItem
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class OrderItemToppingModel : OrderItemTopping
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class PaymentModel : Payment
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class PayrollModel : Payroll
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class PayrollItemModel : PayrollItem
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class ProductModel : Product
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class PromotionModel : Promotion
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class PurchaseOrderModel : PurchaseOrder
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class PurchaseOrderItemModel : PurchaseOrderItem
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class RecipeModel : Recipe
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class RecipeItemModel : RecipeItem
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class RefundModel : Refund
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class RoleModel : Role
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class RolePermissionModel : RolePermission
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class RosterModel : Roster
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class SalaryStructureModel : SalaryStructure
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class ShiftModel : Shift
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class StoreModel : Store
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class StoreSettingModel : StoreSetting
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class SupplierModel : Supplier
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class SystemSettingModel : SystemSetting
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class TimeLogModel : TimeLog
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class ToppingModel : Topping
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class UserModel : User
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    public partial class UserRoleModel : UserRole
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public bool AllowPaging { get; set; } = true;
        public string Ids { get; set; } = string.Empty;
    }

    #endregion

    public class MailModel
    {
        [Required]
        public string To { get; set; } = string.Empty;
        [Required]
        public string Subject { get; set; } = string.Empty;
        [Required]
        public string Body { get; set; } = string.Empty;
        public List<string> CC { get; set; } = new List<string>();
        public List<string> BCC { get; set; } = new List<string>();
        public List<IFormFile>? Attachments { get; set; }
    }

    public class FilterModel
    {
        public bool AllowPaging { get; set; } = true;
        public Guid? IdMain { get; set; }
        public int PageSize { get; set; } = 20;
        public int PageIndex { get; set; } = 1;
        public List<FilterItemModel> Filters { get; set; } = new List<FilterItemModel>();
    }

    public class FilterItemModel
    {
        public string FilterName { get; set; } = string.Empty;
        public string FilterValue { get; set; } = string.Empty;
        public string FilterType { get; set; } = string.Empty;
        public string FilterOperator { get; set; } = string.Empty;
    }
}
