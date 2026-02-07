using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class ApprovalStepAssignment
{
    [Key]
    public Guid Id { get; set; }

    public Guid? ApprovalRequestId { get; set; }

    public Guid? ApprovalStepId { get; set; }

    public Guid? ApproverId { get; set; }

    public Guid? DelegatedFromId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AssignmentStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AssignedAt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActedAt { get; set; }

    [Column("SLADeadlineAt", TypeName = "datetime")]
    public DateTime? SladeadlineAt { get; set; }

    public bool? IsDelegated { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(500)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    [ForeignKey("ApprovalRequestId")]
    [InverseProperty("ApprovalStepAssignments")]
    public virtual ApprovalRequest? ApprovalRequest { get; set; }

    [ForeignKey("ApprovalStepId")]
    [InverseProperty("ApprovalStepAssignments")]
    public virtual ApprovalStep? ApprovalStep { get; set; }

    [ForeignKey("ApproverId")]
    [InverseProperty("ApprovalStepAssignmentApprovers")]
    public virtual Employee? Approver { get; set; }

    [ForeignKey("DelegatedFromId")]
    [InverseProperty("ApprovalStepAssignmentDelegatedFroms")]
    public virtual Employee? DelegatedFrom { get; set; }
}
