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
    public partial class FormClassAdd : Form
    {
        private School15PrackContext db;
        public FormClassAdd()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            db = new School15PrackContext();
           
              comboBoxNameClass.DataSource = db.Classes.ToList();
              comboBoxNameClass.DisplayMember = "ClassName"; // Отображаем название предмета
              comboBoxNameClass.ValueMember = "ClassId";   // Используем ID предмета как значение
          
            comboBoxFIOTeach.DataSource=db.Teachers
                .Select(u=>new
                {
                    Name = u.NameTeacher +" "  + u.SurnameTeacher +" "+ u.PatronymicTeacher, u.TeacherId
                })
                .ToList();
            comboBoxFIOTeach.DisplayMember = "Name";
            comboBoxFIOTeach.ValueMember = "TeacherId";


        }
        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
