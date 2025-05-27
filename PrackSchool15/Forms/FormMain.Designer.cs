namespace PrackSchool15
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            labelName = new Label();
            panelBottom = new Panel();
            buttonExit = new Button();
            panelFill = new Panel();
            buttonAtten = new Button();
            buttonLesson = new Button();
            buttonGrade = new Button();
            buttonClass = new Button();
            buttonTeach = new Button();
            buttonStud = new Button();
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            panelFill.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelName);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(363, 60);
            panelTop.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.Location = new Point(68, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(235, 45);
            labelName.TabIndex = 0;
            labelName.Text = "МБОУ СОШ 15";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonExit);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 376);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(10);
            panelBottom.Size = new Size(363, 62);
            panelBottom.TabIndex = 1;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonExit.Location = new Point(13, 11);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(338, 38);
            buttonExit.TabIndex = 6;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(buttonAtten);
            panelFill.Controls.Add(buttonLesson);
            panelFill.Controls.Add(buttonGrade);
            panelFill.Controls.Add(buttonClass);
            panelFill.Controls.Add(buttonTeach);
            panelFill.Controls.Add(buttonStud);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 60);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(363, 316);
            panelFill.TabIndex = 2;
            // 
            // buttonAtten
            // 
            buttonAtten.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAtten.Location = new Point(12, 227);
            buttonAtten.Name = "buttonAtten";
            buttonAtten.Size = new Size(338, 38);
            buttonAtten.TabIndex = 5;
            buttonAtten.Text = "Просмотр  посещаемости";
            buttonAtten.UseVisualStyleBackColor = true;
            // 
            // buttonLesson
            // 
            buttonLesson.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonLesson.Location = new Point(13, 183);
            buttonLesson.Name = "buttonLesson";
            buttonLesson.Size = new Size(338, 38);
            buttonLesson.TabIndex = 4;
            buttonLesson.Text = "Просмотр  расписания";
            buttonLesson.UseVisualStyleBackColor = true;
            // 
            // buttonGrade
            // 
            buttonGrade.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonGrade.Location = new Point(12, 139);
            buttonGrade.Name = "buttonGrade";
            buttonGrade.Size = new Size(338, 38);
            buttonGrade.TabIndex = 3;
            buttonGrade.Text = "Просмотр оценок";
            buttonGrade.UseVisualStyleBackColor = true;
            buttonGrade.Click += buttonGrade_Click;
            // 
            // buttonClass
            // 
            buttonClass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonClass.Location = new Point(13, 94);
            buttonClass.Name = "buttonClass";
            buttonClass.Size = new Size(338, 38);
            buttonClass.TabIndex = 2;
            buttonClass.Text = "Просмотр классов";
            buttonClass.UseVisualStyleBackColor = true;
            buttonClass.Click += buttonClass_Click;
            // 
            // buttonTeach
            // 
            buttonTeach.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonTeach.Location = new Point(13, 50);
            buttonTeach.Name = "buttonTeach";
            buttonTeach.Size = new Size(338, 38);
            buttonTeach.TabIndex = 1;
            buttonTeach.Text = "Просмотр учителей";
            buttonTeach.UseVisualStyleBackColor = true;
            buttonTeach.Click += buttonTeach_Click;
            // 
            // buttonStud
            // 
            buttonStud.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonStud.Location = new Point(13, 6);
            buttonStud.Name = "buttonStud";
            buttonStud.Size = new Size(338, 38);
            buttonStud.TabIndex = 0;
            buttonStud.Text = "Просмотр учеников";
            buttonStud.UseVisualStyleBackColor = true;
            buttonStud.Click += buttonStud_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 438);
            Controls.Add(panelFill);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главный экран";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelBottom.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label labelName;
        private Panel panelBottom;
        private Panel panelFill;
        private Button buttonLesson;
        private Button buttonGrade;
        private Button buttonClass;
        private Button buttonTeach;
        private Button buttonStud;
        private Button buttonExit;
        private Button buttonAtten;
    }
}
