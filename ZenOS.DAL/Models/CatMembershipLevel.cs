using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

[Table("Cat_MembershipLevels")]
public partial class CatMembershipLevel
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LevelCode { get; set; }

    [StringLength(100)]
    public string? LevelName { get; set; }

    public int? RankOrder { get; set; }

    public int? ThresholdPoint { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? DiscountRate { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(500)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    [InverseProperty("MembershipLevelCat")]
    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
