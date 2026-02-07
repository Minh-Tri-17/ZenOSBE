using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class NotificationHistory
{
    [Key]
    public Guid Id { get; set; }

    public Guid? NotificationTemplateId { get; set; }

    public Guid? ReceiverId { get; set; }

    public Guid? EntityId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EntityType { get; set; }

    [StringLength(500)]
    public string? NotificationSubject { get; set; }

    public string? NotificationBody { get; set; }

    public bool? IsRead { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReadAt { get; set; }

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

    [ForeignKey("EntityId")]
    [InverseProperty("NotificationHistories")]
    public virtual Store? Entity { get; set; }

    [ForeignKey("NotificationTemplateId")]
    [InverseProperty("NotificationHistories")]
    public virtual NotificationTemplate? NotificationTemplate { get; set; }

    [ForeignKey("ReceiverId")]
    [InverseProperty("NotificationHistories")]
    public virtual User? Receiver { get; set; }
}
