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
        }
        private void buttonAddTeach_Click(object sender, EventArgs e)
        {
            FormTeacherAdd addForm = new FormTeacherAdd(); // Создаем экземпляр FormTeacherAdd
            addForm.ShowDialog(); // Открываем форму как модальное окно
            LoadTeachers();
        }

        private void buttonEditTeach_Click(object sender, EventArgs e)
        {
            if (dataGridViewTeacher.SelectedRows.Count == 0)
                return;
            int id = (int)dataGridViewTeacher.SelectedRows[0].Cells["teacherid"].Value;
            var teacher = db.Teachers.FirstOrDefault(u => u.TeacherId == id);

            if (teacher != null)
            {
                // Открываем форму редактирования, передаем выбранного студента
                FormTeacherAdd editForm = new FormTeacherAdd(teacher);
                if (editForm.ShowDialog() == DialogResult.OK)  //  Проверяем, что форма редактирования была закрыта успешно
                {
                    LoadTeachers(); // Обновляем список студентов
                }
            }
        }

        private void buttonDelTeach_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewTeacher.SelectedRows[0].Cells["teacherid"].Value;
            var teacher = db.Teachers.FirstOrDefault(u => u.TeacherId == id);

            if (teacher != null)
            {
                var confirmResult = MessageBox.Show(
                    "Вы уверены, что хотите удалить данные об этом учителя?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    db.Teachers.Remove(teacher); // Удаляем из базы
                    db.SaveChanges(); // Сохраняем
                    MessageBox.Show("Данные о учителя удалены.");
                    LoadTeachers(); // Обновляем таблицу
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите учителя для удаления.");
            }
        }
    }
}
