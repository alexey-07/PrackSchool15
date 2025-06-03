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

    public partial class FormLessons : Form
    {
        private School15PrackContext db;
        public FormLessons()
        {
            InitializeComponent();
        }

        private void UpdateTable()
        {
            // Преобразуем список оценок в анонимный тип для DataGridView
            var lessonsWithDetails = db.Lessons.Local
                .Select(l => new
                {
                    l.LessonId,
                    НазваниеКласса = (l.Class != null) ? l.Class.ClassName : null,
                    Предмет = (l.Subject != null) ? l.Subject.SubjectName : null,
                    Учитель = (l.Teacher != null) ? $"{l.Teacher.SurnameTeacher} {l.Teacher.NameTeacher} {l.Teacher.PatronymicTeacher}" : null, // Собираем ФИО учителя
                    ДатаУрока = l.LessonDate,
                    НачалоУрока = l.StartTime, //  Предполагаем, что это `TimeSpan` или `DateTime`
                    КонецУрока = l.EndTime,  //  Предполагаем, что это `TimeSpan` или `DateTime`
                    Кабинет = l.RoomNumber
                }).ToList();

            dataGridViewLesson.DataSource = lessonsWithDetails;
            dataGridViewLesson.Columns["LessonId"].Visible = false;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            db = new School15PrackContext();

            // Жадная загрузка связанных данных для уроков
            db.Lessons
                .Include(l => l.Class)      // Загружаем информацию о классе
                .Include(l => l.Subject)    // Загружаем информацию о предмете
                .Include(l => l.Teacher)    // Загружаем информацию об учителе
                .Load();

            // Преобразуем список уроков в анонимный тип для DataGridView
            var lessonsWithDetails = db.Lessons.Local
                .Select(l => new
                {
                    l.LessonId,
                    НазваниеКласса = (l.Class != null) ? l.Class.ClassName : null,
                    Предмет = (l.Subject != null) ? l.Subject.SubjectName : null,
                    Учитель = (l.Teacher != null) ? $"{l.Teacher.SurnameTeacher} {l.Teacher.NameTeacher} {l.Teacher.PatronymicTeacher}" : null, // Собираем ФИО учителя
                    ДатаУрока = l.LessonDate,
                    НачалоУрока = l.StartTime, //  Предполагаем, что это `TimeSpan` или `DateTime`
                    КонецУрока = l.EndTime,  //  Предполагаем, что это `TimeSpan` или `DateTime`
                    Кабинет = l.RoomNumber
                }).ToList();

            dataGridViewLesson.DataSource = lessonsWithDetails;
            dataGridViewLesson.Columns["LessonId"].Visible = false;
        }

        private void buttonAddLesson_Click(object sender, EventArgs e)
        {
            FormLessonAdd form = new FormLessonAdd();

            DialogResult result = form.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }
      /*      MessageBox.Show(form.comboBoxRoomNum.SelectedItem.ToString());*/
            Lesson lessonly = new Lesson();
            try
            {
                lessonly = new Lesson
                {
                    ClassId = (int)form.comboBoxClassInto.SelectedValue,
                    SubjectId = (int)form.comboBoxSubjectInto.SelectedValue,
                    TeacherId = (int)form.comboBoxTeacherInto.SelectedValue,
                    LessonDate = DateOnly.FromDateTime(form.dateTimePickerLessonDate.Value),
                    StartTime = TimeOnly.FromDateTime(form.dateTimePickerStartTime.Value),
                    EndTime = TimeOnly.FromDateTime(form.dateTimePickerEndTime.Value),

                    RoomNumber =form.textBoxRoom.Text
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
            db.Lessons.Add(lessonly);
            db.SaveChanges();

            UpdateTable();
        }

        private void buttonEditLesson_Click(object sender, EventArgs e)
        {
            if (dataGridViewLesson.SelectedRows.Count == 0)
                return;
            int id = (int)dataGridViewLesson.SelectedRows[0].Cells["LessonId"].Value;
            var lessony = db.Lessons.FirstOrDefault(u => u.LessonId == id);

            if (lessony != null)
            {
                // Открываем форму редактирования, передаем выбранного студента
                FormLessonAdd editForm = new FormLessonAdd(lessony);
                if (editForm.ShowDialog() == DialogResult.OK)  //  Проверяем, что форма редактирования была закрыта успешно
                {
                    var lessonsWithDetails = db.Lessons.Local
                  .Select(l => new
                  {
                      l.LessonId,
                      НазваниеКласса = (l.Class != null) ? l.Class.ClassName : null,
                      Предмет = (l.Subject != null) ? l.Subject.SubjectName : null,
                      Учитель = (l.Teacher != null) ? $"{l.Teacher.SurnameTeacher} {l.Teacher.NameTeacher} {l.Teacher.PatronymicTeacher}" : null, // Собираем ФИО учителя
                      ДатаУрока = l.LessonDate,
                      НачалоУрока = l.StartTime, //  Предполагаем, что это `TimeSpan` или `DateTime`
                      КонецУрока = l.EndTime,  //  Предполагаем, что это `TimeSpan` или `DateTime`
                      Кабинет = l.RoomNumber
                  }).ToList();

                    dataGridViewLesson.DataSource = lessonsWithDetails;
                    dataGridViewLesson.Columns["LessonId"].Visible = false;
                    db.SaveChanges();
                    MessageBox.Show("Данные о расписании изменены");
                    UpdateTable();

                }
            }
        }

        private void buttonDelLesson_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewLesson.SelectedRows[0].Cells["LessonId"].Value;
            var lessony = db.Lessons.FirstOrDefault(u => u.LessonId == id);

            if (lessony != null)
            {
                var confirmResult = MessageBox.Show(
                    "Вы уверены, что хотите удалить данные об посещаемости?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    db.Attendances.Where(u => u.LessonId == id).ExecuteDelete();
                    db.Grades.Where(u => u.LessonId == id).ExecuteDelete();
                    // Удаляем сам класс
                    db.Lessons.Remove(lessony);

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
