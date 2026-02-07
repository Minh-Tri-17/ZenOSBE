using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class ComboItem
{
    [Key]
    public Guid Id { get; set; }

    public Guid? ComboId { get; set; }

    public Guid? ProductId { get; set; }

    public int? Quantity { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? ExtraPrice { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(500)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    [ForeignKey("ComboId")]
    [InverseProperty("ComboItems")]
    public virtual Combo? Combo { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("ComboItems")]
    public virtual Product? Product { get; set; }
}
