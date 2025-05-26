using System;
using System.Collections.Generic;

namespace PrackSchool15.Models;

public partial class Attendance
{
    public int AttendanceId { get; set; }

    public int StudentId { get; set; }

    public int LessonId { get; set; }

    public DateOnly? AttendanceDate { get; set; }

    public bool? IsPresent { get; set; }

    public string? ReasonForAbsence { get; set; }

    public virtual Lesson Lesson { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
