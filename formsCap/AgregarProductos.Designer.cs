using System.Drawing;
using System.Windows.Forms;

namespace LoginCRUMAR
{
    partial class AgregarProductos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.btnCosultar = new FontAwesome.Sharp.IconButton();
            this.lblFechaC = new System.Windows.Forms.Label();
            this.lblPrecioV = new System.Windows.Forms.Label();
            this.lblPrecioC = new System.Windows.Forms.Label();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.btncalendaario = new FontAwesome.Sharp.IconButton();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.codigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCaducidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.txtFechaV = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.txtPrecioV = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txtPrecioC = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtCodigoB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.tbProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_CRUMARPDataSet1 = new LoginCRUMAR.CRUMARpvDataSet();
            this.db_CRUMARPDataSet = new LoginCRUMAR.CRUMARpvDataSet();
            this.dbCRUMARPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbProductosTableAdapter = new LoginCRUMAR.CRUMARpvDataSetTableAdapters.tbProductosTableAdapter();
            this.tbProductosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.pPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_CRUMARPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_CRUMARPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRUMARPDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pPrincipal
            // 
            this.pPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pPrincipal.Controls.Add(this.btnCosultar);
            this.pPrincipal.Controls.Add(this.lblFechaC);
            this.pPrincipal.Controls.Add(this.lblPrecioV);
            this.pPrincipal.Controls.Add(this.lblPrecioC);
            this.pPrincipal.Controls.Add(this.lblExistencia);
            this.pPrincipal.Controls.Add(this.lblIva);
            this.pPrincipal.Controls.Add(this.lblMarca);
            this.pPrincipal.Controls.Add(this.lblnombre);
            this.pPrincipal.Controls.Add(this.lblCodigoBarras);
            this.pPrincipal.Controls.Add(this.btncalendaario);
            this.pPrincipal.Controls.Add(this.dgvProductos);
            this.pPrincipal.Controls.Add(this.btnLimpiar);
            this.pPrincipal.Controls.Add(this.btnGuardar);
            this.pPrincipal.Controls.Add(this.txtFechaV);
            this.pPrincipal.Controls.Add(this.pictureBox8);
            this.pPrincipal.Controls.Add(this.txtPrecioV);
            this.pPrincipal.Controls.Add(this.pictureBox7);
            this.pPrincipal.Controls.Add(this.txtPrecioC);
            this.pPrincipal.Controls.Add(this.pictureBox6);
            this.pPrincipal.Controls.Add(this.txtExistencias);
            this.pPrincipal.Controls.Add(this.pictureBox5);
            this.pPrincipal.Controls.Add(this.txtIva);
            this.pPrincipal.Controls.Add(this.pictureBox4);
            this.pPrincipal.Controls.Add(this.txtMarca);
            this.pPrincipal.Controls.Add(this.pictureBox3);
            this.pPrincipal.Controls.Add(this.txtNombre);
            this.pPrincipal.Controls.Add(this.pictureBox2);
            this.pPrincipal.Controls.Add(this.txtCodigoB);
            this.pPrincipal.Controls.Add(this.pictureBox1);
            this.pPrincipal.Controls.Add(this.Titulo);
            this.pPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(1261, 894);
            this.pPrincipal.TabIndex = 0;
            // 
            // btnCosultar
            // 
            this.btnCosultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCosultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCosultar.FlatAppearance.BorderSize = 0;
            this.btnCosultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCosultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCosultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCosultar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCosultar.ForeColor = System.Drawing.Color.LightGray;
            this.btnCosultar.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            this.btnCosultar.IconColor = System.Drawing.Color.White;
            this.btnCosultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCosultar.IconSize = 30;
            this.btnCosultar.Location = new System.Drawing.Point(549, 447);
            this.btnCosultar.Name = "btnCosultar";
            this.btnCosultar.Size = new System.Drawing.Size(216, 54);
            this.btnCosultar.TabIndex = 39;
            this.btnCosultar.Text = "Consultar Productos";
            this.btnCosultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCosultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCosultar.UseVisualStyleBackColor = false;
            this.btnCosultar.Click += new System.EventHandler(this.btnCosultar_Click);
            // 
            // lblFechaC
            // 
            this.lblFechaC.AutoSize = true;
            this.lblFechaC.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaC.ForeColor = System.Drawing.Color.White;
            this.lblFechaC.Location = new System.Drawing.Point(924, 206);
            this.lblFechaC.Name = "lblFechaC";
            this.lblFechaC.Size = new System.Drawing.Size(222, 23);
            this.lblFechaC.TabIndex = 38;
            this.lblFechaC.Text = "Fecha de caducidad";
            this.lblFechaC.Visible = false;
            // 
            // lblPrecioV
            // 
            this.lblPrecioV.AutoSize = true;
            this.lblPrecioV.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioV.ForeColor = System.Drawing.Color.White;
            this.lblPrecioV.Location = new System.Drawing.Point(624, 206);
            this.lblPrecioV.Name = "lblPrecioV";
            this.lblPrecioV.Size = new System.Drawing.Size(170, 23);
            this.lblPrecioV.TabIndex = 37;
            this.lblPrecioV.Text = "Precio de Venta";
            this.lblPrecioV.Visible = false;
            // 
            // lblPrecioC
            // 
            this.lblPrecioC.AutoSize = true;
            this.lblPrecioC.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioC.ForeColor = System.Drawing.Color.White;
            this.lblPrecioC.Location = new System.Drawing.Point(332, 206);
            this.lblPrecioC.Name = "lblPrecioC";
            this.lblPrecioC.Size = new System.Drawing.Size(188, 23);
            this.lblPrecioC.TabIndex = 36;
            this.lblPrecioC.Text = "Preco de Compra";
            this.lblPrecioC.Visible = false;
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistencia.ForeColor = System.Drawing.Color.White;
            this.lblExistencia.Location = new System.Drawing.Point(34, 206);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(112, 23);
            this.lblExistencia.TabIndex = 35;
            this.lblExistencia.Text = "Existencias";
            this.lblExistencia.Visible = false;
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.ForeColor = System.Drawing.Color.White;
            this.lblIva.Location = new System.Drawing.Point(924, 73);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(42, 23);
            this.lblIva.TabIndex = 34;
            this.lblIva.Text = "Iva";
            this.lblIva.Visible = false;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(623, 73);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(74, 23);
            this.lblMarca.TabIndex = 33;
            this.lblMarca.Text = "Marca";
            this.lblMarca.Visible = false;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.Location = new System.Drawing.Point(332, 73);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(90, 23);
            this.lblnombre.TabIndex = 32;
            this.lblnombre.Text = "Nombre";
            this.lblnombre.Visible = false;
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBarras.ForeColor = System.Drawing.Color.White;
            this.lblCodigoBarras.Location = new System.Drawing.Point(33, 73);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(180, 23);
            this.lblCodigoBarras.TabIndex = 30;
            this.lblCodigoBarras.Text = "Codigo de Barras";
            this.lblCodigoBarras.Visible = false;
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
            this.btncalendaario.Location = new System.Drawing.Point(1188, 215);
            this.btncalendaario.Name = "btncalendaario";
            this.btncalendaario.Size = new System.Drawing.Size(61, 46);
            this.btncalendaario.TabIndex = 29;
            this.btncalendaario.UseVisualStyleBackColor = false;
            this.btncalendaario.Click += new System.EventHandler(this.btncalendaario_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvProductos.ColumnHeadersHeight = 53;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoBarras,
            this.nombre,
            this.marca,
            this.iva,
            this.existencia,
            this.precioCompra,
            this.precioVenta,
            this.fechaCaducidad});
            this.dgvProductos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.Color.Gray;
            this.dgvProductos.Location = new System.Drawing.Point(12, 541);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 62;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(1243, 330);
            this.dgvProductos.TabIndex = 21;
            this.dgvProductos.Visible = false;
            // 
            // codigoBarras
            // 
            this.codigoBarras.HeaderText = "Codigo de Barras";
            this.codigoBarras.MinimumWidth = 8;
            this.codigoBarras.Name = "codigoBarras";
            this.codigoBarras.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 8;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.MinimumWidth = 8;
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // iva
            // 
            this.iva.HeaderText = "Iva";
            this.iva.MinimumWidth = 8;
            this.iva.Name = "iva";
            this.iva.ReadOnly = true;
            // 
            // existencia
            // 
            this.existencia.HeaderText = "Existencias";
            this.existencia.MinimumWidth = 8;
            this.existencia.Name = "existencia";
            this.existencia.ReadOnly = true;
            // 
            // precioCompra
            // 
            this.precioCompra.HeaderText = "Precio de Compra";
            this.precioCompra.MinimumWidth = 8;
            this.precioCompra.Name = "precioCompra";
            this.precioCompra.ReadOnly = true;
            // 
            // precioVenta
            // 
            this.precioVenta.HeaderText = "Precio de Venta";
            this.precioVenta.MinimumWidth = 8;
            this.precioVenta.Name = "precioVenta";
            this.precioVenta.ReadOnly = true;
            // 
            // fechaCaducidad
            // 
            this.fechaCaducidad.HeaderText = "Fecha de Caducidad";
            this.fechaCaducidad.MinimumWidth = 8;
            this.fechaCaducidad.Name = "fechaCaducidad";
            this.fechaCaducidad.ReadOnly = true;
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
            this.btnLimpiar.Location = new System.Drawing.Point(661, 309);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(188, 54);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.LightGray;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 30;
            this.btnGuardar.Location = new System.Drawing.Point(379, 309);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(188, 54);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtFechaV
            // 
            this.txtFechaV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtFechaV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaV.ForeColor = System.Drawing.Color.DimGray;
            this.txtFechaV.Location = new System.Drawing.Point(928, 232);
            this.txtFechaV.Name = "txtFechaV";
            this.txtFechaV.Size = new System.Drawing.Size(261, 30);
            this.txtFechaV.TabIndex = 16;
            this.txtFechaV.Text = "Fecha de Caducidad";
            this.txtFechaV.Enter += new System.EventHandler(this.txtFechaV_Enter);
            this.txtFechaV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFechaV_KeyPress);
            this.txtFechaV.Leave += new System.EventHandler(this.txtFechaV_Leave);
            this.txtFechaV.MouseEnter += new System.EventHandler(this.txtFechaV_MouseEnter);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Location = new System.Drawing.Point(928, 267);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(310, 3);
            this.pictureBox8.TabIndex = 15;
            this.pictureBox8.TabStop = false;
            // 
            // txtPrecioV
            // 
            this.txtPrecioV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtPrecioV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioV.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrecioV.Location = new System.Drawing.Point(628, 232);
            this.txtPrecioV.Name = "txtPrecioV";
            this.txtPrecioV.Size = new System.Drawing.Size(250, 30);
            this.txtPrecioV.TabIndex = 14;
            this.txtPrecioV.Text = "Precio de Venta";
            this.txtPrecioV.Enter += new System.EventHandler(this.txtPrecioV_Enter);
            this.txtPrecioV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioV_KeyPress);
            this.txtPrecioV.Leave += new System.EventHandler(this.txtPrecioV_Leave);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Location = new System.Drawing.Point(628, 267);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(250, 3);
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            // 
            // txtPrecioC
            // 
            this.txtPrecioC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtPrecioC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioC.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrecioC.Location = new System.Drawing.Point(336, 232);
            this.txtPrecioC.Name = "txtPrecioC";
            this.txtPrecioC.Size = new System.Drawing.Size(250, 30);
            this.txtPrecioC.TabIndex = 12;
            this.txtPrecioC.Text = "Precio de Compra";
            this.txtPrecioC.Enter += new System.EventHandler(this.txtPrecioC_Enter);
            this.txtPrecioC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioC_KeyPress);
            this.txtPrecioC.Leave += new System.EventHandler(this.txtPrecioC_Leave);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(336, 267);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(250, 3);
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // txtExistencias
            // 
            this.txtExistencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtExistencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExistencias.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExistencias.ForeColor = System.Drawing.Color.DimGray;
            this.txtExistencias.Location = new System.Drawing.Point(38, 232);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(250, 30);
            this.txtExistencias.TabIndex = 10;
            this.txtExistencias.Text = "Existencias";
            this.txtExistencias.Enter += new System.EventHandler(this.txtExistencias_Enter);
            this.txtExistencias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExistencias_KeyPress);
            this.txtExistencias.Leave += new System.EventHandler(this.txtExistencias_Leave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(38, 267);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(250, 3);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // txtIva
            // 
            this.txtIva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtIva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIva.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.ForeColor = System.Drawing.Color.DimGray;
            this.txtIva.Location = new System.Drawing.Point(928, 116);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(250, 30);
            this.txtIva.TabIndex = 8;
            this.txtIva.Text = "Iva";
            this.txtIva.Enter += new System.EventHandler(this.txtIva_Enter);
            this.txtIva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIva_KeyPress);
            this.txtIva.Leave += new System.EventHandler(this.txtIva_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(928, 152);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(250, 3);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.Color.DimGray;
            this.txtMarca.Location = new System.Drawing.Point(628, 116);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(250, 30);
            this.txtMarca.TabIndex = 6;
            this.txtMarca.Text = "Marca";
            this.txtMarca.Enter += new System.EventHandler(this.txtMarca_Enter);
            this.txtMarca.Leave += new System.EventHandler(this.txtMarca_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(628, 152);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(250, 3);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(336, 116);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 30);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(336, 152);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 3);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // txtCodigoB
            // 
            this.txtCodigoB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtCodigoB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoB.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodigoB.Location = new System.Drawing.Point(38, 116);
            this.txtCodigoB.Name = "txtCodigoB";
            this.txtCodigoB.Size = new System.Drawing.Size(250, 30);
            this.txtCodigoB.TabIndex = 17;
            this.txtCodigoB.Text = "Codigo de Barras";
            this.txtCodigoB.Enter += new System.EventHandler(this.txtCodigoB_Enter);
            this.txtCodigoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoB_KeyPress);
            this.txtCodigoB.Leave += new System.EventHandler(this.txtCodigoB_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(38, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 3);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(498, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(305, 38);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Agregar Productos";
            // 
            // tbProductosBindingSource
            // 
            this.tbProductosBindingSource.DataMember = "tbProductos";
            this.tbProductosBindingSource.DataSource = this.db_CRUMARPDataSet1;
            // 
            // db_CRUMARPDataSet1
            // 
            this.db_CRUMARPDataSet1.DataSetName = "db_CRUMARPDataSet";
            this.db_CRUMARPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db_CRUMARPDataSet
            // 
            this.db_CRUMARPDataSet.DataSetName = "db_CRUMARPDataSet";
            this.db_CRUMARPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbCRUMARPDataSetBindingSource
            // 
            this.dbCRUMARPDataSetBindingSource.DataSource = this.db_CRUMARPDataSet;
            this.dbCRUMARPDataSetBindingSource.Position = 0;
            // 
            // tbProductosTableAdapter
            // 
            this.tbProductosTableAdapter.ClearBeforeFill = true;
            // 
            // tbProductosBindingSource1
            // 
            this.tbProductosBindingSource1.DataMember = "tbProductos";
            this.tbProductosBindingSource1.DataSource = this.dbCRUMARPDataSetBindingSource;
            // 
            // calendario
            // 
            this.calendario.BackColor = System.Drawing.Color.White;
            this.calendario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calendario.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendario.Location = new System.Drawing.Point(1210, 276);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 29;
            this.calendario.Visible = false;
            this.calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateSelected);
            // 
            // AgregarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1261, 894);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.pPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarProductos";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_CRUMARPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_CRUMARPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRUMARPDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox txtCodigoB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFechaV;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private CRUMARpvDataSet db_CRUMARPDataSet;
        private System.Windows.Forms.BindingSource dbCRUMARPDataSetBindingSource;
        private System.Windows.Forms.DataGridView dgvProductos;
        private CRUMARpvDataSet db_CRUMARPDataSet1;
        private System.Windows.Forms.BindingSource tbProductosBindingSource;
        private CRUMARpvDataSetTableAdapters.tbProductosTableAdapter tbProductosTableAdapter;
        private System.Windows.Forms.BindingSource tbProductosBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCaducidad;
        private MonthCalendar calendario;
        private FontAwesome.Sharp.IconButton btncalendaario;
        private TextBox txtPrecioV;
        private PictureBox pictureBox7;
        private TextBox txtPrecioC;
        private PictureBox pictureBox6;
        private TextBox txtExistencias;
        private PictureBox pictureBox5;
        private Label lblCodigoBarras;
        private Label lblFechaC;
        private Label lblPrecioV;
        private Label lblPrecioC;
        private Label lblExistencia;
        private Label lblIva;
        private Label lblMarca;
        private Label lblnombre;
        private FontAwesome.Sharp.IconButton btnCosultar;
    }
}