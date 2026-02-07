using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class Roster
{
    [Key]
    public Guid Id { get; set; }

    public Guid? StoreId { get; set; }

    public Guid? EmployeeId { get; set; }

    public Guid? ShiftId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RosterCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? WorkDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PlannedStartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PlannedEndTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RosterStatus { get; set; }

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
    [InverseProperty("Rosters")]
    public virtual Employee? Employee { get; set; }

    [ForeignKey("ShiftId")]
    [InverseProperty("Rosters")]
    public virtual Shift? Shift { get; set; }

    [ForeignKey("StoreId")]
    [InverseProperty("Rosters")]
    public virtual Store? Store { get; set; }
}
