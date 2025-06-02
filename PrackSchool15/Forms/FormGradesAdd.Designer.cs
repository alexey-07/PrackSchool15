namespace PrackSchool15
{
    partial class FormGradesAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGradesAdd));
            panelFill = new Panel();
            textBoxComments = new TextBox();
            labelComment = new Label();
            dateTimePickerGrade = new DateTimePicker();
            labelDateGrade = new Label();
            textBoxGradeNum = new TextBox();
            labelGrade = new Label();
            labelLessonInfo = new Label();
            comboBoxLessonInfo = new ComboBox();
            comboBoxNameUser = new ComboBox();
            labelNameUser = new Label();
            dataGridViewGradesAdd = new DataGridView();
            panelBottom = new Panel();
            buttonCancel = new Button();
            buttonSave = new Button();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGradesAdd).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(textBoxComments);
            panelFill.Controls.Add(labelComment);
            panelFill.Controls.Add(dateTimePickerGrade);
            panelFill.Controls.Add(labelDateGrade);
            panelFill.Controls.Add(textBoxGradeNum);
            panelFill.Controls.Add(labelGrade);
            panelFill.Controls.Add(labelLessonInfo);
            panelFill.Controls.Add(comboBoxLessonInfo);
            panelFill.Controls.Add(comboBoxNameUser);
            panelFill.Controls.Add(labelNameUser);
            panelFill.Controls.Add(dataGridViewGradesAdd);
            panelFill.Controls.Add(panelBottom);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(686, 601);
            panelFill.TabIndex = 0;
            // 
            // textBoxComments
            // 
            textBoxComments.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxComments.Location = new Point(34, 340);
            textBoxComments.Name = "textBoxComments";
            textBoxComments.Size = new Size(284, 29);
            textBoxComments.TabIndex = 11;
            // 
            // labelComment
            // 
            labelComment.AutoSize = true;
            labelComment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelComment.Location = new Point(34, 305);
            labelComment.Name = "labelComment";
            labelComment.Size = new Size(109, 21);
            labelComment.TabIndex = 10;
            labelComment.Text = "Комментарий";
            // 
            // dateTimePickerGrade
            // 
            dateTimePickerGrade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePickerGrade.Location = new Point(34, 255);
            dateTimePickerGrade.Name = "dateTimePickerGrade";
            dateTimePickerGrade.Size = new Size(200, 29);
            dateTimePickerGrade.TabIndex = 9;
            // 
            // labelDateGrade
            // 
            labelDateGrade.AutoSize = true;
            labelDateGrade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDateGrade.Location = new Point(34, 231);
            labelDateGrade.Name = "labelDateGrade";
            labelDateGrade.Size = new Size(139, 21);
            labelDateGrade.TabIndex = 8;
            labelDateGrade.Text = "Дата выставления";
            // 
            // textBoxGradeNum
            // 
            textBoxGradeNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxGradeNum.Location = new Point(34, 181);
            textBoxGradeNum.Name = "textBoxGradeNum";
            textBoxGradeNum.Size = new Size(90, 29);
            textBoxGradeNum.TabIndex = 7;
            // 
            // labelGrade
            // 
            labelGrade.AutoSize = true;
            labelGrade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelGrade.Location = new Point(34, 157);
            labelGrade.Name = "labelGrade";
            labelGrade.Size = new Size(65, 21);
            labelGrade.TabIndex = 6;
            labelGrade.Text = "Оценка";
            // 
            // labelLessonInfo
            // 
            labelLessonInfo.AutoSize = true;
            labelLessonInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLessonInfo.Location = new Point(34, 85);
            labelLessonInfo.Name = "labelLessonInfo";
            labelLessonInfo.Size = new Size(93, 21);
            labelLessonInfo.TabIndex = 5;
            labelLessonInfo.Text = "Расписание";
            // 
            // comboBoxLessonInfo
            // 
            comboBoxLessonInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxLessonInfo.FormattingEnabled = true;
            comboBoxLessonInfo.Location = new Point(34, 109);
            comboBoxLessonInfo.Name = "comboBoxLessonInfo";
            comboBoxLessonInfo.Size = new Size(635, 29);
            comboBoxLessonInfo.TabIndex = 4;
            // 
            // comboBoxNameUser
            // 
            comboBoxNameUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxNameUser.FormattingEnabled = true;
            comboBoxNameUser.Location = new Point(34, 43);
            comboBoxNameUser.Name = "comboBoxNameUser";
            comboBoxNameUser.Size = new Size(231, 29);
            comboBoxNameUser.TabIndex = 3;
            // 
            // labelNameUser
            // 
            labelNameUser.AutoSize = true;
            labelNameUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNameUser.Location = new Point(34, 19);
            labelNameUser.Name = "labelNameUser";
            labelNameUser.Size = new Size(90, 21);
            labelNameUser.TabIndex = 2;
            labelNameUser.Text = "Имя юзера";
            // 
            // dataGridViewGradesAdd
            // 
            dataGridViewGradesAdd.BackgroundColor = Color.White;
            dataGridViewGradesAdd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGradesAdd.Dock = DockStyle.Fill;
            dataGridViewGradesAdd.Location = new Point(10, 10);
            dataGridViewGradesAdd.Name = "dataGridViewGradesAdd";
            dataGridViewGradesAdd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGradesAdd.Size = new Size(666, 522);
            dataGridViewGradesAdd.TabIndex = 1;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonCancel);
            panelBottom.Controls.Add(buttonSave);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(10, 532);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(10);
            panelBottom.Size = new Size(666, 59);
            panelBottom.TabIndex = 0;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(239, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Padding = new Padding(10);
            buttonCancel.Size = new Size(220, 52);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(13, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Padding = new Padding(10);
            buttonSave.Size = new Size(220, 52);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormGradesAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 601);
            Controls.Add(panelFill);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormGradesAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGradesAdd";
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGradesAdd).EndInit();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        private DataGridView dataGridViewGradesAdd;
        private Panel panelBottom;
        private Label labelNameUser;
        public TextBox textBoxGradeNum;
        private Label labelGrade;
        private Label labelLessonInfo;
        public ComboBox comboBoxLessonInfo;
        public ComboBox comboBoxNameUser;
        public TextBox textBoxComments;
        private Label labelComment;
        public DateTimePicker dateTimePickerGrade;
        private Label labelDateGrade;
        private Button buttonCancel;
        private Button buttonSave;
    }
}