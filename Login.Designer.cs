namespace TallerBD
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUser = new TextBox();
            lblUser = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(109, 25);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(137, 23);
            txtUser.TabIndex = 0;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(53, 28);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(50, 15);
            lblUser.TabIndex = 2;
            lblUser.Text = "Usuario:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(33, 71);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(109, 68);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(137, 23);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "asdasdad";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(140, 109);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 164);
            Controls.Add(btnEntrar);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblUser);
            Controls.Add(txtUser);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private Label lblUser;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnEntrar;
    }
}