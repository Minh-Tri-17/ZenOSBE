using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class InventoryTransaction
{
    [Key]
    public Guid Id { get; set; }

    public Guid? StoreId { get; set; }

    public Guid? IngredientId { get; set; }

    public Guid? ReferenceId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TransactionType { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ReferenceType { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? QuantityChange { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? CostPerUnit { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalCost { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? StockBefore { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? StockAfter { get; set; }

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
    [InverseProperty("InventoryTransactions")]
    public virtual Ingredient? Ingredient { get; set; }

    [ForeignKey("StoreId")]
    [InverseProperty("InventoryTransactions")]
    public virtual Store? Store { get; set; }
}
