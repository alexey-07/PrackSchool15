namespace PrackSchool15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonStud_Click(object sender, EventArgs e)
        {
            FormStudents formCildrens = new FormStudents();
            formCildrens.ShowDialog();
        }

        private void buttonTeach_Click(object sender, EventArgs e)
        {
            FormTeachers formTeachers = new FormTeachers();
            formTeachers.ShowDialog();
        }

        private void buttonClass_Click(object sender, EventArgs e)
        {
            FormClasses formClasses = new FormClasses();
            formClasses.ShowDialog();
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
    }
}
