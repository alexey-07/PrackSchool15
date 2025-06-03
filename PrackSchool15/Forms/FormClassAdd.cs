using PrackSchool15.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
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

        public FormClassAdd(Class classe)
        {
            InitializeComponent();
            Classe = classe;
        }

     

        public Class Classe { get; }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            db = new School15PrackContext();

            comboBoxFIOTeach.DataSource = db.Teachers
                .Select(u => new
                {
                    Name = u.NameTeacher + " " + u.SurnameTeacher + " " + u.PatronymicTeacher, u.TeacherId
                })
                .ToList();
            comboBoxFIOTeach.DisplayMember = "Name";
            comboBoxFIOTeach.ValueMember = "TeacherId";


            if (Classe != null)
            {
                this.Text = "Редактирование класса";
                textBoxNameClass.Text = Classe.ClassName;
                comboBoxFIOTeach.SelectedValue = Classe.TeacherId;
            }

        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Classe == null)
            {
                try
                {
                    // 1. Валидация данных
                    if (string.IsNullOrWhiteSpace(textBoxNameClass.Text) ||
                        comboBoxFIOTeach.SelectedItem == null)

                    {
                        MessageBox.Show("Пожалуйста, заполните все поля.");
                        return;
                    }
                }
                catch (EntityException ex)
                {
                    MessageBox.Show($"Ошибка базы данных: {ex.InnerException?.Message ?? ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }
            else
            {

                Classe.ClassName = textBoxNameClass.Text;
                Classe.TeacherId = (int)comboBoxFIOTeach.SelectedValue;
                db.SaveChanges();

                MessageBox.Show("Пользователь и класс успешно отредакрированны!");

            }
        }
        }
    }
