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
            /*  //  LoadTeachers();  // Загружайте преподавателей только, если это необходимо (если они выбираются из списка)
              comboBoxNameClass.DataSource = db.Classes.ToList();
              comboBoxNameClass.DisplayMember = "ClassName"; // Отображаем название предмета
              comboBoxNameClass.ValueMember = "ClasstId";   // Используем ID предмета как значение
          }*/

            
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
