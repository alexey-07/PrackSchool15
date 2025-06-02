namespace PrackSchool15
{
    partial class FormLessonAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLessonAdd));
            panelFill = new Panel();
            comboBoxRoomNum = new ComboBox();
            labelRoom = new Label();
            labelEndTime = new Label();
            labelStartTime = new Label();
            dateTimePickerLessonDate = new DateTimePicker();
            labelLessonDate = new Label();
            comboBoxTeacherInto = new ComboBox();
            labelTeacherInto = new Label();
            comboBoxSubjectInto = new ComboBox();
            labelSubjectInto = new Label();
            comboBoxClassInto = new ComboBox();
            labelClassInto = new Label();
            dataGridViewLessonAdd = new DataGridView();
            panelBottom = new Panel();
            buttonCancel = new Button();
            buttonSave = new Button();
            dateTimePickerStartTime = new DateTimePicker();
            dateTimePickerEndTime = new DateTimePicker();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLessonAdd).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dateTimePickerEndTime);
            panelFill.Controls.Add(dateTimePickerStartTime);
            panelFill.Controls.Add(comboBoxRoomNum);
            panelFill.Controls.Add(labelRoom);
            panelFill.Controls.Add(labelEndTime);
            panelFill.Controls.Add(labelStartTime);
            panelFill.Controls.Add(dateTimePickerLessonDate);
            panelFill.Controls.Add(labelLessonDate);
            panelFill.Controls.Add(comboBoxTeacherInto);
            panelFill.Controls.Add(labelTeacherInto);
            panelFill.Controls.Add(comboBoxSubjectInto);
            panelFill.Controls.Add(labelSubjectInto);
            panelFill.Controls.Add(comboBoxClassInto);
            panelFill.Controls.Add(labelClassInto);
            panelFill.Controls.Add(dataGridViewLessonAdd);
            panelFill.Controls.Add(panelBottom);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(558, 643);
            panelFill.TabIndex = 0;
            // 
            // comboBoxRoomNum
            // 
            comboBoxRoomNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxRoomNum.FormattingEnabled = true;
            comboBoxRoomNum.Location = new Point(48, 492);
            comboBoxRoomNum.Name = "comboBoxRoomNum";
            comboBoxRoomNum.Size = new Size(73, 29);
            comboBoxRoomNum.TabIndex = 12;
            // 
            // labelRoom
            // 
            labelRoom.AutoSize = true;
            labelRoom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelRoom.Location = new Point(48, 468);
            labelRoom.Name = "labelRoom";
            labelRoom.Size = new Size(128, 21);
            labelRoom.TabIndex = 11;
            labelRoom.Text = "Номер кабинета";
            // 
            // labelEndTime
            // 
            labelEndTime.AutoSize = true;
            labelEndTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelEndTime.Location = new Point(48, 395);
            labelEndTime.Name = "labelEndTime";
            labelEndTime.Size = new Size(101, 21);
            labelEndTime.TabIndex = 10;
            labelEndTime.Text = "Конец урока";
            // 
            // labelStartTime
            // 
            labelStartTime.AutoSize = true;
            labelStartTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelStartTime.Location = new Point(48, 321);
            labelStartTime.Name = "labelStartTime";
            labelStartTime.Size = new Size(109, 21);
            labelStartTime.TabIndex = 9;
            labelStartTime.Text = "Начало урока";
            // 
            // dateTimePickerLessonDate
            // 
            dateTimePickerLessonDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePickerLessonDate.Location = new Point(48, 272);
            dateTimePickerLessonDate.Name = "dateTimePickerLessonDate";
            dateTimePickerLessonDate.Size = new Size(200, 29);
            dateTimePickerLessonDate.TabIndex = 8;
            // 
            // labelLessonDate
            // 
            labelLessonDate.AutoSize = true;
            labelLessonDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLessonDate.Location = new Point(48, 248);
            labelLessonDate.Name = "labelLessonDate";
            labelLessonDate.Size = new Size(90, 21);
            labelLessonDate.TabIndex = 7;
            labelLessonDate.Text = "Дата урока";
            // 
            // comboBoxTeacherInto
            // 
            comboBoxTeacherInto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxTeacherInto.FormattingEnabled = true;
            comboBoxTeacherInto.Location = new Point(48, 195);
            comboBoxTeacherInto.Name = "comboBoxTeacherInto";
            comboBoxTeacherInto.Size = new Size(464, 29);
            comboBoxTeacherInto.TabIndex = 6;
            // 
            // labelTeacherInto
            // 
            labelTeacherInto.AutoSize = true;
            labelTeacherInto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTeacherInto.Location = new Point(48, 171);
            labelTeacherInto.Name = "labelTeacherInto";
            labelTeacherInto.Size = new Size(68, 21);
            labelTeacherInto.TabIndex = 5;
            labelTeacherInto.Text = "Учитель";
            // 
            // comboBoxSubjectInto
            // 
            comboBoxSubjectInto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxSubjectInto.FormattingEnabled = true;
            comboBoxSubjectInto.Location = new Point(48, 117);
            comboBoxSubjectInto.Name = "comboBoxSubjectInto";
            comboBoxSubjectInto.Size = new Size(166, 29);
            comboBoxSubjectInto.TabIndex = 4;
            // 
            // labelSubjectInto
            // 
            labelSubjectInto.AutoSize = true;
            labelSubjectInto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSubjectInto.Location = new Point(48, 93);
            labelSubjectInto.Name = "labelSubjectInto";
            labelSubjectInto.Size = new Size(73, 21);
            labelSubjectInto.TabIndex = 3;
            labelSubjectInto.Text = "Предмет";
            // 
            // comboBoxClassInto
            // 
            comboBoxClassInto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxClassInto.FormattingEnabled = true;
            comboBoxClassInto.Location = new Point(48, 44);
            comboBoxClassInto.Name = "comboBoxClassInto";
            comboBoxClassInto.Size = new Size(121, 29);
            comboBoxClassInto.TabIndex = 2;
            // 
            // labelClassInto
            // 
            labelClassInto.AutoSize = true;
            labelClassInto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelClassInto.Location = new Point(48, 20);
            labelClassInto.Name = "labelClassInto";
            labelClassInto.Size = new Size(49, 21);
            labelClassInto.TabIndex = 1;
            labelClassInto.Text = "Класс";
            // 
            // dataGridViewLessonAdd
            // 
            dataGridViewLessonAdd.BackgroundColor = Color.White;
            dataGridViewLessonAdd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLessonAdd.Dock = DockStyle.Fill;
            dataGridViewLessonAdd.Location = new Point(10, 10);
            dataGridViewLessonAdd.Name = "dataGridViewLessonAdd";
            dataGridViewLessonAdd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLessonAdd.Size = new Size(538, 564);
            dataGridViewLessonAdd.TabIndex = 1;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonCancel);
            panelBottom.Controls.Add(buttonSave);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(10, 574);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(10);
            panelBottom.Size = new Size(538, 59);
            panelBottom.TabIndex = 0;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.OK;
            buttonCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.Location = new Point(312, 6);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Padding = new Padding(10);
            buttonCancel.Size = new Size(158, 50);
            buttonCancel.TabIndex = 2;
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
            buttonSave.Size = new Size(158, 50);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // dateTimePickerStartTime
            // 
            dateTimePickerStartTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePickerStartTime.Location = new Point(48, 345);
            dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            dateTimePickerStartTime.Size = new Size(200, 29);
            dateTimePickerStartTime.TabIndex = 13;
            // 
            // dateTimePickerEndTime
            // 
            dateTimePickerEndTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePickerEndTime.Location = new Point(48, 419);
            dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            dateTimePickerEndTime.Size = new Size(200, 29);
            dateTimePickerEndTime.TabIndex = 14;
            // 
            // FormLessonAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 643);
            Controls.Add(panelFill);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLessonAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLessonAdd";
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLessonAdd).EndInit();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        private DataGridView dataGridViewLessonAdd;
        private Panel panelBottom;
        public ComboBox comboBoxSubjectInto;
        private Label labelSubjectInto;
        public ComboBox comboBoxClassInto;
        private Label labelClassInto;
        private Label labelStartTime;
        public DateTimePicker dateTimePickerLessonDate;
        private Label labelLessonDate;
        public ComboBox comboBoxTeacherInto;
        private Label labelTeacherInto;
        public ComboBox comboBoxRoomNum;
        private Label labelRoom;
        private Label labelEndTime;
        private Button buttonCancel;
        private Button buttonSave;
        public DateTimePicker dateTimePickerEndTime;
        public DateTimePicker dateTimePickerStartTime;
    }
}