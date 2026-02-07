using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class Product
{
    [Key]
    public Guid Id { get; set; }

    public Guid? StoreId { get; set; }

    public Guid? ProductCatId { get; set; }

    public Guid? UnitCatId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProductCode { get; set; }

    [StringLength(250)]
    public string? ProductName { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? BasePrice { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? CostEstimate { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? TaxRate { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? ServiceChargeRate { get; set; }

    public bool? AllowDiscount { get; set; }

    public bool? AllowTopping { get; set; }

    public bool? AllowNote { get; set; }

    public bool? IsInventoryTracked { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Photo { get; set; }

    public int? SortOrder { get; set; }

    public bool? IsAvailable { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(500)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<ComboItem> ComboItems { get; set; } = new List<ComboItem>();

    [InverseProperty("Product")]
    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    [ForeignKey("ProductCatId")]
    [InverseProperty("Products")]
    public virtual CatProductCategory? ProductCat { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();

    [ForeignKey("StoreId")]
    [InverseProperty("Products")]
    public virtual Store? Store { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<Topping> Toppings { get; set; } = new List<Topping>();

    [ForeignKey("UnitCatId")]
    [InverseProperty("Products")]
    public virtual CatUnit? UnitCat { get; set; }
}
