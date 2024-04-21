namespace Aromalia
{
    partial class FormPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPanel));
            this.txtLogo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_salir = new Guna.UI2.WinForms.Guna2Button();
            this.btn_pedidos = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ventas = new Guna.UI2.WinForms.Guna2Button();
            this.btn_inventario = new Guna.UI2.WinForms.Guna2Button();
            this.txtUsername = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogo
            // 
            this.txtLogo.AutoSize = true;
            this.txtLogo.Font = new System.Drawing.Font("Golden Radiant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogo.ForeColor = System.Drawing.Color.White;
            this.txtLogo.Location = new System.Drawing.Point(33, 35);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(183, 43);
            this.txtLogo.TabIndex = 0;
            this.txtLogo.Text = "AROMALIA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.btn_pedidos);
            this.panel1.Controls.Add(this.btn_ventas);
            this.panel1.Controls.Add(this.btn_inventario);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 603);
            this.panel1.TabIndex = 0;
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_salir.BorderColor = System.Drawing.Color.Transparent;
            this.btn_salir.BorderRadius = 10;
            this.btn_salir.CustomBorderThickness = new System.Windows.Forms.Padding(10);
            this.btn_salir.CustomizableEdges.BottomRight = false;
            this.btn_salir.CustomizableEdges.TopRight = false;
            this.btn_salir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_salir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_salir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_salir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_salir.FillColor = System.Drawing.Color.Transparent;
            this.btn_salir.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btn_salir.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_salir.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_salir.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_salir.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.btn_salir.HoverState.Image = global::Aromalia.Properties.Resources.salir_hover_icon;
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_salir.ImageOffset = new System.Drawing.Point(10, 0);
            this.btn_salir.IndicateFocus = true;
            this.btn_salir.Location = new System.Drawing.Point(44, 547);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_salir.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
            this.btn_salir.Size = new System.Drawing.Size(209, 44);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_pedidos
            // 
            this.btn_pedidos.BackColor = System.Drawing.Color.Transparent;
            this.btn_pedidos.BorderColor = System.Drawing.Color.Transparent;
            this.btn_pedidos.BorderRadius = 10;
            this.btn_pedidos.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_pedidos.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_pedidos.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btn_pedidos.CustomizableEdges.BottomRight = false;
            this.btn_pedidos.CustomizableEdges.TopRight = false;
            this.btn_pedidos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_pedidos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_pedidos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_pedidos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_pedidos.FillColor = System.Drawing.Color.Transparent;
            this.btn_pedidos.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btn_pedidos.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_pedidos.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_pedidos.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_pedidos.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.btn_pedidos.HoverState.Image = global::Aromalia.Properties.Resources.pedidos_hover_icon;
            this.btn_pedidos.Image = ((System.Drawing.Image)(resources.GetObject("btn_pedidos.Image")));
            this.btn_pedidos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_pedidos.ImageOffset = new System.Drawing.Point(10, 0);
            this.btn_pedidos.IndicateFocus = true;
            this.btn_pedidos.Location = new System.Drawing.Point(42, 281);
            this.btn_pedidos.Name = "btn_pedidos";
            this.btn_pedidos.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_pedidos.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
            this.btn_pedidos.Size = new System.Drawing.Size(209, 44);
            this.btn_pedidos.TabIndex = 4;
            this.btn_pedidos.Text = "Pedidos";
            this.btn_pedidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_pedidos.Click += new System.EventHandler(this.btn_pedidos_Click);
            // 
            // btn_ventas
            // 
            this.btn_ventas.BackColor = System.Drawing.Color.Transparent;
            this.btn_ventas.BorderColor = System.Drawing.Color.Transparent;
            this.btn_ventas.BorderRadius = 10;
            this.btn_ventas.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_ventas.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_ventas.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btn_ventas.CustomizableEdges.BottomRight = false;
            this.btn_ventas.CustomizableEdges.TopRight = false;
            this.btn_ventas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ventas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ventas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ventas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ventas.FillColor = System.Drawing.Color.Transparent;
            this.btn_ventas.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ventas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btn_ventas.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_ventas.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_ventas.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_ventas.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.btn_ventas.HoverState.Image = global::Aromalia.Properties.Resources.ventas_hover_icon;
            this.btn_ventas.Image = ((System.Drawing.Image)(resources.GetObject("btn_ventas.Image")));
            this.btn_ventas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_ventas.ImageOffset = new System.Drawing.Point(10, 0);
            this.btn_ventas.IndicateFocus = true;
            this.btn_ventas.Location = new System.Drawing.Point(41, 231);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_ventas.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
            this.btn_ventas.Size = new System.Drawing.Size(209, 44);
            this.btn_ventas.TabIndex = 4;
            this.btn_ventas.Text = "Ventas";
            this.btn_ventas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // btn_inventario
            // 
            this.btn_inventario.BackColor = System.Drawing.Color.Transparent;
            this.btn_inventario.BorderColor = System.Drawing.Color.Transparent;
            this.btn_inventario.BorderRadius = 10;
            this.btn_inventario.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btn_inventario.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_inventario.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_inventario.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btn_inventario.CustomizableEdges.BottomRight = false;
            this.btn_inventario.CustomizableEdges.TopRight = false;
            this.btn_inventario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_inventario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_inventario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_inventario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_inventario.FillColor = System.Drawing.Color.Transparent;
            this.btn_inventario.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btn_inventario.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_inventario.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_inventario.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_inventario.HoverState.Image = global::Aromalia.Properties.Resources.inventario_hover_icon;
            this.btn_inventario.Image = ((System.Drawing.Image)(resources.GetObject("btn_inventario.Image")));
            this.btn_inventario.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_inventario.ImageOffset = new System.Drawing.Point(10, 0);
            this.btn_inventario.IndicateFocus = true;
            this.btn_inventario.Location = new System.Drawing.Point(40, 181);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_inventario.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
            this.btn_inventario.Size = new System.Drawing.Size(209, 44);
            this.btn_inventario.TabIndex = 3;
            this.btn_inventario.Text = "Inventario";
            this.btn_inventario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_inventario.Click += new System.EventHandler(this.btn_inventario_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Font = new System.Drawing.Font("Inter", 10F);
            this.txtUsername.Location = new System.Drawing.Point(45, 105);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(158, 17);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Bienvenido {username}";
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.White;
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(248, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(756, 603);
            this.panelChildForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Aromalia.Properties.Resources.logo_background;
            this.pictureBox1.Location = new System.Drawing.Point(249, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 603);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1020, 603);
            this.Name = "FormPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Button btn_inventario;
        private Guna.UI2.WinForms.Guna2Button btn_ventas;
        private Guna.UI2.WinForms.Guna2Button btn_pedidos;
        private System.Windows.Forms.Label txtUsername;
        private Guna.UI2.WinForms.Guna2Button btn_salir;
    }
}