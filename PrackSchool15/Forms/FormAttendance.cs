using Microsoft.EntityFrameworkCore;
using PrackSchool15.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrackSchool15
{
    public partial class FormAttendance : Form
    {
        private School15PrackContext db;
        public FormAttendance()
        {
            InitializeComponent();
        }

        private void UpdateTable()
        {
            // Преобразуем список оценок в анонимный тип для DataGridView
            var attendanceDetails = db.Attendances.Local
               .Select(a => new
               {
                   a.AttendanceId,
                   Ученик = (a.Student != null && a.Student.User != null) ? a.Student.User.Username : null,
                   ДатаПосещения = a.AttendanceDate,
                   Присутствовал = a.IsPresent.HasValue ? (a.IsPresent.Value ? "Да" : "Нет") : "Неизвестно",
                   Причина = a.ReasonForAbsence,
                   Предмет = (a.Lesson != null && a.Lesson.Subject != null && !string.IsNullOrEmpty(a.Lesson.Subject.SubjectName)) ? a.Lesson.Subject.SubjectName : null,
                   Учитель = (a.Lesson != null && a.Lesson.Teacher != null) ? a.Lesson.Teacher.SurnameTeacher : null // Добавляем фамилию учителя
               }).ToList();

            dataGridViewAtten.DataSource = attendanceDetails;
            dataGridViewAtten.Columns["AttendanceId"].Visible = false;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            db = new School15PrackContext();

            // Жадная загрузка связанных данных
            db.Attendances
                .Include(a => a.Student)
                .ThenInclude(s => s.User)
                .Include(a => a.Lesson)
                .ThenInclude(l => l.Subject)
                .Include(a => a.Lesson.Teacher) // Загружаем информацию об учителе, ведущем урок
                .Load();

            // Преобразуем список посещаемости в анонимный тип для DataGridView
            var attendanceDetails = db.Attendances.Local
               .Select(a => new
               {
                   a.AttendanceId,
                   Ученик = (a.Student != null && a.Student.User != null) ? a.Student.User.Username : null,
                   ДатаПосещения = a.AttendanceDate,
                   Присутствовал = a.IsPresent.HasValue ? (a.IsPresent.Value ? "Да" : "Нет") : "Неизвестно",
                   Причина = a.ReasonForAbsence,
                   Предмет = (a.Lesson != null && a.Lesson.Subject != null && !string.IsNullOrEmpty(a.Lesson.Subject.SubjectName)) ? a.Lesson.Subject.SubjectName : null,
                   Учитель = (a.Lesson != null && a.Lesson.Teacher != null) ? a.Lesson.Teacher.SurnameTeacher : null // Добавляем фамилию учителя
               }).ToList();

            dataGridViewAtten.DataSource = attendanceDetails;
            dataGridViewAtten.Columns["AttendanceId"].Visible = false;
        }

        private void buttonAddAtten_Click(object sender, EventArgs e)
        {
            FormAttendanceAdd form = new FormAttendanceAdd();

            DialogResult result = form.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }

            Attendance atteny = new Attendance();
            try
            {
                atteny = new Attendance
                {
                    StudentId = (int)form.comboBoxUsernameAdd.SelectedValue,
                    LessonId = (int)form.comboBoxLessonInfo.SelectedValue,
                    AttendanceDate = DateOnly.FromDateTime(form.dateTimePickerAttenDate.Value),
                    IsPresent = form.checkBoxPresent.Checked,
                    ReasonForAbsence = form.textBoxReasonAbsence.Text
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            db.Attendances.Add(atteny);
            db.SaveChanges();

            UpdateTable();
        }

        private void buttonEditAtten_Click(object sender, EventArgs e)
        {
            if (dataGridViewAtten.SelectedRows.Count == 0)
                return;
            int id = (int)dataGridViewAtten.SelectedRows[0].Cells["AttendanceId"].Value;
            var atteny = db.Attendances.FirstOrDefault(u => u.AttendanceId == id);

            if (atteny != null)
            {
                // Открываем форму редактирования, передаем выбранного студента
                FormAttendanceAdd editForm = new FormAttendanceAdd(atteny);
                if (editForm.ShowDialog() == DialogResult.OK)  //  Проверяем, что форма редактирования была закрыта успешно
                {
                    var attendanceDetails = db.Attendances.Local
                .Select(a => new
                {
                    a.AttendanceId,
                    ИмяЮзера = (a.Student != null && a.Student.User != null) ? a.Student.User.Username : null,
                    ДатаПосещения = a.AttendanceDate,
                    Присутствовал = a.IsPresent.HasValue ? (a.IsPresent.Value ? "Да" : "Нет") : "Неизвестно",
                    ПричинаОтсутствия = a.ReasonForAbsence,
                    Предмет = (a.Lesson != null && a.Lesson.Subject != null && !string.IsNullOrEmpty(a.Lesson.Subject.SubjectName)) ? a.Lesson.Subject.SubjectName : null,
                    Учитель = (a.Lesson != null && a.Lesson.Teacher != null) ? a.Lesson.Teacher.SurnameTeacher : null // Добавляем фамилию учителя
                }).ToList();

                    dataGridViewAtten.DataSource = attendanceDetails;
                    dataGridViewAtten.Columns["AttendanceId"].Visible = false;
                    db.SaveChanges();
                    MessageBox.Show("Данные о посещаемости изменены");
                    UpdateTable();
                }
            }
        }

        private void buttonDelAtten_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewAtten.SelectedRows[0].Cells["AttendanceId"].Value;
            var atteny = db.Attendances.FirstOrDefault(u => u.AttendanceId == id);

            if (atteny != null)
            {
                var confirmResult = MessageBox.Show(
                    "Вы уверены, что хотите удалить данные об посещаемости?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {

                    // Удаляем сам класс
                    db.Attendances.Remove(atteny);

                    db.SaveChanges();
                    MessageBox.Show("Данные о посещаемости удалены.");
                    UpdateTable();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите посещаемость для удаления.");
            }
        }
    }
}
