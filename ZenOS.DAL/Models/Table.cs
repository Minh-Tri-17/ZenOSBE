using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class Table
{
    [Key]
    public Guid Id { get; set; }

    public Guid? StoreId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TableCode { get; set; }

    [StringLength(250)]
    public string? TableNumber { get; set; }

    [StringLength(250)]
    public string? FloorOrZone { get; set; }

    public int? Capacity { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Shape { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Status { get; set; }

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

    [InverseProperty("Table")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    [ForeignKey("StoreId")]
    [InverseProperty("Tables")]
    public virtual Store? Store { get; set; }
}
