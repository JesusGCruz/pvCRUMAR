namespace Repositorio
{
    partial class test
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbCaducidad = new System.Windows.Forms.ComboBox();
            this.cbOptions = new System.Windows.Forms.ComboBox();
            this.spConsultarProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRUMARpvDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRUMARpvDataSet = new Repositorio.CRUMARpvDataSet();
            this.tbProductosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.Categoria = new System.Windows.Forms.Label();
            this.Productos = new System.Windows.Forms.Label();
            this.tbProductosTableAdapter = new Repositorio.CRUMARpvDataSetTableAdapters.tbProductosTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtProductos = new System.Windows.Forms.TextBox();
            this.lblnom = new System.Windows.Forms.Label();
            this.spConsultarProductoTableAdapter = new Repositorio.CRUMARpvDataSetTableAdapters.spConsultarProductoTableAdapter();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.codigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCaducidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbProductosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spConsultarProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUMARpvDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUMARpvDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbMarca);
            this.panel1.Controls.Add(this.cbCaducidad);
            this.panel1.Location = new System.Drawing.Point(34, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 70);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(116, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 34);
            this.label3.TabIndex = 123;
            this.label3.Text = "Caducidades";
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Black;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(1047, 10);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(51, 35);
            this.iconButton2.TabIndex = 122;
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Black;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(547, 13);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(51, 35);
            this.iconButton1.TabIndex = 121;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(737, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 34);
            this.label2.TabIndex = 14;
            this.label2.Text = "Stock";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbMarca
            // 
            this.cbMarca.BackColor = System.Drawing.Color.Black;
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.ForeColor = System.Drawing.SystemColors.Menu;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "Próximos a caducar",
            "Caducados"});
            this.cbMarca.Location = new System.Drawing.Point(832, 17);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(188, 28);
            this.cbMarca.TabIndex = 13;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // cbCaducidad
            // 
            this.cbCaducidad.BackColor = System.Drawing.SystemColors.MenuText;
            this.cbCaducidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaducidad.ForeColor = System.Drawing.SystemColors.Menu;
            this.cbCaducidad.FormattingEnabled = true;
            this.cbCaducidad.Items.AddRange(new object[] {
            "Próximos a caducar",
            "Caducados"});
            this.cbCaducidad.Location = new System.Drawing.Point(352, 20);
            this.cbCaducidad.Name = "cbCaducidad";
            this.cbCaducidad.Size = new System.Drawing.Size(162, 28);
            this.cbCaducidad.TabIndex = 12;
            // 
            // cbOptions
            // 
            this.cbOptions.BackColor = System.Drawing.SystemColors.MenuText;
            this.cbOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOptions.ForeColor = System.Drawing.SystemColors.Menu;
            this.cbOptions.FormattingEnabled = true;
            this.cbOptions.Items.AddRange(new object[] {
            "nombre",
            "codigoBarras",
            "marca",
            "precioVenta"});
            this.cbOptions.Location = new System.Drawing.Point(337, 192);
            this.cbOptions.Name = "cbOptions";
            this.cbOptions.Size = new System.Drawing.Size(317, 28);
            this.cbOptions.TabIndex = 10;
            // 
            // spConsultarProductoBindingSource
            // 
            this.spConsultarProductoBindingSource.DataMember = "spConsultarProducto";
            this.spConsultarProductoBindingSource.DataSource = this.cRUMARpvDataSetBindingSource;
            // 
            // cRUMARpvDataSetBindingSource
            // 
            this.cRUMARpvDataSetBindingSource.DataSource = this.cRUMARpvDataSet;
            this.cRUMARpvDataSetBindingSource.Position = 0;
            // 
            // cRUMARpvDataSet
            // 
            this.cRUMARpvDataSet.DataSetName = "CRUMARpvDataSet";
            this.cRUMARpvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbProductosBindingSource1
            // 
            this.tbProductosBindingSource1.DataMember = "tbProductos";
            this.tbProductosBindingSource1.DataSource = this.cRUMARpvDataSetBindingSource;
            // 
            // tbProductosBindingSource
            // 
            this.tbProductosBindingSource.DataMember = "tbProductos";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Black;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::Repositorio.Properties.Resources.Price_Tag_USD;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(921, 167);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(230, 53);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Imprimir Precios";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnF
            // 
            this.btnF.BackColor = System.Drawing.Color.White;
            this.btnF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnF.FlatAppearance.BorderSize = 0;
            this.btnF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnF.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnF.ForeColor = System.Drawing.Color.White;
            this.btnF.Image = global::Repositorio.Properties.Resources.Filtro;
            this.btnF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnF.Location = new System.Drawing.Point(521, 24);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(37, 32);
            this.btnF.TabIndex = 12;
            this.btnF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnF.UseVisualStyleBackColor = false;
            // 
            // Categoria
            // 
            this.Categoria.AutoSize = true;
            this.Categoria.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Categoria.ForeColor = System.Drawing.Color.White;
            this.Categoria.Location = new System.Drawing.Point(332, 152);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(122, 25);
            this.Categoria.TabIndex = 12;
            this.Categoria.Text = "Categoria";
            // 
            // Productos
            // 
            this.Productos.AutoSize = true;
            this.Productos.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.Productos.ForeColor = System.Drawing.Color.White;
            this.Productos.Location = new System.Drawing.Point(531, 57);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(213, 47);
            this.Productos.TabIndex = 13;
            this.Productos.Text = "Productos";
            // 
            // tbProductosTableAdapter
            // 
            this.tbProductosTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(53, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 3);
            this.pictureBox2.TabIndex = 115;
            this.pictureBox2.TabStop = false;
            // 
            // txtProductos
            // 
            this.txtProductos.BackColor = System.Drawing.Color.Black;
            this.txtProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductos.ForeColor = System.Drawing.Color.White;
            this.txtProductos.Location = new System.Drawing.Point(53, 185);
            this.txtProductos.Multiline = true;
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.Size = new System.Drawing.Size(260, 37);
            this.txtProductos.TabIndex = 114;
            this.txtProductos.TextChanged += new System.EventHandler(this.txtProductos_TextChanged_1);
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.BackColor = System.Drawing.Color.Transparent;
            this.lblnom.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom.ForeColor = System.Drawing.Color.White;
            this.lblnom.Location = new System.Drawing.Point(49, 145);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(89, 23);
            this.lblnom.TabIndex = 113;
            this.lblnom.Text = "Producto";
            // 
            // spConsultarProductoTableAdapter
            // 
            this.spConsultarProductoTableAdapter.ClearBeforeFill = true;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoBarras,
            this.nombre,
            this.marca,
            this.existencia,
            this.precioVenta,
            this.fechaCaducidad});
            this.dgvProducts.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvProducts.DataSource = this.tbProductosBindingSource2;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.Location = new System.Drawing.Point(34, 410);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 62;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.RowTemplate.Height = 28;
            this.dgvProducts.Size = new System.Drawing.Size(1070, 481);
            this.dgvProducts.TabIndex = 116;
            // 
            // codigoBarras
            // 
            this.codigoBarras.DataPropertyName = "codigoBarras";
            this.codigoBarras.HeaderText = "codigoBarras";
            this.codigoBarras.MinimumWidth = 12;
            this.codigoBarras.Name = "codigoBarras";
            this.codigoBarras.Width = 190;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "nombre";
            this.nombre.MinimumWidth = 12;
            this.nombre.Name = "nombre";
            this.nombre.Width = 190;
            // 
            // marca
            // 
            this.marca.DataPropertyName = "marca";
            this.marca.HeaderText = "marca";
            this.marca.MinimumWidth = 12;
            this.marca.Name = "marca";
            this.marca.Width = 170;
            // 
            // existencia
            // 
            this.existencia.DataPropertyName = "existencia";
            this.existencia.HeaderText = "existencia";
            this.existencia.MinimumWidth = 12;
            this.existencia.Name = "existencia";
            this.existencia.Width = 150;
            // 
            // precioVenta
            // 
            this.precioVenta.DataPropertyName = "precioVenta";
            this.precioVenta.HeaderText = "precioVenta";
            this.precioVenta.MinimumWidth = 12;
            this.precioVenta.Name = "precioVenta";
            this.precioVenta.Width = 170;
            // 
            // fechaCaducidad
            // 
            this.fechaCaducidad.DataPropertyName = "fechaCaducidad";
            this.fechaCaducidad.HeaderText = "fechaCaducidad";
            this.fechaCaducidad.MinimumWidth = 12;
            this.fechaCaducidad.Name = "fechaCaducidad";
            this.fechaCaducidad.Width = 190;
            // 
            // tbProductosBindingSource2
            // 
            this.tbProductosBindingSource2.DataMember = "tbProductos";
            this.tbProductosBindingSource2.DataSource = this.cRUMARpvDataSetBindingSource;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1231, 1037);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtProductos);
            this.Controls.Add(this.lblnom);
            this.Controls.Add(this.Productos);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.cbOptions);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "test";
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spConsultarProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUMARpvDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRUMARpvDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductosBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbOptions;
        private System.Windows.Forms.BindingSource tbProductosBindingSource;
        private System.Windows.Forms.ComboBox cbCaducidad;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCaducidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.Label Productos;
        private System.Windows.Forms.BindingSource cRUMARpvDataSetBindingSource;
        private CRUMARpvDataSet cRUMARpvDataSet;
        private System.Windows.Forms.BindingSource tbProductosBindingSource1;
        private CRUMARpvDataSetTableAdapters.tbProductosTableAdapter tbProductosTableAdapter;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtProductos;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.BindingSource spConsultarProductoBindingSource;
        private CRUMARpvDataSetTableAdapters.spConsultarProductoTableAdapter spConsultarProductoTableAdapter;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.BindingSource tbProductosBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCaducidad;
    }
}