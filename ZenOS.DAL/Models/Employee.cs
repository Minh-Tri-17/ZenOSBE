using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class Employee
{
    [Key]
    public Guid Id { get; set; }

    public Guid? DepartmentCatId { get; set; }

    public Guid? JobTitleCatId { get; set; }

    public Guid? StoreId { get; set; }

    public Guid? CountryCatId { get; set; }

    public Guid? ProvinceCatId { get; set; }

    public Guid? WardCatId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EmployeeCode { get; set; }

    [StringLength(250)]
    public string? EmployeeName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateOfBirth { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PhoneNumber { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? IdentityNumber { get; set; }

    [StringLength(500)]
    public string? Address { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HireDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TerminationDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EmploymentStatus { get; set; }

    public bool? IsMultiStore { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Photo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? HealthInsuranceNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SocialInsuranceNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BankAccountNumber { get; set; }

    [StringLength(250)]
    public string? BankName { get; set; }

    [StringLength(250)]
    public string? EducationLevel { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TaxCode { get; set; }

    [StringLength(250)]
    public string? EmergencyContactName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? EmergencyContactPhone { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(500)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    [InverseProperty("Employee")]
    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    [InverseProperty("ActionBy")]
    public virtual ICollection<ApprovalAction> ApprovalActions { get; set; } = new List<ApprovalAction>();

    [InverseProperty("RequestedBy")]
    public virtual ICollection<ApprovalRequest> ApprovalRequests { get; set; } = new List<ApprovalRequest>();

    [InverseProperty("Approver")]
    public virtual ICollection<ApprovalStepAssignment> ApprovalStepAssignmentApprovers { get; set; } = new List<ApprovalStepAssignment>();

    [InverseProperty("DelegatedFrom")]
    public virtual ICollection<ApprovalStepAssignment> ApprovalStepAssignmentDelegatedFroms { get; set; } = new List<ApprovalStepAssignment>();

    [InverseProperty("Employee")]
    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    [ForeignKey("CountryCatId")]
    [InverseProperty("Employees")]
    public virtual CatCountry? CountryCat { get; set; }

    [ForeignKey("DepartmentCatId")]
    [InverseProperty("Employees")]
    public virtual CatDepartment? DepartmentCat { get; set; }

    [ForeignKey("JobTitleCatId")]
    [InverseProperty("Employees")]
    public virtual CatJobTitle? JobTitleCat { get; set; }

    [InverseProperty("Employee")]
    public virtual ICollection<LeaveRequest> LeaveRequests { get; set; } = new List<LeaveRequest>();

    [InverseProperty("ReceivedByNavigation")]
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    [InverseProperty("Employee")]
    public virtual ICollection<PayrollItem> PayrollItems { get; set; } = new List<PayrollItem>();

    [ForeignKey("ProvinceCatId")]
    [InverseProperty("Employees")]
    public virtual CatProvince? ProvinceCat { get; set; }

    [InverseProperty("ProcessedByNavigation")]
    public virtual ICollection<Refund> Refunds { get; set; } = new List<Refund>();

    [InverseProperty("Employee")]
    public virtual ICollection<Roster> Rosters { get; set; } = new List<Roster>();

    [ForeignKey("StoreId")]
    [InverseProperty("Employees")]
    public virtual Store? Store { get; set; }

    [InverseProperty("Manager")]
    public virtual ICollection<Store> Stores { get; set; } = new List<Store>();

    [InverseProperty("Employee")]
    public virtual ICollection<TimeLog> TimeLogs { get; set; } = new List<TimeLog>();

    [InverseProperty("Employee")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();

    [ForeignKey("WardCatId")]
    [InverseProperty("Employees")]
    public virtual CatWard? WardCat { get; set; }
}
