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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Documents;
using System.Xml.Linq;


namespace LoginCRUMAR
{
    public partial class GUIProductos : Form
    {
        private int originalInventarioY = 234;
        private int panelHeight = 181;
        private bool panelVisible = false;
        private int animationSpeed = 20;
        private string usuario;
 
        public GUIProductos()
        {
            InitializeComponent();
            abrirFormHija(new inicio());
        }

        public GUIProductos(string usuario)
        {
            InitializeComponent();
            abrirFormHija(new inicio());
            this.usuario = usuario;
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
            this.WindowState = FormWindowState.Minimized;
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

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    if (subMenuEliminar.Visible == false)
        //    {
        //        subMenuEliminar.Visible = true;
        //    }
        //    else
        //    {
        //        subMenuEliminar.Visible = false;
        //    }
        //}

        //private void btnDeleteUs_Click(object sender, EventArgs e)
        //{
        //    subMenuEliminar.Visible = false;
        //}

        //private void btnDeleteData_Click(object sender, EventArgs e)
        //{
        //    subMenuEliminar.Visible = false;
        //}

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

        private void bajarbtoton()
        {
            
            if (!panelVisible)
            {
                
                pMenuProductos.Visible = true;

               
                while (btnInventario.Location.Y < originalInventarioY + panelHeight)
                {
                    btnInventario.Location = new Point(
                        btnInventario.Location.X,
                        btnInventario.Location.Y + animationSpeed);
                    pPanelP.Location = new Point(
                                  pPanelP.Location.X,
                                  pPanelP.Location.Y + animationSpeed);
                    pMenupedidos.Location = new Point(
                                 pMenupedidos.Location.X,
                                 pMenupedidos.Location.Y + animationSpeed);
                    Application.DoEvents(); 
                    System.Threading.Thread.Sleep(10); 
                }
            }
            else
            {
               
                pMenuProductos.Visible = false;

               
                while (btnInventario.Location.Y > originalInventarioY)
                {
                    btnInventario.Location = new Point(
                        btnInventario.Location.X,
                        btnInventario.Location.Y - animationSpeed);
                    pPanelP.Location = new Point(
                                  pPanelP.Location.X,
                                  pPanelP.Location.Y - animationSpeed);
                    pMenupedidos.Location = new Point(
                                 pMenupedidos.Location.X,
                                 pMenupedidos.Location.Y - animationSpeed);
                    Application.DoEvents(); 
                    System.Threading.Thread.Sleep(10); 
                }
            }

            panelVisible = !panelVisible;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bajarbtoton();
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


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            pMenuProductos.Visible = false;
            bajarbtoton();
            abrirFormHija(new AgregarProductos());
            

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            pMenuProductos.Visible = false;
            bajarbtoton();
            abrirFormHija(new EditarProducto());

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pMenuProductos.Visible = false;
            bajarbtoton();
            abrirFormHija(new EliminarProducto());

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            if (pMenupedidos.Visible==false )
            {
                pMenupedidos.Visible = true;

            }
            else
            {
                pMenupedidos.Visible = false;
            }
            
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

            pMenupedidos.Visible = false;
            abrirFormHija(new AgregarPedidos());

        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            pMenuProductos.Visible = false;
            bajarbtoton();
            abrirFormHija(new BudquedaProduto());

        }

        private void EliminarP_Click(object sender, EventArgs e)
        {
            pMenupedidos.Visible = false;
            abrirFormHija(new EliminarPedido());

        }

        private void btnBusquedaP_Click(object sender, EventArgs e)
        {
            pMenupedidos.Visible = false;
            abrirFormHija(new BucarPedido());
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditarP_Click(object sender, EventArgs e)
        {
            pMenupedidos.Visible = false;
            abrirFormHija(new EditarPedidos());
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

        private void button2_Click(object sender, EventArgs e)
        {
            panelPerfil.Visible = false;
            abrirFormHija(new Perfil(usuario));
        }
    }
}
