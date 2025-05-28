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
                    Студент = (c.Student != null && c.Student.User != null) ? c.Student.User.Username : null,
                    Оценки = c.Grade1,
                    ДатаВыставления = c.GradeDate,
                    Комментарий = c.Comment,
                    Предмет = (c.Lesson != null && c.Lesson.Subject != null) ? c.Lesson.Subject.SubjectName : null
                }).ToList();

            dataGridViewGrade.DataSource = gradesWithGroup;
        }
    }
}