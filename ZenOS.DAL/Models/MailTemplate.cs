using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class MailTemplate
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MailTemplateCode { get; set; }

    [StringLength(250)]
    public string? MailTemplateName { get; set; }

    [StringLength(500)]
    public string? MailTemplateSubject { get; set; }

    public string? MailTemplateContent { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(500)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    [InverseProperty("MailTemplate")]
    public virtual ICollection<MailHistory> MailHistories { get; set; } = new List<MailHistory>();
}
