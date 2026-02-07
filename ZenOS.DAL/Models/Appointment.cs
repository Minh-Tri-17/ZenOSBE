using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class Appointment
{
    [Key]
    public Guid Id { get; set; }

    public Guid? CustomerId { get; set; }

    public Guid? StoreId { get; set; }

    public Guid? EmployeeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AppointmentDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AppointmentStatus { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(500)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("Appointments")]
    public virtual Customer? Customer { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("Appointments")]
    public virtual Employee? Employee { get; set; }

    [ForeignKey("StoreId")]
    [InverseProperty("Appointments")]
    public virtual Store? Store { get; set; }
}
