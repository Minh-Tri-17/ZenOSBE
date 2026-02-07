using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class NotificationTemplate
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NotificationTemplateCode { get; set; }

    [StringLength(250)]
    public string? NotificationTemplateName { get; set; }

    [StringLength(500)]
    public string? NotificationTemplateSubject { get; set; }

    public string? NotificationTemplateContent { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(500)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    [InverseProperty("NotificationTemplate")]
    public virtual ICollection<NotificationHistory> NotificationHistories { get; set; } = new List<NotificationHistory>();
}
