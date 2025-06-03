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
    public partial class FormGrades : Form
    {
        private School15PrackContext db;
        public FormGrades()
        {
            InitializeComponent();
        }
        private void UpdateTable()
        {
            // Преобразуем список оценок в анонимный тип для DataGridView
            var gradesWithGroup = db.Grades.Local
                .Select(c => new
                {
                    c.GradeId,
                    Ученик = (c.Student != null && c.Student.User != null) ? c.Student.User.Username : null,
                    Оценки = c.Grade1,
                    ДатаВыставления = c.GradeDate,
                    Комментарий = c.Comment,
                    Предмет = (c.Lesson != null && c.Lesson.Subject != null) ? c.Lesson.Subject.SubjectName : null
                }).ToList();

            dataGridViewGrade.DataSource = gradesWithGroup;
            dataGridViewGrade.Columns["GradeId"].Visible = false;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            db = new School15PrackContext();

            // Жадная загрузка Student, User, Lesson и Subject
            db.Grades
                .Include(c => c.Student)
                .ThenInclude(s => s.User)
                .Include(c => c.Lesson)
                .ThenInclude(l => l.Subject) // Загружаем информацию о предмете
                .Load();

            // Преобразуем список оценок в анонимный тип для DataGridView
            var gradesWithGroup = db.Grades.Local
                .Select(c => new
                {
                    c.GradeId,
                    Ученик = (c.Student != null && c.Student.User != null) ? c.Student.User.Username : null,
                    Оценки = c.Grade1,
                    ДатаВыставления = c.GradeDate,
                    Комментарий = c.Comment,
                    Предмет = (c.Lesson != null && c.Lesson.Subject != null) ? c.Lesson.Subject.SubjectName : null
                }).ToList();

            dataGridViewGrade.DataSource = gradesWithGroup;
            dataGridViewGrade.Columns["GradeId"].Visible = false;
        }

        private void buttonAddGrade_Click(object sender, EventArgs e)
        {
            FormGradesAdd form = new FormGradesAdd();

            DialogResult result = form.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }

            Grade grady = new Grade();
            try
            {
                grady = new Grade
                {
                    StudentId = (int)form.comboBoxNameUser.SelectedValue,
                    LessonId = (int)form.comboBoxLessonInfo.SelectedValue,
                    Grade1 = Int32.Parse(form.textBoxGradeNum.Text),
                    GradeDate = DateOnly.FromDateTime(form.dateTimePickerGrade.Value),
                    Comment = form.textBoxComments.Text

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
            db.Grades.Add(grady);
            db.SaveChanges();

            UpdateTable();
        }

        private void buttonEditGrade_Click(object sender, EventArgs e)
        {
            if (dataGridViewGrade.SelectedRows.Count == 0)
                return;
            int id = (int)dataGridViewGrade.SelectedRows[0].Cells["GradeId"].Value;
            var gradee = db.Grades.FirstOrDefault(u => u.GradeId == id);

            if (gradee != null)
            {
                // Открываем форму редактирования, передаем выбранного студента
                FormGradesAdd editForm = new FormGradesAdd(gradee);
                if (editForm.ShowDialog() == DialogResult.OK)  //  Проверяем, что форма редактирования была закрыта успешно
                {
                    var gradesWithGroup = db.Grades.Local
                  .Select(c => new
                  {    
                      c.GradeId,
                      Ученик = (c.Student != null && c.Student.User != null) ? c.Student.User.Username : null,
                      Оценки = c.Grade1,
                      ДатаВыставления = c.GradeDate,
                      Комментарий = c.Comment,
                      Предмет = (c.Lesson != null && c.Lesson.Subject != null) ? c.Lesson.Subject.SubjectName : null
                  }).ToList();

                    dataGridViewGrade.DataSource = gradesWithGroup;
                    dataGridViewGrade.Columns["GradeId"].Visible = false;
                    db.SaveChanges();
                    MessageBox.Show("Данные о оценках изменены");
                }
            }
        }

        private void buttonDelGrade_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewGrade.SelectedRows[0].Cells["GradeId"].Value;
            var gradee = db.Grades.FirstOrDefault(u => u.GradeId == id);

            if (gradee != null)
            {
                var confirmResult = MessageBox.Show(
                    "Вы уверены, что хотите удалить данные об оценки?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                   
                    // Удаляем сам класс
                    db.Grades.Remove(gradee);

                    db.SaveChanges();
                    MessageBox.Show("Данные о оценки удалены.");
                    UpdateTable();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите оценку для удаления.");
            }
        }
    }
}
