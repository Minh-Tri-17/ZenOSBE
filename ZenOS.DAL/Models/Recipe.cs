using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class Recipe
{
    [Key]
    public Guid Id { get; set; }

    public Guid? StoreId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? UnitId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RecipeCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RecipeVersion { get; set; }

    [StringLength(250)]
    public string? RecipeName { get; set; }

    public bool? IsDefault { get; set; }

    public bool? IsActive { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? YieldQuantity { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalCostEstimate { get; set; }

    public int? PreparationTimeSeconds { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? LossRatePercent { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(500)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("Recipes")]
    public virtual Product? Product { get; set; }

    [InverseProperty("Recipe")]
    public virtual ICollection<RecipeItem> RecipeItems { get; set; } = new List<RecipeItem>();

    [ForeignKey("StoreId")]
    [InverseProperty("Recipes")]
    public virtual Store? Store { get; set; }

    [InverseProperty("Recipe")]
    public virtual ICollection<Topping> Toppings { get; set; } = new List<Topping>();

    [ForeignKey("UnitId")]
    [InverseProperty("Recipes")]
    public virtual CatUnit? Unit { get; set; }
}
