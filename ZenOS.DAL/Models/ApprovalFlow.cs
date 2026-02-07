using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class ApprovalFlow
{
    [Key]
    public Guid Id { get; set; }

    public Guid? StoreId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FlowCode { get; set; }

    [StringLength(250)]
    public string? FlowName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FlowCategory { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ApplicableEntity { get; set; }

    [StringLength(500)]
    public string? TriggerCondition { get; set; }

    public int? MaxApprovalLevel { get; set; }

    public bool? AllowSkipLevel { get; set; }

    public bool? AllowAutoApprove { get; set; }

    [StringLength(500)]
    public string? AutoApproveRule { get; set; }

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

    [InverseProperty("ApprovalFlow")]
    public virtual ICollection<ApprovalRequest> ApprovalRequests { get; set; } = new List<ApprovalRequest>();

    [InverseProperty("ApprovalFlow")]
    public virtual ICollection<ApprovalStep> ApprovalSteps { get; set; } = new List<ApprovalStep>();

    [ForeignKey("StoreId")]
    [InverseProperty("ApprovalFlows")]
    public virtual Store? Store { get; set; }
}
