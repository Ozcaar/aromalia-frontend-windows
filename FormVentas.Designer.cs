namespace Aromalia
{
    partial class FormVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.inventoryChildForm = new System.Windows.Forms.Panel();
            this.tboxBusqueda = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ventasTabla_dgv = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_todo = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tituloVentas_txt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbox_metodo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dpick_fecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_verPedido = new Guna.UI2.WinForms.Guna2Button();
            this.formNoPedido_txt = new System.Windows.Forms.Label();
            this.formMetodo_txt = new System.Windows.Forms.Label();
            this.formFecha_txt = new System.Windows.Forms.Label();
            this.formFactura_txt = new System.Windows.Forms.Label();
            this.formTotal_txt = new System.Windows.Forms.Label();
            this.tbox_factura = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbox_total = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.inventoryChildForm.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventasTabla_dgv)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.inventoryChildForm.TabIndex = 8;
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
            this.tboxBusqueda.PlaceholderText = "Buscar por No. Factura...";
            this.tboxBusqueda.SelectedText = "";
            this.tboxBusqueda.Size = new System.Drawing.Size(429, 29);
            this.tboxBusqueda.TabIndex = 3;
            this.tboxBusqueda.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.ventasTabla_dgv);
            this.panel4.Location = new System.Drawing.Point(21, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(425, 398);
            this.panel4.TabIndex = 2;
            // 
            // ventasTabla_dgv
            // 
            this.ventasTabla_dgv.AllowUserToAddRows = false;
            this.ventasTabla_dgv.AllowUserToDeleteRows = false;
            this.ventasTabla_dgv.AllowUserToResizeColumns = false;
            this.ventasTabla_dgv.AllowUserToResizeRows = false;
            this.ventasTabla_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ventasTabla_dgv.BackgroundColor = System.Drawing.Color.White;
            this.ventasTabla_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ventasTabla_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ventasTabla_dgv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.ventasTabla_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ventasTabla_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ventasTabla_dgv.ColumnHeadersHeight = 70;
            this.ventasTabla_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ventasTabla_dgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.ventasTabla_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ventasTabla_dgv.EnableHeadersVisualStyles = false;
            this.ventasTabla_dgv.GridColor = System.Drawing.Color.White;
            this.ventasTabla_dgv.Location = new System.Drawing.Point(0, 0);
            this.ventasTabla_dgv.MultiSelect = false;
            this.ventasTabla_dgv.Name = "ventasTabla_dgv";
            this.ventasTabla_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ventasTabla_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ventasTabla_dgv.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ventasTabla_dgv.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.ventasTabla_dgv.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ventasTabla_dgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventasTabla_dgv.RowTemplate.DividerHeight = 10;
            this.ventasTabla_dgv.RowTemplate.Height = 40;
            this.ventasTabla_dgv.RowTemplate.ReadOnly = true;
            this.ventasTabla_dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ventasTabla_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ventasTabla_dgv.Size = new System.Drawing.Size(425, 398);
            this.ventasTabla_dgv.TabIndex = 1;
            this.ventasTabla_dgv.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.ventasTabla_dgv_RowStateChanged);
            this.ventasTabla_dgv.SelectionChanged += new System.EventHandler(this.ventasTabla_dgv_SelectionChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_todo);
            this.panel3.Controls.Add(this.guna2Separator1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(466, 73);
            this.panel3.TabIndex = 7;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tituloVentas_txt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 67);
            this.panel1.TabIndex = 5;
            // 
            // tituloVentas_txt
            // 
            this.tituloVentas_txt.AutoSize = true;
            this.tituloVentas_txt.Font = new System.Drawing.Font("Inter Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloVentas_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.tituloVentas_txt.Location = new System.Drawing.Point(12, 27);
            this.tituloVentas_txt.Name = "tituloVentas_txt";
            this.tituloVentas_txt.Size = new System.Drawing.Size(85, 26);
            this.tituloVentas_txt.TabIndex = 0;
            this.tituloVentas_txt.Text = "Ventas";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbox_metodo);
            this.panel2.Controls.Add(this.dpick_fecha);
            this.panel2.Controls.Add(this.btn_verPedido);
            this.panel2.Controls.Add(this.formNoPedido_txt);
            this.panel2.Controls.Add(this.formMetodo_txt);
            this.panel2.Controls.Add(this.formFecha_txt);
            this.panel2.Controls.Add(this.formFactura_txt);
            this.panel2.Controls.Add(this.formTotal_txt);
            this.panel2.Controls.Add(this.tbox_factura);
            this.panel2.Controls.Add(this.tbox_total);
            this.panel2.Controls.Add(this.guna2VSeparator1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(466, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 603);
            this.panel2.TabIndex = 6;
            // 
            // cbox_metodo
            // 
            this.cbox_metodo.BackColor = System.Drawing.Color.Transparent;
            this.cbox_metodo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.cbox_metodo.BorderRadius = 5;
            this.cbox_metodo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cbox_metodo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.cbox_metodo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cbox_metodo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbox_metodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_metodo.Enabled = false;
            this.cbox_metodo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.cbox_metodo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbox_metodo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbox_metodo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbox_metodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbox_metodo.ItemHeight = 30;
            this.cbox_metodo.Location = new System.Drawing.Point(30, 263);
            this.cbox_metodo.Name = "cbox_metodo";
            this.cbox_metodo.Size = new System.Drawing.Size(233, 36);
            this.cbox_metodo.TabIndex = 7;
            // 
            // dpick_fecha
            // 
            this.dpick_fecha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.dpick_fecha.BorderRadius = 5;
            this.dpick_fecha.BorderThickness = 1;
            this.dpick_fecha.Checked = true;
            this.dpick_fecha.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dpick_fecha.Enabled = false;
            this.dpick_fecha.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.dpick_fecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dpick_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpick_fecha.Location = new System.Drawing.Point(30, 188);
            this.dpick_fecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpick_fecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpick_fecha.Name = "dpick_fecha";
            this.dpick_fecha.Size = new System.Drawing.Size(233, 36);
            this.dpick_fecha.TabIndex = 6;
            this.dpick_fecha.Value = new System.DateTime(2024, 4, 19, 1, 38, 21, 269);
            // 
            // btn_verPedido
            // 
            this.btn_verPedido.BackColor = System.Drawing.Color.White;
            this.btn_verPedido.BorderColor = System.Drawing.Color.Empty;
            this.btn_verPedido.BorderRadius = 10;
            this.btn_verPedido.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_verPedido.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_verPedido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_verPedido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_verPedido.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btn_verPedido.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verPedido.ForeColor = System.Drawing.Color.White;
            this.btn_verPedido.Location = new System.Drawing.Point(30, 411);
            this.btn_verPedido.Name = "btn_verPedido";
            this.btn_verPedido.Size = new System.Drawing.Size(233, 50);
            this.btn_verPedido.TabIndex = 5;
            this.btn_verPedido.Text = "Ver pedido";
            // 
            // formNoPedido_txt
            // 
            this.formNoPedido_txt.AutoSize = true;
            this.formNoPedido_txt.Font = new System.Drawing.Font("Inter", 11F);
            this.formNoPedido_txt.ForeColor = System.Drawing.Color.Gray;
            this.formNoPedido_txt.Location = new System.Drawing.Point(26, 315);
            this.formNoPedido_txt.Name = "formNoPedido_txt";
            this.formNoPedido_txt.Size = new System.Drawing.Size(108, 19);
            this.formNoPedido_txt.TabIndex = 0;
            this.formNoPedido_txt.Text = "No. de pedido";
            // 
            // formMetodo_txt
            // 
            this.formMetodo_txt.AutoSize = true;
            this.formMetodo_txt.Font = new System.Drawing.Font("Inter", 11F);
            this.formMetodo_txt.ForeColor = System.Drawing.Color.Gray;
            this.formMetodo_txt.Location = new System.Drawing.Point(26, 241);
            this.formMetodo_txt.Name = "formMetodo_txt";
            this.formMetodo_txt.Size = new System.Drawing.Size(124, 19);
            this.formMetodo_txt.TabIndex = 0;
            this.formMetodo_txt.Text = "Método de pago";
            // 
            // formFecha_txt
            // 
            this.formFecha_txt.AutoSize = true;
            this.formFecha_txt.Font = new System.Drawing.Font("Inter", 11F);
            this.formFecha_txt.ForeColor = System.Drawing.Color.Gray;
            this.formFecha_txt.Location = new System.Drawing.Point(26, 166);
            this.formFecha_txt.Name = "formFecha_txt";
            this.formFecha_txt.Size = new System.Drawing.Size(51, 19);
            this.formFecha_txt.TabIndex = 0;
            this.formFecha_txt.Text = "Fecha";
            // 
            // formFactura_txt
            // 
            this.formFactura_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formFactura_txt.AutoSize = true;
            this.formFactura_txt.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formFactura_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.formFactura_txt.Location = new System.Drawing.Point(57, 27);
            this.formFactura_txt.Name = "formFactura_txt";
            this.formFactura_txt.Size = new System.Drawing.Size(165, 19);
            this.formFactura_txt.TabIndex = 4;
            this.formFactura_txt.Text = "Factura: #00000000";
            // 
            // formTotal_txt
            // 
            this.formTotal_txt.AutoSize = true;
            this.formTotal_txt.Font = new System.Drawing.Font("Inter", 11F);
            this.formTotal_txt.ForeColor = System.Drawing.Color.Gray;
            this.formTotal_txt.Location = new System.Drawing.Point(26, 91);
            this.formTotal_txt.Name = "formTotal_txt";
            this.formTotal_txt.Size = new System.Drawing.Size(44, 19);
            this.formTotal_txt.TabIndex = 0;
            this.formTotal_txt.Text = "Total";
            // 
            // tbox_factura
            // 
            this.tbox_factura.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.tbox_factura.BorderRadius = 5;
            this.tbox_factura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_factura.DefaultText = "";
            this.tbox_factura.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbox_factura.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.tbox_factura.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.tbox_factura.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_factura.Enabled = false;
            this.tbox_factura.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbox_factura.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_factura.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbox_factura.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_factura.Location = new System.Drawing.Point(30, 337);
            this.tbox_factura.Name = "tbox_factura";
            this.tbox_factura.PasswordChar = '\0';
            this.tbox_factura.PlaceholderText = "";
            this.tbox_factura.ReadOnly = true;
            this.tbox_factura.SelectedText = "";
            this.tbox_factura.Size = new System.Drawing.Size(233, 36);
            this.tbox_factura.TabIndex = 4;
            // 
            // tbox_total
            // 
            this.tbox_total.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.tbox_total.BorderRadius = 5;
            this.tbox_total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_total.DefaultText = "";
            this.tbox_total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbox_total.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.tbox_total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.tbox_total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbox_total.Enabled = false;
            this.tbox_total.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.tbox_total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_total.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbox_total.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbox_total.Location = new System.Drawing.Point(30, 113);
            this.tbox_total.Name = "tbox_total";
            this.tbox_total.PasswordChar = '\0';
            this.tbox_total.PlaceholderText = "";
            this.tbox_total.ReadOnly = true;
            this.tbox_total.SelectedText = "";
            this.tbox_total.Size = new System.Drawing.Size(233, 36);
            this.tbox_total.TabIndex = 1;
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
            // FormVentas
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
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.inventoryChildForm.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ventasTabla_dgv)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel inventoryChildForm;
        private Guna.UI2.WinForms.Guna2TextBox tboxBusqueda;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView ventasTabla_dgv;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btn_todo;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tituloVentas_txt;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_verPedido;
        private System.Windows.Forms.Label formNoPedido_txt;
        private System.Windows.Forms.Label formMetodo_txt;
        private System.Windows.Forms.Label formFecha_txt;
        private System.Windows.Forms.Label formFactura_txt;
        private System.Windows.Forms.Label formTotal_txt;
        private Guna.UI2.WinForms.Guna2TextBox tbox_factura;
        private Guna.UI2.WinForms.Guna2TextBox tbox_total;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2ComboBox cbox_metodo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpick_fecha;
    }
}