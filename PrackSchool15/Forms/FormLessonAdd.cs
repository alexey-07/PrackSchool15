using PrackSchool15.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrackSchool15
{
    public partial class FormLessonAdd : Form
    {
        private School15PrackContext db;
        public FormLessonAdd()
        {
            InitializeComponent();
        }

        public FormLessonAdd(Lesson lessony)
        {
            InitializeComponent();
            Lessony = lessony;
        }

        public Lesson Lessony { get; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            db = new School15PrackContext();
            comboBoxClassInto.DataSource = db.Classes
                .Select(u => new
                {
                    u.ClassId,
                    u.ClassName
                }
                )
                .ToList();
            comboBoxClassInto.DisplayMember = "Classname";
            comboBoxClassInto.ValueMember = "ClassId";

            comboBoxSubjectInto.DataSource = db.Subjects
                .Select(s => new
                {
                    s.SubjectId,
                    s.SubjectName
                }
                ).ToList();
            comboBoxSubjectInto.DisplayMember = "SubjectName";
            comboBoxSubjectInto.ValueMember = "SubjectId";

            comboBoxTeacherInto.DataSource = db.Teachers
                .Select(c => new
                {
                    c.TeacherId,
                    FIO = c.NameTeacher + " " + c.SurnameTeacher + " " + c.PatronymicTeacher + ", " + c.Qualification
                }
                ).ToList();
            comboBoxTeacherInto.DisplayMember = "FIO";
            comboBoxTeacherInto.ValueMember = "TeacherId";

            /* comboBoxRoomNum.DataSource = db.Lessons
                 .Select(a => new
                 {
         *//*            a.LessonId,*//*
                     a.RoomNumber
                 }
                 ).ToList();*/
            comboBoxRoomNum.DataSource = db.Lessons
                .Where(a => a.RoomNumber != null && a.RoomNumber.Length <= 10)
                .Select(a => new
                {
                    a.LessonId,
                    a.RoomNumber
                })
                .Distinct()
                .ToList();
            comboBoxRoomNum.DisplayMember = "RoomNumber";
            comboBoxRoomNum.ValueMember = "LessonId";

            if (Lessony != null)
            {
                comboBoxClassInto.SelectedValue = Lessony.ClassId;
                comboBoxSubjectInto.SelectedValue = Lessony.SubjectId;
                comboBoxTeacherInto.SelectedValue = Lessony.TeacherId;
                dateTimePickerLessonDate.Value = ((DateOnly)Lessony.LessonDate).ToDateTime(new TimeOnly(0, 0, 0));
              /*   dateTimePickerStartTime.Value = Lessony.StartTime.ToDateTime(TimeOnly.MinValue);
                *//*  dateTimePickerEndTime.Value = Lessony.LessonDate.*/
                comboBoxRoomNum.SelectedValue = Lessony.RoomNumber;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Lessony == null)
            {
               /* try
                {*/
                    // 1. Валидация данных
                    if (comboBoxClassInto.SelectedItem == null ||
                        comboBoxSubjectInto.SelectedItem == null ||
                         comboBoxTeacherInto.SelectedItem == null ||
                      comboBoxRoomNum.SelectedItem == null)
                      
                    {
                        MessageBox.Show("Пожалуйста, заполните все поля.");
                        return;
                    }

                    var newLesson = new Lesson
                    {
                        ClassId = (int)comboBoxClassInto.SelectedValue,
                        SubjectId = (int)comboBoxSubjectInto.SelectedValue,
                        TeacherId = (int)comboBoxTeacherInto.SelectedValue,
                        LessonDate = DateOnly.FromDateTime(dateTimePickerLessonDate.Value),
                        StartTime=TimeOnly.FromDateTime(dateTimePickerStartTime.Value),
                        EndTime = TimeOnly.FromDateTime(dateTimePickerEndTime.Value),
                        RoomNumber = comboBoxRoomNum.SelectedItem?.ToString()
                    };
                    db.Lessons.Add(newLesson);
                    db.SaveChanges();
                    MessageBox.Show("Расписание успешно добавлена!");
                    DialogResult = DialogResult.OK;
                
               /* catch (EntityException ex)
                {
                    MessageBox.Show($"Ошибка базы данных: {ex.InnerException?.Message ?? ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }*/
            }
            else
            {

                Lessony.ClassId = (int)comboBoxClassInto.SelectedValue; ;
                Lessony. SubjectId= (int)comboBoxSubjectInto.SelectedValue;
                Lessony.TeacherId = (int)comboBoxTeacherInto.SelectedValue;
                Lessony.LessonDate = DateOnly.FromDateTime(dateTimePickerLessonDate.Value);
                Lessony.StartTime = TimeOnly.FromDateTime(dateTimePickerStartTime.Value);
                Lessony.EndTime = TimeOnly.FromDateTime(dateTimePickerEndTime.Value);
                Lessony.RoomNumber = comboBoxRoomNum.SelectedItem?.ToString();
                db.SaveChanges();

                MessageBox.Show("Расписание успешно отредакрированно!");

            }
        }
    }
}
