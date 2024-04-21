namespace Aromalia
{
    partial class EditarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarProducto));
            this.btnAceptar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.tboxNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.formTotal_txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxDescripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tboxAlto = new Guna.UI2.WinForms.Guna2TextBox();
            this.tboxAncho = new Guna.UI2.WinForms.Guna2TextBox();
            this.tboxPeso = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxStock = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.tboxPrecio = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtSKU = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSeleccionarImagen = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.tboxStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(107)))));
            this.btnAceptar.BorderRadius = 10;
            this.btnAceptar.BorderThickness = 1;
            this.btnAceptar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAceptar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAceptar.FillColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(178)))), ((int)(((byte)(107)))));
            this.btnAceptar.Location = new System.Drawing.Point(350, 396);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(267, 36);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderColor = System.Drawing.Color.Red;
            this.btnCancelar.BorderRadius = 10;
            this.btnCancelar.BorderThickness = 1;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.FillColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(350, 452);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(267, 36);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tboxNombre
            // 
            this.tboxNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.tboxNombre.BorderRadius = 5;
            this.tboxNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxNombre.DefaultText = "";
            this.tboxNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tboxNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tboxNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxNombre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tboxNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxNombre.Location = new System.Drawing.Point(34, 82);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.PasswordChar = '\0';
            this.tboxNombre.PlaceholderText = "";
            this.tboxNombre.SelectedText = "";
            this.tboxNombre.Size = new System.Drawing.Size(267, 36);
            this.tboxNombre.TabIndex = 3;
            // 
            // formTotal_txt
            // 
            this.formTotal_txt.AutoSize = true;
            this.formTotal_txt.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTotal_txt.ForeColor = System.Drawing.Color.Gray;
            this.formTotal_txt.Location = new System.Drawing.Point(30, 60);
            this.formTotal_txt.Name = "formTotal_txt";
            this.formTotal_txt.Size = new System.Drawing.Size(66, 19);
            this.formTotal_txt.TabIndex = 0;
            this.formTotal_txt.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(30, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(30, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Precio";
            // 
            // tboxDescripcion
            // 
            this.tboxDescripcion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.tboxDescripcion.BorderRadius = 5;
            this.tboxDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxDescripcion.DefaultText = "";
            this.tboxDescripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tboxDescripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tboxDescripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxDescripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxDescripcion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tboxDescripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxDescripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxDescripcion.Location = new System.Drawing.Point(34, 291);
            this.tboxDescripcion.Multiline = true;
            this.tboxDescripcion.Name = "tboxDescripcion";
            this.tboxDescripcion.PasswordChar = '\0';
            this.tboxDescripcion.PlaceholderText = "";
            this.tboxDescripcion.SelectedText = "";
            this.tboxDescripcion.Size = new System.Drawing.Size(267, 197);
            this.tboxDescripcion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(30, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descripción";
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.BackColor = System.Drawing.Color.Transparent;
            this.cboxCategoria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.cboxCategoria.BorderRadius = 10;
            this.cboxCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategoria.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.cboxCategoria.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxCategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboxCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboxCategoria.ItemHeight = 30;
            this.cboxCategoria.Location = new System.Drawing.Point(350, 291);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(267, 36);
            this.cboxCategoria.TabIndex = 4;
            // 
            // tboxAlto
            // 
            this.tboxAlto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.tboxAlto.BorderRadius = 5;
            this.tboxAlto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxAlto.DefaultText = "";
            this.tboxAlto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tboxAlto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tboxAlto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxAlto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxAlto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tboxAlto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxAlto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxAlto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxAlto.Location = new System.Drawing.Point(350, 82);
            this.tboxAlto.Name = "tboxAlto";
            this.tboxAlto.PasswordChar = '\0';
            this.tboxAlto.PlaceholderText = "";
            this.tboxAlto.SelectedText = "";
            this.tboxAlto.Size = new System.Drawing.Size(267, 36);
            this.tboxAlto.TabIndex = 3;
            // 
            // tboxAncho
            // 
            this.tboxAncho.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.tboxAncho.BorderRadius = 5;
            this.tboxAncho.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxAncho.DefaultText = "";
            this.tboxAncho.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tboxAncho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tboxAncho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxAncho.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxAncho.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tboxAncho.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxAncho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxAncho.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxAncho.Location = new System.Drawing.Point(350, 152);
            this.tboxAncho.Name = "tboxAncho";
            this.tboxAncho.PasswordChar = '\0';
            this.tboxAncho.PlaceholderText = "";
            this.tboxAncho.SelectedText = "";
            this.tboxAncho.Size = new System.Drawing.Size(267, 36);
            this.tboxAncho.TabIndex = 3;
            // 
            // tboxPeso
            // 
            this.tboxPeso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.tboxPeso.BorderRadius = 5;
            this.tboxPeso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxPeso.DefaultText = "";
            this.tboxPeso.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tboxPeso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tboxPeso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxPeso.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxPeso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tboxPeso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxPeso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxPeso.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxPeso.Location = new System.Drawing.Point(350, 221);
            this.tboxPeso.Name = "tboxPeso";
            this.tboxPeso.PasswordChar = '\0';
            this.tboxPeso.PlaceholderText = "";
            this.tboxPeso.SelectedText = "";
            this.tboxPeso.Size = new System.Drawing.Size(267, 36);
            this.tboxPeso.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(346, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Alto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(346, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ancho";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(346, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Peso";
            // 
            // tboxStock
            // 
            this.tboxStock.BackColor = System.Drawing.Color.Transparent;
            this.tboxStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.tboxStock.BorderRadius = 5;
            this.tboxStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxStock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tboxStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxStock.Location = new System.Drawing.Point(34, 152);
            this.tboxStock.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.tboxStock.Name = "tboxStock";
            this.tboxStock.Size = new System.Drawing.Size(267, 36);
            this.tboxStock.TabIndex = 5;
            this.tboxStock.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            // 
            // tboxPrecio
            // 
            this.tboxPrecio.BackColor = System.Drawing.Color.Transparent;
            this.tboxPrecio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.tboxPrecio.BorderRadius = 5;
            this.tboxPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxPrecio.DecimalPlaces = 2;
            this.tboxPrecio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tboxPrecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxPrecio.Location = new System.Drawing.Point(34, 221);
            this.tboxPrecio.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.tboxPrecio.Name = "tboxPrecio";
            this.tboxPrecio.Size = new System.Drawing.Size(267, 36);
            this.tboxPrecio.TabIndex = 6;
            this.tboxPrecio.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            // 
            // txtSKU
            // 
            this.txtSKU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSKU.AutoSize = true;
            this.txtSKU.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSKU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.txtSKU.Location = new System.Drawing.Point(255, 20);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(140, 19);
            this.txtSKU.TabIndex = 7;
            this.txtSKU.Text = "SKU: #00000000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(346, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Categoría";
            // 
            // btnSeleccionarImagen
            // 
            this.btnSeleccionarImagen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.btnSeleccionarImagen.BorderRadius = 10;
            this.btnSeleccionarImagen.BorderThickness = 1;
            this.btnSeleccionarImagen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeleccionarImagen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeleccionarImagen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeleccionarImagen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeleccionarImagen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btnSeleccionarImagen.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnSeleccionarImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarImagen.Image")));
            this.btnSeleccionarImagen.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSeleccionarImagen.Location = new System.Drawing.Point(350, 343);
            this.btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            this.btnSeleccionarImagen.Size = new System.Drawing.Size(267, 36);
            this.btnSeleccionarImagen.TabIndex = 0;
            this.btnSeleccionarImagen.Text = "Adjuntar imagen...";
            this.btnSeleccionarImagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSeleccionarImagen.Click += new System.EventHandler(this.btnSeleccionarImagen_Click);
            // 
            // EditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 522);
            this.Controls.Add(this.txtSKU);
            this.Controls.Add(this.tboxPrecio);
            this.Controls.Add(this.tboxStock);
            this.Controls.Add(this.cboxCategoria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.formTotal_txt);
            this.Controls.Add(this.tboxDescripcion);
            this.Controls.Add(this.tboxPeso);
            this.Controls.Add(this.tboxAncho);
            this.Controls.Add(this.tboxAlto);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionarImagen);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditarProducto";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EditarProducto_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.tboxStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tboxPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAceptar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2TextBox tboxNombre;
        private System.Windows.Forms.Label formTotal_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tboxDescripcion;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cboxCategoria;
        private Guna.UI2.WinForms.Guna2Button btnSeleccionarImagen;
        private Guna.UI2.WinForms.Guna2TextBox tboxAlto;
        private Guna.UI2.WinForms.Guna2TextBox tboxAncho;
        private Guna.UI2.WinForms.Guna2TextBox tboxPeso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2NumericUpDown tboxStock;
        private Guna.UI2.WinForms.Guna2NumericUpDown tboxPrecio;
        private System.Windows.Forms.Label txtSKU;
        private System.Windows.Forms.Label label7;
    }
}