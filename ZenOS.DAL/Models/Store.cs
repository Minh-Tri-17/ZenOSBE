using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class Store
{
    [Key]
    public Guid Id { get; set; }

    public Guid? ManagerId { get; set; }

    public Guid? CountryCatId { get; set; }

    public Guid? ProvinceCatId { get; set; }

    public Guid? WardCatId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StoreCode { get; set; }

    [StringLength(250)]
    public string? StoreName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StoreType { get; set; }

    [StringLength(250)]
    public string? BrandName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PhoneNumber { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(500)]
    public string? Address { get; set; }

    [Column(TypeName = "decimal(9, 6)")]
    public decimal? Latitude { get; set; }

    [Column(TypeName = "decimal(9, 6)")]
    public decimal? Longitude { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Timezone { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Currency { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OpeningDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BusinessStatus { get; set; }

    public bool? IsHeadOffice { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(500)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    [InverseProperty("Store")]
    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    [InverseProperty("Store")]
    public virtual ICollection<ApprovalFlow> ApprovalFlows { get; set; } = new List<ApprovalFlow>();

    [InverseProperty("Store")]
    public virtual ICollection<Combo> Combos { get; set; } = new List<Combo>();

    [InverseProperty("Store")]
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    [InverseProperty("Store")]
    public virtual ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

    [InverseProperty("Store")]
    public virtual ICollection<InventoryStock> InventoryStocks { get; set; } = new List<InventoryStock>();

    [InverseProperty("Store")]
    public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; } = new List<InventoryTransaction>();

    [InverseProperty("Store")]
    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    [ForeignKey("ManagerId")]
    [InverseProperty("Stores")]
    public virtual Employee? Manager { get; set; }

    [InverseProperty("Entity")]
    public virtual ICollection<NotificationHistory> NotificationHistories { get; set; } = new List<NotificationHistory>();

    [InverseProperty("Store")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    [InverseProperty("Store")]
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    [InverseProperty("Store")]
    public virtual ICollection<Payroll> Payrolls { get; set; } = new List<Payroll>();

    [InverseProperty("Store")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    [InverseProperty("Store")]
    public virtual ICollection<Promotion> Promotions { get; set; } = new List<Promotion>();

    [InverseProperty("Store")]
    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    [InverseProperty("Store")]
    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();

    [InverseProperty("Store")]
    public virtual ICollection<Refund> Refunds { get; set; } = new List<Refund>();

    [InverseProperty("Store")]
    public virtual ICollection<Roster> Rosters { get; set; } = new List<Roster>();

    [InverseProperty("Store")]
    public virtual ICollection<Shift> Shifts { get; set; } = new List<Shift>();

    [InverseProperty("Store")]
    public virtual ICollection<StoreSetting> StoreSettings { get; set; } = new List<StoreSetting>();

    [InverseProperty("Store")]
    public virtual ICollection<TimeLog> TimeLogs { get; set; } = new List<TimeLog>();

    [InverseProperty("Store")]
    public virtual ICollection<Topping> Toppings { get; set; } = new List<Topping>();

    [InverseProperty("Store")]
    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

    [InverseProperty("Store")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
