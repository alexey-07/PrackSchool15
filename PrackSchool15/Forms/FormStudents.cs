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
            this.db.Students.Load();
            this.dataGridViewStud.DataSource = this.db.Students.Local.OrderBy(o => o.ClassId).ToList();
        }

        private void buttonAddStud_Click(object sender, EventArgs e)
        {
            using (FormStudentsAdd formAdd = new FormStudentsAdd())
            {
                DialogResult result = formAdd.ShowDialog(this);
                if (result == DialogResult.Cancel) return;


                //  Создаем нового студента
                Student newStudent = new Student
                {
                    //  Получаем или создаем пользователя

                    DateOfBirth = DateOnly.FromDateTime(formAdd.dateTimePickerDate.Value),
                    Address = formAdd.textBoxAdress.Text,
                    PhoneNumber = formAdd.textBoxNumber.Text,
                    AdmissionDate = DateOnly.FromDateTime(formAdd.dateTimePickerAdm.Value),
                    ParentName = formAdd.textBoxNameParents.Text,
                    ParentPhone = formAdd.textBoxNumberParents.Text

                };

                // Добавляем в базу
                db.Students.Add(newStudent); // Исправлено на Students
                db.SaveChanges();

                MessageBox.Show("Новые данные о ребенке добавлены");
                LoadStudent(); // Обновляем данные в DataGridView
            }
        }
        private Student GetSelectedStudent() //  Вместо GetSelectedChild()
        {
            //  Если DataGridView привязан напрямую:
            if (dataGridViewStud.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewStud.SelectedRows[0];
                return (Student)selectedRow.DataBoundItem; //  Получаем объект Student
            }

  

            return null; //  Если ничего не выбрано
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Student selectedStudent = GetSelectedStudent();

            if (selectedStudent != null)
            {
                FormStudentsAdd editForm = new FormStudentsAdd(selectedStudent); // Передаем выбранного студента в форму редактирования
                editForm.ShowDialog(); // Открываем форму как модальное окно

                // После закрытия формы редактирования обновляем список студентов
                LoadStudent();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите студента для редактирования.");
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            Student selectedStudent = GetSelectedStudent(); // Используем наш метод

            if (selectedStudent != null)
            {
                DialogResult confirmResult = MessageBox.Show(
                    $"Вы уверены, что хотите удалить студента {selectedStudent.User.Username} {selectedStudent.Class.ClassId} {selectedStudent.Class.ClassName} {selectedStudent.DateOfBirth} " +
                    $"{selectedStudent.Address} {selectedStudent.PhoneNumber} {selectedStudent.AdmissionDate} {selectedStudent.ParentName} {selectedStudent.ParentPhone}?",
                "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        db.Students.Remove(selectedStudent); // Удаляем из базы
                        db.SaveChanges(); // Сохраняем

                        MessageBox.Show("Данные о студенте удалены.");
                        LoadStudent(); // Обновляем таблицу
                    }
                    catch (EntityException ex)
                    {
                        MessageBox.Show($"Ошибка базы данных: {ex.InnerException?.Message ?? ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при удалении студента: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите студента для удаления.");
            }

        }
    }
}

