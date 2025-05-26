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
    }
}
