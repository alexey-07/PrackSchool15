namespace PrackSchool15
{
    partial class FormAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAttendance));
            panelFill = new Panel();
            dataGridViewAtten = new DataGridView();
            panelTop = new Panel();
            buttonDelAtten = new Button();
            buttonEditAtten = new Button();
            buttonAddAtten = new Button();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtten).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewAtten);
            panelFill.Controls.Add(panelTop);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(912, 490);
            panelFill.TabIndex = 0;
            // 
            // dataGridViewAtten
            // 
            dataGridViewAtten.BackgroundColor = Color.White;
            dataGridViewAtten.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAtten.Dock = DockStyle.Fill;
            dataGridViewAtten.Location = new Point(10, 66);
            dataGridViewAtten.Name = "dataGridViewAtten";
            dataGridViewAtten.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAtten.Size = new Size(892, 414);
            dataGridViewAtten.TabIndex = 1;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonDelAtten);
            panelTop.Controls.Add(buttonEditAtten);
            panelTop.Controls.Add(buttonAddAtten);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(10, 10);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(892, 56);
            panelTop.TabIndex = 0;
            // 
            // buttonDelAtten
            // 
            buttonDelAtten.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDelAtten.Location = new Point(593, 5);
            buttonDelAtten.Name = "buttonDelAtten";
            buttonDelAtten.Padding = new Padding(5);
            buttonDelAtten.Size = new Size(284, 45);
            buttonDelAtten.TabIndex = 5;
            buttonDelAtten.Text = "Удалить";
            buttonDelAtten.UseVisualStyleBackColor = true;
            buttonDelAtten.Click += buttonDelAtten_Click;
            // 
            // buttonEditAtten
            // 
            buttonEditAtten.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEditAtten.Location = new Point(303, 5);
            buttonEditAtten.Name = "buttonEditAtten";
            buttonEditAtten.Padding = new Padding(5);
            buttonEditAtten.Size = new Size(284, 45);
            buttonEditAtten.TabIndex = 4;
            buttonEditAtten.Text = "Редактировать";
            buttonEditAtten.UseVisualStyleBackColor = true;
            buttonEditAtten.Click += buttonEditAtten_Click;
            // 
            // buttonAddAtten
            // 
            buttonAddAtten.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAddAtten.Location = new Point(13, 5);
            buttonAddAtten.Name = "buttonAddAtten";
            buttonAddAtten.Padding = new Padding(5);
            buttonAddAtten.Size = new Size(284, 45);
            buttonAddAtten.TabIndex = 3;
            buttonAddAtten.Text = "Добавить";
            buttonAddAtten.UseVisualStyleBackColor = true;
            buttonAddAtten.Click += buttonAddAtten_Click;
            // 
            // FormAttendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 490);
            Controls.Add(panelFill);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAttendance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Посещаемость";
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtten).EndInit();
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        private Panel panelTop;
        private DataGridView dataGridViewAtten;
        private Button buttonDelAtten;
        private Button buttonEditAtten;
        private Button buttonAddAtten;
    }
}