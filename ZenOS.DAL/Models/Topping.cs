using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class Topping
{
    [Key]
    public Guid Id { get; set; }

    public Guid? StoreId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? RecipeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ToppingCode { get; set; }

    [StringLength(250)]
    public string? ToppingName { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Price { get; set; }

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

    [InverseProperty("Topping")]
    public virtual ICollection<OrderItemTopping> OrderItemToppings { get; set; } = new List<OrderItemTopping>();

    [ForeignKey("ProductId")]
    [InverseProperty("Toppings")]
    public virtual Product? Product { get; set; }

    [ForeignKey("RecipeId")]
    [InverseProperty("Toppings")]
    public virtual Recipe? Recipe { get; set; }

    [ForeignKey("StoreId")]
    [InverseProperty("Toppings")]
    public virtual Store? Store { get; set; }
}
