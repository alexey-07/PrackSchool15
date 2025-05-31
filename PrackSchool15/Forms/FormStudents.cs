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

                MessageBox.Show("Новые данные о студенте добавлены");
                LoadStudent(); // Обновляем данные в DataGridView
            }
        }
        
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            /*Student selectedStudent = GetSelectedStudent();*/
            if(dataGridViewStud.SelectedRows.Count == 0)
                return;
            int id = (int)dataGridViewStud.SelectedRows[0].Cells["studentid"].Value;
            var student=db.Students.FirstOrDefault(u=>u.StudentId == id);

            if (student != null)
            {
                // Открываем форму редактирования, передаем выбранного студента
                FormStudentsAdd editForm = new FormStudentsAdd(student);
                if (editForm.ShowDialog() == DialogResult.OK)  //  Проверяем, что форма редактирования была закрыта успешно
                {

                    MessageBox.Show("Карась");
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

