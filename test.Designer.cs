﻿namespace LoginCRUMAR
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
            this.tbClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbEmpresaWXDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbEmpresaWXDataSet = new LoginCRUMAR.dbEmpresaWXDataSet();
            this.tbClientesTableAdapter = new LoginCRUMAR.dbEmpresaWXDataSetTableAdapters.tbClientesTableAdapter();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbIdUssE = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.rbActivoSA = new System.Windows.Forms.RadioButton();
            this.btnActuAct = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUserAct = new System.Windows.Forms.TextBox();
            this.btnBuscarAct = new System.Windows.Forms.Button();
            this.rbActivoNA = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellidoAct = new System.Windows.Forms.TextBox();
            this.txtContraAct = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreAct = new System.Windows.Forms.TextBox();
            this.txtUssAct = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmpresaWXDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmpresaWXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbClientesBindingSource
            // 
            this.tbClientesBindingSource.DataMember = "tbClientes";
            this.tbClientesBindingSource.DataSource = this.dbEmpresaWXDataSetBindingSource;
            // 
            // dbEmpresaWXDataSetBindingSource
            // 
            this.dbEmpresaWXDataSetBindingSource.DataSource = this.dbEmpresaWXDataSet;
            this.dbEmpresaWXDataSetBindingSource.Position = 0;
            // 
            // dbEmpresaWXDataSet
            // 
            this.dbEmpresaWXDataSet.DataSetName = "dbEmpresaWXDataSet";
            this.dbEmpresaWXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbClientesTableAdapter
            // 
            this.tbClientesTableAdapter.ClearBeforeFill = true;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 271);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(566, 310);
            this.dgvUsuarios.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(134, 124);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(294, 36);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Cargar datos";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(9, 95);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 3;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(9, 148);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Usuario";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(141, 99);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(100, 20);
            this.tbUser.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contraseña";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(141, 148);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(100, 20);
            this.tbPass.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(58, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Agregar Usuario";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Location = new System.Drawing.Point(177, 29);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(55, 17);
            this.rbActivo.TabIndex = 16;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(153, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(252, 36);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Eliminar Usuario";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(6, 29);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 18;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(580, 610);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tabPage1.Controls.Add(this.iconButton1);
            this.tabPage1.Controls.Add(this.btnConsultar);
            this.tabPage1.Controls.Add(this.dgvUsuarios);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(572, 584);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consultar";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtId);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Controls.Add(this.rbActivo);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tbLastName);
            this.tabPage2.Controls.Add(this.tbPass);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbName);
            this.tabPage2.Controls.Add(this.tbUser);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(572, 584);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Insertar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tabPage3.Controls.Add(this.tbIdUssE);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.btnDelete);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(572, 584);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar";
            // 
            // tbIdUssE
            // 
            this.tbIdUssE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tbIdUssE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIdUssE.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdUssE.ForeColor = System.Drawing.Color.Black;
            this.tbIdUssE.Location = new System.Drawing.Point(153, 137);
            this.tbIdUssE.Name = "tbIdUssE";
            this.tbIdUssE.Size = new System.Drawing.Size(252, 26);
            this.tbIdUssE.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(235, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Id del usuario";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Silver;
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.rbActivoSA);
            this.tabPage4.Controls.Add(this.btnActuAct);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.txtUserAct);
            this.tabPage4.Controls.Add(this.btnBuscarAct);
            this.tabPage4.Controls.Add(this.rbActivoNA);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.txtApellidoAct);
            this.tabPage4.Controls.Add(this.txtContraAct);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.txtNombreAct);
            this.tabPage4.Controls.Add(this.txtUssAct);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(572, 584);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Actualizar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(256, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Activo";
            // 
            // rbActivoSA
            // 
            this.rbActivoSA.AutoSize = true;
            this.rbActivoSA.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActivoSA.ForeColor = System.Drawing.Color.Black;
            this.rbActivoSA.Location = new System.Drawing.Point(291, 248);
            this.rbActivoSA.Name = "rbActivoSA";
            this.rbActivoSA.Size = new System.Drawing.Size(48, 24);
            this.rbActivoSA.TabIndex = 30;
            this.rbActivoSA.TabStop = true;
            this.rbActivoSA.Text = "No";
            this.rbActivoSA.UseVisualStyleBackColor = true;
            // 
            // btnActuAct
            // 
            this.btnActuAct.BackColor = System.Drawing.Color.DimGray;
            this.btnActuAct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActuAct.FlatAppearance.BorderSize = 0;
            this.btnActuAct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnActuAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActuAct.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActuAct.ForeColor = System.Drawing.Color.Black;
            this.btnActuAct.Location = new System.Drawing.Point(96, 370);
            this.btnActuAct.Name = "btnActuAct";
            this.btnActuAct.Size = new System.Drawing.Size(338, 34);
            this.btnActuAct.TabIndex = 29;
            this.btnActuAct.Text = "Actualizar Usuario";
            this.btnActuAct.UseVisualStyleBackColor = false;
            this.btnActuAct.Click += new System.EventHandler(this.btnActuAct_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Usuario";
            // 
            // txtUserAct
            // 
            this.txtUserAct.BackColor = System.Drawing.Color.White;
            this.txtUserAct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserAct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserAct.ForeColor = System.Drawing.Color.Black;
            this.txtUserAct.Location = new System.Drawing.Point(82, 30);
            this.txtUserAct.Name = "txtUserAct";
            this.txtUserAct.Size = new System.Drawing.Size(141, 26);
            this.txtUserAct.TabIndex = 27;
            // 
            // btnBuscarAct
            // 
            this.btnBuscarAct.Location = new System.Drawing.Point(280, 33);
            this.btnBuscarAct.Name = "btnBuscarAct";
            this.btnBuscarAct.Size = new System.Drawing.Size(126, 23);
            this.btnBuscarAct.TabIndex = 25;
            this.btnBuscarAct.Text = "Buscar Usuario";
            this.btnBuscarAct.UseVisualStyleBackColor = true;
            this.btnBuscarAct.Click += new System.EventHandler(this.btnBuscarAct_Click);
            // 
            // rbActivoNA
            // 
            this.rbActivoNA.AutoSize = true;
            this.rbActivoNA.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActivoNA.ForeColor = System.Drawing.Color.Black;
            this.rbActivoNA.Location = new System.Drawing.Point(248, 248);
            this.rbActivoNA.Name = "rbActivoNA";
            this.rbActivoNA.Size = new System.Drawing.Size(37, 24);
            this.rbActivoNA.TabIndex = 26;
            this.rbActivoNA.TabStop = true;
            this.rbActivoNA.Text = "Si";
            this.rbActivoNA.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(296, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Contraseña";
            // 
            // txtApellidoAct
            // 
            this.txtApellidoAct.BackColor = System.Drawing.Color.White;
            this.txtApellidoAct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidoAct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoAct.ForeColor = System.Drawing.Color.Black;
            this.txtApellidoAct.Location = new System.Drawing.Point(164, 184);
            this.txtApellidoAct.Name = "txtApellidoAct";
            this.txtApellidoAct.Size = new System.Drawing.Size(100, 26);
            this.txtApellidoAct.TabIndex = 18;
            // 
            // txtContraAct
            // 
            this.txtContraAct.BackColor = System.Drawing.Color.White;
            this.txtContraAct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraAct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraAct.ForeColor = System.Drawing.Color.Black;
            this.txtContraAct.Location = new System.Drawing.Point(291, 184);
            this.txtContraAct.Name = "txtContraAct";
            this.txtContraAct.Size = new System.Drawing.Size(100, 26);
            this.txtContraAct.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Usuario";
            // 
            // txtNombreAct
            // 
            this.txtNombreAct.BackColor = System.Drawing.Color.White;
            this.txtNombreAct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreAct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAct.ForeColor = System.Drawing.Color.Black;
            this.txtNombreAct.Location = new System.Drawing.Point(164, 124);
            this.txtNombreAct.Name = "txtNombreAct";
            this.txtNombreAct.Size = new System.Drawing.Size(126, 26);
            this.txtNombreAct.TabIndex = 17;
            // 
            // txtUssAct
            // 
            this.txtUssAct.BackColor = System.Drawing.Color.White;
            this.txtUssAct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUssAct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUssAct.ForeColor = System.Drawing.Color.Black;
            this.txtUssAct.Location = new System.Drawing.Point(71, 222);
            this.txtUssAct.Name = "txtUssAct";
            this.txtUssAct.Size = new System.Drawing.Size(100, 26);
            this.txtUssAct.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(164, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(164, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Apellidos";
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(294, 217);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 23);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Editar";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(580, 610);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Principal";
            this.Text = "frm_Principal";
            this.Load += new System.EventHandler(this.frm_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmpresaWXDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmpresaWXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dbEmpresaWXDataSetBindingSource;
        private dbEmpresaWXDataSet dbEmpresaWXDataSet;
        private System.Windows.Forms.BindingSource tbClientesBindingSource;
        private dbEmpresaWXDataSetTableAdapters.tbClientesTableAdapter tbClientesTableAdapter;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnActuAct;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUserAct;
        private System.Windows.Forms.Button btnBuscarAct;
        private System.Windows.Forms.RadioButton rbActivoNA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApellidoAct;
        private System.Windows.Forms.TextBox txtContraAct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreAct;
        private System.Windows.Forms.TextBox txtUssAct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbIdUssE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbActivoSA;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}