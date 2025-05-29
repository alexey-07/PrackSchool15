namespace PrackSchool15
{
    partial class FormLessons
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
            dataGridViewLesson = new DataGridView();
            panelTop = new Panel();
            buttonDelLesson = new Button();
            buttonEditLesson = new Button();
            buttonAddLesson = new Button();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLesson).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewLesson);
            panelFill.Controls.Add(panelTop);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(916, 477);
            panelFill.TabIndex = 0;
            // 
            // dataGridViewLesson
            // 
            dataGridViewLesson.BackgroundColor = Color.White;
            dataGridViewLesson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLesson.Dock = DockStyle.Fill;
            dataGridViewLesson.Location = new Point(10, 71);
            dataGridViewLesson.Name = "dataGridViewLesson";
            dataGridViewLesson.Size = new Size(896, 396);
            dataGridViewLesson.TabIndex = 1;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonDelLesson);
            panelTop.Controls.Add(buttonEditLesson);
            panelTop.Controls.Add(buttonAddLesson);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(10, 10);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(896, 61);
            panelTop.TabIndex = 0;
            // 
            // buttonDelLesson
            // 
            buttonDelLesson.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDelLesson.Location = new Point(593, 10);
            buttonDelLesson.Name = "buttonDelLesson";
            buttonDelLesson.Padding = new Padding(5);
            buttonDelLesson.Size = new Size(284, 45);
            buttonDelLesson.TabIndex = 5;
            buttonDelLesson.Text = "Удалить";
            buttonDelLesson.UseVisualStyleBackColor = true;
            // 
            // buttonEditLesson
            // 
            buttonEditLesson.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEditLesson.Location = new Point(303, 10);
            buttonEditLesson.Name = "buttonEditLesson";
            buttonEditLesson.Padding = new Padding(5);
            buttonEditLesson.Size = new Size(284, 45);
            buttonEditLesson.TabIndex = 4;
            buttonEditLesson.Text = "Редактировать";
            buttonEditLesson.UseVisualStyleBackColor = true;
            // 
            // buttonAddLesson
            // 
            buttonAddLesson.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAddLesson.Location = new Point(13, 10);
            buttonAddLesson.Name = "buttonAddLesson";
            buttonAddLesson.Padding = new Padding(5);
            buttonAddLesson.Size = new Size(284, 45);
            buttonAddLesson.TabIndex = 3;
            buttonAddLesson.Text = "Добавить";
            buttonAddLesson.UseVisualStyleBackColor = true;
            // 
            // FormLessons
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 477);
            Controls.Add(panelFill);
            Name = "FormLessons";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Расписание";
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLesson).EndInit();
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        private Panel panelTop;
        private DataGridView dataGridViewLesson;
        private Button buttonDelLesson;
        private Button buttonEditLesson;
        private Button buttonAddLesson;
    }
}