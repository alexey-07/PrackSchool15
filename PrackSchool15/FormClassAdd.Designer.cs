namespace PrackSchool15
{
    partial class FormClassAdd
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
            comboBoxNameClass = new ComboBox();
            labelNameTeacher = new Label();
            labelNameClass = new Label();
            textBoxClassNumber = new TextBox();
            labelNumberClass = new Label();
            dataGridViewClassAdd = new DataGridView();
            panelBottom = new Panel();
            button1 = new Button();
            buttonSave = new Button();
            comboBoxFIOTeach = new ComboBox();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClassAdd).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(comboBoxFIOTeach);
            panelFill.Controls.Add(comboBoxNameClass);
            panelFill.Controls.Add(labelNameTeacher);
            panelFill.Controls.Add(labelNameClass);
            panelFill.Controls.Add(textBoxClassNumber);
            panelFill.Controls.Add(labelNumberClass);
            panelFill.Controls.Add(dataGridViewClassAdd);
            panelFill.Controls.Add(panelBottom);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(376, 628);
            panelFill.TabIndex = 0;
            // 
            // comboBoxNameClass
            // 
            comboBoxNameClass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxNameClass.FormattingEnabled = true;
            comboBoxNameClass.Location = new Point(32, 118);
            comboBoxNameClass.Name = "comboBoxNameClass";
            comboBoxNameClass.Size = new Size(135, 29);
            comboBoxNameClass.TabIndex = 12;
            // 
            // labelNameTeacher
            // 
            labelNameTeacher.AutoSize = true;
            labelNameTeacher.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNameTeacher.Location = new Point(32, 167);
            labelNameTeacher.Name = "labelNameTeacher";
            labelNameTeacher.Size = new Size(123, 25);
            labelNameTeacher.TabIndex = 6;
            labelNameTeacher.Text = "Имя учителя";
            // 
            // labelNameClass
            // 
            labelNameClass.AutoSize = true;
            labelNameClass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNameClass.Location = new Point(32, 90);
            labelNameClass.Name = "labelNameClass";
            labelNameClass.Size = new Size(95, 25);
            labelNameClass.TabIndex = 4;
            labelNameClass.Text = "Название";
            // 
            // textBoxClassNumber
            // 
            textBoxClassNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxClassNumber.Location = new Point(32, 48);
            textBoxClassNumber.Name = "textBoxClassNumber";
            textBoxClassNumber.Size = new Size(135, 29);
            textBoxClassNumber.TabIndex = 3;
            // 
            // labelNumberClass
            // 
            labelNumberClass.AutoSize = true;
            labelNumberClass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNumberClass.Location = new Point(32, 20);
            labelNumberClass.Name = "labelNumberClass";
            labelNumberClass.Size = new Size(61, 25);
            labelNumberClass.TabIndex = 2;
            labelNumberClass.Text = "Класс";
            // 
            // dataGridViewClassAdd
            // 
            dataGridViewClassAdd.BackgroundColor = Color.White;
            dataGridViewClassAdd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClassAdd.Dock = DockStyle.Fill;
            dataGridViewClassAdd.Location = new Point(10, 10);
            dataGridViewClassAdd.Name = "dataGridViewClassAdd";
            dataGridViewClassAdd.Size = new Size(356, 548);
            dataGridViewClassAdd.TabIndex = 1;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(button1);
            panelBottom.Controls.Add(buttonSave);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(10, 558);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(10);
            panelBottom.Size = new Size(356, 60);
            panelBottom.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(3, 6);
            button1.Name = "button1";
            button1.Padding = new Padding(10);
            button1.Size = new Size(168, 47);
            button1.TabIndex = 14;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(185, 6);
            buttonSave.Name = "buttonSave";
            buttonSave.Padding = new Padding(10);
            buttonSave.Size = new Size(168, 47);
            buttonSave.TabIndex = 13;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // comboBoxFIOTeach
            // 
            comboBoxFIOTeach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxFIOTeach.FormattingEnabled = true;
            comboBoxFIOTeach.Location = new Point(32, 195);
            comboBoxFIOTeach.Name = "comboBoxFIOTeach";
            comboBoxFIOTeach.Size = new Size(238, 29);
            comboBoxFIOTeach.TabIndex = 13;
            // 
            // FormClassAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 628);
            Controls.Add(panelFill);
            Name = "FormClassAdd";
            Text = "FormClassAdd";
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClassAdd).EndInit();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        private DataGridView dataGridViewClassAdd;
        private Panel panelBottom;
        private Label labelNumberClass;
        private Label labelNameClass;
        private Label labelNameTeacher;
        private Button button1;
        private Button buttonSave;
        public TextBox textBoxClassNumber;
        public ComboBox comboBoxNameClass;
        public ComboBox comboBoxFIOTeach;
    }
}