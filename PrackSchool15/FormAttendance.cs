using Microsoft.EntityFrameworkCore;
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
                    UsernameСтудента = (a.Student != null && a.Student.User != null) ? a.Student.User.Username : null,
                    ДатаПосещения = a.AttendanceDate,
                    Присутствовал = a.IsPresent.HasValue ? (a.IsPresent.Value ? "Да" : "Нет") : "Неизвестно",
                    ПричинаОтсутствия = a.ReasonForAbsence,
                    Предмет = (a.Lesson != null && a.Lesson.Subject != null && !string.IsNullOrEmpty(a.Lesson.Subject.SubjectName)) ? a.Lesson.Subject.SubjectName : null,
                    Учитель = (a.Lesson != null && a.Lesson.Teacher != null) ? a.Lesson.Teacher.SurnameTeacher : null // Добавляем фамилию учителя
                }).ToList();

            dataGridViewAtten.DataSource = attendanceDetails;
        }
    }
}
