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

    public partial class FormGradesAdd : Form
    {
        private School15PrackContext db;
        public FormGradesAdd()
        {
            InitializeComponent();
        }

        public FormGradesAdd(Grade gradee)
        {
            InitializeComponent();
            Gradee = gradee;
        }

        public Grade Gradee { get; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            db = new School15PrackContext();

            comboBoxNameUser.DataSource = db.Students
                .Select(u => new
                {
                    u.StudentId,
                    u.User.Username
                })
                .ToList();
            comboBoxNameUser.DisplayMember = "Username";
            comboBoxNameUser.ValueMember = "studentid";

            /*comboBoxLessonInfo.DataSource = db.Lessons
                .Select(u => new
                {
                    u.LessonId,
                    inf = u.Class.ClassName + " " + u.Teacher.NameTeacher + " " + u.Teacher.SurnameTeacher + " " + u.Teacher.PatronymicTeacher + " " + u.LessonDate + " " +
                     u.StartTime + " " + u.EndTime + " " + u.RoomNumber
                })
                .ToList();
            comboBoxLessonInfo.DisplayMember = "inf";
            comboBoxLessonInfo.ValueMember = "lessonid";*/
            comboBoxLessonInfo.DataSource = db.Lessons
                .Select(u => new
                {
                    u.LessonId,
                    inf = u.Class.ClassName + ", " + u.Teacher.NameTeacher + " " + u.Teacher.SurnameTeacher + " " + u.Teacher.PatronymicTeacher + ", " + "Дата: " + u.LessonDate + ", " + "Начало урока: " +
                     u.StartTime + ", " + "Конец урока: " + u.EndTime + ", " + "Кабинет: " + u.RoomNumber
                })
                .ToList();
            comboBoxLessonInfo.DisplayMember = "inf";
            comboBoxLessonInfo.ValueMember = "lessonid";

            if (Gradee != null)
            {
                this.Text = "Редактирование оценок";
                comboBoxNameUser.SelectedValue = Gradee.StudentId;
                comboBoxLessonInfo.SelectedValue = Gradee.LessonId;
                dateTimePickerGrade.Value = ((DateOnly)Gradee.GradeDate).ToDateTime(new TimeOnly(0, 0, 0));
                textBoxGradeNum.Text = Gradee.Grade1.ToString();
                textBoxComments.Text = Gradee.Comment;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Gradee == null)
            {
                try
                {
                    // 1. Валидация данных
                    if (comboBoxNameUser.SelectedItem ==null||
                        comboBoxLessonInfo.SelectedItem == null ||
                      string.IsNullOrWhiteSpace (textBoxGradeNum.Text)||
                      string.IsNullOrWhiteSpace(textBoxComments.Text))
                    {
                        MessageBox.Show("Пожалуйста, заполните все поля.");
                        return;
                    }

                    var newGrade = new Grade
                    {
                        StudentId = (int)comboBoxNameUser.SelectedValue,
                        LessonId = (int)comboBoxLessonInfo.SelectedValue,
                        Grade1 = Int32.Parse(textBoxGradeNum.Text),
                        GradeDate = DateOnly.FromDateTime(dateTimePickerGrade.Value),
                        Comment = textBoxComments.Text
                    };
                    db.Grades.Add(newGrade);
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

                Gradee.StudentId = (int)comboBoxNameUser.SelectedValue; ;
                Gradee.LessonId = (int)comboBoxLessonInfo.SelectedValue;
                Gradee.Grade1 = Int32.Parse(textBoxGradeNum.Text);
                Gradee.GradeDate = DateOnly.FromDateTime(dateTimePickerGrade.Value);
                Gradee.Comment = textBoxComments.Text;
                db.SaveChanges();

                MessageBox.Show("Пользователь и класс успешно отредакрированны!");

            }
        }
    }
}