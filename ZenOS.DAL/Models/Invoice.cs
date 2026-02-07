using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class Invoice
{
    [Key]
    public Guid Id { get; set; }

    public Guid? StoreId { get; set; }

    public Guid? OrderId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? InvoiceCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InvoiceDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? InvoiceType { get; set; }

    [StringLength(250)]
    public string? CustomerName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CustomerTaxCode { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? SubTotalAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? DiscountAmount { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? TaxRate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TaxAmount { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? ServiceChargeRate { get; set; }

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
    public string? InvoiceStatus { get; set; }

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
    [InverseProperty("Invoices")]
    public virtual Order? Order { get; set; }

    [InverseProperty("Invoice")]
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    [ForeignKey("StoreId")]
    [InverseProperty("Invoices")]
    public virtual Store? Store { get; set; }
}
