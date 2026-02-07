using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class PurchaseOrder
{
    [Key]
    public Guid Id { get; set; }

    public Guid? StoreId { get; set; }

    public Guid? SupplierId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PurchaseOrderCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpectedDeliveryDate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? SubTotalAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TaxAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalAmount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Currency { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PaymentStatus { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ApprovalStatus { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(500)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    [InverseProperty("PurchaseOrder")]
    public virtual ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; } = new List<PurchaseOrderItem>();

    [ForeignKey("StoreId")]
    [InverseProperty("PurchaseOrders")]
    public virtual Store? Store { get; set; }

    [ForeignKey("SupplierId")]
    [InverseProperty("PurchaseOrders")]
    public virtual Supplier? Supplier { get; set; }
}
