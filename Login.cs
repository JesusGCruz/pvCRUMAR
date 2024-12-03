using Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginCRUMAR
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void label1_Click(object sender, EventArgs e)
        {

        }

        ConexionUsuarios coBD = new ConexionUsuarios();

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int rol = coBD.AutenticarUsuarios(txtUss.Text, txtPass.Text);
                if (rol == 0)
                {
                    MessageBox.Show("Verificar Usuario y/o contraseña", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUss.Focus();
                }
                else if (rol == 1)
                {
                    MessageBox.Show("Bienvenido Admin", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //GUI gui = new GUI(txtUss.Text);
                    GUI gui = new GUI();
                    this.Hide();
                    gui.ShowDialog();
                }
                else if (rol == 2)
                {
                    MessageBox.Show("Bienvenido Cajero", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (rol == 3)
                {
                    MessageBox.Show("Bienvenido Capturista", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    GUIProductos gui = new GUIProductos(txtUss.Text);
                    this.Hide();
                    gui.ShowDialog();
                }
                else if (rol == 4)
                {
                    MessageBox.Show("Bienvenido Repositor", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    GUIRep gui = new GUIRep(txtUss.Text);
                    this.Hide();
                    gui.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbEmpresaWXDataSet1.tbUsuarios' Puede moverla o quitarla según sea necesario.
            //this.tbUsuariosTableAdapter.Fill(this.dbEmpresaWXDataSet1.tbUsuarios);

        }

        private void uss_Enter(object sender, EventArgs e)
        {
            if (txtUss.Text == "Usuario")
            {
                txtUss.Text = "";
                txtUss.ForeColor = Color.LightGray;
            }
        }

        private void txtUss_Leave(object sender, EventArgs e)
        {
            if (txtUss.Text == "")
            {
                txtUss.Text = "Usuario";
                txtUss.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Enter acceder
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();

            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();

            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lBtnEye_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar)
            {
                txtPass.UseSystemPasswordChar = false;
                lBtnEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }else if(txtPass.Text != "Contraseña")
            {
                txtPass.UseSystemPasswordChar = true;
                lBtnEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Pues acuerdate");
        }
    }
}
