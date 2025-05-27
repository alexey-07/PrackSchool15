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
    public partial class FormTeachers : Form
    {
        private School15PrackContext db;
        public FormTeachers()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {

            base.OnLoad(e);

            db = new School15PrackContext();
            db.Teachers.Include(c => c.Classes).Load();
            db.Teachers.Include(c => c.Subject).Load();
            db.Teachers.Include(c => c.User).Load();


          // Преобразуем список в новый объект, где видно название группы
          var teacherWithClass = db.Teachers.Local
                .Select(c => new
                {
                    c.TeacherId,
                    Юзер = c.User != null ? c.User.Username : null,
                    Предмет = c.Subject != null ? c.Subject.SubjectName : null,
                    /*Группа = c.Class != null ? c.Class.ClassName : null,*/
                    ДатаПриемаНаРаботу = c.HireDate,
                    Зарплата = c.Salary,
                    Квалификация = c.Qualification,
                    ИмяУчителя = c.NameTeacher,
                    ФамилияУчителя = c.SurnameTeacher,
                    Отечество = c.PatronymicTeacher,
                    Образование = c.EducationTeacher,
                    Адрес = c.AdressTeacher,
                    НомерТелефона = c.NumberTeacher,
                    Почта = c.EmailTeacher
                }).ToList();

            dataGridViewTeacher.DataSource = teacherWithClass;

            dataGridViewTeacher.Columns["teacherid"].Visible = false;

        }

        /*protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new School15PrackContext();
            this.db.Teachers.Load();
            this.dataGridViewTeacher.DataSource = this.db.Teachers.Local.OrderBy(o => o.HireDate).ToList();
            dataGridViewTeacher.Columns["Teacherid"].Visible = false;
            dataGridViewTeacher.Columns["userid"].Visible = false;
           *//* dataGridViewTeacher.Columns["class"].Visible = false;
            dataGridViewTeacher.Columns["user"].Visible = false;
            dataGridViewTeacher.Columns["subject"].Visible = false;*//*

        }*/
    }
}
