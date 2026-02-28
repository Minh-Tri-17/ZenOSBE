using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZenOS.DAL.Models
{
    public partial class Appointment : IBaseEntity { }
    public partial class ApprovalAction : IBaseEntity { }
    public partial class ApprovalFlow : IBaseEntity { }
    public partial class ApprovalRequest : IBaseEntity { }
    public partial class ApprovalStep : IBaseEntity { }
    public partial class ApprovalStepAssignment : IBaseEntity { }
    public partial class CatContractType : IBaseEntity { }
    public partial class CatCountry : IBaseEntity { }
    public partial class CatDepartment : IBaseEntity { }
    public partial class CatIngredientCategory : IBaseEntity { }
    public partial class CatJobTitle : IBaseEntity { }
    public partial class CatLeaveType : IBaseEntity { }
    public partial class CatMembershipLevel : IBaseEntity { }
    public partial class CatProductCategory : IBaseEntity { }
    public partial class CatProvince : IBaseEntity { }
    public partial class CatSupplierCategory : IBaseEntity { }
    public partial class CatUnit : IBaseEntity { }
    public partial class CatWard : IBaseEntity { }
    public partial class Combo : IBaseEntity { }
    public partial class ComboItem : IBaseEntity { }
    public partial class Contract : IBaseEntity { }
    public partial class Customer : IBaseEntity { }
    public partial class Employee : IBaseEntity { }
    public partial class Ingredient : IBaseEntity { }
    public partial class InventoryStock : IBaseEntity { }
    public partial class InventoryTransaction : IBaseEntity { }
    public partial class Invoice : IBaseEntity { }
    public partial class LeaveRequest : IBaseEntity { }
    public partial class MailHistory : IBaseEntity { }
    public partial class MailTemplate : IBaseEntity { }
    public partial class NotificationHistory : IBaseEntity { }
    public partial class NotificationTemplate : IBaseEntity { }
    public partial class Order : IBaseEntity { }
    public partial class OrderItem : IBaseEntity { }
    public partial class OrderItemTopping : IBaseEntity { }
    public partial class Payment : IBaseEntity { }
    public partial class Payroll : IBaseEntity { }
    public partial class PayrollItem : IBaseEntity { }
    public partial class Product : IBaseEntity { }
    public partial class Promotion : IBaseEntity { }
    public partial class PurchaseOrder : IBaseEntity { }
    public partial class PurchaseOrderItem : IBaseEntity { }
    public partial class Recipe : IBaseEntity { }
    public partial class RecipeItem : IBaseEntity { }
    public partial class Refund : IBaseEntity { }
    public partial class Role : IBaseEntity { }
    public partial class RolePermission : IBaseEntity { }
    public partial class Roster : IBaseEntity { }
    public partial class SalaryStructure : IBaseEntity { }
    public partial class Shift : IBaseEntity { }
    public partial class Store : IBaseEntity { }
    public partial class StoreSetting : IBaseEntity { }
    public partial class Supplier : IBaseEntity { }
    public partial class SystemSetting : IBaseEntity { }
    public partial class Table : IBaseEntity { }
    public partial class TimeLog : IBaseEntity { }
    public partial class Topping : IBaseEntity { }
    public partial class User : IBaseEntity { }
    public partial class UserRole : IBaseEntity { }
}
