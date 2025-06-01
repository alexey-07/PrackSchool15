namespace PrackSchool15
{
    partial class FormGrades
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
            dataGridViewGrade = new DataGridView();
            panelTop = new Panel();
            buttonDelGrade = new Button();
            buttonEditGrade = new Button();
            buttonAddGrade = new Button();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrade).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewGrade);
            panelFill.Controls.Add(panelTop);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(912, 475);
            panelFill.TabIndex = 0;
            // 
            // dataGridViewGrade
            // 
            dataGridViewGrade.BackgroundColor = Color.White;
            dataGridViewGrade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGrade.Dock = DockStyle.Fill;
            dataGridViewGrade.Location = new Point(10, 67);
            dataGridViewGrade.Name = "dataGridViewGrade";
            dataGridViewGrade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGrade.Size = new Size(892, 398);
            dataGridViewGrade.TabIndex = 1;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonDelGrade);
            panelTop.Controls.Add(buttonEditGrade);
            panelTop.Controls.Add(buttonAddGrade);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(10, 10);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(892, 57);
            panelTop.TabIndex = 0;
            // 
            // buttonDelGrade
            // 
            buttonDelGrade.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDelGrade.Location = new Point(593, 6);
            buttonDelGrade.Name = "buttonDelGrade";
            buttonDelGrade.Padding = new Padding(5);
            buttonDelGrade.Size = new Size(284, 45);
            buttonDelGrade.TabIndex = 4;
            buttonDelGrade.Text = "Удалить";
            buttonDelGrade.UseVisualStyleBackColor = true;
            buttonDelGrade.Click += buttonDelGrade_Click;
            // 
            // buttonEditGrade
            // 
            buttonEditGrade.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEditGrade.Location = new Point(303, 6);
            buttonEditGrade.Name = "buttonEditGrade";
            buttonEditGrade.Padding = new Padding(5);
            buttonEditGrade.Size = new Size(284, 45);
            buttonEditGrade.TabIndex = 3;
            buttonEditGrade.Text = "Редактировать";
            buttonEditGrade.UseVisualStyleBackColor = true;
            buttonEditGrade.Click += buttonEditGrade_Click;
            // 
            // buttonAddGrade
            // 
            buttonAddGrade.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAddGrade.Location = new Point(13, 6);
            buttonAddGrade.Name = "buttonAddGrade";
            buttonAddGrade.Padding = new Padding(5);
            buttonAddGrade.Size = new Size(284, 45);
            buttonAddGrade.TabIndex = 2;
            buttonAddGrade.Text = "Добавить";
            buttonAddGrade.UseVisualStyleBackColor = true;
            buttonAddGrade.Click += buttonAddGrade_Click;
            // 
            // FormGrades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 475);
            Controls.Add(panelFill);
            Name = "FormGrades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Оценки";
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrade).EndInit();
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        private DataGridView dataGridViewGrade;
        private Panel panelTop;
        private Button buttonDelGrade;
        private Button buttonEditGrade;
        private Button buttonAddGrade;
    }
}