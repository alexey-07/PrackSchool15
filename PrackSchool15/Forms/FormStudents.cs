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
    public partial class FormStudents : Form
    {
        private School15PrackContext db;
        public FormStudents()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {

            base.OnLoad(e);

            db = new School15PrackContext();
            db.Students.Include(c => c.Class).Load();
            db.Students.Include(c => c.User).Load();


            // Преобразуем список в новый объект, где видно название группы
            var studentWithClass = db.Students.Local
                .Select(c => new
                {
                    c.StudentId,
                    Юзер = c.User != null ? c.User.Username : null,
                    Класс = c.ClassId,
                    Название = c.Class != null ? c.Class.ClassName : "—",
                    ДатаРождения = c.DateOfBirth,
                    Адрес = c.Address,
                    Телефон = c.PhoneNumber,
                    ДатаЗачисления = c.AdmissionDate,
                    Имя_Родителя = c.ParentName,
                    ТелефонРодителей = c.ParentPhone
                }).ToList();

            dataGridViewStud.DataSource = studentWithClass; ;

            dataGridViewStud.Columns["studentid"].Visible = false;

        }

        private void LoadStudent()
        {
            var studentWithClass = db.Students.Local
               .Select(c => new
               {
                   c.StudentId,
                   Юзер = c.User != null ? c.User.Username : null,
                   Класс = c.ClassId,
                   Название = c.Class != null ? c.Class.ClassName : "—",
                   ДатаРождения = c.DateOfBirth,
                   Адрес = c.Address,
                   Телефон = c.PhoneNumber,
                   ДатаЗачисления = c.AdmissionDate,
                   Имя_Родителя = c.ParentName,
                   ТелефонРодителей = c.ParentPhone
               }).ToList();

            dataGridViewStud.DataSource = studentWithClass; ;
        }

        private void buttonAddStud_Click(object sender, EventArgs e)
        {
            using (FormStudentsAdd formAdd = new FormStudentsAdd())
            {
                DialogResult result = formAdd.ShowDialog(this);
                if (result == DialogResult.Cancel) return;



                try
                {
                    string username = formAdd.textBoxUsername.Text.Trim();
                    string password = formAdd.textBoxPassword.Text.Trim();

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
                    var newUser = new User
                    {
                        Username = username,
                        Password = password, // Рекомендуется хешировать
                        RoleId = studentRoleId
                    };

                    db.Users.Add(newUser);
                    db.SaveChanges();

                    var newStudent = new Student
                    {
                        UserId = newUser.UserId, // Устанавливаем внешний ключ напрямую
                        DateOfBirth = DateOnly.FromDateTime(formAdd.dateTimePickerDate.Value),
                        Address = formAdd.textBoxAdress.Text,
                        ClassId = (int)formAdd.comboBoxClass.SelectedValue,
                        PhoneNumber = formAdd.textBoxNumber.Text,
                        AdmissionDate = DateOnly.FromDateTime(formAdd.dateTimePickerAdm.Value), // Используем Adm date picker
                        ParentName = formAdd.textBoxNameParents.Text,
                        ParentPhone = formAdd.textBoxNumberParents.Text,
                    };

                    db.Students.Add(newStudent);
                    db.SaveChanges();
                    MessageBox.Show("Пользователь и студент успешно добавлены!");
       /*             this.Close();*/
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении студента: {ex.Message}");
                }
            }

            MessageBox.Show("Новые данные о студенте добавлены");
            var studentWithClass = db.Students.Local
            .Select(c => new
            {
                c.StudentId,
                Юзер = c.User != null ? c.User.Username : null,
                Класс = c.ClassId,
                Название = c.Class != null ? c.Class.ClassName : "—",
                ДатаРождения = c.DateOfBirth,
                Адрес = c.Address,
                Телефон = c.PhoneNumber,
                ДатаЗачисления = c.AdmissionDate,
                Имя_Родителя = c.ParentName,
                ТелефонРодителей = c.ParentPhone
            }).ToList();

            dataGridViewStud.DataSource = studentWithClass; ;
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            /*Student selectedStudent = GetSelectedStudent();*/
            if (dataGridViewStud.SelectedRows.Count == 0)
                return;
            int id = (int)dataGridViewStud.SelectedRows[0].Cells["studentid"].Value;
            var student = db.Students.FirstOrDefault(u => u.StudentId == id);

            if (student != null)
            {
                // Открываем форму редактирования, передаем выбранного студента
                FormStudentsAdd editForm = new FormStudentsAdd(student);
                if (editForm.ShowDialog() == DialogResult.OK)  //  Проверяем, что форма редактирования была закрыта успешно
                {
                    var user = db.Users.FirstOrDefault(u => u.UserId == editForm.SelectedStudent.UserId);
                    user.Username = editForm.textBoxUsername.Text;
                    user.Password = editForm.textBoxPassword.Text;
                    student.DateOfBirth = DateOnly.FromDateTime(editForm.dateTimePickerDate.Value);
                    student.Address = editForm.textBoxAdress.Text;
                    student.PhoneNumber = editForm.textBoxNumber.Text;
                    student.ParentName = editForm.textBoxNameParents.Text;
                    student.ParentPhone = editForm.textBoxNumberParents.Text;
                    db.SaveChanges();

                    MessageBox.Show("Пользователь и студент успешно отредакрированны!");
                    var studentWithClass = db.Students.Local
                    .Select(c => new
                    {
                        c.StudentId,
                        Юзер = c.User != null ? c.User.Username : null,
                        Класс = c.ClassId,
                        Название = c.Class != null ? c.Class.ClassName : "—",
                        ДатаРождения = c.DateOfBirth,
                        Адрес = c.Address,
                        Телефон = c.PhoneNumber,
                        ДатаЗачисления = c.AdmissionDate,
                        Имя_Родителя = c.ParentName,
                        ТелефонРодителей = c.ParentPhone
                    }).ToList();

                            dataGridViewStud.DataSource = studentWithClass; ;
                        }

            }

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewStud.SelectedRows[0].Cells["studentid"].Value;
            var student = db.Students.FirstOrDefault(u => u.StudentId == id);

            if (student != null)
            {
                var confirmResult = MessageBox.Show(
                    "Вы уверены, что хотите удалить данные об этом студенте?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    db.Grades.Where(u => u.StudentId == id).ExecuteDelete();
                    db.Attendances.Where(u => u.StudentId == id).ExecuteDelete();
                    db.Students.Remove(student); // Удаляем из базы
                    db.SaveChanges(); // Сохраняем
                    MessageBox.Show("Данные о студенте удалены.");
                    LoadStudent(); // Обновляем таблицу
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите студента для удаления.");
            }
        }

    }
}

