using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class InventoryStock
{
    [Key]
    public Guid Id { get; set; }

    public Guid? StoreId { get; set; }

    public Guid? IngredientId { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? CurrentQuantity { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? ReservedQuantity { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastTransactionAt { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? LastCost { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? AverageCost { get; set; }

    public int? RowVersion { get; set; }

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

    [ForeignKey("IngredientId")]
    [InverseProperty("InventoryStocks")]
    public virtual Ingredient? Ingredient { get; set; }

    [ForeignKey("StoreId")]
    [InverseProperty("InventoryStocks")]
    public virtual Store? Store { get; set; }
}
