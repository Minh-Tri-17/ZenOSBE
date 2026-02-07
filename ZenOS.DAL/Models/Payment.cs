using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class Payment
{
    [Key]
    public Guid Id { get; set; }

    public Guid? StoreId { get; set; }

    public Guid? OrderId { get; set; }

    public Guid? InvoiceId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PaymentMethod { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PaymentProvider { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PaidAmount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Currency { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? ExchangeRate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PaymentStatus { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TransactionReference { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PaidAt { get; set; }

    public Guid? ReceivedBy { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(500)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    [ForeignKey("InvoiceId")]
    [InverseProperty("Payments")]
    public virtual Invoice? Invoice { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("Payments")]
    public virtual Order? Order { get; set; }

    [ForeignKey("ReceivedBy")]
    [InverseProperty("Payments")]
    public virtual Employee? ReceivedByNavigation { get; set; }

    [InverseProperty("Payment")]
    public virtual ICollection<Refund> Refunds { get; set; } = new List<Refund>();

    [ForeignKey("StoreId")]
    [InverseProperty("Payments")]
    public virtual Store? Store { get; set; }
}
