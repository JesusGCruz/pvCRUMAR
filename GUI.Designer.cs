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
            this.btnAgregarP = new FontAwesome.Sharp.IconButton();
            this.btnEditarP = new FontAwesome.Sharp.IconButton();
            this.EliminarP = new FontAwesome.Sharp.IconButton();
            this.btnBusquedaP = new FontAwesome.Sharp.IconButton();
            this.btnpe = new FontAwesome.Sharp.IconButton();
            this.panbtnpro = new System.Windows.Forms.FlowLayoutPanel();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btnbus = new FontAwesome.Sharp.IconButton();
            this.btneditar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnpro = new FontAwesome.Sharp.IconButton();
            this.panbtnin = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnBuscarP = new FontAwesome.Sharp.IconButton();
            this.btnin = new FontAwesome.Sharp.IconButton();
            this.panbtnem = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelPerfil = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            this.menuVertical.SuspendLayout();
            this.panbtnpe.SuspendLayout();
            this.panbtnpro.SuspendLayout();
            this.panbtnin.SuspendLayout();
            this.panbtnem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.panelPerfil.SuspendLayout();
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
            this.menuVertical.Controls.Add(this.panelPerfil);
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
            this.menuVertical.Size = new System.Drawing.Size(192, 500);
            this.menuVertical.TabIndex = 1;
            this.menuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.menuVertical_Paint);
            // 
            // btnUser
            // 
            this.btnUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUser.IconSize = 45;
            this.btnUser.Location = new System.Drawing.Point(2, 424);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(59, 54);
            this.btnUser.TabIndex = 8;
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(2, 92);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnve.Location = new System.Drawing.Point(0, 783);
            this.btnve.Name = "btnve";
            this.btnve.Size = new System.Drawing.Size(192, 45);
            this.btnve.TabIndex = 1;
            this.btnve.Text = "Venta";
            this.btnve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnve.UseVisualStyleBackColor = true;
            this.btnve.Click += new System.EventHandler(this.btnve_Click);
            // 
            // panbtnpe
            // 
            this.panbtnpe.Controls.Add(this.btnAgregarP);
            this.panbtnpe.Controls.Add(this.btnEditarP);
            this.panbtnpe.Controls.Add(this.EliminarP);
            this.panbtnpe.Controls.Add(this.btnBusquedaP);
            this.panbtnpe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panbtnpe.Location = new System.Drawing.Point(0, 634);
            this.panbtnpe.Margin = new System.Windows.Forms.Padding(2);
            this.panbtnpe.Name = "panbtnpe";
            this.panbtnpe.Size = new System.Drawing.Size(192, 149);
            this.panbtnpe.TabIndex = 61;
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAgregarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarP.FlatAppearance.BorderSize = 0;
            this.btnAgregarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAgregarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarP.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarP.ForeColor = System.Drawing.Color.LightGray;
            this.btnAgregarP.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAgregarP.IconColor = System.Drawing.Color.White;
            this.btnAgregarP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarP.IconSize = 30;
            this.btnAgregarP.Location = new System.Drawing.Point(2, 2);
            this.btnAgregarP.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(167, 33);
            this.btnAgregarP.TabIndex = 33;
            this.btnAgregarP.Text = "Agregar Pedido";
            this.btnAgregarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarP.UseVisualStyleBackColor = false;
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click);
            // 
            // btnEditarP
            // 
            this.btnEditarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEditarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditarP.FlatAppearance.BorderSize = 0;
            this.btnEditarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarP.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarP.ForeColor = System.Drawing.Color.LightGray;
            this.btnEditarP.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarP.IconColor = System.Drawing.Color.White;
            this.btnEditarP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarP.IconSize = 30;
            this.btnEditarP.Location = new System.Drawing.Point(2, 39);
            this.btnEditarP.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarP.Name = "btnEditarP";
            this.btnEditarP.Size = new System.Drawing.Size(167, 33);
            this.btnEditarP.TabIndex = 35;
            this.btnEditarP.Text = "Editar Pedido";
            this.btnEditarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarP.UseVisualStyleBackColor = false;
            this.btnEditarP.Click += new System.EventHandler(this.btnEditarP_Click);
            // 
            // EliminarP
            // 
            this.EliminarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.EliminarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliminarP.Dock = System.Windows.Forms.DockStyle.Top;
            this.EliminarP.FlatAppearance.BorderSize = 0;
            this.EliminarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.EliminarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EliminarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarP.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarP.ForeColor = System.Drawing.Color.LightGray;
            this.EliminarP.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.EliminarP.IconColor = System.Drawing.Color.White;
            this.EliminarP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EliminarP.IconSize = 30;
            this.EliminarP.Location = new System.Drawing.Point(2, 76);
            this.EliminarP.Margin = new System.Windows.Forms.Padding(2);
            this.EliminarP.Name = "EliminarP";
            this.EliminarP.Size = new System.Drawing.Size(175, 33);
            this.EliminarP.TabIndex = 37;
            this.EliminarP.Text = "Eliminar Pedido";
            this.EliminarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarP.UseVisualStyleBackColor = false;
            this.EliminarP.Click += new System.EventHandler(this.EliminarP_Click);
            // 
            // btnBusquedaP
            // 
            this.btnBusquedaP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBusquedaP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusquedaP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBusquedaP.FlatAppearance.BorderSize = 0;
            this.btnBusquedaP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBusquedaP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBusquedaP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusquedaP.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaP.ForeColor = System.Drawing.Color.LightGray;
            this.btnBusquedaP.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBusquedaP.IconColor = System.Drawing.Color.White;
            this.btnBusquedaP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBusquedaP.IconSize = 30;
            this.btnBusquedaP.Location = new System.Drawing.Point(2, 113);
            this.btnBusquedaP.Margin = new System.Windows.Forms.Padding(2);
            this.btnBusquedaP.Name = "btnBusquedaP";
            this.btnBusquedaP.Size = new System.Drawing.Size(167, 33);
            this.btnBusquedaP.TabIndex = 43;
            this.btnBusquedaP.Text = "Busqueda de Pedido";
            this.btnBusquedaP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusquedaP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBusquedaP.UseVisualStyleBackColor = false;
            this.btnBusquedaP.Click += new System.EventHandler(this.btnBusquedaP_Click);
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
            this.btnpe.Location = new System.Drawing.Point(0, 591);
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
            this.panbtnpro.Location = new System.Drawing.Point(0, 444);
            this.panbtnpro.Margin = new System.Windows.Forms.Padding(2);
            this.panbtnpro.Name = "panbtnpro";
            this.panbtnpro.Size = new System.Drawing.Size(192, 147);
            this.panbtnpro.TabIndex = 61;
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
            this.btnguardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(192, 33);
            this.btnguardar.TabIndex = 54;
            this.btnguardar.Text = "Ingresar Proveedor";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
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
            this.btnbus.Margin = new System.Windows.Forms.Padding(2);
            this.btnbus.Name = "btnbus";
            this.btnbus.Size = new System.Drawing.Size(192, 33);
            this.btnbus.TabIndex = 57;
            this.btnbus.Text = "Buscar Proveedor";
            this.btnbus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbus.UseVisualStyleBackColor = false;
            this.btnbus.Click += new System.EventHandler(this.btnbus_Click);
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
            this.btneditar.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnpro.Location = new System.Drawing.Point(0, 398);
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
            this.panbtnin.Controls.Add(this.iconButton4);
            this.panbtnin.Controls.Add(this.btnActualizar);
            this.panbtnin.Controls.Add(this.iconButton3);
            this.panbtnin.Controls.Add(this.btnBuscarP);
            this.panbtnin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panbtnin.Location = new System.Drawing.Point(0, 250);
            this.panbtnin.Margin = new System.Windows.Forms.Padding(2);
            this.panbtnin.Name = "panbtnin";
            this.panbtnin.Size = new System.Drawing.Size(192, 148);
            this.panbtnin.TabIndex = 61;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.iconButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.LightGray;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.Location = new System.Drawing.Point(2, 2);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(156, 33);
            this.iconButton4.TabIndex = 33;
            this.iconButton4.Text = "Agregar Producto";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.LightGray;
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnActualizar.IconColor = System.Drawing.Color.White;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 30;
            this.btnActualizar.Location = new System.Drawing.Point(2, 39);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(156, 33);
            this.btnActualizar.TabIndex = 35;
            this.btnActualizar.Text = "Editar Producto";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.iconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.LightGray;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.Location = new System.Drawing.Point(2, 76);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(156, 33);
            this.iconButton3.TabIndex = 37;
            this.iconButton3.Text = "Eliminar Producto";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click_1);
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBuscarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarP.FlatAppearance.BorderSize = 0;
            this.btnBuscarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBuscarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarP.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarP.ForeColor = System.Drawing.Color.LightGray;
            this.btnBuscarP.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarP.IconColor = System.Drawing.Color.White;
            this.btnBuscarP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarP.IconSize = 30;
            this.btnBuscarP.Location = new System.Drawing.Point(2, 113);
            this.btnBuscarP.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(156, 33);
            this.btnBuscarP.TabIndex = 39;
            this.btnBuscarP.Text = "Busqueda de Producto";
            this.btnBuscarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarP.UseVisualStyleBackColor = false;
            this.btnBuscarP.Click += new System.EventHandler(this.btnBuscarP_Click);
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
            this.panbtnem.Margin = new System.Windows.Forms.Padding(2);
            this.panbtnem.Name = "panbtnem";
            this.panbtnem.Size = new System.Drawing.Size(192, 67);
            this.panbtnem.TabIndex = 61;
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
            this.panelContenedor.Size = new System.Drawing.Size(608, 500);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // panelPerfil
            // 
            this.panelPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelPerfil.Controls.Add(this.panel7);
            this.panelPerfil.Controls.Add(this.btnCerrarSesion);
            this.panelPerfil.Controls.Add(this.panel8);
            this.panelPerfil.Controls.Add(this.button2);
            this.panelPerfil.Location = new System.Drawing.Point(55, 424);
            this.panelPerfil.Name = "panelPerfil";
            this.panelPerfil.Size = new System.Drawing.Size(152, 64);
            this.panelPerfil.TabIndex = 13;
            this.panelPerfil.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel7.Location = new System.Drawing.Point(136, 34);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 29);
            this.panel7.TabIndex = 11;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.AutoSize = true;
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(3, 34);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(146, 29);
            this.btnCerrarSesion.TabIndex = 10;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel8.Location = new System.Drawing.Point(136, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 28);
            this.panel8.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Editar Perfil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 541);
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
            this.panbtnpe.ResumeLayout(false);
            this.panbtnpro.ResumeLayout(false);
            this.panbtnin.ResumeLayout(false);
            this.panbtnem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.panelPerfil.ResumeLayout(false);
            this.panelPerfil.PerformLayout();
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
        private FontAwesome.Sharp.IconButton btnbus;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnve;
        private FontAwesome.Sharp.IconButton btnpe;
        private System.Windows.Forms.FlowLayoutPanel panbtnpro;
        private FontAwesome.Sharp.IconButton btnpro;
        private System.Windows.Forms.FlowLayoutPanel panbtnin;
        private FontAwesome.Sharp.IconButton btnin;
        private System.Windows.Forms.FlowLayoutPanel panbtnem;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.FlowLayoutPanel panbtnpe;
        private FontAwesome.Sharp.IconButton btnAgregarP;
        private FontAwesome.Sharp.IconButton btnEditarP;
        private FontAwesome.Sharp.IconButton EliminarP;
        private FontAwesome.Sharp.IconButton btnBusquedaP;
        private System.Windows.Forms.Panel panelContenedor;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnBuscarP;
        private System.Windows.Forms.Panel panelPerfil;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button2;
    }
}