using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class PayrollItem
{
    [Key]
    public Guid Id { get; set; }

    public Guid? PayrollId { get; set; }

    public Guid? EmployeeId { get; set; }

    public Guid? SalaryStructureId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SalaryType { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? HourlyRate { get; set; }

    public int? TotalWorkingMinutes { get; set; }

    public int? OvertimeMinutes { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? GrossSalary { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? AllowanceAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? BonusAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? DeductionAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? NetSalary { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PaymentMethod { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PaymentStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PaidAt { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(500)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("PayrollItems")]
    public virtual Employee? Employee { get; set; }

    [ForeignKey("PayrollId")]
    [InverseProperty("PayrollItems")]
    public virtual Payroll? Payroll { get; set; }

    [ForeignKey("SalaryStructureId")]
    [InverseProperty("PayrollItems")]
    public virtual SalaryStructure? SalaryStructure { get; set; }
}
