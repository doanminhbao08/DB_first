using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EF_DBFirst.Models;

[Keyless]
[Table("db_first")]
public partial class DbFirst
{
    [StringLength(10)]
    public string? Ten { get; set; }

    public int? Tuoi { get; set; }

    [StringLength(10)]
    public string? Lop { get; set; }
}
