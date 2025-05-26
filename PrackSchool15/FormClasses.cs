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
        }
    }
}
