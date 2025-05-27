using Microsoft.EntityFrameworkCore;
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
        /*protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new School15PrackContext();
            this.db.Classes.Load();
            this.dataGridViewClass.DataSource = this.db.Classes.Local.OrderBy(o => o.ClassId).ToList();
            dataGridViewClass.Columns["Classid"].Visible = false;
            dataGridViewClass.Columns["Lessons"].Visible = false;
            dataGridViewClass.Columns["Students"].Visible = false;
            dataGridViewClass.Columns["Teacher"].Visible = false;
            
        }
        private void LoadGrops()
        {
            this.db.Classes.Load();
            this.dataGridViewClass.DataSource = this.db.Classes.Local.OrderBy(o => o.ClassId).ToList();
        }*/
    }
}
