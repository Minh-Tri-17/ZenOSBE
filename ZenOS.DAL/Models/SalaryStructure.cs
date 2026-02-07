using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class SalaryStructure
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StructureCode { get; set; }

    [StringLength(250)]
    public string? StructureName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SalaryType { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? BaseSalary { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? HourlyRate { get; set; }

    [Column("OTRate", TypeName = "decimal(5, 2)")]
    public decimal? Otrate { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? NightShiftRate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? AllowanceAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Allowance1 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Allowance2 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Allowance3 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Allowance4 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Allowance5 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Allowance6 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Allowance7 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Allowance8 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Allowance9 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Allowance10 { get; set; }

    [StringLength(500)]
    public string? BonusRule { get; set; }

    [StringLength(500)]
    public string? DeductionRule { get; set; }

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

    [InverseProperty("SalaryStructure")]
    public virtual ICollection<PayrollItem> PayrollItems { get; set; } = new List<PayrollItem>();
}
