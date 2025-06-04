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
    public partial class FormClasses : Form
    {
        private School15PrackContext db;
        public FormClasses()
        {
            InitializeComponent();
        }

        private void UpdateTable()
        {
            dataGridViewClass.DataSource = db.Classes
                .Select(u => new { u.ClassId, u.ClassName, u.Teacher.NameTeacher })

                .ToList();
            var classesWithGroup = db.Classes.Local
              .Select(c => new
              {
                  Класс = c.ClassId, // Получаем ClassId из таблицы Classes
                  Название = c.ClassName, // Достаем ClassName из таблицы Classes
                  Имя = c.Teacher != null ? c.Teacher.NameTeacher : null, // Достаем Name из Teacher
                  Фамилия = c.Teacher != null ? c.Teacher.SurnameTeacher : null, // Достаем Surname из Teacher
                  Отечество = c.Teacher != null ? c.Teacher.PatronymicTeacher : null // Достаем Patronymic из Teacher


              }).ToList();

            dataGridViewClass.DataSource = classesWithGroup;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            db = new School15PrackContext();
            db.Classes.Include(c => c.Teacher).Load();

            // Преобразуем список в новый объект, где видно название группы
            var classesWithGroup = db.Classes.Local
                .Select(c => new
                {
                    Класс = c.ClassId, // Получаем ClassId из таблицы Classes
                    Название = c.ClassName, // Достаем ClassName из таблицы Classes
                    Имя = c.Teacher != null ? c.Teacher.NameTeacher : null, // Достаем Name из Teacher
                    Фамилия = c.Teacher != null ? c.Teacher.SurnameTeacher : null, // Достаем Surname из Teacher
                    Отечество = c.Teacher != null ? c.Teacher.PatronymicTeacher : null // Достаем Patronymic из Teacher


                }).ToList();

            dataGridViewClass.DataSource = classesWithGroup;
        }

        private void buttonAddClass_Click(object sender, EventArgs e)
        {
            FormClassAdd form = new FormClassAdd();

            DialogResult result = form.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }

            Class classy = new Class();

            try
            {
                classy = new Class
                {
                    ClassName = form.textBoxNameClass.Text,
                    TeacherId = (int)form.comboBoxFIOTeach.SelectedValue,

                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            db.Classes.Add(classy);
            db.SaveChanges();

            UpdateTable();
        }

        private void buttonEditClass_Click(object sender, EventArgs e)
        {
            if (dataGridViewClass.SelectedRows.Count == 0)
                return;
            int id = (int)dataGridViewClass.SelectedRows[0].Cells["Класс"].Value;
            var classe = db.Classes.FirstOrDefault(u => u.ClassId == id);

            if (classe != null)
            {
                // Открываем форму редактирования, передаем выбранного студента
                FormClassAdd editForm = new FormClassAdd(classe);
                if (editForm.ShowDialog() == DialogResult.OK)  //  Проверяем, что форма редактирования была закрыта успешно
                {
                    var classesWithGroup = db.Classes.Local
               .Select(c => new
               {
                   Класс = c.ClassId, // Получаем ClassId из таблицы Classes
                   Название = c.ClassName, // Достаем ClassName из таблицы Classes
                   Имя = c.Teacher != null ? c.Teacher.NameTeacher : null, // Достаем Name из Teacher
                   Фамилия = c.Teacher != null ? c.Teacher.SurnameTeacher : null, // Достаем Surname из Teacher
                   Отечество = c.Teacher != null ? c.Teacher.PatronymicTeacher : null // Достаем Patronymic из Teacher


               }).ToList();

                    dataGridViewClass.DataSource = classesWithGroup;
                    db.SaveChanges();
                    MessageBox.Show("Данные о классе изменены");
                }
            }
        }

        private void buttonDelClass_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewClass.SelectedRows[0].Cells["Класс"].Value;
            var classe = db.Classes.FirstOrDefault(u => u.ClassId == id);

            if (classe != null)
            {
                var confirmResult = MessageBox.Show(
                    "Вы уверены, что хотите удалить данные об этом классе?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Получаем всех студентов этого класса
                    var studentIds = db.Students
                        .Where(s => s.ClassId == id)
                        .Select(s => s.StudentId)
                        .ToList();

                    // Удаляем оценки этих студентов
                    db.Grades.Where(g => studentIds.Contains(g.StudentId)).ExecuteDelete();

                    // Удаляем студентов класса
                    db.Students.Where(u => u.ClassId == id).ExecuteDelete();

                    // Удаляем уроки класса
                    db.Lessons.Where(u => u.ClassId == id).ExecuteDelete();

                    // Удаляем сам класс
                    db.Classes.Remove(classe);

                    db.SaveChanges();
                    MessageBox.Show("Данные о классе удалены.");
                    UpdateTable();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите класс для удаления.");
            }
        }
    }
}
