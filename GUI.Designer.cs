namespace LoginCRUMAR
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.menuVertical = new System.Windows.Forms.Panel();
            this.btnUser = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnve = new FontAwesome.Sharp.IconButton();
            this.panbtnpe = new System.Windows.Forms.FlowLayoutPanel();
            this.btnpe = new FontAwesome.Sharp.IconButton();
            this.panbtnpro = new System.Windows.Forms.FlowLayoutPanel();
            this.btnbus = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btneditar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnpro = new FontAwesome.Sharp.IconButton();
            this.panbtnin = new System.Windows.Forms.FlowLayoutPanel();
            this.btnin = new FontAwesome.Sharp.IconButton();
            this.panbtnem = new System.Windows.Forms.FlowLayoutPanel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            this.menuVertical.SuspendLayout();
            this.panbtnpro.SuspendLayout();
            this.panbtnem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.barraTitulo.Controls.Add(this.btnMin);
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Controls.Add(this.btnRestaurar);
            this.barraTitulo.Controls.Add(this.btnMax);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(800, 41);
            this.barraTitulo.TabIndex = 0;
            this.barraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.barraTitulo_Paint);
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Image = global::LoginCRUMAR.Properties.Resources.forbidden_497830;
            this.btnMin.Location = new System.Drawing.Point(695, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 41);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 2;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(767, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 32);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Image = global::LoginCRUMAR.Properties.Resources.exclude_1014931;
            this.btnRestaurar.Location = new System.Drawing.Point(731, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(30, 41);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Image = global::LoginCRUMAR.Properties.Resources.maximize;
            this.btnMax.Location = new System.Drawing.Point(731, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(30, 41);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 1;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuVertical.Controls.Add(this.btnUser);
            this.menuVertical.Controls.Add(this.panel2);
            this.menuVertical.Controls.Add(this.btnve);
            this.menuVertical.Controls.Add(this.panbtnpe);
            this.menuVertical.Controls.Add(this.btnpe);
            this.menuVertical.Controls.Add(this.panbtnpro);
            this.menuVertical.Controls.Add(this.btnpro);
            this.menuVertical.Controls.Add(this.panbtnin);
            this.menuVertical.Controls.Add(this.btnin);
            this.menuVertical.Controls.Add(this.panbtnem);
            this.menuVertical.Controls.Add(this.btnInsert);
            this.menuVertical.Controls.Add(this.btnInicio);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 41);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(192, 484);
            this.menuVertical.TabIndex = 1;
            this.menuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.menuVertical_Paint);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUser.IconSize = 45;
            this.btnUser.Location = new System.Drawing.Point(21, 619);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(67, 63);
            this.btnUser.TabIndex = 8;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(2, 92);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 47);
            this.panel2.TabIndex = 1;
            // 
            // btnve
            // 
            this.btnve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnve.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnve.FlatAppearance.BorderSize = 0;
            this.btnve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnve.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.btnve.ForeColor = System.Drawing.Color.White;
            this.btnve.IconChar = FontAwesome.Sharp.IconChar.BasketShopping;
            this.btnve.IconColor = System.Drawing.Color.White;
            this.btnve.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnve.IconSize = 32;
            this.btnve.Location = new System.Drawing.Point(0, 620);
            this.btnve.Name = "btnve";
            this.btnve.Size = new System.Drawing.Size(192, 45);
            this.btnve.TabIndex = 1;
            this.btnve.Text = "Venta";
            this.btnve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnve.UseVisualStyleBackColor = true;
            // 
            // panbtnpe
            // 
            this.panbtnpe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panbtnpe.Location = new System.Drawing.Point(0, 553);
            this.panbtnpe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panbtnpe.Name = "panbtnpe";
            this.panbtnpe.Size = new System.Drawing.Size(192, 67);
            this.panbtnpe.TabIndex = 61;
            // 
            // btnpe
            // 
            this.btnpe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnpe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnpe.FlatAppearance.BorderSize = 0;
            this.btnpe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnpe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpe.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.btnpe.ForeColor = System.Drawing.Color.White;
            this.btnpe.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.btnpe.IconColor = System.Drawing.Color.White;
            this.btnpe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnpe.IconSize = 32;
            this.btnpe.Location = new System.Drawing.Point(0, 510);
            this.btnpe.Name = "btnpe";
            this.btnpe.Size = new System.Drawing.Size(192, 43);
            this.btnpe.TabIndex = 1;
            this.btnpe.Text = "Pedidos";
            this.btnpe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpe.UseVisualStyleBackColor = true;
            this.btnpe.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // panbtnpro
            // 
            this.panbtnpro.Controls.Add(this.btnguardar);
            this.panbtnpro.Controls.Add(this.btnbus);
            this.panbtnpro.Controls.Add(this.btneditar);
            this.panbtnpro.Controls.Add(this.btnEliminar);
            this.panbtnpro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panbtnpro.Location = new System.Drawing.Point(0, 363);
            this.panbtnpro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panbtnpro.Name = "panbtnpro";
            this.panbtnpro.Size = new System.Drawing.Size(192, 147);
            this.panbtnpro.TabIndex = 61;
            // 
            // btnbus
            // 
            this.btnbus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.btnbus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnbus.FlatAppearance.BorderSize = 0;
            this.btnbus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnbus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnbus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbus.Font = new System.Drawing.Font("Century Gothic", 9.2F);
            this.btnbus.ForeColor = System.Drawing.Color.White;
            this.btnbus.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbus.IconColor = System.Drawing.Color.White;
            this.btnbus.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnbus.IconSize = 20;
            this.btnbus.Location = new System.Drawing.Point(2, 39);
            this.btnbus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnbus.Name = "btnbus";
            this.btnbus.Size = new System.Drawing.Size(192, 33);
            this.btnbus.TabIndex = 57;
            this.btnbus.Text = "Buscar Proveedor";
            this.btnbus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbus.UseVisualStyleBackColor = false;
            this.btnbus.Click += new System.EventHandler(this.btnbus_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Century Gothic", 9.2F);
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            this.btnguardar.IconColor = System.Drawing.Color.White;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnguardar.IconSize = 20;
            this.btnguardar.Location = new System.Drawing.Point(2, 2);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(192, 33);
            this.btnguardar.TabIndex = 54;
            this.btnguardar.Text = "Ingresar Proveedor";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btneditar.FlatAppearance.BorderSize = 0;
            this.btneditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btneditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Font = new System.Drawing.Font("Century Gothic", 9.2F);
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btneditar.IconColor = System.Drawing.Color.White;
            this.btneditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneditar.IconSize = 20;
            this.btneditar.Location = new System.Drawing.Point(2, 76);
            this.btneditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(192, 33);
            this.btneditar.TabIndex = 55;
            this.btneditar.Text = "Editar Informacion";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.2F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 20;
            this.btnEliminar.Location = new System.Drawing.Point(2, 113);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(192, 33);
            this.btnEliminar.TabIndex = 56;
            this.btnEliminar.Text = "Eliminar Proveedor";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnpro
            // 
            this.btnpro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnpro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnpro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnpro.FlatAppearance.BorderSize = 0;
            this.btnpro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnpro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpro.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.btnpro.ForeColor = System.Drawing.Color.White;
            this.btnpro.IconChar = FontAwesome.Sharp.IconChar.TruckArrowRight;
            this.btnpro.IconColor = System.Drawing.Color.White;
            this.btnpro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnpro.IconSize = 32;
            this.btnpro.Location = new System.Drawing.Point(0, 317);
            this.btnpro.Name = "btnpro";
            this.btnpro.Size = new System.Drawing.Size(192, 46);
            this.btnpro.TabIndex = 1;
            this.btnpro.Text = "Proveedores";
            this.btnpro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpro.UseVisualStyleBackColor = true;
            this.btnpro.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // panbtnin
            // 
            this.panbtnin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panbtnin.Location = new System.Drawing.Point(0, 250);
            this.panbtnin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panbtnin.Name = "panbtnin";
            this.panbtnin.Size = new System.Drawing.Size(192, 67);
            this.panbtnin.TabIndex = 61;
            // 
            // btnin
            // 
            this.btnin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnin.FlatAppearance.BorderSize = 0;
            this.btnin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnin.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.btnin.ForeColor = System.Drawing.Color.Transparent;
            this.btnin.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.btnin.IconColor = System.Drawing.Color.White;
            this.btnin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnin.IconSize = 32;
            this.btnin.Location = new System.Drawing.Point(0, 206);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(192, 44);
            this.btnin.TabIndex = 1;
            this.btnin.Text = "Inventario";
            this.btnin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panbtnem
            // 
            this.panbtnem.Controls.Add(this.iconButton2);
            this.panbtnem.Controls.Add(this.iconButton1);
            this.panbtnem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panbtnem.Location = new System.Drawing.Point(0, 139);
            this.panbtnem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panbtnem.Name = "panbtnem";
            this.panbtnem.Size = new System.Drawing.Size(192, 67);
            this.panbtnem.TabIndex = 61;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.Location = new System.Drawing.Point(0, 92);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(192, 47);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Empleados";
            this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.Image = global::LoginCRUMAR.Properties.Resources.LogoCRUMAR;
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(192, 92);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicio.TabIndex = 0;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(192, 41);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(608, 484);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 9.2F);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(2, 39);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(192, 33);
            this.iconButton1.TabIndex = 59;
            this.iconButton1.Text = "Buscar Empleado";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Century Gothic", 9.2F);
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(2, 2);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(192, 33);
            this.iconButton2.TabIndex = 58;
            this.iconButton2.Text = "Ingresar Empleado";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click_1);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            this.menuVertical.ResumeLayout(false);
            this.panbtnpro.ResumeLayout(false);
            this.panbtnem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.PictureBox btnInicio;
        private System.Windows.Forms.Button btnInsert;
        private FontAwesome.Sharp.IconButton btnUser;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btneditar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.Panel panelContenedor;
        private FontAwesome.Sharp.IconButton btnbus;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnve;
        private System.Windows.Forms.FlowLayoutPanel panbtnpe;
        private FontAwesome.Sharp.IconButton btnpe;
        private System.Windows.Forms.FlowLayoutPanel panbtnpro;
        private FontAwesome.Sharp.IconButton btnpro;
        private System.Windows.Forms.FlowLayoutPanel panbtnin;
        private FontAwesome.Sharp.IconButton btnin;
        private System.Windows.Forms.FlowLayoutPanel panbtnem;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}