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
            this.db = new School15PrackContext();
            this.db.Teachers.Load();
            this.dataGridViewTeacher.DataSource = this.db.Teachers.Local.OrderBy(o => o.HireDate).ToList();
            dataGridViewTeacher.Columns["Teacherid"].Visible = false;
            dataGridViewTeacher.Columns["userid"].Visible = false;
            dataGridViewTeacher.Columns["subjectid"].Visible = false;

        }
    }
}
