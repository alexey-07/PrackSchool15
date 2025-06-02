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
    public partial class FormAttendanceAdd : Form
    {
        private School15PrackContext db;
        public FormAttendanceAdd()
        {
            InitializeComponent();
        }

        public FormAttendanceAdd(Attendance atteny)
        {
            InitializeComponent();
            Atteny = atteny;
        }

        public Attendance Atteny { get; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            db = new School15PrackContext();

            comboBoxUsernameAdd.DataSource = db.Students
                .Select(u => new
                {
                    u.StudentId,
                    u.User.Username
                })
                .ToList();
            comboBoxUsernameAdd.DisplayMember = "Username";
            comboBoxUsernameAdd.ValueMember = "studentid";

            comboBoxLessonInfo.DataSource = db.Lessons
                .Select(u => new
                {
                    u.LessonId,
                    inf = u.Class.ClassName + " " + u.Teacher.NameTeacher + " " + u.Teacher.SurnameTeacher + " " + u.Teacher.PatronymicTeacher + " " + u.LessonDate + " " +
                     u.StartTime + " " + u.EndTime + " " + u.RoomNumber
                })
                .ToList();
            comboBoxLessonInfo.DisplayMember = "inf";
            comboBoxLessonInfo.ValueMember = "lessonid";

            if (Atteny != null)
            {
                comboBoxUsernameAdd.SelectedValue = Atteny.StudentId;
                comboBoxLessonInfo.SelectedValue = Atteny.LessonId;
                dateTimePickerAttenDate.Value = ((DateOnly)Atteny.AttendanceDate).ToDateTime(new TimeOnly(0, 0, 0));
                checkBoxPresent.Checked = Atteny.IsPresent ?? false;
                textBoxReasonAbsence.Text = Atteny.ReasonForAbsence;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Atteny == null)
            {
                try
                {
                    // 1. Валидация данных
                    if (comboBoxUsernameAdd.SelectedItem == null ||
                        comboBoxLessonInfo.SelectedItem == null ||
                      checkBoxPresent.Checked ==null||
                      string.IsNullOrWhiteSpace(textBoxReasonAbsence.Text))
                    {
                        MessageBox.Show("Пожалуйста, заполните все поля.");
                        return;
                    }

                    var newAttendance = new Attendance
                    {
                        StudentId = (int)comboBoxUsernameAdd.SelectedValue,
                        LessonId = (int)comboBoxLessonInfo.SelectedValue,
                        AttendanceDate = DateOnly.FromDateTime(dateTimePickerAttenDate.Value),
                        IsPresent = checkBoxPresent.Checked,
                        ReasonForAbsence = textBoxReasonAbsence.Text
                    };
                    db.Attendances.Add(newAttendance);
                    db.SaveChanges();
                    MessageBox.Show("Посещаемость успешно добавлена!");
                    DialogResult = DialogResult.OK;
                }
                catch (EntityException ex)
                {
                    MessageBox.Show($"Ошибка базы данных: {ex.InnerException?.Message ?? ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }
            else
            {

                Atteny.StudentId = (int)comboBoxUsernameAdd.SelectedValue; ;
                Atteny.LessonId = (int)comboBoxLessonInfo.SelectedValue;
                Atteny.AttendanceDate = DateOnly.FromDateTime(dateTimePickerAttenDate.Value);
                Atteny.IsPresent= checkBoxPresent.Checked;
                Atteny.ReasonForAbsence = textBoxReasonAbsence.Text;
                db.SaveChanges();

                MessageBox.Show("Пользователь и класс успешно отредакрированны!");

            }
        }
    }
}
