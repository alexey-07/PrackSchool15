namespace PrackSchool15
{
    partial class FormClasses
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
            panelTop = new Panel();
            dataGridViewClass = new DataGridView();
            buttonAddClass = new Button();
            buttonEditClass = new Button();
            buttonDelClass = new Button();
            panelFill.SuspendLayout();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClass).BeginInit();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewClass);
            panelFill.Controls.Add(panelTop);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(917, 457);
            panelFill.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonDelClass);
            panelTop.Controls.Add(buttonEditClass);
            panelTop.Controls.Add(buttonAddClass);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(10, 10);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(897, 58);
            panelTop.TabIndex = 0;
            // 
            // dataGridViewClass
            // 
            dataGridViewClass.BackgroundColor = Color.White;
            dataGridViewClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClass.Dock = DockStyle.Fill;
            dataGridViewClass.Location = new Point(10, 68);
            dataGridViewClass.Name = "dataGridViewClass";
            dataGridViewClass.Size = new Size(897, 379);
            dataGridViewClass.TabIndex = 1;
            // 
            // buttonAddClass
            // 
            buttonAddClass.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAddClass.Location = new Point(13, 7);
            buttonAddClass.Name = "buttonAddClass";
            buttonAddClass.Padding = new Padding(5);
            buttonAddClass.Size = new Size(284, 45);
            buttonAddClass.TabIndex = 1;
            buttonAddClass.Text = "Добавить";
            buttonAddClass.UseVisualStyleBackColor = true;
            // 
            // buttonEditClass
            // 
            buttonEditClass.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEditClass.Location = new Point(303, 7);
            buttonEditClass.Name = "buttonEditClass";
            buttonEditClass.Padding = new Padding(5);
            buttonEditClass.Size = new Size(284, 45);
            buttonEditClass.TabIndex = 2;
            buttonEditClass.Text = "Редактировать";
            buttonEditClass.UseVisualStyleBackColor = true;
            // 
            // buttonDelClass
            // 
            buttonDelClass.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDelClass.Location = new Point(593, 7);
            buttonDelClass.Name = "buttonDelClass";
            buttonDelClass.Padding = new Padding(5);
            buttonDelClass.Size = new Size(284, 45);
            buttonDelClass.TabIndex = 3;
            buttonDelClass.Text = "Удалить";
            buttonDelClass.UseVisualStyleBackColor = true;
            // 
            // FormClasses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 457);
            Controls.Add(panelFill);
            Name = "FormClasses";
            Text = "Классы";
            panelFill.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewClass).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        private Panel panelTop;
        private DataGridView dataGridViewClass;
        private Button buttonDelClass;
        private Button buttonEditClass;
        private Button buttonAddClass;
    }
}