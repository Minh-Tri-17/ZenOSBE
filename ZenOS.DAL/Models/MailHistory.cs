using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class MailHistory
{
    [Key]
    public Guid Id { get; set; }

    public Guid? MailTemplateId { get; set; }

    public Guid? EntityId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EntityType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReceiverEmail { get; set; }

    [StringLength(500)]
    public string? MailSubject { get; set; }

    public string? MailBody { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SentStatus { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(500)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    [ForeignKey("MailTemplateId")]
    [InverseProperty("MailHistories")]
    public virtual MailTemplate? MailTemplate { get; set; }
}
