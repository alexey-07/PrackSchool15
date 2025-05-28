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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace PrackSchool15
{
    public partial class FormStudentsAdd : Form
    {
        private School15PrackContext db;
        private Student currentStudent;
        public Student SelectedStudent { get; }

        public FormStudentsAdd()
        {
            InitializeComponent();
        }


        public FormStudentsAdd(Student selectedStudent)
        {
            SelectedStudent = selectedStudent;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            db = new School15PrackContext();

            // Загрузка классов в ComboBox
            LoadClasses();
        }

        private void LoadClasses()
        {
            comboBoxClass.DataSource = db.Classes.ToList();
            comboBoxClass.DisplayMember = "ClassName"; // Отображаем название класса
            comboBoxClass.ValueMember = "ClassId";   // Используем ID класса как значение
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBoxUsername.Text.Trim();
                string password = textBoxPassword.Text.Trim();

                // 1. Получение или создание пользователя
                var existingUser = db.Users.FirstOrDefault(u => u.Username == username);

                if (existingUser != null)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует!");
                    return;
                }

                // 2. Получаем ID роли "Ученик" (или создаем, если ее нет)
                // ВАЖНО: Укажите правильное название роли ("Ученик" или "Ученик")
                var studentRole = db.Roles.FirstOrDefault(r => r.RoleName == "Ученик");
                int studentRoleId;

                if (studentRole != null)
                {
                    studentRoleId = studentRole.RoleId; //  Используем существующую роль
                }
                else
                {
                    //  Если роль "Ученик" не существует, создайте ее (если необходимо)
                    var newRole = new Role { RoleName = "Ученик" };
                    db.Roles.Add(newRole);
                    db.SaveChanges();
                    studentRoleId = newRole.RoleId;
                }

                // 3. Создаём нового пользователя
                var newUser = new User
                {
                    Username = username,
                    Password = password, // Хеширование пароля!
                    RoleId = studentRoleId //  Присваиваем ID роли
                };

                db.Users.Add(newUser);
                db.SaveChanges(); // Сохраняем, чтобы у User появился ID

                // 4. Создаём студента, связанного с новым пользователем
                var newStudent = new Student
                {
                    User = newUser, // Теперь это объект User
                    DateOfBirth = DateOnly.FromDateTime(dateTimePickerDate.Value),
                    Address = textBoxAdress.Text,
                    ClassId = (int)comboBoxClass.SelectedValue,
                    PhoneNumber = textBoxNumber.Text,
                    AdmissionDate = DateOnly.FromDateTime(dateTimePickerDate.Value),
                    ParentName = textBoxNameParents.Text,
                    ParentPhone = textBoxNumberParents.Text,
                };
                db.Students.Add(newStudent);
                db.SaveChanges();

                MessageBox.Show("Пользователь и студент успешно добавлены!");
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении студента: {ex.Message}");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

  
