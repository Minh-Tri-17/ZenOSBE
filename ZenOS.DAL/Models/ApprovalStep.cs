using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class ApprovalStep
{
    [Key]
    public Guid Id { get; set; }

    public Guid? ApprovalFlowId { get; set; }

    public int? StepOrder { get; set; }

    [StringLength(250)]
    public string? StepName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ApproverRoleCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ApproverScope { get; set; }

    [StringLength(500)]
    public string? ApproverRule { get; set; }

    public bool? IsParallel { get; set; }

    public bool? RequireAllApprovers { get; set; }

    public bool? AllowReject { get; set; }

    public bool? AllowEditRequest { get; set; }

    [Column("SLAHours")]
    public int? Slahours { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OnRejectAction { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OnApproveAction { get; set; }

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

    [InverseProperty("ApprovalStep")]
    public virtual ICollection<ApprovalAction> ApprovalActions { get; set; } = new List<ApprovalAction>();

    [ForeignKey("ApprovalFlowId")]
    [InverseProperty("ApprovalSteps")]
    public virtual ApprovalFlow? ApprovalFlow { get; set; }

    [InverseProperty("ApprovalStep")]
    public virtual ICollection<ApprovalStepAssignment> ApprovalStepAssignments { get; set; } = new List<ApprovalStepAssignment>();
}
