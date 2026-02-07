using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class Payroll
{
    [Key]
    public Guid Id { get; set; }

    public Guid? StoreId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PayrollCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PayrollPeriodStart { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PayrollPeriodEnd { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PayrollType { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PayrollStatus { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalGrossAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalDeductionAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalNetAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GeneratedAt { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ApprovalStatus { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(500)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    [InverseProperty("Payroll")]
    public virtual ICollection<PayrollItem> PayrollItems { get; set; } = new List<PayrollItem>();

    [ForeignKey("StoreId")]
    [InverseProperty("Payrolls")]
    public virtual Store? Store { get; set; }
}
