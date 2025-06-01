using Microsoft.EntityFrameworkCore;
using PrackSchool15.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace PrackSchool15
{
    public partial class FormStudentsAdd : Form
    {
        private School15PrackContext db;
        private Student currentStudent;
        public Student SelectedStudent { get; }

        public FormStudentsAdd()
        {
            InitializeComponent();
        }


        public FormStudentsAdd(Student selectedStudent)
        {
            InitializeComponent();
            SelectedStudent = selectedStudent;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            db = new School15PrackContext();

            // Загрузка классов в ComboBox
            LoadClasses();
            if(SelectedStudent != null)
            {
                var user = db.Users.FirstOrDefault(u=>u.UserId == SelectedStudent.UserId);
                this.Text = "Редактирование сотрудника";
                textBoxUsername.Text = user.Username;
                textBoxPassword.Text = user.Password; ;
                dateTimePickerDate.Value = ((DateOnly)SelectedStudent.DateOfBirth).ToDateTime(new TimeOnly(0, 0, 0));
                textBoxAdress.Text = SelectedStudent.Address;
                textBoxNumber.Text = SelectedStudent.PhoneNumber;
                textBoxNameParents.Text = SelectedStudent.ParentName;
                textBoxNumberParents.Text = SelectedStudent.ParentPhone;

            }
            comboBoxClass.DataSource = db.Classes.ToList();
            comboBoxClass.DisplayMember = "ClassName"; // Отображаем название класса
            comboBoxClass.ValueMember = "ClassId";   // Используем ID класса как значение
        }

        private void LoadClasses()
        {
            /*comboBoxClass.DataSource = db.Classes.ToList();
            comboBoxClass.DisplayMember = "ClassName"; // Отображаем название класса
            comboBoxClass.ValueMember = "ClassId";   // Используем ID класса как значение*/
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

  
