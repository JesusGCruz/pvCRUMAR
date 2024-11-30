namespace LoginCRUMAR
{
    partial class provedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.spObtenerProveedoresContactos2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_CRUMARDataSet = new LoginCRUMAR.db_CRUMARDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.txtbusque = new System.Windows.Forms.TextBox();
            this.btnbusque = new FontAwesome.Sharp.IconButton();
            this.select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.tbProveedoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbProveedoresTableAdapter = new LoginCRUMAR.db_CRUMARDataSetTableAdapters.tbProveedoresTableAdapter();
            this.dbCRUMARDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ObtenerProveedoresContactos2TableAdapter = new LoginCRUMAR.db_CRUMARDataSetTableAdapters.sp_ObtenerProveedoresContactos2TableAdapter();
            this.btlim = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.idPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LadaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoElec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activ = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spObtenerProveedoresContactos2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_CRUMARDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProveedoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRUMARDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.AutoGenerateColumns = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.Black;
            this.dgvdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.ColumnHeadersHeight = 34;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPro,
            this.nomb,
            this.idCont,
            this.numTel,
            this.LadaP,
            this.correoElec,
            this.activ});
            this.dgvdata.DataSource = this.spObtenerProveedoresContactos2BindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.GridColor = System.Drawing.Color.DimGray;
            this.dgvdata.Location = new System.Drawing.Point(1, 255);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.RowHeadersVisible = false;
            this.dgvdata.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdata.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Empty;
            this.dgvdata.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvdata.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvdata.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdata.Size = new System.Drawing.Size(917, 394);
            this.dgvdata.TabIndex = 17;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // spObtenerProveedoresContactos2BindingSource
            // 
            this.spObtenerProveedoresContactos2BindingSource.DataMember = "sp_ObtenerProveedoresContactos2";
            this.spObtenerProveedoresContactos2BindingSource.DataSource = this.db_CRUMARDataSet;
            // 
            // db_CRUMARDataSet
            // 
            this.db_CRUMARDataSet.DataSetName = "db_CRUMARDataSet";
            this.db_CRUMARDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(913, 90);
            this.label9.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(10, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "Buscar por:";
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.DropDownWidth = 260;
            this.cboBusqueda.ForeColor = System.Drawing.Color.White;
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.ItemHeight = 20;
            this.cboBusqueda.Location = new System.Drawing.Point(185, 154);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(260, 28);
            this.cboBusqueda.TabIndex = 22;
            this.cboBusqueda.UseWaitCursor = true;
            this.cboBusqueda.SelectedIndexChanged += new System.EventHandler(this.cboBusqueda_SelectedIndexChanged);
            // 
            // txtbusque
            // 
            this.txtbusque.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbusque.ForeColor = System.Drawing.Color.White;
            this.txtbusque.Location = new System.Drawing.Point(465, 154);
            this.txtbusque.Multiline = true;
            this.txtbusque.Name = "txtbusque";
            this.txtbusque.Size = new System.Drawing.Size(190, 35);
            this.txtbusque.TabIndex = 23;
            // 
            // btnbusque
            // 
            this.btnbusque.BackColor = System.Drawing.Color.Black;
            this.btnbusque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbusque.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnbusque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnbusque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbusque.ForeColor = System.Drawing.Color.Transparent;
            this.btnbusque.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbusque.IconColor = System.Drawing.Color.White;
            this.btnbusque.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbusque.IconSize = 20;
            this.btnbusque.Location = new System.Drawing.Point(687, 154);
            this.btnbusque.Name = "btnbusque";
            this.btnbusque.Size = new System.Drawing.Size(63, 35);
            this.btnbusque.TabIndex = 24;
            this.btnbusque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbusque.UseVisualStyleBackColor = false;
            this.btnbusque.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // select
            // 
            this.select.HeaderText = "";
            this.select.MinimumWidth = 8;
            this.select.Name = "select";
            this.select.ReadOnly = true;
            this.select.Width = 30;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Red;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.File;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(327, 778);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(232, 39);
            this.iconButton1.TabIndex = 28;
            this.iconButton1.Text = "Descargar PDF";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_2);
            // 
            // tbProveedoresBindingSource1
            // 
            this.tbProveedoresBindingSource1.DataMember = "tbProveedores";
            this.tbProveedoresBindingSource1.DataSource = this.db_CRUMARDataSet;
            // 
            // tbProveedoresBindingSource
            // 
            this.tbProveedoresBindingSource.DataMember = "tbProveedores";
            this.tbProveedoresBindingSource.DataSource = this.db_CRUMARDataSet;
            // 
            // tbProveedoresTableAdapter
            // 
            this.tbProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // dbCRUMARDataSetBindingSource
            // 
            this.dbCRUMARDataSetBindingSource.DataSource = this.db_CRUMARDataSet;
            this.dbCRUMARDataSetBindingSource.Position = 0;
            // 
            // sp_ObtenerProveedoresContactos2TableAdapter
            // 
            this.sp_ObtenerProveedoresContactos2TableAdapter.ClearBeforeFill = true;
            // 
            // btlim
            // 
            this.btlim.BackColor = System.Drawing.Color.Black;
            this.btlim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlim.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btlim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btlim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlim.ForeColor = System.Drawing.Color.Transparent;
            this.btlim.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btlim.IconColor = System.Drawing.Color.White;
            this.btlim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btlim.IconSize = 20;
            this.btlim.Location = new System.Drawing.Point(771, 154);
            this.btlim.Name = "btlim";
            this.btlim.Size = new System.Drawing.Size(63, 35);
            this.btlim.TabIndex = 75;
            this.btlim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btlim.UseVisualStyleBackColor = false;
            this.btlim.Click += new System.EventHandler(this.btlim_Click_1);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(307, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(268, 49);
            this.label8.TabIndex = 109;
            this.label8.Text = "PROVEEDORES";
            // 
            // idPro
            // 
            this.idPro.DataPropertyName = "idProvedor";
            this.idPro.HeaderText = "idProvedor";
            this.idPro.MinimumWidth = 8;
            this.idPro.Name = "idPro";
            this.idPro.ReadOnly = true;
            this.idPro.Width = 120;
            // 
            // nomb
            // 
            this.nomb.DataPropertyName = "nombre";
            this.nomb.HeaderText = "nombre";
            this.nomb.MinimumWidth = 8;
            this.nomb.Name = "nomb";
            this.nomb.ReadOnly = true;
            this.nomb.Width = 160;
            // 
            // idCont
            // 
            this.idCont.DataPropertyName = "idContacto";
            this.idCont.HeaderText = "idContacto";
            this.idCont.MinimumWidth = 8;
            this.idCont.Name = "idCont";
            this.idCont.ReadOnly = true;
            this.idCont.Width = 112;
            // 
            // numTel
            // 
            this.numTel.DataPropertyName = "numTelefono";
            this.numTel.HeaderText = "numTelefono";
            this.numTel.MinimumWidth = 8;
            this.numTel.Name = "numTel";
            this.numTel.ReadOnly = true;
            this.numTel.Width = 150;
            // 
            // LadaP
            // 
            this.LadaP.DataPropertyName = "ladaPais";
            this.LadaP.FillWeight = 68.7773F;
            this.LadaP.HeaderText = "Lada";
            this.LadaP.MinimumWidth = 8;
            this.LadaP.Name = "LadaP";
            this.LadaP.ReadOnly = true;
            this.LadaP.Width = 70;
            // 
            // correoElec
            // 
            this.correoElec.DataPropertyName = "correoElectronico";
            this.correoElec.HeaderText = "correoElectronico";
            this.correoElec.MinimumWidth = 8;
            this.correoElec.Name = "correoElec";
            this.correoElec.ReadOnly = true;
            this.correoElec.Width = 180;
            // 
            // activ
            // 
            this.activ.DataPropertyName = "activo";
            this.activ.HeaderText = "activo";
            this.activ.MinimumWidth = 8;
            this.activ.Name = "activ";
            this.activ.ReadOnly = true;
            this.activ.Width = 80;
            // 
            // provedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(912, 938);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btlim);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnbusque);
            this.Controls.Add(this.txtbusque);
            this.Controls.Add(this.cboBusqueda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvdata);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "provedores";
            this.Text = "provedores";
            this.Load += new System.EventHandler(this.provedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spObtenerProveedoresContactos2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_CRUMARDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProveedoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRUMARDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.TextBox txtbusque;
        private FontAwesome.Sharp.IconButton btnbusque;
        private db_CRUMARDataSet db_CRUMARDataSet;
        private System.Windows.Forms.BindingSource tbProveedoresBindingSource;
        private db_CRUMARDataSetTableAdapters.tbProveedoresTableAdapter tbProveedoresTableAdapter;
        private System.Windows.Forms.BindingSource tbProveedoresBindingSource1;
        private System.Windows.Forms.BindingSource dbCRUMARDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProvedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn lada;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewButtonColumn select;
        private System.Windows.Forms.BindingSource spObtenerProveedoresContactos2BindingSource;
        private db_CRUMARDataSetTableAdapters.sp_ObtenerProveedoresContactos2TableAdapter sp_ObtenerProveedoresContactos2TableAdapter;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btlim;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomb;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCont;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn LadaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoElec;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activ;
    }
}