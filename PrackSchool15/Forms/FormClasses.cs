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

                /*if (String.IsNullOrEmpty(frtextBoxClassNumber.Text) ||
                    String.IsNullOrEmpty(form.textBoxAdress.Text))
                {
                    throw new Exception("Название и адрес здания обязательно должны быть введены");
                }*/

                /* if (form.checkBoxCancel.Checked && DateOnly.FromDateTime(form.dateTimePickerDateOfCancel.Value) < DateOnly.FromDateTime(form.dateTimePickerDateOfRegistration.Value))
                 {
                     throw new Exception("Дата закрытия организации не может быть меньше даты регистрации");
                 }*/

                classy = new Class
                {
                    ClassName = form.comboBoxNameClass.SelectedText,
                    TeacherId=(int)form.comboBoxFIOTeach.SelectedValue,

                   
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
        }

    }
}
