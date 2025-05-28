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
    public partial class FormTeacherAdd : Form
    {
        private School15PrackContext db;

        public object textBoxNameTeacher { get; private set; }

        public FormTeacherAdd()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            db = new School15PrackContext();
            LoadSubjects();  // Загрузка предметов в ComboBox
           /* LoadQualifications(); // Загрузка квалификаций в ComboBox*/
        }

        private void LoadSubjects()
        {
            // Загрузка предметов в ComboBox
            comboBoxSubject.DataSource = db.Subjects.ToList();
            comboBoxSubject.DisplayMember = "SubjectName"; // Отображаем название предмета
            comboBoxSubject.ValueMember = "SubjectId";   // Используем ID предмета как значение
        }

        /*private void LoadQualifications()
        {
            // Загрузка квалификаций в ComboBox
            comboBoxQual.DataSource = db.Teachers.ToList();
            comboBoxQual.DisplayMember = "QualificationName"; // Отображаем название квалификации
            comboBoxQual.ValueMember = "QualificationId";   // Используем ID квалификации как значение
        }*/
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Валидация данных
                if (string.IsNullOrWhiteSpace(textBoxTeachUsername.Text) ||
                    comboBoxSubject.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(textBoxSalary.Text) ||
                    string.IsNullOrWhiteSpace(textBoxQual.Text)||
                    string.IsNullOrWhiteSpace(textBoxNameTeach.Text) ||
                    string.IsNullOrWhiteSpace(textBoxSurTeach.Text) ||
                    string.IsNullOrWhiteSpace(textBoxParTeach.Text) ||
                    string.IsNullOrWhiteSpace(textBoxEduc.Text) ||
                    string.IsNullOrWhiteSpace(textBoxAdressTeach.Text) ||
                    string.IsNullOrWhiteSpace(textBoxNumberTeach.Text) ||
                    string.IsNullOrWhiteSpace(textBoxEmailTeach.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                    return;
                }

                // 2. Проверка на уникальность логина
                /* string username = textBoxTeachUsername.Text.Trim();

                 var existingUser = db.Users.FirstOrDefault(u => u.Username == username);
                 if (existingUser != null)
                 {
                     MessageBox.Show("Пользователь с таким логином уже существует!");
                     return;
                 }

                 // 3. Создание нового пользователя
                 var newUser = new User
                 {
                     Username = username,
                     Password = BCrypt.Net.BCrypt.HashPassword("defaultPassword"), // Хеширование пароля!
                     // Добавьте RoleId для преподавателя (предположим, что у вас есть роль "Преподаватель")
                     RoleId = db.Roles.FirstOrDefault(r => r.RoleName == "Преподаватель")?.RoleId ?? 0 //  или другое значение по умолчанию
                 };*/
                string username = textBoxTeachUsername.Text.Trim();
                string password = textBoxPasswordTeach.Text.Trim();

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
                    //  Если роль "Ученик" не существует, создайте ее (если необходимо)
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
                    SubjectId = (int)comboBoxSubject.SelectedValue, // Получаем ID предмета
                    HireDate = DateOnly.FromDateTime(dateTimePickerDateHare.Value),
                    Salary = decimal.Parse(textBoxSalary.Text), // Преобразуем зарплату в decimal
                    Qualification = textBoxQual.Text, // Получаем ID квалификации
                   NameTeacher = textBoxNameTeach.Text,
                    SurnameTeacher= textBoxSurTeach.Text,
                    PatronymicTeacher = textBoxParTeach.Text,
                    EducationTeacher = textBoxEduc.Text,
                    AdressTeacher = textBoxAdressTeach.Text,
                    NumberTeacher = textBoxNumberTeach.Text,
                    EmailTeacher = textBoxEmailTeach.Text
                    
                };

                db.Teachers.Add(newTeacher);
                db.SaveChanges();

                MessageBox.Show("Преподаватель успешно добавлен!");
                this.Close(); // Закрываем форму
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
    }
}
