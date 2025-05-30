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
    public partial class FormLogin : Form
    {
        private School15PrackContext db;
        public FormLogin()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            db = new School15PrackContext();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBoxUsername.Text.Trim();
                string password = textBoxPassword.Text.Trim();

                // 1. Поиск пользователя по логину
                var user = db.Users.FirstOrDefault(u => u.Username == username);

                // 2. Проверка наличия пользователя и пароля
                if (user == null || user.Password != password)
                {
                    MessageBox.Show("Неверный логин или пароль.");
                    return;
                }

                // 3. Авторизация успешна
                MessageBox.Show($"Добро пожаловать, {user.Username}!");

                // 4. Открытие главной формы (или другой формы, в зависимости от роли)
                OpenMainForm(user.RoleId);

                // 5. Закрытие формы логина
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при авторизации: {ex.Message}");
            }
        }
    

        private void OpenMainForm(int roleId)
        {
            // Открытие главной формы в зависимости от роли пользователя

            switch (roleId)
            {
                case 1: //  Предположим, что 1 - это ID роли администратора
                    FormMain adminForm = new FormMain();
                    adminForm.Show();
                    break;
                case 2: //  Предположим, что 2 - это ID роли преподавателя
                    FormForTeacher teacherForm = new FormForTeacher();
                    teacherForm.Show();
                    break;
                /*case 3: //  Предположим, что 3 - это ID роли студента
                    FormStudentMain studentForm = new FormStudentMain();
                    studentForm.Show();
                    break;*/
               /* default:
                    MessageBox.Show("Неизвестная роль пользователя.");
                    break;*/
            }
        }
    }
}
