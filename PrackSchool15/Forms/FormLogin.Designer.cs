namespace PrackSchool15
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panelFill = new Panel();
            buttonLogin = new Button();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            textBoxUsername = new TextBox();
            labelName = new Label();
            dataGridViewLogin = new DataGridView();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogin).BeginInit();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(buttonLogin);
            panelFill.Controls.Add(textBoxPassword);
            panelFill.Controls.Add(labelPassword);
            panelFill.Controls.Add(textBoxUsername);
            panelFill.Controls.Add(labelName);
            panelFill.Controls.Add(dataGridViewLogin);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(341, 313);
            panelFill.TabIndex = 0;
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonLogin.Location = new Point(24, 216);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(111, 46);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPassword.Location = new Point(24, 161);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(152, 35);
            textBoxPassword.TabIndex = 4;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPassword.Location = new Point(24, 126);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(111, 32);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxUsername.Location = new Point(24, 69);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(152, 35);
            textBoxUsername.TabIndex = 2;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.Location = new Point(24, 34);
            labelName.Name = "labelName";
            labelName.Size = new Size(121, 32);
            labelName.TabIndex = 1;
            labelName.Text = "Username";
            // 
            // dataGridViewLogin
            // 
            dataGridViewLogin.BackgroundColor = Color.White;
            dataGridViewLogin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLogin.Dock = DockStyle.Fill;
            dataGridViewLogin.Location = new Point(10, 10);
            dataGridViewLogin.Name = "dataGridViewLogin";
            dataGridViewLogin.Size = new Size(321, 293);
            dataGridViewLogin.TabIndex = 0;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 313);
            Controls.Add(panelFill);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFill;
        private Label labelPassword;
        private TextBox textBoxUsername;
        private Label labelName;
        private DataGridView dataGridViewLogin;
        private TextBox textBoxPassword;
        private Button buttonLogin;
    }
}