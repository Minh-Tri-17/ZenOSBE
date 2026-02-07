using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class Shift
{
    [Key]
    public Guid Id { get; set; }

    public Guid? StoreId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ShiftCode { get; set; }

    [StringLength(250)]
    public string? ShiftName { get; set; }

    [Precision(0)]
    public TimeOnly? StartTime { get; set; }

    [Precision(0)]
    public TimeOnly? EndTime { get; set; }

    [Precision(0)]
    public TimeOnly? BreakStartTime { get; set; }

    [Precision(0)]
    public TimeOnly? BreakEndTime { get; set; }

    public int? PlannedWorkingMinutes { get; set; }

    public int? AllowLateMinutes { get; set; }

    public int? AllowEarlyLeaveMinutes { get; set; }

    public bool? IsOvernight { get; set; }

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

    [InverseProperty("Shift")]
    public virtual ICollection<Roster> Rosters { get; set; } = new List<Roster>();

    [ForeignKey("StoreId")]
    [InverseProperty("Shifts")]
    public virtual Store? Store { get; set; }
}
