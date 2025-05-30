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
    public partial class FormForTeacher : Form
    {
        public FormForTeacher()
        {
            InitializeComponent();
        }

        private void buttonStud_Click(object sender, EventArgs e)
        {
            FormStudents formCildrens = new FormStudents();
            formCildrens.ShowDialog();
        }

        private void buttonGrade_Click(object sender, EventArgs e)
        {
            FormGrades formGrades = new FormGrades();
            formGrades.ShowDialog();
        }

        private void buttonLesson_Click(object sender, EventArgs e)
        {
            FormLessons formLessons = new FormLessons();
            formLessons.ShowDialog();
        }

        private void buttonAtten_Click(object sender, EventArgs e)
        {
            FormAttendance formAttendace = new FormAttendance();
            formAttendace.ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
