using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class StoreSetting
{
    [Key]
    public Guid Id { get; set; }

    public Guid? StoreId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StoreSettingCode { get; set; }

    [StringLength(250)]
    public string? StoreSettingName { get; set; }

    [Precision(0)]
    public TimeOnly? OpeningTime { get; set; }

    [Precision(0)]
    public TimeOnly? ClosingTime { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? TaxRate { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? ServiceChargeRate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BillRoundingRule { get; set; }

    public int? BillRoundingValue { get; set; }

    public bool? AllowSplitBill { get; set; }

    public bool? AllowPartialPayment { get; set; }

    public bool? EnableInventoryDeduction { get; set; }

    public bool? EnableRecipeCosting { get; set; }

    [Column("POSAutoPrintReceipt")]
    public bool? PosautoPrintReceipt { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KitchenDisplayMode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PaymentMethod { get; set; }

    public bool? ShiftRequired { get; set; }

    public bool? ApprovalRequiredForVoid { get; set; }

    public bool? ApprovalRequiredForRefund { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DataSyncMode { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(500)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    [ForeignKey("StoreId")]
    [InverseProperty("StoreSettings")]
    public virtual Store? Store { get; set; }
}
