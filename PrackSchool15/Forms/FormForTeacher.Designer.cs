namespace PrackSchool15
{
    partial class FormForTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForTeacher));
            panelFill = new Panel();
            buttonCancel = new Button();
            buttonAtten = new Button();
            buttonLesson = new Button();
            buttonGrade = new Button();
            dataGridViewForTeach = new DataGridView();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewForTeach).BeginInit();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(buttonCancel);
            panelFill.Controls.Add(buttonAtten);
            panelFill.Controls.Add(buttonLesson);
            panelFill.Controls.Add(buttonGrade);
            panelFill.Controls.Add(dataGridViewForTeach);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(377, 289);
            panelFill.TabIndex = 0;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(108, 220);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(155, 40);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Выход";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAtten
            // 
            buttonAtten.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAtten.Location = new Point(25, 113);
            buttonAtten.Name = "buttonAtten";
            buttonAtten.Size = new Size(325, 38);
            buttonAtten.TabIndex = 6;
            buttonAtten.Text = "Просмотр  посещаемости";
            buttonAtten.UseVisualStyleBackColor = true;
            buttonAtten.Click += buttonAtten_Click;
            // 
            // buttonLesson
            // 
            buttonLesson.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonLesson.Location = new Point(25, 69);
            buttonLesson.Name = "buttonLesson";
            buttonLesson.Size = new Size(325, 38);
            buttonLesson.TabIndex = 5;
            buttonLesson.Text = "Просмотр  расписания";
            buttonLesson.UseVisualStyleBackColor = true;
            buttonLesson.Click += buttonLesson_Click;
            // 
            // buttonGrade
            // 
            buttonGrade.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonGrade.Location = new Point(25, 25);
            buttonGrade.Name = "buttonGrade";
            buttonGrade.Size = new Size(325, 38);
            buttonGrade.TabIndex = 4;
            buttonGrade.Text = "Просмотр оценок";
            buttonGrade.UseVisualStyleBackColor = true;
            buttonGrade.Click += buttonGrade_Click;
            // 
            // dataGridViewForTeach
            // 
            dataGridViewForTeach.BackgroundColor = Color.White;
            dataGridViewForTeach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewForTeach.Dock = DockStyle.Fill;
            dataGridViewForTeach.Location = new Point(10, 10);
            dataGridViewForTeach.Name = "dataGridViewForTeach";
            dataGridViewForTeach.Size = new Size(357, 269);
            dataGridViewForTeach.TabIndex = 0;
            // 
            // FormForTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 289);
            Controls.Add(panelFill);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormForTeacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormForTeacher";
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewForTeach).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        private DataGridView dataGridViewForTeach;
        private Button buttonGrade;
        private Button buttonLesson;
        private Button buttonAtten;
        private Button buttonCancel;
    }
}