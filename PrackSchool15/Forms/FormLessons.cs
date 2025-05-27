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
    
    public partial class FormLessons : Form
    {
        private School15PrackContext db;
        public FormLessons()
        {
            InitializeComponent();
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
                    НазваниеКласса = (l.Class != null) ? l.Class.ClassName : null,
                    Предмет = (l.Subject != null) ? l.Subject.SubjectName : null,
                    Учитель = (l.Teacher != null) ? $"{l.Teacher.SurnameTeacher} {l.Teacher.NameTeacher} {l.Teacher.PatronymicTeacher}" : null, // Собираем ФИО учителя
                    ДатаУрока = l.LessonDate,
                    НачалоУрока = l.StartTime, //  Предполагаем, что это `TimeSpan` или `DateTime`
                    КонецУрока = l.EndTime,  //  Предполагаем, что это `TimeSpan` или `DateTime`
                    Кабинет = l.RoomNumber
                }).ToList();

            dataGridViewLesson.DataSource = lessonsWithDetails;
        }
    }
}
