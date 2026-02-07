using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class ApprovalAction
{
    [Key]
    public Guid Id { get; set; }

    public Guid? ApprovalRequestId { get; set; }

    public Guid? ApprovalStepId { get; set; }

    public Guid? ActionById { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ActionType { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ActionRoleCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActionAt { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(500)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    [ForeignKey("ActionById")]
    [InverseProperty("ApprovalActions")]
    public virtual Employee? ActionBy { get; set; }

    [ForeignKey("ApprovalRequestId")]
    [InverseProperty("ApprovalActions")]
    public virtual ApprovalRequest? ApprovalRequest { get; set; }

    [ForeignKey("ApprovalStepId")]
    [InverseProperty("ApprovalActions")]
    public virtual ApprovalStep? ApprovalStep { get; set; }
}
