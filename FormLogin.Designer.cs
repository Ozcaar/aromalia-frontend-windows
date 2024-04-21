namespace Aromalia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_title2 = new System.Windows.Forms.Label();
            this.label_title1 = new System.Windows.Forms.Label();
            this.label_login_1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_login = new Guna.UI2.WinForms.Guna2Button();
            this.tboxUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.tboxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.panel1.Controls.Add(this.label_title2);
            this.panel1.Controls.Add(this.label_title1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 536);
            this.panel1.TabIndex = 0;
            // 
            // label_title2
            // 
            this.label_title2.AutoSize = true;
            this.label_title2.Font = new System.Drawing.Font("Golden Radiant", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title2.ForeColor = System.Drawing.Color.White;
            this.label_title2.Location = new System.Drawing.Point(60, 255);
            this.label_title2.Name = "label_title2";
            this.label_title2.Size = new System.Drawing.Size(309, 73);
            this.label_title2.TabIndex = 1;
            this.label_title2.Text = "AROMALIA";
            this.label_title2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_title1
            // 
            this.label_title1.AutoSize = true;
            this.label_title1.Font = new System.Drawing.Font("Inter Medium Italic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title1.ForeColor = System.Drawing.Color.White;
            this.label_title1.Location = new System.Drawing.Point(102, 198);
            this.label_title1.Name = "label_title1";
            this.label_title1.Size = new System.Drawing.Size(222, 41);
            this.label_title1.TabIndex = 0;
            this.label_title1.Text = "Bienvenido a";
            this.label_title1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_login_1
            // 
            this.label_login_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_login_1.AutoSize = true;
            this.label_login_1.Font = new System.Drawing.Font("Inter", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.label_login_1.Location = new System.Drawing.Point(189, 96);
            this.label_login_1.Name = "label_login_1";
            this.label_login_1.Size = new System.Drawing.Size(247, 42);
            this.label_login_1.TabIndex = 2;
            this.label_login_1.Text = "Iniciar sesión";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_login);
            this.panel2.Controls.Add(this.tboxUsuario);
            this.panel2.Controls.Add(this.tboxPassword);
            this.panel2.Controls.Add(this.label_login_1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(416, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 536);
            this.panel2.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.BorderRadius = 20;
            this.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btn_login.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(212, 359);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(200, 45);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Entrar";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tboxUsuario
            // 
            this.tboxUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.tboxUsuario.BorderRadius = 5;
            this.tboxUsuario.BorderThickness = 0;
            this.tboxUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxUsuario.DefaultText = "";
            this.tboxUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tboxUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tboxUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tboxUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxUsuario.Font = new System.Drawing.Font("Inter Italic", 15.75F);
            this.tboxUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.tboxUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxUsuario.IconLeft = global::Aromalia.Properties.Resources.user_img;
            this.tboxUsuario.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.tboxUsuario.IconLeftSize = new System.Drawing.Size(21, 24);
            this.tboxUsuario.Location = new System.Drawing.Point(160, 197);
            this.tboxUsuario.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tboxUsuario.Name = "tboxUsuario";
            this.tboxUsuario.PasswordChar = '\0';
            this.tboxUsuario.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.tboxUsuario.PlaceholderText = "Usuario";
            this.tboxUsuario.SelectedText = "";
            this.tboxUsuario.Size = new System.Drawing.Size(311, 43);
            this.tboxUsuario.TabIndex = 4;
            this.tboxUsuario.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // tboxPassword
            // 
            this.tboxPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.tboxPassword.BorderRadius = 5;
            this.tboxPassword.BorderThickness = 0;
            this.tboxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxPassword.DefaultText = "";
            this.tboxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tboxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tboxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tboxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxPassword.Font = new System.Drawing.Font("Inter Italic", 15.75F);
            this.tboxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.tboxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxPassword.IconLeft = global::Aromalia.Properties.Resources.password_img;
            this.tboxPassword.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.tboxPassword.IconLeftSize = new System.Drawing.Size(21, 24);
            this.tboxPassword.Location = new System.Drawing.Point(160, 276);
            this.tboxPassword.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.PasswordChar = '\0';
            this.tboxPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.tboxPassword.PlaceholderText = "Contraseña";
            this.tboxPassword.SelectedText = "";
            this.tboxPassword.Size = new System.Drawing.Size(311, 43);
            this.tboxPassword.TabIndex = 1;
            this.tboxPassword.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 536);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_title1;
        private System.Windows.Forms.Label label_title2;
        private System.Windows.Forms.Label label_login_1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_login;
        private Guna.UI2.WinForms.Guna2TextBox tboxUsuario;
        private Guna.UI2.WinForms.Guna2TextBox tboxPassword;
    }
}

