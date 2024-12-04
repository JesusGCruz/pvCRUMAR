namespace LoginCRUMAR
{
    partial class FrmRegistrarVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.MaskedTextBox();
            this.txtPagaCon = new System.Windows.Forms.MaskedTextBox();
            this.txtTotal = new System.Windows.Forms.MaskedTextBox();
            this.txtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.txtCambio = new System.Windows.Forms.MaskedTextBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.codigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnRegistrarVenta = new FontAwesome.Sharp.IconButton();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelPagaC = new System.Windows.Forms.Label();
            this.labelCambio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminarProducto = new FontAwesome.Sharp.IconButton();
            this.labelMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodigo.Location = new System.Drawing.Point(74, 94);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(246, 30);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "Codigo";
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.Enter += new System.EventHandler(this.txtCodigo_Enter);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.ForeColor = System.Drawing.Color.DimGray;
            this.txtProducto.Location = new System.Drawing.Point(74, 236);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(236, 30);
            this.txtProducto.TabIndex = 1;
            this.txtProducto.Text = "Nombre";
            this.txtProducto.Enter += new System.EventHandler(this.txtProducto_Enter);
            this.txtProducto.Leave += new System.EventHandler(this.txtProducto_Leave);
            // 
            // txtPagaCon
            // 
            this.txtPagaCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtPagaCon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPagaCon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagaCon.ForeColor = System.Drawing.Color.DimGray;
            this.txtPagaCon.Location = new System.Drawing.Point(779, 201);
            this.txtPagaCon.Name = "txtPagaCon";
            this.txtPagaCon.Size = new System.Drawing.Size(184, 30);
            this.txtPagaCon.TabIndex = 2;
            this.txtPagaCon.Text = "Paga con";
            this.txtPagaCon.Enter += new System.EventHandler(this.txtPagaCon_Enter);
            this.txtPagaCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagaCon_KeyPress);
            this.txtPagaCon.Leave += new System.EventHandler(this.txtPagaCon_Leave);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.DimGray;
            this.txtTotal.Location = new System.Drawing.Point(779, 68);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(214, 30);
            this.txtTotal.TabIndex = 3;
            this.txtTotal.Text = "Total";
            this.txtTotal.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTotal_MaskInputRejected);
            this.txtTotal.Enter += new System.EventHandler(this.txtTotal_Enter);
            this.txtTotal.Leave += new System.EventHandler(this.txtTotal_Leave);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrecio.Location = new System.Drawing.Point(433, 85);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(224, 30);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.Text = "Precio";
            this.txtPrecio.Enter += new System.EventHandler(this.txtPrecio_Enter);
            this.txtPrecio.Leave += new System.EventHandler(this.txtPrecio_Leave);
            // 
            // txtCambio
            // 
            this.txtCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtCambio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCambio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.ForeColor = System.Drawing.Color.DimGray;
            this.txtCambio.Location = new System.Drawing.Point(779, 311);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(204, 30);
            this.txtCambio.TabIndex = 6;
            this.txtCambio.Text = "Cambio";
            this.txtCambio.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCambio_MaskInputRejected);
            this.txtCambio.Enter += new System.EventHandler(this.txtCambio_Enter);
            this.txtCambio.Leave += new System.EventHandler(this.txtCambio_Leave);
            // 
            // nudCantidad
            // 
            this.nudCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.nudCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudCantidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.ForeColor = System.Drawing.Color.LightGray;
            this.nudCantidad.Location = new System.Drawing.Point(428, 233);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(229, 33);
            this.nudCantidad.TabIndex = 7;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDetalles.ColumnHeadersHeight = 34;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoBarras,
            this.nombre,
            this.cantidad,
            this.precioVenta,
            this.subtotal});
            this.dgvDetalles.EnableHeadersVisualStyles = false;
            this.dgvDetalles.GridColor = System.Drawing.Color.Gray;
            this.dgvDetalles.Location = new System.Drawing.Point(62, 406);
            this.dgvDetalles.Name = "dgvDetalles";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalles.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDetalles.RowHeadersVisible = false;
            this.dgvDetalles.RowHeadersWidth = 62;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetalles.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDetalles.RowTemplate.Height = 28;
            this.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalles.Size = new System.Drawing.Size(911, 425);
            this.dgvDetalles.TabIndex = 8;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // codigoBarras
            // 
            this.codigoBarras.HeaderText = "Codigo";
            this.codigoBarras.MinimumWidth = 8;
            this.codigoBarras.Name = "codigoBarras";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Producto";
            this.nombre.MinimumWidth = 8;
            this.nombre.Name = "nombre";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 8;
            this.cantidad.Name = "cantidad";
            // 
            // precioVenta
            // 
            this.precioVenta.HeaderText = "Precio";
            this.precioVenta.MinimumWidth = 8;
            this.precioVenta.Name = "precioVenta";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.MinimumWidth = 8;
            this.subtotal.Name = "subtotal";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBuscarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProducto.IconColor = System.Drawing.Color.White;
            this.btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProducto.Location = new System.Drawing.Point(74, 321);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(223, 55);
            this.btnBuscarProducto.TabIndex = 9;
            this.btnBuscarProducto.Text = "Buscar Producto";
            this.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(1051, 176);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(145, 54);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRegistrarVenta.FlatAppearance.BorderSize = 0;
            this.btnRegistrarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRegistrarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnRegistrarVenta.IconColor = System.Drawing.Color.White;
            this.btnRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(1023, 676);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(216, 55);
            this.btnRegistrarVenta.TabIndex = 11;
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarVenta.UseVisualStyleBackColor = false;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.labelCodigo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.ForeColor = System.Drawing.Color.White;
            this.labelCodigo.Location = new System.Drawing.Point(70, 60);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(82, 23);
            this.labelCodigo.TabIndex = 12;
            this.labelCodigo.Text = "Codigo";
            this.labelCodigo.Visible = false;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.labelNombre.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(70, 198);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(90, 23);
            this.labelNombre.TabIndex = 13;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.Visible = false;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.labelPrecio.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.Color.White;
            this.labelPrecio.Location = new System.Drawing.Point(429, 51);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(70, 23);
            this.labelPrecio.TabIndex = 14;
            this.labelPrecio.Text = "Precio";
            this.labelPrecio.Visible = false;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.labelTotal.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.White;
            this.labelTotal.Location = new System.Drawing.Point(775, 30);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(57, 23);
            this.labelTotal.TabIndex = 15;
            this.labelTotal.Text = "Total";
            this.labelTotal.Visible = false;
            // 
            // labelPagaC
            // 
            this.labelPagaC.AutoSize = true;
            this.labelPagaC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.labelPagaC.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPagaC.ForeColor = System.Drawing.Color.White;
            this.labelPagaC.Location = new System.Drawing.Point(775, 163);
            this.labelPagaC.Name = "labelPagaC";
            this.labelPagaC.Size = new System.Drawing.Size(107, 23);
            this.labelPagaC.TabIndex = 16;
            this.labelPagaC.Text = "Paga con";
            this.labelPagaC.Visible = false;
            // 
            // labelCambio
            // 
            this.labelCambio.AutoSize = true;
            this.labelCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.labelCambio.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambio.ForeColor = System.Drawing.Color.White;
            this.labelCambio.Location = new System.Drawing.Point(775, 275);
            this.labelCambio.Name = "labelCambio";
            this.labelCambio.Size = new System.Drawing.Size(89, 23);
            this.labelCambio.TabIndex = 17;
            this.labelCambio.Text = "Cambio";
            this.labelCambio.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, -17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cantidad";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.labelMensaje);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnEliminarProducto);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.nudCantidad);
            this.panel1.Controls.Add(this.btnRegistrarVenta);
            this.panel1.Controls.Add(this.labelCambio);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnBuscarProducto);
            this.panel1.Controls.Add(this.labelCodigo);
            this.panel1.Controls.Add(this.labelPagaC);
            this.panel1.Controls.Add(this.dgvDetalles);
            this.panel1.Controls.Add(this.labelPrecio);
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.labelNombre);
            this.panel1.Controls.Add(this.txtProducto);
            this.panel1.Controls.Add(this.txtPagaCon);
            this.panel1.Controls.Add(this.txtCambio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 894);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Location = new System.Drawing.Point(428, 271);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(230, 3);
            this.pictureBox7.TabIndex = 28;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(74, 272);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(236, 3);
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(779, 237);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(184, 3);
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(779, 104);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(214, 3);
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(779, 349);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(204, 3);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(433, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(224, 3);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(72, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 3);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(424, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Cantidad de Producto";
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProducto.FlatAppearance.BorderSize = 0;
            this.btnEliminarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEliminarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarProducto.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarProducto.IconColor = System.Drawing.Color.White;
            this.btnEliminarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProducto.Location = new System.Drawing.Point(1023, 484);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(211, 63);
            this.btnEliminarProducto.TabIndex = 20;
            this.btnEliminarProducto.Text = "Quitar Producto";
            this.btnEliminarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensaje.ForeColor = System.Drawing.Color.DimGray;
            this.labelMensaje.Location = new System.Drawing.Point(158, 62);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(0, 21);
            this.labelMensaje.TabIndex = 29;
            this.labelMensaje.Visible = false;
            // 
            // FrmRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1261, 894);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistrarVenta";
            this.Load += new System.EventHandler(this.FrmRegistrarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.MaskedTextBox txtProducto;
        private System.Windows.Forms.MaskedTextBox txtPagaCon;
        private System.Windows.Forms.MaskedTextBox txtTotal;
        private System.Windows.Forms.MaskedTextBox txtPrecio;
        private System.Windows.Forms.MaskedTextBox txtCambio;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnRegistrarVenta;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelPagaC;
        private System.Windows.Forms.Label labelCambio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnEliminarProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Label labelMensaje;
    }
}