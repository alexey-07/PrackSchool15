using System;
using System.Collections.Generic;

namespace PrackSchool15.Models;

public partial class Class
{
    public int ClassId { get; set; }

    public string ClassName { get; set; } = null!;

    public int? TeacherId { get; set; }

    public virtual ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual Teacher? Teacher { get; set; }

}
