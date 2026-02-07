using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class OrderItemTopping
{
    [Key]
    public Guid Id { get; set; }

    public Guid? OrderItemId { get; set; }

    public Guid? ToppingId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Quantity { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalPrice { get; set; }

    public bool? DeductInventory { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(500)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    [ForeignKey("OrderItemId")]
    [InverseProperty("OrderItemToppings")]
    public virtual OrderItem? OrderItem { get; set; }

    [ForeignKey("ToppingId")]
    [InverseProperty("OrderItemToppings")]
    public virtual Topping? Topping { get; set; }
}
