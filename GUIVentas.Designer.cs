namespace LoginCRUMAR
{
    partial class GUIVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIVentas));
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.menuVertical = new System.Windows.Forms.Panel();
            this.btnUser = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnventas = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelPerfil = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            this.menuVertical.SuspendLayout();
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
            this.barraTitulo.Size = new System.Drawing.Size(924, 41);
            this.barraTitulo.TabIndex = 0;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(818, 0);
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
            this.btnCerrar.Location = new System.Drawing.Point(890, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 32);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(854, 0);
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
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(854, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(30, 41);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 1;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.Black;
            this.menuVertical.Controls.Add(this.panelPerfil);
            this.menuVertical.Controls.Add(this.btnUser);
            this.menuVertical.Controls.Add(this.panel1);
            this.menuVertical.Controls.Add(this.btnventas);
            this.menuVertical.Controls.Add(this.btnInicio);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 41);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(220, 484);
            this.menuVertical.TabIndex = 1;
            // 
            // btnUser
            // 
            this.btnUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUser.BackColor = System.Drawing.Color.Black;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUser.IconSize = 45;
            this.btnUser.Location = new System.Drawing.Point(12, 425);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(48, 47);
            this.btnUser.TabIndex = 8;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 33);
            this.panel1.TabIndex = 2;
            // 
            // btnventas
            // 
            this.btnventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnventas.FlatAppearance.BorderSize = 0;
            this.btnventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnventas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventas.ForeColor = System.Drawing.Color.White;
            this.btnventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnventas.Location = new System.Drawing.Point(0, 124);
            this.btnventas.Name = "btnventas";
            this.btnventas.Size = new System.Drawing.Size(220, 33);
            this.btnventas.TabIndex = 1;
            this.btnventas.Text = "Ventas";
            this.btnventas.UseVisualStyleBackColor = false;
            this.btnventas.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.Location = new System.Drawing.Point(12, 6);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(208, 92);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicio.TabIndex = 0;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(220, 41);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(704, 484);
            this.panelContenedor.TabIndex = 2;
            // 
            // panelPerfil
            // 
            this.panelPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelPerfil.Controls.Add(this.panel9);
            this.panelPerfil.Controls.Add(this.btnCerrarSesion);
            this.panelPerfil.Controls.Add(this.panel10);
            this.panelPerfil.Controls.Add(this.button2);
            this.panelPerfil.Location = new System.Drawing.Point(62, 415);
            this.panelPerfil.Name = "panelPerfil";
            this.panelPerfil.Size = new System.Drawing.Size(152, 64);
            this.panelPerfil.TabIndex = 14;
            this.panelPerfil.Visible = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel9.Location = new System.Drawing.Point(136, 34);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 29);
            this.panel9.TabIndex = 11;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.AutoSize = true;
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(3, 34);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(143, 29);
            this.btnCerrarSesion.TabIndex = 10;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel10.Location = new System.Drawing.Point(136, 1);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 28);
            this.panel10.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
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
            // GUIVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(924, 525);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUIVentas";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI";
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            this.menuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.panelPerfil.ResumeLayout(false);
            this.panelPerfil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.PictureBox btnInicio;
        private System.Windows.Forms.Button btnventas;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnUser;
        private System.Windows.Forms.Panel panelPerfil;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button2;
        //private dbEmpresaWXDataSetTableAdapters.vendedores_EsteTableAdapter vendedores_EsteTableAdapter1;
        //private dbEmpresaWXDataSetTableAdapters.vendedores_EsteTableAdapter vendedores_EsteTableAdapter2;
    }
}