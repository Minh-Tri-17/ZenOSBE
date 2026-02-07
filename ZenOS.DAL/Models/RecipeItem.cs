using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class RecipeItem
{
    [Key]
    public Guid Id { get; set; }

    public Guid? RecipeId { get; set; }

    public Guid? IngredientId { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Quantity { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? CostPerUnit { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalCost { get; set; }

    public bool? IsOptional { get; set; }

    public bool? IsAutoDeduct { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? WastagePercent { get; set; }

    public int? PreparationStep { get; set; }

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
    [InverseProperty("RecipeItems")]
    public virtual Ingredient? Ingredient { get; set; }

    [ForeignKey("RecipeId")]
    [InverseProperty("RecipeItems")]
    public virtual Recipe? Recipe { get; set; }
}
