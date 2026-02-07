using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class Order
{
    [Key]
    public Guid Id { get; set; }

    public Guid? StoreId { get; set; }

    public Guid? CustomerId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OrderCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OrderType { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OrderStatus { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CustomerCode { get; set; }

    [StringLength(250)]
    public string? CustomerName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TableNumber { get; set; }

    [StringLength(500)]
    public string? DeliveryAddress { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? SubTotalAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? DiscountAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TaxAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ServiceChargeAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? RoundingAmount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Currency { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PaymentStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OpenedAt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ClosedAt { get; set; }

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

    [ForeignKey("CustomerId")]
    [InverseProperty("Orders")]
    public virtual Customer? Customer { get; set; }

    [InverseProperty("Order")]
    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    [InverseProperty("Order")]
    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    [InverseProperty("Order")]
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    [InverseProperty("Order")]
    public virtual ICollection<Refund> Refunds { get; set; } = new List<Refund>();

    [ForeignKey("StoreId")]
    [InverseProperty("Orders")]
    public virtual Store? Store { get; set; }
}
