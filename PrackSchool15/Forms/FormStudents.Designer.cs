namespace PrackSchool15
{
    partial class FormStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudents));
            panelFill = new Panel();
            dataGridViewStud = new DataGridView();
            panelTop = new Panel();
            buttonDelStud = new Button();
            buttonEditStud = new Button();
            buttonAddStud = new Button();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStud).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewStud);
            panelFill.Controls.Add(panelTop);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(15);
            panelFill.Size = new Size(920, 503);
            panelFill.TabIndex = 0;
            // 
            // dataGridViewStud
            // 
            dataGridViewStud.BackgroundColor = Color.White;
            dataGridViewStud.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStud.Dock = DockStyle.Fill;
            dataGridViewStud.Location = new Point(15, 70);
            dataGridViewStud.Name = "dataGridViewStud";
            dataGridViewStud.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStud.Size = new Size(890, 418);
            dataGridViewStud.TabIndex = 1;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonDelStud);
            panelTop.Controls.Add(buttonEditStud);
            panelTop.Controls.Add(buttonAddStud);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(15, 15);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(890, 55);
            panelTop.TabIndex = 0;
            // 
            // buttonDelStud
            // 
            buttonDelStud.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDelStud.Location = new Point(593, 5);
            buttonDelStud.Name = "buttonDelStud";
            buttonDelStud.Padding = new Padding(5);
            buttonDelStud.Size = new Size(284, 45);
            buttonDelStud.TabIndex = 2;
            buttonDelStud.Text = "Удалить";
            buttonDelStud.UseVisualStyleBackColor = true;
            buttonDelStud.Click += buttonDel_Click;
            // 
            // buttonEditStud
            // 
            buttonEditStud.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEditStud.Location = new Point(303, 5);
            buttonEditStud.Name = "buttonEditStud";
            buttonEditStud.Padding = new Padding(5);
            buttonEditStud.Size = new Size(284, 45);
            buttonEditStud.TabIndex = 1;
            buttonEditStud.Text = "Редактировать";
            buttonEditStud.UseVisualStyleBackColor = true;
            buttonEditStud.Click += buttonEdit_Click;
            // 
            // buttonAddStud
            // 
            buttonAddStud.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAddStud.Location = new Point(13, 5);
            buttonAddStud.Name = "buttonAddStud";
            buttonAddStud.Padding = new Padding(5);
            buttonAddStud.Size = new Size(284, 45);
            buttonAddStud.TabIndex = 0;
            buttonAddStud.Text = "Добавить";
            buttonAddStud.UseVisualStyleBackColor = true;
            buttonAddStud.Click += buttonAddStud_Click;
            // 
            // FormStudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 503);
            Controls.Add(panelFill);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormStudents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Студенты";
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStud).EndInit();
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        private Panel panelTop;
        private DataGridView dataGridViewStud;
        private Button buttonAddStud;
        private Button buttonDelStud;
        private Button buttonEditStud;
    }
}