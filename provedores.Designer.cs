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
            this.jlbfrom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtidpro = new System.Windows.Forms.TextBox();
            this.txtnombrepro = new System.Windows.Forms.TextBox();
            this.txtnnumpro = new System.Windows.Forms.TextBox();
            this.txtladapro = new System.Windows.Forms.TextBox();
            this.txtcorreopro = new System.Windows.Forms.TextBox();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btneditar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.spObtenerProveedoresContactos2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_CRUMARDataSet = new LoginCRUMAR.db_CRUMARDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.rbactivo = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.txtbusque = new System.Windows.Forms.TextBox();
            this.btnbusque = new FontAwesome.Sharp.IconButton();
            this.btlim = new FontAwesome.Sharp.IconButton();
            this.select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rbnoact = new System.Windows.Forms.RadioButton();
            this.Limpia = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.tbProveedoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbProveedoresTableAdapter = new LoginCRUMAR.db_CRUMARDataSetTableAdapters.tbProveedoresTableAdapter();
            this.dbCRUMARDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ObtenerProveedoresContactos2TableAdapter = new LoginCRUMAR.db_CRUMARDataSetTableAdapters.sp_ObtenerProveedoresContactos2TableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.selec = new System.Windows.Forms.DataGridViewButtonColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // jlbfrom
            // 
            this.jlbfrom.BackColor = System.Drawing.SystemColors.MenuText;
            this.jlbfrom.Dock = System.Windows.Forms.DockStyle.Top;
            this.jlbfrom.ForeColor = System.Drawing.Color.White;
            this.jlbfrom.Location = new System.Drawing.Point(0, 0);
            this.jlbfrom.Name = "jlbfrom";
            this.jlbfrom.Size = new System.Drawing.Size(912, 335);
            this.jlbfrom.TabIndex = 0;
            this.jlbfrom.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre completo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(324, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(324, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(602, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo Electronico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(36, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Id Proveedor";
            // 
            // txtidpro
            // 
            this.txtidpro.BackColor = System.Drawing.Color.Black;
            this.txtidpro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidpro.ForeColor = System.Drawing.Color.Transparent;
            this.txtidpro.Location = new System.Drawing.Point(31, 95);
            this.txtidpro.Name = "txtidpro";
            this.txtidpro.Size = new System.Drawing.Size(256, 26);
            this.txtidpro.TabIndex = 6;
            this.txtidpro.TextChanged += new System.EventHandler(this.txtidpro_TextChanged);
            // 
            // txtnombrepro
            // 
            this.txtnombrepro.BackColor = System.Drawing.SystemColors.ControlText;
            this.txtnombrepro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombrepro.ForeColor = System.Drawing.Color.White;
            this.txtnombrepro.Location = new System.Drawing.Point(31, 175);
            this.txtnombrepro.Name = "txtnombrepro";
            this.txtnombrepro.Size = new System.Drawing.Size(256, 26);
            this.txtnombrepro.TabIndex = 7;
            // 
            // txtnnumpro
            // 
            this.txtnnumpro.BackColor = System.Drawing.SystemColors.ControlText;
            this.txtnnumpro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnnumpro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnnumpro.ForeColor = System.Drawing.Color.White;
            this.txtnnumpro.Location = new System.Drawing.Point(328, 95);
            this.txtnnumpro.Name = "txtnnumpro";
            this.txtnnumpro.Size = new System.Drawing.Size(256, 26);
            this.txtnnumpro.TabIndex = 8;
            this.txtnnumpro.TextChanged += new System.EventHandler(this.txtnnumpro_TextChanged);
            // 
            // txtladapro
            // 
            this.txtladapro.BackColor = System.Drawing.SystemColors.ControlText;
            this.txtladapro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtladapro.ForeColor = System.Drawing.Color.White;
            this.txtladapro.Location = new System.Drawing.Point(328, 177);
            this.txtladapro.Name = "txtladapro";
            this.txtladapro.Size = new System.Drawing.Size(256, 26);
            this.txtladapro.TabIndex = 9;
            // 
            // txtcorreopro
            // 
            this.txtcorreopro.BackColor = System.Drawing.SystemColors.ControlText;
            this.txtcorreopro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcorreopro.ForeColor = System.Drawing.Color.White;
            this.txtcorreopro.Location = new System.Drawing.Point(606, 95);
            this.txtcorreopro.Name = "txtcorreopro";
            this.txtcorreopro.Size = new System.Drawing.Size(256, 26);
            this.txtcorreopro.TabIndex = 10;
            this.txtcorreopro.TextChanged += new System.EventHandler(this.txtcorreopro_TextChanged);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Black;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            this.btnguardar.IconColor = System.Drawing.Color.White;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 20;
            this.btnguardar.Location = new System.Drawing.Point(31, 265);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(131, 49);
            this.btnguardar.TabIndex = 13;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.Black;
            this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btneditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btneditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btneditar.IconColor = System.Drawing.Color.White;
            this.btneditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneditar.IconSize = 20;
            this.btneditar.Location = new System.Drawing.Point(261, 265);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(126, 49);
            this.btneditar.TabIndex = 14;
            this.btneditar.Text = "Editar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 20;
            this.btnEliminar.Location = new System.Drawing.Point(483, 265);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(141, 49);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(322, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 36);
            this.label8.TabIndex = 16;
            this.label8.Text = "PROVEEDORES";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.AllowUserToDeleteRows = false;
            this.dgvdata.AllowUserToOrderColumns = true;
            this.dgvdata.AutoGenerateColumns = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.Black;
            this.dgvdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selec,
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
            this.dgvdata.GridColor = System.Drawing.Color.Black;
            this.dgvdata.Location = new System.Drawing.Point(0, 397);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.RowHeadersWidth = 62;
            this.dgvdata.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvdata.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvdata.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
            this.dgvdata.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(912, 468);
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
            this.label9.Location = new System.Drawing.Point(-1, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(913, 48);
            this.label9.TabIndex = 18;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // rbactivo
            // 
            this.rbactivo.AutoSize = true;
            this.rbactivo.BackColor = System.Drawing.Color.Transparent;
            this.rbactivo.ForeColor = System.Drawing.Color.White;
            this.rbactivo.Location = new System.Drawing.Point(616, 177);
            this.rbactivo.Name = "rbactivo";
            this.rbactivo.Size = new System.Drawing.Size(77, 24);
            this.rbactivo.TabIndex = 20;
            this.rbactivo.TabStop = true;
            this.rbactivo.Text = "Activo";
            this.rbactivo.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "Buscar por:";
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboBusqueda.ForeColor = System.Drawing.Color.White;
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(184, 343);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(213, 28);
            this.cboBusqueda.TabIndex = 22;
            // 
            // txtbusque
            // 
            this.txtbusque.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbusque.ForeColor = System.Drawing.Color.White;
            this.txtbusque.Location = new System.Drawing.Point(425, 345);
            this.txtbusque.Name = "txtbusque";
            this.txtbusque.Size = new System.Drawing.Size(190, 26);
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
            this.btnbusque.Location = new System.Drawing.Point(704, 341);
            this.btnbusque.Name = "btnbusque";
            this.btnbusque.Size = new System.Drawing.Size(63, 35);
            this.btnbusque.TabIndex = 24;
            this.btnbusque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbusque.UseVisualStyleBackColor = false;
            this.btnbusque.Click += new System.EventHandler(this.iconButton2_Click);
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
            this.btlim.Location = new System.Drawing.Point(799, 343);
            this.btlim.Name = "btlim";
            this.btlim.Size = new System.Drawing.Size(63, 35);
            this.btlim.TabIndex = 25;
            this.btlim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btlim.UseVisualStyleBackColor = false;
            this.btlim.Click += new System.EventHandler(this.btlim_Click);
            // 
            // select
            // 
            this.select.HeaderText = "";
            this.select.MinimumWidth = 8;
            this.select.Name = "select";
            this.select.ReadOnly = true;
            this.select.Width = 30;
            // 
            // rbnoact
            // 
            this.rbnoact.AutoSize = true;
            this.rbnoact.BackColor = System.Drawing.Color.Transparent;
            this.rbnoact.ForeColor = System.Drawing.Color.White;
            this.rbnoact.Location = new System.Drawing.Point(748, 178);
            this.rbnoact.Name = "rbnoact";
            this.rbnoact.Size = new System.Drawing.Size(101, 24);
            this.rbnoact.TabIndex = 26;
            this.rbnoact.TabStop = true;
            this.rbnoact.Text = "No Activo";
            this.rbnoact.UseVisualStyleBackColor = false;
            // 
            // Limpia
            // 
            this.Limpia.BackColor = System.Drawing.Color.Black;
            this.Limpia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Limpia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Limpia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Limpia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Limpia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpia.ForeColor = System.Drawing.Color.White;
            this.Limpia.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.Limpia.IconColor = System.Drawing.Color.White;
            this.Limpia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Limpia.IconSize = 20;
            this.Limpia.Location = new System.Drawing.Point(721, 265);
            this.Limpia.Name = "Limpia";
            this.Limpia.Size = new System.Drawing.Size(141, 49);
            this.Limpia.TabIndex = 27;
            this.Limpia.Text = "Limpiar";
            this.Limpia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Limpia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Limpia.UseVisualStyleBackColor = false;
            this.Limpia.Click += new System.EventHandler(this.Limpia_Click);
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
            this.iconButton1.Location = new System.Drawing.Point(328, 871);
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(31, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 3);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(31, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 3);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(328, 200);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(256, 3);
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(328, 118);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(256, 3);
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(606, 118);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(256, 3);
            this.pictureBox5.TabIndex = 33;
            this.pictureBox5.TabStop = false;
            // 
            // selec
            // 
            this.selec.HeaderText = "";
            this.selec.MinimumWidth = 8;
            this.selec.Name = "selec";
            this.selec.ReadOnly = true;
            this.selec.Width = 30;
            // 
            // idPro
            // 
            this.idPro.DataPropertyName = "idProvedor";
            this.idPro.HeaderText = "idProvedor";
            this.idPro.MinimumWidth = 8;
            this.idPro.Name = "idPro";
            this.idPro.ReadOnly = true;
            this.idPro.Width = 112;
            // 
            // nomb
            // 
            this.nomb.DataPropertyName = "nombre";
            this.nomb.HeaderText = "nombre";
            this.nomb.MinimumWidth = 8;
            this.nomb.Name = "nomb";
            this.nomb.ReadOnly = true;
            this.nomb.Width = 130;
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
            this.numTel.Width = 130;
            // 
            // LadaP
            // 
            this.LadaP.DataPropertyName = "ladaPais";
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
            this.correoElec.Width = 170;
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
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.Limpia);
            this.Controls.Add(this.rbnoact);
            this.Controls.Add(this.btlim);
            this.Controls.Add(this.btnbusque);
            this.Controls.Add(this.txtbusque);
            this.Controls.Add(this.cboBusqueda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbactivo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtcorreopro);
            this.Controls.Add(this.txtladapro);
            this.Controls.Add(this.txtnnumpro);
            this.Controls.Add(this.txtnombrepro);
            this.Controls.Add(this.txtidpro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jlbfrom);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label jlbfrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtidpro;
        private System.Windows.Forms.TextBox txtnombrepro;
        private System.Windows.Forms.TextBox txtnnumpro;
        private System.Windows.Forms.TextBox txtladapro;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btneditar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbactivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.TextBox txtbusque;
        private FontAwesome.Sharp.IconButton btnbusque;
        private FontAwesome.Sharp.IconButton btlim;
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
        private System.Windows.Forms.RadioButton rbnoact;
        public System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton Limpia;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox txtcorreopro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridViewButtonColumn selec;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomb;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCont;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn LadaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoElec;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activ;
    }
}