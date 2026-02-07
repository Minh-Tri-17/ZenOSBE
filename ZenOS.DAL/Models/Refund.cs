using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class Refund
{
    [Key]
    public Guid Id { get; set; }

    public Guid? StoreId { get; set; }

    public Guid? PaymentId { get; set; }

    public Guid? OrderId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? RefundAmount { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RefundMethod { get; set; }

    [StringLength(500)]
    public string? RefundReason { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProcessedAt { get; set; }

    public Guid? ProcessedBy { get; set; }

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

    [ForeignKey("OrderId")]
    [InverseProperty("Refunds")]
    public virtual Order? Order { get; set; }

    [ForeignKey("PaymentId")]
    [InverseProperty("Refunds")]
    public virtual Payment? Payment { get; set; }

    [ForeignKey("ProcessedBy")]
    [InverseProperty("Refunds")]
    public virtual Employee? ProcessedByNavigation { get; set; }

    [ForeignKey("StoreId")]
    [InverseProperty("Refunds")]
    public virtual Store? Store { get; set; }
}
