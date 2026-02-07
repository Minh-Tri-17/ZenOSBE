using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ZenOS.DAL.Models;

public partial class CodeSequence
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EntityName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Prefix { get; set; }

    public int? EntityValue { get; set; }
}
