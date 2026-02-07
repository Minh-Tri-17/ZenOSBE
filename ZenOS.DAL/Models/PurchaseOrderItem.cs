using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class PurchaseOrderItem
{
    [Key]
    public Guid Id { get; set; }

    public Guid? PurchaseOrderId { get; set; }

    public Guid? IngredientId { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Quantity { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? UnitPrice { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? LineTotal { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? ReceivedQuantity { get; set; }

    public bool? IsCompleted { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(500)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    [ForeignKey("IngredientId")]
    [InverseProperty("PurchaseOrderItems")]
    public virtual Ingredient? Ingredient { get; set; }

    [ForeignKey("PurchaseOrderId")]
    [InverseProperty("PurchaseOrderItems")]
    public virtual PurchaseOrder? PurchaseOrder { get; set; }
}
