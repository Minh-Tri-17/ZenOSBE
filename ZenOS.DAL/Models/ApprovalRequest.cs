using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class ApprovalRequest
{
    [Key]
    public Guid Id { get; set; }

    public Guid? ApprovalFlowId { get; set; }

    public Guid? RequestedById { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RequestCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EntityType { get; set; }

    public Guid? EntityId { get; set; }

    [StringLength(250)]
    public string? RequestTitle { get; set; }

    [StringLength(500)]
    public string? RequestReason { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RequestStatus { get; set; }

    public int? CurrentStepOrder { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SubmittedAt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CompletedAt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CancelledAt { get; set; }

    [StringLength(500)]
    public string? CancelledReason { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovalDeadlineAt { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(500)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    [InverseProperty("ApprovalRequest")]
    public virtual ICollection<ApprovalAction> ApprovalActions { get; set; } = new List<ApprovalAction>();

    [ForeignKey("ApprovalFlowId")]
    [InverseProperty("ApprovalRequests")]
    public virtual ApprovalFlow? ApprovalFlow { get; set; }

    [InverseProperty("ApprovalRequest")]
    public virtual ICollection<ApprovalStepAssignment> ApprovalStepAssignments { get; set; } = new List<ApprovalStepAssignment>();

    [ForeignKey("RequestedById")]
    [InverseProperty("ApprovalRequests")]
    public virtual Employee? RequestedBy { get; set; }
}
