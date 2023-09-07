using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models1;

public partial class StudentGrade
{
    [Key]
    public int Id { get; set; }

    public int? Score { get; set; }

    public int StudentId { get; set; }

    [ForeignKey("StudentId")]
    [InverseProperty("StudentGrades")]
    public virtual Student Student { get; set; } = null!;
}
