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
using System.Runtime.InteropServices;

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

        Conexion coBD = new Conexion();

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                bool res = coBD.AutenticarUsuarios(txtUss.Text, txtPass.Text);
                if (res)
                {
                    GUI miform2 = new GUI();
                    this.Hide();
                    miform2.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Verificar Usuario y contrtaseña", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUss.Focus();

                }
            }
            catch(Exception ex)
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
            //this.tbUsuariosTableAdapter.Fill(this.db.tbUsuarios);

           
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
    }
}
