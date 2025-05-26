using System;
using System.Collections.Generic;

namespace PrackSchool15;

public partial class Grade
{
    public int GradeId { get; set; }

    public int StudentId { get; set; }

    public int LessonId { get; set; }

    public int? Grade1 { get; set; }

    public DateOnly? GradeDate { get; set; }

    public string? Comment { get; set; }

    public virtual Lesson Lesson { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
