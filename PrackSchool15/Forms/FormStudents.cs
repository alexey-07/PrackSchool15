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


            // Преобразуем список в новый объект, где видно название группы
            var studentWithClass = db.Students.Local
                .Select(c => new
                {
                    c.StudentId,
                    Юзер = c.UserId,
                    Класс = c.ClassId,
                    Группа = c.Class != null ? c.Class.ClassName : "—",
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
    }
}
