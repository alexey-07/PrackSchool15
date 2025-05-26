using System;
using System.Collections.Generic;

namespace PrackSchool15.Models;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string SubjectName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();

    public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}
