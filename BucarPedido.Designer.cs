namespace LoginCRUMAR
{
    partial class BucarPedido
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
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.idProductoprove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigpBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnComprobante = new FontAwesome.Sharp.IconButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btLimpiar2 = new FontAwesome.Sharp.IconButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBuscarpor = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.pPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // pPrincipal
            // 
            this.pPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pPrincipal.Controls.Add(this.dgvPedidos);
            this.pPrincipal.Controls.Add(this.btnComprobante);
            this.pPrincipal.Controls.Add(this.panel10);
            this.pPrincipal.Controls.Add(this.pictureBox9);
            this.pPrincipal.Controls.Add(this.btLimpiar2);
            this.pPrincipal.Controls.Add(this.txtBuscar);
            this.pPrincipal.Controls.Add(this.cboBusqueda);
            this.pPrincipal.Controls.Add(this.label2);
            this.pPrincipal.Controls.Add(this.lblBuscarpor);
            this.pPrincipal.Controls.Add(this.Titulo);
            this.pPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(1233, 838);
            this.pPrincipal.TabIndex = 0;
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
            this.dgvPedidos.Location = new System.Drawing.Point(3, 296);
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
            this.dgvPedidos.Size = new System.Drawing.Size(1227, 539);
            this.dgvPedidos.TabIndex = 102;
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
            // btnComprobante
            // 
            this.btnComprobante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnComprobante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprobante.FlatAppearance.BorderSize = 0;
            this.btnComprobante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnComprobante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprobante.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobante.ForeColor = System.Drawing.Color.LightGray;
            this.btnComprobante.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnComprobante.IconColor = System.Drawing.Color.White;
            this.btnComprobante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnComprobante.IconSize = 30;
            this.btnComprobante.Location = new System.Drawing.Point(920, 45);
            this.btnComprobante.Name = "btnComprobante";
            this.btnComprobante.Size = new System.Drawing.Size(250, 49);
            this.btnComprobante.TabIndex = 82;
            this.btnComprobante.Text = "Comprobante de Pedido";
            this.btnComprobante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComprobante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComprobante.UseVisualStyleBackColor = false;
            this.btnComprobante.Click += new System.EventHandler(this.btnComprobante_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel10.Location = new System.Drawing.Point(910, 45);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 49);
            this.panel10.TabIndex = 81;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.White;
            this.pictureBox9.Location = new System.Drawing.Point(795, 188);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(193, 3);
            this.pictureBox9.TabIndex = 43;
            this.pictureBox9.TabStop = false;
            // 
            // btLimpiar2
            // 
            this.btLimpiar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btLimpiar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLimpiar2.FlatAppearance.BorderSize = 0;
            this.btLimpiar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btLimpiar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btLimpiar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpiar2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar2.ForeColor = System.Drawing.Color.LightGray;
            this.btLimpiar2.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btLimpiar2.IconColor = System.Drawing.Color.White;
            this.btLimpiar2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btLimpiar2.IconSize = 30;
            this.btLimpiar2.Location = new System.Drawing.Point(1003, 149);
            this.btLimpiar2.Name = "btLimpiar2";
            this.btLimpiar2.Size = new System.Drawing.Size(68, 45);
            this.btLimpiar2.TabIndex = 42;
            this.btLimpiar2.UseVisualStyleBackColor = false;
            this.btLimpiar2.Click += new System.EventHandler(this.btLimpiar2_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuscar.Location = new System.Drawing.Point(795, 153);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(193, 30);
            this.txtBuscar.TabIndex = 40;
            this.txtBuscar.Text = "Busca Aqui";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cboBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBusqueda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBusqueda.ForeColor = System.Drawing.Color.White;
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(560, 153);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(220, 38);
            this.cboBusqueda.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(400, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 30);
            this.label2.TabIndex = 38;
            this.label2.Text = "Buscar por:";
            // 
            // lblBuscarpor
            // 
            this.lblBuscarpor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblBuscarpor.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarpor.ForeColor = System.Drawing.Color.White;
            this.lblBuscarpor.Location = new System.Drawing.Point(8, 97);
            this.lblBuscarpor.Name = "lblBuscarpor";
            this.lblBuscarpor.Size = new System.Drawing.Size(1178, 141);
            this.lblBuscarpor.TabIndex = 37;
            this.lblBuscarpor.Text = "Lista de Pedidos\r\n";
            this.lblBuscarpor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(433, 11);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(338, 38);
            this.Titulo.TabIndex = 36;
            this.Titulo.Text = "Busqueda de Pedido\r\n";
            // 
            // BucarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1233, 838);
            this.Controls.Add(this.pPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BucarPedido";
            this.Opacity = 0.9D;
            this.Text = "BucarPedido";
            this.Load += new System.EventHandler(this.BucarPedido_Load);
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.PictureBox pictureBox9;
        private FontAwesome.Sharp.IconButton btLimpiar2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBuscarpor;
        private System.Windows.Forms.Label Titulo;
        private FontAwesome.Sharp.IconButton btnComprobante;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoprove;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigpBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePro;
    }
}