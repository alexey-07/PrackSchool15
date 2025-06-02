namespace PrackSchool15
{
    partial class FormAttendanceAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAttendanceAdd));
            panelFill = new Panel();
            textBoxReasonAbsence = new TextBox();
            labelReasonForAbsence = new Label();
            checkBoxPresent = new CheckBox();
            labelPresent = new Label();
            dateTimePickerAttenDate = new DateTimePicker();
            labelDateAtten = new Label();
            comboBoxLessonInfo = new ComboBox();
            labelLessonInfo = new Label();
            comboBoxUsernameAdd = new ComboBox();
            labelNameUser = new Label();
            dataGridViewAttenAdd = new DataGridView();
            panelBottom = new Panel();
            buttonCancel = new Button();
            buttonSave = new Button();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttenAdd).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(textBoxReasonAbsence);
            panelFill.Controls.Add(labelReasonForAbsence);
            panelFill.Controls.Add(checkBoxPresent);
            panelFill.Controls.Add(labelPresent);
            panelFill.Controls.Add(dateTimePickerAttenDate);
            panelFill.Controls.Add(labelDateAtten);
            panelFill.Controls.Add(comboBoxLessonInfo);
            panelFill.Controls.Add(labelLessonInfo);
            panelFill.Controls.Add(comboBoxUsernameAdd);
            panelFill.Controls.Add(labelNameUser);
            panelFill.Controls.Add(dataGridViewAttenAdd);
            panelFill.Controls.Add(panelBottom);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(616, 601);
            panelFill.TabIndex = 0;
            // 
            // textBoxReasonAbsence
            // 
            textBoxReasonAbsence.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxReasonAbsence.Location = new Point(41, 335);
            textBoxReasonAbsence.Name = "textBoxReasonAbsence";
            textBoxReasonAbsence.Size = new Size(200, 29);
            textBoxReasonAbsence.TabIndex = 11;
            // 
            // labelReasonForAbsence
            // 
            labelReasonForAbsence.AutoSize = true;
            labelReasonForAbsence.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelReasonForAbsence.Location = new Point(41, 311);
            labelReasonForAbsence.Name = "labelReasonForAbsence";
            labelReasonForAbsence.Size = new Size(155, 21);
            labelReasonForAbsence.TabIndex = 10;
            labelReasonForAbsence.Text = "Причина отсутствия";
            // 
            // checkBoxPresent
            // 
            checkBoxPresent.AutoSize = true;
            checkBoxPresent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBoxPresent.Location = new Point(163, 267);
            checkBoxPresent.Name = "checkBoxPresent";
            checkBoxPresent.Size = new Size(15, 14);
            checkBoxPresent.TabIndex = 9;
            checkBoxPresent.TextImageRelation = TextImageRelation.TextAboveImage;
            checkBoxPresent.UseVisualStyleBackColor = true;
            // 
            // labelPresent
            // 
            labelPresent.AutoSize = true;
            labelPresent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPresent.Location = new Point(41, 260);
            labelPresent.Name = "labelPresent";
            labelPresent.Size = new Size(116, 21);
            labelPresent.TabIndex = 8;
            labelPresent.Text = "Присутствовал";
            // 
            // dateTimePickerAttenDate
            // 
            dateTimePickerAttenDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePickerAttenDate.Location = new Point(41, 198);
            dateTimePickerAttenDate.Name = "dateTimePickerAttenDate";
            dateTimePickerAttenDate.Size = new Size(200, 29);
            dateTimePickerAttenDate.TabIndex = 7;
            // 
            // labelDateAtten
            // 
            labelDateAtten.AutoSize = true;
            labelDateAtten.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDateAtten.Location = new Point(41, 174);
            labelDateAtten.Name = "labelDateAtten";
            labelDateAtten.Size = new Size(128, 21);
            labelDateAtten.TabIndex = 6;
            labelDateAtten.Text = "Дата посещения";
            // 
            // comboBoxLessonInfo
            // 
            comboBoxLessonInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxLessonInfo.FormattingEnabled = true;
            comboBoxLessonInfo.Location = new Point(41, 121);
            comboBoxLessonInfo.Name = "comboBoxLessonInfo";
            comboBoxLessonInfo.Size = new Size(547, 29);
            comboBoxLessonInfo.TabIndex = 5;
            // 
            // labelLessonInfo
            // 
            labelLessonInfo.AutoSize = true;
            labelLessonInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLessonInfo.Location = new Point(41, 97);
            labelLessonInfo.Name = "labelLessonInfo";
            labelLessonInfo.Size = new Size(93, 21);
            labelLessonInfo.TabIndex = 4;
            labelLessonInfo.Text = "Расписание";
            // 
            // comboBoxUsernameAdd
            // 
            comboBoxUsernameAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxUsernameAdd.FormattingEnabled = true;
            comboBoxUsernameAdd.Location = new Point(41, 46);
            comboBoxUsernameAdd.Name = "comboBoxUsernameAdd";
            comboBoxUsernameAdd.Size = new Size(200, 29);
            comboBoxUsernameAdd.TabIndex = 3;
            // 
            // labelNameUser
            // 
            labelNameUser.AutoSize = true;
            labelNameUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNameUser.Location = new Point(41, 22);
            labelNameUser.Name = "labelNameUser";
            labelNameUser.Size = new Size(90, 21);
            labelNameUser.TabIndex = 2;
            labelNameUser.Text = "Имя юзера";
            // 
            // dataGridViewAttenAdd
            // 
            dataGridViewAttenAdd.BackgroundColor = Color.White;
            dataGridViewAttenAdd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttenAdd.Dock = DockStyle.Fill;
            dataGridViewAttenAdd.Location = new Point(10, 10);
            dataGridViewAttenAdd.Name = "dataGridViewAttenAdd";
            dataGridViewAttenAdd.Size = new Size(596, 523);
            dataGridViewAttenAdd.TabIndex = 1;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonCancel);
            panelBottom.Controls.Add(buttonSave);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(10, 533);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(10);
            panelBottom.Size = new Size(596, 58);
            panelBottom.TabIndex = 0;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(335, 6);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Padding = new Padding(10);
            buttonCancel.Size = new Size(196, 47);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(65, 6);
            buttonSave.Name = "buttonSave";
            buttonSave.Padding = new Padding(10);
            buttonSave.Size = new Size(196, 47);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormAttendanceAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 601);
            Controls.Add(panelFill);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAttendanceAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAttendanceAdd";
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttenAdd).EndInit();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        private DataGridView dataGridViewAttenAdd;
        private Panel panelBottom;
        private Button buttonCancel;
        private Button buttonSave;
        private Label labelNameUser;
        private Label labelLessonInfo;
        private Label labelPresent;
        private Label labelDateAtten;
        public ComboBox comboBoxUsernameAdd;
        public DateTimePicker dateTimePickerAttenDate;
        public ComboBox comboBoxLessonInfo;
        public TextBox textBoxReasonAbsence;
        private Label labelReasonForAbsence;
        public CheckBox checkBoxPresent;
    }
}