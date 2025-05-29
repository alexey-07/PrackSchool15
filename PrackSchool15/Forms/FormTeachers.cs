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
    public partial class FormTeachers : Form
    {
        private School15PrackContext db;
        private BindingSource teachersBindingSource = new BindingSource();
        public FormTeachers()
        {
            InitializeComponent();

        }

        protected override void OnLoad(EventArgs e)
        {

            base.OnLoad(e);
            /* LoadTeachers();*/ // Загружаем список преподавателей
            db = new School15PrackContext();
            db.Teachers.Include(c => c.Classes).Load();
            db.Teachers.Include(c => c.Subject).Load();
            db.Teachers.Include(c => c.User).Load();


            // Преобразуем список в новый объект, где видно название группы
            var teacherWithClass = db.Teachers.Local
                  .Select(c => new
                  {
                      c.TeacherId,
                      Юзер = c.User != null ? c.User.Username : null,
                      Предмет = c.Subject != null ? c.Subject.SubjectName : null,
                      /*Группа = c.Class != null ? c.Class.ClassName : null,*/
                      ДатаПриемаНаРаботу = c.HireDate,
                      Зарплата = c.Salary,
                      Квалификация = c.Qualification,
                      ИмяУчителя = c.NameTeacher,
                      ФамилияУчителя = c.SurnameTeacher,
                      Отечество = c.PatronymicTeacher,
                      Образование = c.EducationTeacher,
                      Адрес = c.AdressTeacher,
                      НомерТелефона = c.NumberTeacher,
                      Почта = c.EmailTeacher
                  }).ToList();

            dataGridViewTeacher.DataSource = teacherWithClass;

            dataGridViewTeacher.Columns["teacherid"].Visible = false;

        }
        private void LoadTeachers()
        {
           /* try
            {*/
                // Загружаем список преподавателей из базы данных
                var teachers = db.Teachers.ToList();
                teachersBindingSource.DataSource = teachers; // Привязываем BindingSource к списку преподавателей
            /*}
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке преподавателей: {ex.Message}");
            }*/
        }
        private void buttonAddTeach_Click(object sender, EventArgs e)
        {
            FormTeacherAdd addForm = new FormTeacherAdd(); // Создаем экземпляр FormTeacherAdd
            addForm.ShowDialog(); // Открываем форму как модальное окно

        }
        /*
       private void LoadTeachers()
       {
           try
           {
               // Загружаем список преподавателей из базы данных
               var teachers = db.Teachers.ToList();
               teachersBindingSource.DataSource = teachers; // Привязываем BindingSource к списку преподавателей
           }
           catch (Exception ex)
           {
               MessageBox.Show($"Ошибка при загрузке преподавателей: {ex.Message}");
           }
       }

       private void buttonAddTeach_Click(object sender, EventArgs e)
       {
           FormTeacherAdd addForm = new FormTeacherAdd(); // Создаем экземпляр FormTeacherAdd
           addForm.ShowDialog(); // Открываем форму как модальное окно

           // После закрытия FormTeacherAdd обновляем список преподавателей
           LoadTeachers();
       }*/
    }
}
