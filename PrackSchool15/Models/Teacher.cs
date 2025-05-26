using System;
using System.Collections.Generic;

namespace PrackSchool15.Models;

public partial class Teacher
{
    public int TeacherId { get; set; }

    public int UserId { get; set; }

    public int? SubjectId { get; set; }

    public DateOnly? HireDate { get; set; }

    public decimal? Salary { get; set; }

    public string? Qualification { get; set; }

    public string? NameTeacher { get; set; }

    public string? SurnameTeacher { get; set; }

    public string? PatronymicTeacher { get; set; }

    public string? EducationTeacher { get; set; }

    public string? AdressTeacher { get; set; }

    public string? NumberTeacher { get; set; }

    public string? EmailTeacher { get; set; }

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();

    public virtual ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();

    public virtual Subject? Subject { get; set; }

    public virtual User User { get; set; } = null!;
}
