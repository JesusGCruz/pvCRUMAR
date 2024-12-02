using LoginCRUMAR;

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
            this.cRUMARpvDataSet = new LoginCRUMAR.CRUMARpvDataSet();
            this.tbProductosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.Categoria = new System.Windows.Forms.Label();
            this.Productos = new System.Windows.Forms.Label();
            this.tbProductosTableAdapter = new LoginCRUMAR.CRUMARpvDataSetTableAdapters.tbProductosTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtProductos = new System.Windows.Forms.TextBox();
            this.lblnom = new System.Windows.Forms.Label();
            this.spConsultarProductoTableAdapter = new LoginCRUMAR.CRUMARpvDataSetTableAdapters.spConsultarProductoTableAdapter();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
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
            this.panel1.Location = new System.Drawing.Point(23, 195);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 47);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(77, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 22);
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
            this.iconButton2.Location = new System.Drawing.Point(698, 7);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(34, 23);
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
            this.iconButton1.Location = new System.Drawing.Point(365, 9);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(34, 23);
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
            this.label2.Location = new System.Drawing.Point(491, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
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
            this.cbMarca.Location = new System.Drawing.Point(555, 11);
            this.cbMarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(127, 21);
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
            this.cbCaducidad.Location = new System.Drawing.Point(235, 13);
            this.cbCaducidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCaducidad.Name = "cbCaducidad";
            this.cbCaducidad.Size = new System.Drawing.Size(109, 21);
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
            this.cbOptions.Location = new System.Drawing.Point(225, 128);
            this.cbOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbOptions.Name = "cbOptions";
            this.cbOptions.Size = new System.Drawing.Size(213, 21);
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
            //this.btnPrint.Image = global::Repositorio.Properties.Resources.Price_Tag_USD;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(614, 111);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(153, 35);
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
            //this.btnF.Image = global::Repositorio.Properties.Resources.Filtro;
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
            this.Categoria.Location = new System.Drawing.Point(221, 101);
            this.Categoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(84, 20);
            this.Categoria.TabIndex = 12;
            this.Categoria.Text = "Categoria";
            // 
            // Productos
            // 
            this.Productos.AutoSize = true;
            this.Productos.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.Productos.ForeColor = System.Drawing.Color.White;
            this.Productos.Location = new System.Drawing.Point(354, 38);
            this.Productos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(143, 32);
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
            this.pictureBox2.Location = new System.Drawing.Point(35, 145);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 2);
            this.pictureBox2.TabIndex = 115;
            this.pictureBox2.TabStop = false;
            // 
            // txtProductos
            // 
            this.txtProductos.BackColor = System.Drawing.Color.Black;
            this.txtProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductos.ForeColor = System.Drawing.Color.White;
            this.txtProductos.Location = new System.Drawing.Point(35, 123);
            this.txtProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProductos.Multiline = true;
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.Size = new System.Drawing.Size(173, 25);
            this.txtProductos.TabIndex = 114;
            this.txtProductos.TextChanged += new System.EventHandler(this.txtProductos_TextChanged_1);
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.BackColor = System.Drawing.Color.Transparent;
            this.lblnom.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom.ForeColor = System.Drawing.Color.White;
            this.lblnom.Location = new System.Drawing.Point(33, 97);
            this.lblnom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(64, 16);
            this.lblnom.TabIndex = 113;
            this.lblnom.Text = "Producto";
            // 
            // spConsultarProductoTableAdapter
            // 
            this.spConsultarProductoTableAdapter.ClearBeforeFill = true;
            // 
            // dgvProducts
            // 
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
            this.dgvProducts.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.Location = new System.Drawing.Point(23, 273);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.dgvProducts.Size = new System.Drawing.Size(713, 321);
            this.dgvProducts.TabIndex = 116;
            // 
            // tbProductosBindingSource2
            // 
            this.tbProductosBindingSource2.DataMember = "tbProductos";
            this.tbProductosBindingSource2.DataSource = this.cRUMARpvDataSetBindingSource;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(821, 525);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private LoginCRUMAR.CRUMARpvDataSetTableAdapters.tbProductosTableAdapter tbProductosTableAdapter;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtProductos;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.BindingSource spConsultarProductoBindingSource;
        private LoginCRUMAR.CRUMARpvDataSetTableAdapters.spConsultarProductoTableAdapter spConsultarProductoTableAdapter;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.BindingSource tbProductosBindingSource2;
    }
}