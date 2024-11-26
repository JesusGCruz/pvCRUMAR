using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LoginCRUMAR
{
    public partial class GUI : Form
    {
        static private string usuario;
        public GUI(string uss)
        {
            InitializeComponent();
            abrirFormHija(new inicio());
            usuario = uss;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMax.Visible = true;
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();

            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (subMenuEliminar.Visible == false)
            {
                subMenuEliminar.Visible = true;
            }
            else
            {
                subMenuEliminar.Visible = false;
            }
        }

        private void btnDeleteUs_Click(object sender, EventArgs e)
        {
            subMenuEliminar.Visible = false;
        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            subMenuEliminar.Visible = false;
            
        }

        private void abrirFormHija(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //abrirFormHija(new test());
            abrirFormHija(new GestionarUsuarios());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            abrirFormHija(new inicio());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            if (panelPerfil.Visible == false)
            {
                panelPerfil.Visible = true;
            }
            else
            {
                panelPerfil.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //abrirFormHija(new EditarUsuarios());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelPerfil.Visible = false;
            abrirFormHija(new Perfil(usuario));
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cerrar sesión en su perfil?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login();
                this.Hide();
                login.ShowDialog();
            }
            else
            {
                panelPerfil.Visible = false;
            }
        }
    }
}
