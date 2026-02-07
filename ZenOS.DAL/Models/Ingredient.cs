using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class Ingredient
{
    [Key]
    public Guid Id { get; set; }

    public Guid? StoreId { get; set; }

    public Guid? UnitCatId { get; set; }

    public Guid? IngredientCatId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IngredientCode { get; set; }

    [StringLength(250)]
    public string? IngredientName { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? ConversionRate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? StandardCost { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? LastPurchaseCost { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? MinStockLevel { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? MaxStockLevel { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? ReorderPoint { get; set; }

    public int? ShelfLifeDays { get; set; }

    public bool? IsBatchTracked { get; set; }

    public bool? IsExpiryTracked { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(500)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    [ForeignKey("IngredientCatId")]
    [InverseProperty("Ingredients")]
    public virtual CatIngredientCategory? IngredientCat { get; set; }

    [InverseProperty("Ingredient")]
    public virtual ICollection<InventoryStock> InventoryStocks { get; set; } = new List<InventoryStock>();

    [InverseProperty("Ingredient")]
    public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; } = new List<InventoryTransaction>();

    [InverseProperty("Ingredient")]
    public virtual ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; } = new List<PurchaseOrderItem>();

    [InverseProperty("Ingredient")]
    public virtual ICollection<RecipeItem> RecipeItems { get; set; } = new List<RecipeItem>();

    [ForeignKey("StoreId")]
    [InverseProperty("Ingredients")]
    public virtual Store? Store { get; set; }

    [ForeignKey("UnitCatId")]
    [InverseProperty("Ingredients")]
    public virtual CatUnit? UnitCat { get; set; }
}
