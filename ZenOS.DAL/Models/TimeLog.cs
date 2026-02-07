using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class TimeLog
{
    [Key]
    public Guid Id { get; set; }

    public Guid? StoreId { get; set; }

    public Guid? EmployeeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? WorkDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CheckInTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CheckOutTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CheckInSource { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CheckOutSource { get; set; }

    [Column(TypeName = "decimal(9, 6)")]
    public decimal? CheckInLatitude { get; set; }

    [Column(TypeName = "decimal(9, 6)")]
    public decimal? CheckInLongitude { get; set; }

    [Column(TypeName = "decimal(9, 6)")]
    public decimal? CheckOutLatitude { get; set; }

    [Column(TypeName = "decimal(9, 6)")]
    public decimal? CheckOutLongitude { get; set; }

    public int? WorkingMinutes { get; set; }

    public int? OvertimeMinutes { get; set; }

    public int? LateMinutes { get; set; }

    public int? EarlyLeaveMinutes { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AttendanceStatus { get; set; }

    public bool? IsManualAdjusted { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(500)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("TimeLogs")]
    public virtual Employee? Employee { get; set; }

    [ForeignKey("StoreId")]
    [InverseProperty("TimeLogs")]
    public virtual Store? Store { get; set; }
}
