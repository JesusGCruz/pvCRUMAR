namespace LoginCRUMAR
{
    partial class EliminarPedido
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFechap = new System.Windows.Forms.TextBox();
            this.lblnumPe = new System.Windows.Forms.Label();
            this.txtnumPe = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnConsultar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.idProductoprove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigpBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCantP = new System.Windows.Forms.Label();
            this.lblCodB = new System.Windows.Forms.Label();
            this.lblNumPro = new System.Windows.Forms.Label();
            this.btncalendaario = new FontAwesome.Sharp.IconButton();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.txtCantidadP = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtNumpro = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtCodigoB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.txtFechap);
            this.panel1.Controls.Add(this.lblnumPe);
            this.panel1.Controls.Add(this.txtnumPe);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.calendario);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.dgvPedidos);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.lblCantP);
            this.panel1.Controls.Add(this.lblCodB);
            this.panel1.Controls.Add(this.lblNumPro);
            this.panel1.Controls.Add(this.btncalendaario);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.txtCantidadP);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.txtNumpro);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txtCodigoB);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 838);
            this.panel1.TabIndex = 0;
            // 
            // txtFechap
            // 
            this.txtFechap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtFechap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechap.ForeColor = System.Drawing.Color.DimGray;
            this.txtFechap.Location = new System.Drawing.Point(629, 215);
            this.txtFechap.Name = "txtFechap";
            this.txtFechap.Size = new System.Drawing.Size(232, 30);
            this.txtFechap.TabIndex = 87;
            this.txtFechap.Text = "Fecha de Pedido";
            this.txtFechap.Enter += new System.EventHandler(this.txtFechap_Enter);
            this.txtFechap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFechap_KeyPress);
            this.txtFechap.Leave += new System.EventHandler(this.txtFechap_Leave);
            this.txtFechap.MouseEnter += new System.EventHandler(this.txtFechap_MouseEnter);
            // 
            // lblnumPe
            // 
            this.lblnumPe.AutoSize = true;
            this.lblnumPe.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumPe.ForeColor = System.Drawing.Color.White;
            this.lblnumPe.Location = new System.Drawing.Point(54, 85);
            this.lblnumPe.Name = "lblnumPe";
            this.lblnumPe.Size = new System.Drawing.Size(214, 25);
            this.lblnumPe.TabIndex = 86;
            this.lblnumPe.Text = "Número de Pedido";
            this.lblnumPe.Visible = false;
            // 
            // txtnumPe
            // 
            this.txtnumPe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtnumPe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnumPe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumPe.ForeColor = System.Drawing.Color.DimGray;
            this.txtnumPe.Location = new System.Drawing.Point(59, 113);
            this.txtnumPe.Name = "txtnumPe";
            this.txtnumPe.Size = new System.Drawing.Size(238, 30);
            this.txtnumPe.TabIndex = 80;
            this.txtnumPe.Text = "Número de Pedido";
            this.txtnumPe.Enter += new System.EventHandler(this.txtnumPe_Enter);
            this.txtnumPe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumPe_KeyPress);
            this.txtnumPe.Leave += new System.EventHandler(this.txtnumPe_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(59, 149);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(238, 3);
            this.pictureBox3.TabIndex = 84;
            this.pictureBox3.TabStop = false;
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(1104, 171);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 83;
            this.calendario.Visible = false;
            this.calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateSelected);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.White;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 30;
            this.btnLimpiar.Location = new System.Drawing.Point(812, 285);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(188, 54);
            this.btnLimpiar.TabIndex = 82;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.LightGray;
            this.btnConsultar.IconChar = FontAwesome.Sharp.IconChar.C;
            this.btnConsultar.IconColor = System.Drawing.Color.White;
            this.btnConsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultar.IconSize = 30;
            this.btnConsultar.Location = new System.Drawing.Point(551, 390);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(188, 54);
            this.btnConsultar.TabIndex = 81;
            this.btnConsultar.Text = "Consultar Pedidos";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.LightGray;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 30;
            this.btnEliminar.Location = new System.Drawing.Point(293, 285);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(188, 54);
            this.btnEliminar.TabIndex = 85;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidos.ColumnHeadersHeight = 53;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoprove,
            this.codigpBarras,
            this.nombre,
            this.idProveedor,
            this.fecha,
            this.cantidadProducto,
            this.nombrePro});
            this.dgvPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPedidos.EnableHeadersVisualStyles = false;
            this.dgvPedidos.GridColor = System.Drawing.Color.Gray;
            this.dgvPedidos.Location = new System.Drawing.Point(19, 472);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.RowHeadersWidth = 62;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPedidos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedidos.RowTemplate.Height = 28;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(1208, 354);
            this.dgvPedidos.TabIndex = 79;
            this.dgvPedidos.Visible = false;
            this.dgvPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellClick);
            // 
            // idProductoprove
            // 
            this.idProductoprove.HeaderText = "Numero de Pedido";
            this.idProductoprove.MinimumWidth = 8;
            this.idProductoprove.Name = "idProductoprove";
            // 
            // codigpBarras
            // 
            this.codigpBarras.HeaderText = "Codigo de Barras";
            this.codigpBarras.MinimumWidth = 8;
            this.codigpBarras.Name = "codigpBarras";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre del producto";
            this.nombre.MinimumWidth = 8;
            this.nombre.Name = "nombre";
            // 
            // idProveedor
            // 
            this.idProveedor.HeaderText = "Número de Proveedor";
            this.idProveedor.MinimumWidth = 8;
            this.idProveedor.Name = "idProveedor";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha de Pedido";
            this.fecha.MinimumWidth = 8;
            this.fecha.Name = "fecha";
            // 
            // cantidadProducto
            // 
            this.cantidadProducto.HeaderText = "Cantidad de Producto";
            this.cantidadProducto.MinimumWidth = 8;
            this.cantidadProducto.Name = "cantidadProducto";
            // 
            // nombrePro
            // 
            this.nombrePro.HeaderText = "Nombre del Proveedor";
            this.nombrePro.MinimumWidth = 8;
            this.nombrePro.Name = "nombrePro";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(624, 188);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(195, 25);
            this.lblFecha.TabIndex = 78;
            this.lblFecha.Text = "Fecha de Pedido";
            this.lblFecha.Visible = false;
            // 
            // lblCantP
            // 
            this.lblCantP.AutoSize = true;
            this.lblCantP.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantP.ForeColor = System.Drawing.Color.White;
            this.lblCantP.Location = new System.Drawing.Point(251, 188);
            this.lblCantP.Name = "lblCantP";
            this.lblCantP.Size = new System.Drawing.Size(254, 25);
            this.lblCantP.TabIndex = 77;
            this.lblCantP.Text = "Cantidad de Producto";
            this.lblCantP.Visible = false;
            // 
            // lblCodB
            // 
            this.lblCodB.AutoSize = true;
            this.lblCodB.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodB.ForeColor = System.Drawing.Color.White;
            this.lblCodB.Location = new System.Drawing.Point(884, 85);
            this.lblCodB.Name = "lblCodB";
            this.lblCodB.Size = new System.Drawing.Size(199, 25);
            this.lblCodB.TabIndex = 76;
            this.lblCodB.Text = "Codigo de Barras";
            this.lblCodB.Visible = false;
            // 
            // lblNumPro
            // 
            this.lblNumPro.AutoSize = true;
            this.lblNumPro.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPro.ForeColor = System.Drawing.Color.White;
            this.lblNumPro.Location = new System.Drawing.Point(468, 85);
            this.lblNumPro.Name = "lblNumPro";
            this.lblNumPro.Size = new System.Drawing.Size(250, 25);
            this.lblNumPro.TabIndex = 75;
            this.lblNumPro.Text = "Número de Proveedor";
            this.lblNumPro.Visible = false;
            // 
            // btncalendaario
            // 
            this.btncalendaario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btncalendaario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncalendaario.FlatAppearance.BorderSize = 0;
            this.btncalendaario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btncalendaario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btncalendaario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalendaario.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalendaario.ForeColor = System.Drawing.Color.LightGray;
            this.btncalendaario.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.btncalendaario.IconColor = System.Drawing.Color.White;
            this.btncalendaario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncalendaario.IconSize = 30;
            this.btncalendaario.Location = new System.Drawing.Point(867, 199);
            this.btncalendaario.Name = "btncalendaario";
            this.btncalendaario.Size = new System.Drawing.Size(61, 46);
            this.btncalendaario.TabIndex = 74;
            this.btncalendaario.UseVisualStyleBackColor = false;
            this.btncalendaario.Click += new System.EventHandler(this.btncalendaario_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Location = new System.Drawing.Point(618, 251);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(310, 3);
            this.pictureBox8.TabIndex = 71;
            this.pictureBox8.TabStop = false;
            // 
            // txtCantidadP
            // 
            this.txtCantidadP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtCantidadP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidadP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadP.ForeColor = System.Drawing.Color.DimGray;
            this.txtCantidadP.Location = new System.Drawing.Point(256, 216);
            this.txtCantidadP.Name = "txtCantidadP";
            this.txtCantidadP.Size = new System.Drawing.Size(281, 30);
            this.txtCantidadP.TabIndex = 70;
            this.txtCantidadP.Text = "Cantidad de Producto";
            this.txtCantidadP.Enter += new System.EventHandler(this.txtCantidadP_Enter);
            this.txtCantidadP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadP_KeyPress);
            this.txtCantidadP.Leave += new System.EventHandler(this.txtCantidadP_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(256, 252);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(281, 3);
            this.pictureBox4.TabIndex = 69;
            this.pictureBox4.TabStop = false;
            // 
            // txtNumpro
            // 
            this.txtNumpro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtNumpro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumpro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumpro.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumpro.Location = new System.Drawing.Point(473, 113);
            this.txtNumpro.Name = "txtNumpro";
            this.txtNumpro.Size = new System.Drawing.Size(266, 30);
            this.txtNumpro.TabIndex = 68;
            this.txtNumpro.Text = "Número de Proveedor";
            this.txtNumpro.Enter += new System.EventHandler(this.txtNumpro_Enter);
            this.txtNumpro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumpro_KeyPress);
            this.txtNumpro.Leave += new System.EventHandler(this.txtNumpro_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(473, 149);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(266, 3);
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // txtCodigoB
            // 
            this.txtCodigoB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtCodigoB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoB.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodigoB.Location = new System.Drawing.Point(889, 113);
            this.txtCodigoB.Name = "txtCodigoB";
            this.txtCodigoB.Size = new System.Drawing.Size(250, 30);
            this.txtCodigoB.TabIndex = 73;
            this.txtCodigoB.Text = "Codigo de Barras";
            this.txtCodigoB.Enter += new System.EventHandler(this.txtCodigoB_Enter);
            this.txtCodigoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoB_KeyPress);
            this.txtCodigoB.Leave += new System.EventHandler(this.txtCodigoB_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(889, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 3);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(491, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(269, 38);
            this.Titulo.TabIndex = 65;
            this.Titulo.Text = "Eliminar Pedidos";
            // 
            // EliminarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1239, 838);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarPedido";
            this.Opacity = 0.9D;
            this.Text = "EliminarPedido";
            this.Load += new System.EventHandler(this.EliminarPedido_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCantP;
        private System.Windows.Forms.Label lblCodB;
        private System.Windows.Forms.Label lblNumPro;
        private FontAwesome.Sharp.IconButton btncalendaario;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox txtCantidadP;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtNumpro;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtCodigoB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoprove;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigpBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePro;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnConsultar;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Label lblnumPe;
        private System.Windows.Forms.TextBox txtnumPe;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtFechap;
    }
}