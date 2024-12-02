namespace LoginCRUMAR
{
    partial class AgregarPedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCantP = new System.Windows.Forms.Label();
            this.lblCodB = new System.Windows.Forms.Label();
            this.lblNumPro = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.idProductoprove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigpBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnConsultar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.txtFechaP = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.txtCantidadP = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtNumpro = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtCodigoB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.pPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pPrincipal
            // 
            this.pPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pPrincipal.Controls.Add(this.lblFecha);
            this.pPrincipal.Controls.Add(this.lblCantP);
            this.pPrincipal.Controls.Add(this.lblCodB);
            this.pPrincipal.Controls.Add(this.lblNumPro);
            this.pPrincipal.Controls.Add(this.dgvPedidos);
            this.pPrincipal.Controls.Add(this.btnLimpiar);
            this.pPrincipal.Controls.Add(this.btnConsultar);
            this.pPrincipal.Controls.Add(this.btnGuardar);
            this.pPrincipal.Controls.Add(this.txtFechaP);
            this.pPrincipal.Controls.Add(this.pictureBox8);
            this.pPrincipal.Controls.Add(this.txtCantidadP);
            this.pPrincipal.Controls.Add(this.pictureBox4);
            this.pPrincipal.Controls.Add(this.txtNumpro);
            this.pPrincipal.Controls.Add(this.pictureBox2);
            this.pPrincipal.Controls.Add(this.txtCodigoB);
            this.pPrincipal.Controls.Add(this.pictureBox1);
            this.pPrincipal.Controls.Add(this.Titulo);
            this.pPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(1233, 838);
            this.pPrincipal.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(523, 163);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(195, 25);
            this.lblFecha.TabIndex = 64;
            this.lblFecha.Text = "Fecha de Pedido";
            this.lblFecha.Visible = false;
            // 
            // lblCantP
            // 
            this.lblCantP.AutoSize = true;
            this.lblCantP.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantP.ForeColor = System.Drawing.Color.White;
            this.lblCantP.Location = new System.Drawing.Point(935, 64);
            this.lblCantP.Name = "lblCantP";
            this.lblCantP.Size = new System.Drawing.Size(254, 25);
            this.lblCantP.TabIndex = 63;
            this.lblCantP.Text = "Cantidad de Producto";
            this.lblCantP.Visible = false;
            // 
            // lblCodB
            // 
            this.lblCodB.AutoSize = true;
            this.lblCodB.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodB.ForeColor = System.Drawing.Color.White;
            this.lblCodB.Location = new System.Drawing.Point(534, 68);
            this.lblCodB.Name = "lblCodB";
            this.lblCodB.Size = new System.Drawing.Size(199, 25);
            this.lblCodB.TabIndex = 62;
            this.lblCodB.Text = "Codigo de Barras";
            this.lblCodB.Visible = false;
            // 
            // lblNumPro
            // 
            this.lblNumPro.AutoSize = true;
            this.lblNumPro.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPro.ForeColor = System.Drawing.Color.White;
            this.lblNumPro.Location = new System.Drawing.Point(101, 64);
            this.lblNumPro.Name = "lblNumPro";
            this.lblNumPro.Size = new System.Drawing.Size(250, 25);
            this.lblNumPro.TabIndex = 61;
            this.lblNumPro.Text = "Número de Proveedor";
            this.lblNumPro.Visible = false;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
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
            this.dgvPedidos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvPedidos.EnableHeadersVisualStyles = false;
            this.dgvPedidos.GridColor = System.Drawing.Color.Gray;
            this.dgvPedidos.Location = new System.Drawing.Point(3, 508);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.RowHeadersWidth = 62;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPedidos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPedidos.RowTemplate.Height = 28;
            this.dgvPedidos.Size = new System.Drawing.Size(1227, 327);
            this.dgvPedidos.TabIndex = 51;
            this.dgvPedidos.Visible = false;
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
            this.btnLimpiar.Location = new System.Drawing.Point(779, 264);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(188, 54);
            this.btnLimpiar.TabIndex = 50;
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
            this.btnConsultar.Location = new System.Drawing.Point(545, 391);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(188, 54);
            this.btnConsultar.TabIndex = 48;
            this.btnConsultar.Text = "Consultar Pedidos";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
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
            this.btnGuardar.Location = new System.Drawing.Point(347, 264);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(188, 54);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "Hacer Pedido";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtFechaP
            // 
            this.txtFechaP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtFechaP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaP.ForeColor = System.Drawing.Color.DimGray;
            this.txtFechaP.Location = new System.Drawing.Point(528, 191);
            this.txtFechaP.Name = "txtFechaP";
            this.txtFechaP.Size = new System.Drawing.Size(310, 30);
            this.txtFechaP.TabIndex = 46;
            this.txtFechaP.Text = "Fecha de Pedido";
            this.txtFechaP.Enter += new System.EventHandler(this.txtFechaP_Enter);
            this.txtFechaP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFechaP_KeyPress);
            this.txtFechaP.Leave += new System.EventHandler(this.txtFechaP_Leave);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Location = new System.Drawing.Point(528, 226);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(310, 3);
            this.pictureBox8.TabIndex = 45;
            this.pictureBox8.TabStop = false;
            // 
            // txtCantidadP
            // 
            this.txtCantidadP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtCantidadP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidadP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadP.ForeColor = System.Drawing.Color.DimGray;
            this.txtCantidadP.Location = new System.Drawing.Point(940, 92);
            this.txtCantidadP.Name = "txtCantidadP";
            this.txtCantidadP.Size = new System.Drawing.Size(281, 30);
            this.txtCantidadP.TabIndex = 38;
            this.txtCantidadP.Text = "Cantidad de Producto";
            this.txtCantidadP.Enter += new System.EventHandler(this.txtCantidadP_Enter);
            this.txtCantidadP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadP_KeyPress);
            this.txtCantidadP.Leave += new System.EventHandler(this.txtCantidadP_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(940, 128);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(281, 3);
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // txtNumpro
            // 
            this.txtNumpro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtNumpro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumpro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumpro.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumpro.Location = new System.Drawing.Point(106, 92);
            this.txtNumpro.Name = "txtNumpro";
            this.txtNumpro.Size = new System.Drawing.Size(266, 30);
            this.txtNumpro.TabIndex = 34;
            this.txtNumpro.Text = "Número de Proveedor";
            this.txtNumpro.Enter += new System.EventHandler(this.txtNumpro_Enter);
            this.txtNumpro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumpro_KeyPress);
            this.txtNumpro.Leave += new System.EventHandler(this.txtNumpro_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(106, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(266, 3);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // txtCodigoB
            // 
            this.txtCodigoB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtCodigoB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoB.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodigoB.Location = new System.Drawing.Point(539, 96);
            this.txtCodigoB.Name = "txtCodigoB";
            this.txtCodigoB.Size = new System.Drawing.Size(250, 30);
            this.txtCodigoB.TabIndex = 47;
            this.txtCodigoB.Text = "Codigo de Barras";
            this.txtCodigoB.Enter += new System.EventHandler(this.txtCodigoB_Enter);
            this.txtCodigoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoB_KeyPress);
            this.txtCodigoB.Leave += new System.EventHandler(this.txtCodigoB_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(539, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 3);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(514, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(275, 38);
            this.Titulo.TabIndex = 30;
            this.Titulo.Text = "Agregar Pedidos";
            // 
            // AgregarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1233, 838);
            this.Controls.Add(this.pPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarPedidos";
            this.Opacity = 0.9D;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnConsultar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.TextBox txtFechaP;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox txtCantidadP;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtNumpro;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtCodigoB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoprove;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigpBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePro;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCantP;
        private System.Windows.Forms.Label lblCodB;
        private System.Windows.Forms.Label lblNumPro;
    }
}