using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class OrderItem
{
    [Key]
    public Guid Id { get; set; }

    public Guid? OrderId { get; set; }

    public Guid? ProductId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Quantity { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? UnitPrice { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? BasePrice { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? DiscountAmount { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? TaxRate { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? ServiceChargeRate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? LineTotal { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? CostEstimate { get; set; }

    public bool? IsVoided { get; set; }

    [StringLength(500)]
    public string? VoidedReason { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PreparedStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? KitchenPrintedAt { get; set; }

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
    [InverseProperty("OrderItems")]
    public virtual Order? Order { get; set; }

    [InverseProperty("OrderItem")]
    public virtual ICollection<OrderItemTopping> OrderItemToppings { get; set; } = new List<OrderItemTopping>();

    [ForeignKey("ProductId")]
    [InverseProperty("OrderItems")]
    public virtual Product? Product { get; set; }
}
