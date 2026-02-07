using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class Combo
{
    [Key]
    public Guid Id { get; set; }

    public Guid? StoreId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ComboCode { get; set; }

    [StringLength(250)]
    public string? ComboName { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? BasePrice { get; set; }

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

    [InverseProperty("Combo")]
    public virtual ICollection<ComboItem> ComboItems { get; set; } = new List<ComboItem>();

    [ForeignKey("StoreId")]
    [InverseProperty("Combos")]
    public virtual Store? Store { get; set; }
}
