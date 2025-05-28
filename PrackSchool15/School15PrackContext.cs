using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PrackSchool15.Models;

namespace PrackSchool15;

public partial class School15PrackContext : DbContext
{
    public School15PrackContext()
    {
    }

    public School15PrackContext(DbContextOptions<School15PrackContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Attendance> Attendances { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<Grade> Grades { get; set; }

    public virtual DbSet<Lesson> Lessons { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=School15Prack;Username=postgres;Password=1234");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Attendance>(entity =>
        {
            entity.HasKey(e => e.AttendanceId).HasName("attendance_pkey");

            entity.ToTable("attendance");

            entity.Property(e => e.AttendanceId)
                .ValueGeneratedNever()
                .HasColumnName("attendance_id");
            entity.Property(e => e.AttendanceDate).HasColumnName("attendance_date");
            entity.Property(e => e.IsPresent).HasColumnName("is_present");
            entity.Property(e => e.LessonId).HasColumnName("lesson_id");
            entity.Property(e => e.ReasonForAbsence).HasColumnName("reason_for_absence");
            entity.Property(e => e.StudentId).HasColumnName("student_id");

            entity.HasOne(d => d.Lesson).WithMany(p => p.Attendances)
                .HasForeignKey(d => d.LessonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("attendance_lesson_id_fkey");

            entity.HasOne(d => d.Student).WithMany(p => p.Attendances)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("attendance_student_id_fkey");
        });

        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.ClassId).HasName("classes_pkey");

            entity.ToTable("classes");

            entity.HasIndex(e => e.ClassName, "classes_class_name_key").IsUnique();

            entity.Property(e => e.ClassId)
                .ValueGeneratedNever()
                .HasColumnName("class_id");
            entity.Property(e => e.ClassName)
                .HasMaxLength(10)
                .HasColumnName("class_name");
            entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

            entity.HasOne(d => d.Teacher).WithMany(p => p.Classes)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("classes_teacher_id_fkey");
        });

        modelBuilder.Entity<Grade>(entity =>
        {
            entity.HasKey(e => e.GradeId).HasName("grades_pkey");

            entity.ToTable("grades");

            entity.Property(e => e.GradeId)
                .ValueGeneratedNever()
                .HasColumnName("grade_id");
            entity.Property(e => e.Comment).HasColumnName("comment");
            entity.Property(e => e.Grade1).HasColumnName("grade");
            entity.Property(e => e.GradeDate).HasColumnName("grade_date");
            entity.Property(e => e.LessonId).HasColumnName("lesson_id");
            entity.Property(e => e.StudentId).HasColumnName("student_id");

            entity.HasOne(d => d.Lesson).WithMany(p => p.Grades)
                .HasForeignKey(d => d.LessonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("grades_lesson_id_fkey");

            entity.HasOne(d => d.Student).WithMany(p => p.Grades)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("grades_student_id_fkey");
        });

        modelBuilder.Entity<Lesson>(entity =>
        {
            entity.HasKey(e => e.LessonId).HasName("lessons_pkey");

            entity.ToTable("lessons");

            entity.Property(e => e.LessonId)
                .ValueGeneratedNever()
                .HasColumnName("lesson_id");
            entity.Property(e => e.ClassId).HasColumnName("class_id");
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.LessonDate).HasColumnName("lesson_date");
            entity.Property(e => e.RoomNumber)
                .HasMaxLength(10)
                .HasColumnName("room_number");
            entity.Property(e => e.StartTime).HasColumnName("start_time");
            entity.Property(e => e.SubjectId).HasColumnName("subject_id");
            entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

            entity.HasOne(d => d.Class).WithMany(p => p.Lessons)
                .HasForeignKey(d => d.ClassId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("lessons_class_id_fkey");

            entity.HasOne(d => d.Subject).WithMany(p => p.Lessons)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("lessons_subject_id_fkey");

            entity.HasOne(d => d.Teacher).WithMany(p => p.Lessons)
                .HasForeignKey(d => d.TeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("lessons_teacher_id_fkey");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("roles_pkey");

            entity.ToTable("roles");

            entity.HasIndex(e => e.RoleName, "roles_role_name_key").IsUnique();

            entity.Property(e => e.RoleId)
                .ValueGeneratedNever()
                .HasColumnName("role_id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .HasColumnName("role_name");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("students_pkey");

            entity.ToTable("students");

            entity.HasIndex(e => e.UserId, "students_user_id_key").IsUnique();

            entity.Property(e => e.StudentId)
                .HasDefaultValueSql("nextval('students_id_seq'::regclass)")
                .HasColumnName("student_id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.AdmissionDate).HasColumnName("admission_date");
            entity.Property(e => e.ClassId).HasColumnName("class_id");
            entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth");
            entity.Property(e => e.ParentName)
                .HasMaxLength(100)
                .HasColumnName("parent_name");
            entity.Property(e => e.ParentPhone)
                .HasMaxLength(20)
                .HasColumnName("parent_phone");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .HasColumnName("phone_number");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Class).WithMany(p => p.Students)
                .HasForeignKey(d => d.ClassId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("students_class_id_fkey");

            entity.HasOne(d => d.User).WithOne(p => p.Student)
                .HasForeignKey<Student>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("students_user_id_fkey");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.SubjectId).HasName("subjects_pkey");

            entity.ToTable("subjects");

            entity.HasIndex(e => e.SubjectName, "subjects_subject_name_key").IsUnique();

            entity.Property(e => e.SubjectId)
                .ValueGeneratedNever()
                .HasColumnName("subject_id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.SubjectName)
                .HasMaxLength(100)
                .HasColumnName("subject_name");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.TeacherId).HasName("teachers_pkey");

            entity.ToTable("teachers");

            entity.HasIndex(e => e.UserId, "teachers_user_id_key").IsUnique();

            entity.Property(e => e.TeacherId)
                .ValueGeneratedNever()
                .HasColumnName("teacher_id");
            entity.Property(e => e.HireDate).HasColumnName("hire_date");
            entity.Property(e => e.Qualification).HasColumnName("qualification");
            entity.Property(e => e.Salary)
                .HasPrecision(10, 2)
                .HasColumnName("salary");
            entity.Property(e => e.SubjectId).HasColumnName("subject_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Subject).WithMany(p => p.Teachers)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("teachers_subject_id_fkey");

            entity.HasOne(d => d.User).WithOne(p => p.Teacher)
                .HasForeignKey<Teacher>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("teachers_user_id_fkey");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("users_pkey");

            entity.ToTable("users");

            entity.HasIndex(e => e.Username, "users_username_key").IsUnique();

            entity.Property(e => e.UserId)
                .HasDefaultValueSql("nextval('users_id_seq'::regclass)")
                .HasColumnName("user_id");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("users_role_id_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
