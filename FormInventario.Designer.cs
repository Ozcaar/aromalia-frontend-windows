namespace Aromalia
{
    partial class FormInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tituloInventario_txt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_eliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_editar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_agregar = new Guna.UI2.WinForms.Guna2Button();
            this.tbox_precio = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.tbox_stock = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.formDescripcion_txt = new System.Windows.Forms.Label();
            this.formPrecio_txt = new System.Windows.Forms.Label();
            this.formStock_txt = new System.Windows.Forms.Label();
            this.formSKU_txt = new System.Windows.Forms.Label();
            this.formNombre_txt = new System.Windows.Forms.Label();
            this.tbox_descripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbox_nombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_sin_stock = new Guna.UI2.WinForms.Guna2Button();
            this.btn_todo = new Guna.UI2.WinForms.Guna2Button();
            this.inventoryChildForm = new System.Windows.Forms.Panel();
            this.tboxBusqueda = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.inventarioTabla_dgv = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbox_precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbox_stock)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.inventoryChildForm.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioTabla_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloInventario_txt
            // 
            this.tituloInventario_txt.AutoSize = true;
            this.tituloInventario_txt.Font = new System.Drawing.Font("Inter Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloInventario_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.tituloInventario_txt.Location = new System.Drawing.Point(12, 27);
            this.tituloInventario_txt.Name = "tituloInventario_txt";
            this.tituloInventario_txt.Size = new System.Drawing.Size(116, 26);
            this.tituloInventario_txt.TabIndex = 0;
            this.tituloInventario_txt.Text = "Inventario";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_eliminar);
            this.panel2.Controls.Add(this.btn_editar);
            this.panel2.Controls.Add(this.btn_agregar);
            this.panel2.Controls.Add(this.tbox_precio);
            this.panel2.Controls.Add(this.tbox_stock);
            this.panel2.Controls.Add(this.formDescripcion_txt);
            this.panel2.Controls.Add(this.formPrecio_txt);
            this.panel2.Controls.Add(this.formStock_txt);
            this.panel2.Controls.Add(this.formSKU_txt);
            this.panel2.Controls.Add(this.formNombre_txt);
            this.panel2.Controls.Add(this.tbox_descripcion);
            this.panel2.Controls.Add(this.tbox_nombre);
            this.panel2.Controls.Add(this.guna2VSeparator1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(466, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 603);
            this.panel2.TabIndex = 1;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.White;
            this.btn_eliminar.BorderColor = System.Drawing.Color.Red;
            this.btn_eliminar.BorderRadius = 10;
            this.btn_eliminar.BorderThickness = 1;
            this.btn_eliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_eliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_eliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_eliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_eliminar.FillColor = System.Drawing.Color.Transparent;
            this.btn_eliminar.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.Red;
            this.btn_eliminar.Location = new System.Drawing.Point(30, 543);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(233, 40);
            this.btn_eliminar.TabIndex = 5;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.White;
            this.btn_editar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btn_editar.BorderRadius = 10;
            this.btn_editar.BorderThickness = 1;
            this.btn_editar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_editar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_editar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_editar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_editar.FillColor = System.Drawing.Color.Transparent;
            this.btn_editar.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btn_editar.Location = new System.Drawing.Point(30, 483);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(233, 40);
            this.btn_editar.TabIndex = 5;
            this.btn_editar.Text = "Editar";
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.White;
            this.btn_agregar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(177)))), ((int)(((byte)(113)))));
            this.btn_agregar.BorderRadius = 10;
            this.btn_agregar.BorderThickness = 1;
            this.btn_agregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_agregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_agregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_agregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_agregar.FillColor = System.Drawing.Color.Transparent;
            this.btn_agregar.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(177)))), ((int)(((byte)(113)))));
            this.btn_agregar.Location = new System.Drawing.Point(30, 420);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(233, 40);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // tbox_precio
            // 
            this.tbox_precio.BackColor = System.Drawing.Color.Transparent;
            this.tbox_precio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.tbox_precio.BorderRadius = 5;
            this.tbox_precio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_precio.DecimalPlaces = 2;
            this.tbox_precio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbox_precio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbox_precio.Location = new System.Drawing.Point(30, 247);
            this.tbox_precio.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.tbox_precio.Name = "tbox_precio";
            this.tbox_precio.Size = new System.Drawing.Size(233, 30);
            this.tbox_precio.TabIndex = 3;
            this.tbox_precio.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            // 
            // tbox_stock
            // 
            this.tbox_stock.BackColor = System.Drawing.Color.Transparent;
            this.tbox_stock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.tbox_stock.BorderRadius = 5;
            this.tbox_stock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_stock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbox_stock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbox_stock.Location = new System.Drawing.Point(30, 178);
            this.tbox_stock.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.tbox_stock.Name = "tbox_stock";
            this.tbox_stock.Size = new System.Drawing.Size(233, 30);
            this.tbox_stock.TabIndex = 2;
            this.tbox_stock.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            // 
            // formDescripcion_txt
            // 
            this.formDescripcion_txt.AutoSize = true;
            this.formDescripcion_txt.Font = new System.Drawing.Font("Inter", 11F);
            this.formDescripcion_txt.ForeColor = System.Drawing.Color.Gray;
            this.formDescripcion_txt.Location = new System.Drawing.Point(26, 292);
            this.formDescripcion_txt.Name = "formDescripcion_txt";
            this.formDescripcion_txt.Size = new System.Drawing.Size(94, 19);
            this.formDescripcion_txt.TabIndex = 0;
            this.formDescripcion_txt.Text = "Descripción";
            // 
            // formPrecio_txt
            // 
            this.formPrecio_txt.AutoSize = true;
            this.formPrecio_txt.Font = new System.Drawing.Font("Inter", 11F);
            this.formPrecio_txt.ForeColor = System.Drawing.Color.Gray;
            this.formPrecio_txt.Location = new System.Drawing.Point(26, 225);
            this.formPrecio_txt.Name = "formPrecio_txt";
            this.formPrecio_txt.Size = new System.Drawing.Size(55, 19);
            this.formPrecio_txt.TabIndex = 0;
            this.formPrecio_txt.Text = "Precio";
            // 
            // formStock_txt
            // 
            this.formStock_txt.AutoSize = true;
            this.formStock_txt.Font = new System.Drawing.Font("Inter", 11F);
            this.formStock_txt.ForeColor = System.Drawing.Color.Gray;
            this.formStock_txt.Location = new System.Drawing.Point(26, 156);
            this.formStock_txt.Name = "formStock_txt";
            this.formStock_txt.Size = new System.Drawing.Size(49, 19);
            this.formStock_txt.TabIndex = 0;
            this.formStock_txt.Text = "Stock";
            // 
            // formSKU_txt
            // 
            this.formSKU_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formSKU_txt.AutoSize = true;
            this.formSKU_txt.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formSKU_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.formSKU_txt.Location = new System.Drawing.Point(72, 27);
            this.formSKU_txt.Name = "formSKU_txt";
            this.formSKU_txt.Size = new System.Drawing.Size(140, 19);
            this.formSKU_txt.TabIndex = 4;
            this.formSKU_txt.Text = "SKU: #00000000";
            // 
            // formNombre_txt
            // 
            this.formNombre_txt.AutoSize = true;
            this.formNombre_txt.Font = new System.Drawing.Font("Inter", 11F);
            this.formNombre_txt.ForeColor = System.Drawing.Color.Gray;
            this.formNombre_txt.Location = new System.Drawing.Point(26, 91);
            this.formNombre_txt.Name = "formNombre_txt";
            this.formNombre_txt.Size = new System.Drawing.Size(66, 19);
            this.formNombre_txt.TabIndex = 0;
            this.formNombre_txt.Text = "Nombre";
            // 
            // tbox_descripcion
            // 
            this.tbox_descripcion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.tbox_descripcion.BorderRadius = 5;
            this.tbox_descripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_descripcion.DefaultText = "";
            this.tbox_descripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbox_descripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbox_descripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_descripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_descripcion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbox_descripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_descripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbox_descripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_descripcion.Location = new System.Drawing.Point(30, 314);
            this.tbox_descripcion.Multiline = true;
            this.tbox_descripcion.Name = "tbox_descripcion";
            this.tbox_descripcion.PasswordChar = '\0';
            this.tbox_descripcion.PlaceholderText = "";
            this.tbox_descripcion.SelectedText = "";
            this.tbox_descripcion.Size = new System.Drawing.Size(233, 87);
            this.tbox_descripcion.TabIndex = 4;
            // 
            // tbox_nombre
            // 
            this.tbox_nombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.tbox_nombre.BorderRadius = 5;
            this.tbox_nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_nombre.DefaultText = "";
            this.tbox_nombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbox_nombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbox_nombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_nombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_nombre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbox_nombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_nombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbox_nombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_nombre.Location = new System.Drawing.Point(30, 113);
            this.tbox_nombre.Name = "tbox_nombre";
            this.tbox_nombre.PasswordChar = '\0';
            this.tbox_nombre.PlaceholderText = "";
            this.tbox_nombre.SelectedText = "";
            this.tbox_nombre.Size = new System.Drawing.Size(233, 30);
            this.tbox_nombre.TabIndex = 1;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.guna2VSeparator1.FillThickness = 2;
            this.guna2VSeparator1.Location = new System.Drawing.Point(0, 85);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 507);
            this.guna2VSeparator1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tituloInventario_txt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 67);
            this.panel1.TabIndex = 0;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(21, 63);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(425, 10);
            this.guna2Separator1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_sin_stock);
            this.panel3.Controls.Add(this.btn_todo);
            this.panel3.Controls.Add(this.guna2Separator1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(466, 73);
            this.panel3.TabIndex = 3;
            // 
            // btn_sin_stock
            // 
            this.btn_sin_stock.BackColor = System.Drawing.Color.Transparent;
            this.btn_sin_stock.BorderColor = System.Drawing.Color.Gray;
            this.btn_sin_stock.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_sin_stock.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.btn_sin_stock.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btn_sin_stock.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_sin_stock.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.btn_sin_stock.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btn_sin_stock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sin_stock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sin_stock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sin_stock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sin_stock.FillColor = System.Drawing.Color.Transparent;
            this.btn_sin_stock.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sin_stock.ForeColor = System.Drawing.Color.Black;
            this.btn_sin_stock.Location = new System.Drawing.Point(106, 24);
            this.btn_sin_stock.Name = "btn_sin_stock";
            this.btn_sin_stock.PressedColor = System.Drawing.Color.Transparent;
            this.btn_sin_stock.Size = new System.Drawing.Size(104, 45);
            this.btn_sin_stock.TabIndex = 0;
            this.btn_sin_stock.Text = "Sin Stock";
            this.btn_sin_stock.Click += new System.EventHandler(this.btn_sin_stock_Click);
            // 
            // btn_todo
            // 
            this.btn_todo.BackColor = System.Drawing.Color.Transparent;
            this.btn_todo.BorderColor = System.Drawing.Color.Gray;
            this.btn_todo.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_todo.Checked = true;
            this.btn_todo.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.btn_todo.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.btn_todo.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_todo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.btn_todo.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btn_todo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_todo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_todo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_todo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_todo.FillColor = System.Drawing.Color.Transparent;
            this.btn_todo.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_todo.ForeColor = System.Drawing.Color.Black;
            this.btn_todo.Location = new System.Drawing.Point(21, 24);
            this.btn_todo.Name = "btn_todo";
            this.btn_todo.PressedColor = System.Drawing.Color.Transparent;
            this.btn_todo.Size = new System.Drawing.Size(79, 45);
            this.btn_todo.TabIndex = 0;
            this.btn_todo.Text = "Todo";
            this.btn_todo.Click += new System.EventHandler(this.btn_todo_Click);
            // 
            // inventoryChildForm
            // 
            this.inventoryChildForm.BackColor = System.Drawing.Color.White;
            this.inventoryChildForm.Controls.Add(this.tboxBusqueda);
            this.inventoryChildForm.Controls.Add(this.panel4);
            this.inventoryChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryChildForm.Location = new System.Drawing.Point(0, 140);
            this.inventoryChildForm.Margin = new System.Windows.Forms.Padding(0);
            this.inventoryChildForm.Name = "inventoryChildForm";
            this.inventoryChildForm.Size = new System.Drawing.Size(466, 463);
            this.inventoryChildForm.TabIndex = 4;
            // 
            // tboxBusqueda
            // 
            this.tboxBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxBusqueda.BorderThickness = 0;
            this.tboxBusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxBusqueda.DefaultText = "";
            this.tboxBusqueda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tboxBusqueda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tboxBusqueda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxBusqueda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxBusqueda.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tboxBusqueda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxBusqueda.Font = new System.Drawing.Font("Inter Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxBusqueda.ForeColor = System.Drawing.Color.Black;
            this.tboxBusqueda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxBusqueda.IconLeft = global::Aromalia.Properties.Resources.buscar_img;
            this.tboxBusqueda.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.tboxBusqueda.IconLeftSize = new System.Drawing.Size(17, 20);
            this.tboxBusqueda.Location = new System.Drawing.Point(21, 16);
            this.tboxBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.tboxBusqueda.Name = "tboxBusqueda";
            this.tboxBusqueda.PasswordChar = '\0';
            this.tboxBusqueda.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.tboxBusqueda.PlaceholderText = "Buscar por nombre...";
            this.tboxBusqueda.SelectedText = "";
            this.tboxBusqueda.Size = new System.Drawing.Size(429, 29);
            this.tboxBusqueda.TabIndex = 3;
            this.tboxBusqueda.TextOffset = new System.Drawing.Point(10, 0);
            this.tboxBusqueda.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.inventarioTabla_dgv);
            this.panel4.Location = new System.Drawing.Point(21, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(425, 398);
            this.panel4.TabIndex = 2;
            // 
            // inventarioTabla_dgv
            // 
            this.inventarioTabla_dgv.AllowUserToAddRows = false;
            this.inventarioTabla_dgv.AllowUserToDeleteRows = false;
            this.inventarioTabla_dgv.AllowUserToResizeColumns = false;
            this.inventarioTabla_dgv.AllowUserToResizeRows = false;
            this.inventarioTabla_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.inventarioTabla_dgv.BackgroundColor = System.Drawing.Color.White;
            this.inventarioTabla_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inventarioTabla_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.inventarioTabla_dgv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.inventarioTabla_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.inventarioTabla_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.inventarioTabla_dgv.ColumnHeadersHeight = 70;
            this.inventarioTabla_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inventarioTabla_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.inventarioTabla_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventarioTabla_dgv.EnableHeadersVisualStyles = false;
            this.inventarioTabla_dgv.GridColor = System.Drawing.Color.White;
            this.inventarioTabla_dgv.Location = new System.Drawing.Point(0, 0);
            this.inventarioTabla_dgv.MultiSelect = false;
            this.inventarioTabla_dgv.Name = "inventarioTabla_dgv";
            this.inventarioTabla_dgv.ReadOnly = true;
            this.inventarioTabla_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventarioTabla_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.inventarioTabla_dgv.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inventarioTabla_dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.inventarioTabla_dgv.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.inventarioTabla_dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventarioTabla_dgv.RowTemplate.DividerHeight = 10;
            this.inventarioTabla_dgv.RowTemplate.Height = 40;
            this.inventarioTabla_dgv.RowTemplate.ReadOnly = true;
            this.inventarioTabla_dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.inventarioTabla_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventarioTabla_dgv.Size = new System.Drawing.Size(425, 398);
            this.inventarioTabla_dgv.TabIndex = 1;
            this.inventarioTabla_dgv.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.inventarioTabla_dgv_RowStateChanged);
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(759, 603);
            this.Controls.Add(this.inventoryChildForm);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(759, 0);
            this.Name = "FormInventario";
            this.Text = "FormInventory";
            this.Load += new System.EventHandler(this.FormInventory_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbox_precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbox_stock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.inventoryChildForm.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioTabla_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label tituloInventario_txt;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btn_todo;
        private System.Windows.Forms.Panel inventoryChildForm;
        private Guna.UI2.WinForms.Guna2TextBox tbox_nombre;
        private System.Windows.Forms.Label formNombre_txt;
        private System.Windows.Forms.Label formDescripcion_txt;
        private System.Windows.Forms.Label formPrecio_txt;
        private System.Windows.Forms.Label formStock_txt;
        private Guna.UI2.WinForms.Guna2TextBox tbox_descripcion;
        private System.Windows.Forms.Label formSKU_txt;
        private System.Windows.Forms.DataGridView inventarioTabla_dgv;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2NumericUpDown tbox_stock;
        private Guna.UI2.WinForms.Guna2NumericUpDown tbox_precio;
        private Guna.UI2.WinForms.Guna2Button btn_agregar;
        private Guna.UI2.WinForms.Guna2Button btn_sin_stock;
        private Guna.UI2.WinForms.Guna2Button btn_eliminar;
        private Guna.UI2.WinForms.Guna2Button btn_editar;
        private Guna.UI2.WinForms.Guna2TextBox tboxBusqueda;
    }
}