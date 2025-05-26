namespace PrackSchool15
{
    partial class FormTeachers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelFill = new Panel();
            dataGridViewTeacher = new DataGridView();
            panelTop = new Panel();
            buttonDelTeach = new Button();
            buttonEditTeach = new Button();
            buttonAddTeach = new Button();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeacher).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewTeacher);
            panelFill.Controls.Add(panelTop);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(911, 468);
            panelFill.TabIndex = 0;
            // 
            // dataGridViewTeacher
            // 
            dataGridViewTeacher.BackgroundColor = Color.White;
            dataGridViewTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeacher.Dock = DockStyle.Fill;
            dataGridViewTeacher.Location = new Point(10, 71);
            dataGridViewTeacher.Name = "dataGridViewTeacher";
            dataGridViewTeacher.Size = new Size(891, 387);
            dataGridViewTeacher.TabIndex = 1;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonDelTeach);
            panelTop.Controls.Add(buttonEditTeach);
            panelTop.Controls.Add(buttonAddTeach);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(10, 10);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(891, 61);
            panelTop.TabIndex = 0;
            // 
            // buttonDelTeach
            // 
            buttonDelTeach.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDelTeach.Location = new Point(593, 10);
            buttonDelTeach.Name = "buttonDelTeach";
            buttonDelTeach.Padding = new Padding(5);
            buttonDelTeach.Size = new Size(284, 45);
            buttonDelTeach.TabIndex = 3;
            buttonDelTeach.Text = "Удалить";
            buttonDelTeach.UseVisualStyleBackColor = true;
            // 
            // buttonEditTeach
            // 
            buttonEditTeach.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEditTeach.Location = new Point(303, 10);
            buttonEditTeach.Name = "buttonEditTeach";
            buttonEditTeach.Padding = new Padding(5);
            buttonEditTeach.Size = new Size(284, 45);
            buttonEditTeach.TabIndex = 2;
            buttonEditTeach.Text = "Редактировать";
            buttonEditTeach.UseVisualStyleBackColor = true;
            // 
            // buttonAddTeach
            // 
            buttonAddTeach.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAddTeach.Location = new Point(13, 10);
            buttonAddTeach.Name = "buttonAddTeach";
            buttonAddTeach.Padding = new Padding(5);
            buttonAddTeach.Size = new Size(284, 45);
            buttonAddTeach.TabIndex = 1;
            buttonAddTeach.Text = "Добавить";
            buttonAddTeach.UseVisualStyleBackColor = true;
            // 
            // FormTeachers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 468);
            Controls.Add(panelFill);
            Name = "FormTeachers";
            Text = "Учителя";
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeacher).EndInit();
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        private DataGridView dataGridViewTeacher;
        private Panel panelTop;
        private Button buttonDelTeach;
        private Button buttonEditTeach;
        private Button buttonAddTeach;
    }
}