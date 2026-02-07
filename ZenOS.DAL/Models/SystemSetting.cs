using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class SystemSetting
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SystemSettingCode { get; set; }

    [StringLength(250)]
    public string? SystemSettingName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SettingGroup { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SettingKey { get; set; }

    [StringLength(500)]
    public string? SettingValue { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ValueType { get; set; }

    public bool? IsDelete { get; set; }

    [StringLength(500)]
    public string? Note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    public Guid? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    public Guid? UpdatedBy { get; set; }
}
