using System;
using System.Collections.Generic;

namespace PrackSchool15.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public int UserId { get; set; }

    public int ClassId { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public DateOnly? AdmissionDate { get; set; }

    public string? ParentName { get; set; }

    public string? ParentPhone { get; set; }

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual Class Class { get; set; } = null!;

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();

    public virtual User User { get; set; } = null!;
  /*  public string Username { get; internal set; }
    public string Password { get; internal set; }*/
}
