using Microsoft.EntityFrameworkCore;
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

            using (FormTeacherAdd addForm = new FormTeacherAdd())
            {
                DialogResult result = addForm.ShowDialog(this);
                if (result == DialogResult.Cancel) return;
                
                    try
                    {
                        // 1. Валидация данных
                        if (string.IsNullOrWhiteSpace(addForm.textBoxTeachUsername.Text) ||
                           addForm.comboBoxSubject.SelectedItem == null ||
                            string.IsNullOrWhiteSpace(addForm.textBoxSalary.Text) ||
                            string.IsNullOrWhiteSpace(addForm.textBoxQual.Text) ||
                            string.IsNullOrWhiteSpace(addForm.textBoxNameTeach.Text) ||
                            string.IsNullOrWhiteSpace(addForm.textBoxSurTeach.Text) ||
                            string.IsNullOrWhiteSpace(addForm.textBoxParTeach.Text) ||
                            string.IsNullOrWhiteSpace(addForm.textBoxEduc.Text) ||
                            string.IsNullOrWhiteSpace(addForm.textBoxAdressTeach.Text) ||
                            string.IsNullOrWhiteSpace(addForm.textBoxNumberTeach.Text) ||
                            string.IsNullOrWhiteSpace(addForm.textBoxEmailTeach.Text))
                        {
                            MessageBox.Show("Пожалуйста, заполните все поля.");
                            return;
                        }


                        string username = addForm.textBoxTeachUsername.Text.Trim();
                        string password = addForm.textBoxPasswordTeach.Text.Trim();

                        // 1. Получение или создание пользователя
                        var existingUser = db.Users.FirstOrDefault(u => u.Username == username);

                        if (existingUser != null)
                        {
                            MessageBox.Show("Пользователь с таким логином уже существует!");
                            return;
                        }

                        // 2. Получаем ID роли "Ученик" (или создаем, если ее нет)
                        // ВАЖНО: Укажите правильное название роли ("Ученик" или "Ученик")
                        var teacherRole = db.Roles.FirstOrDefault(r => r.RoleName == "Учитель");
                        int tacherRoleId;

                        if (teacherRole != null)
                        {
                            tacherRoleId = teacherRole.RoleId; //  Используем существующую роль
                        }
                        else
                        {
                            //  Если роль "Учитель" не существует, создайте ее (если необходимо)
                            var newRole = new Role { RoleName = "Учитель" };
                            db.Roles.Add(newRole);
                            db.SaveChanges();
                            tacherRoleId = newRole.RoleId;
                        }

                        // 3. Создаём нового пользователя
                        var newUser = new User
                        {
                            Username = username,
                            Password = password, // Хеширование пароля!
                            RoleId = tacherRoleId //  Присваиваем ID роли
                        };
                        db.Users.Add(newUser);
                        db.SaveChanges(); // Сохраняем, чтобы у User появился ID

                        // 4. Создание нового преподавателя
                        var newTeacher = new Teacher
                        {

                            User = newUser, // Теперь это объект User
                            SubjectId = (int)addForm.comboBoxSubject.SelectedValue, // Получаем ID предмета
                            HireDate = DateOnly.FromDateTime(addForm.dateTimePickerDateHare.Value),
                            Salary = decimal.Parse(addForm.textBoxSalary.Text), // Преобразуем зарплату в decimal
                            Qualification = addForm.textBoxQual.Text, // Получаем ID квалификации
                            NameTeacher = addForm.textBoxNameTeach.Text,
                            SurnameTeacher = addForm.textBoxSurTeach.Text,
                            PatronymicTeacher = addForm.textBoxParTeach.Text,
                            EducationTeacher =  addForm.textBoxEduc.Text,
                            AdressTeacher = addForm.textBoxAdressTeach.Text,
                            NumberTeacher = addForm.textBoxNumberTeach.Text,
                            EmailTeacher = addForm.textBoxEmailTeach.Text

                        };

                        db.Teachers.Add(newTeacher);
                        db.SaveChanges();

                        MessageBox.Show("Преподаватель успешно добавлен!");
                      /*  this.Close(); // Закрываем форму*/
                    }
                    catch (EntityException ex)
                    {
                        MessageBox.Show($"Ошибка базы данных: {ex.InnerException?.Message ?? ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}");
                    }
                MessageBox.Show("Новые данные о учители добавлены");
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
                    var user = db.Users.FirstOrDefault(u => u.UserId == editForm.Teacher.UserId);
                    user.Username = editForm.textBoxTeachUsername.Text;
                    user.Password = editForm.textBoxPasswordTeach.Text;
                    teacher.SubjectId= (int)editForm.comboBoxSubject.SelectedValue;
                    teacher.HireDate = DateOnly.FromDateTime(editForm.dateTimePickerDateHare.Value);
                    teacher.Salary = Decimal.Parse(editForm.textBoxSalary.Text);
                    teacher.Qualification = editForm.textBoxQual.Text;
                    teacher.NameTeacher = editForm.textBoxNameTeach.Text;
                    teacher.SurnameTeacher = editForm.textBoxSurTeach.Text;
                    teacher.PatronymicTeacher = editForm.textBoxParTeach.Text;
                    teacher.EducationTeacher = editForm.textBoxEduc.Text;
                    teacher.AdressTeacher = editForm.textBoxAdressTeach.Text;
                    teacher.NumberTeacher = editForm.textBoxNumberTeach.Text;
                    teacher.EmailTeacher = editForm.textBoxEmailTeach.Text;
                    db.SaveChanges();

                    MessageBox.Show("Пользователь и учитель успешно отредакрированны!");
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

                if(confirmResult == DialogResult.Yes)
                {
                    // Получаем ID всех уроков этого учителя
                    var lessonIds = db.Lessons
                        .Where(l => l.TeacherId == id)
                        .Select(l => l.LessonId)
                        .ToList();
                    db.Attendances.Where(a => lessonIds.Contains(a.LessonId)).ExecuteDelete();
                    // Удаляем оценки этих уроков
                    db.Grades.Where(g => lessonIds.Contains(g.LessonId)).ExecuteDelete();

                    // Удаляем уроки учителя
                    db.Lessons.Where(u => u.TeacherId == id).ExecuteDelete();

                    // Обнуляем TeacherId в классах, где этот учитель был классным руководителем
                    db.Classes.Where(c => c.TeacherId == id).ExecuteUpdate(c => c.SetProperty(x => x.TeacherId, (int?)null));

                    // Удаляем самого учителя
                    db.Teachers.Remove(teacher);

                    db.SaveChanges();
                    MessageBox.Show("Данные об учителе удалены.");
                    LoadTeachers();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите учителя для удаления.");
            }
        }
    }
}
