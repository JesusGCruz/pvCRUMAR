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
using System.Drawing.Drawing2D;
using System.Net.Http;



namespace LoginCRUMAR
{
    public partial class GUI : Form
    {

        Conexion coBD = new Conexion();
        provedores provedores = new provedores();

        // Timer para la animación
        private Timer animationTimer;
        private Panel panelToAnimate;
        private int targetHeight;
        private const int ANIMATION_STEP = 8; // Velocidad de la animación
        private const int ANIMATION_INTERVAL = 10; // Suavidad de la animación
        private Dictionary<Panel, int> panelHeights = new Dictionary<Panel, int>();
        public GUI()
        {
            InitializeComponent();
            abrirFormHija(new inicio());
            SetupAnimation();
            customizeDesing();

        }
        private void SetupAnimation()
        {
            // Inicializar el timer para la animación
            animationTimer = new Timer();
            animationTimer.Interval = ANIMATION_INTERVAL;
            animationTimer.Tick += AnimationTimer_Tick;

            // Guardar las alturas originales de los paneles
            panelHeights[panbtnpro] = panbtnpro.Height;
            panelHeights[panbtnpe] = panbtnpe.Height;
            panelHeights[panbtnem] = panbtnem.Height;
            panelHeights[panbtnin] = panbtnin.Height;
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (panelToAnimate == null) return;

            if (panelToAnimate.Height < targetHeight)
            {
                panelToAnimate.Height += ANIMATION_STEP;
                if (panelToAnimate.Height >= targetHeight)
                {
                    panelToAnimate.Height = targetHeight;
                    animationTimer.Stop();
                }
            }
            else
            {
                panelToAnimate.Height -= ANIMATION_STEP;
                if (panelToAnimate.Height <= 0)
                {
                    panelToAnimate.Height = 0;
                    panelToAnimate.Visible = false;
                    animationTimer.Stop();
                }
            }
        }
        private void customizeDesing()
        {
            panbtnpro.Visible = false;
            panbtnpe.Visible = false;
            panbtnem.Visible = false;
            panbtnin.Visible = false;

        }
        private void hideSubMenu()
        {
            foreach (Panel panel in new[] { panbtnpro, panbtnpe, panbtnem, panbtnin })
            {
                if (panel.Visible)
                {
                    panelToAnimate = panel;
                    targetHeight = 0;
                    animationTimer.Start();
                }
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();

                // Iniciar animación de mostrar
                subMenu.Height = 0;
                subMenu.Visible = true;
                panelToAnimate = subMenu;
                targetHeight = panelHeights[subMenu];
                animationTimer.Start();
            }
            else
            {
                // Iniciar animación de ocultar
                panelToAnimate = subMenu;
                targetHeight = 0;
                animationTimer.Start();
            }
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

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();

            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           

        }



        private void btnDeleteUs_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
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
           
            showSubMenu(panbtnem);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            abrirFormHija(new inicio());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ajustes de usuario.");
        }


        


        private void menuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panelContenedor_Click(object sender, EventArgs e)
        {

        }

        private void GUI_Load(object sender, EventArgs e)
        {
            
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            abrirFormHija(new guardar());
            hideSubMenu();

        }

        private void btneditar_Click(object sender, EventArgs e)
        {

            abrirFormHija(new editarfrm());
            hideSubMenu();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            abrirFormHija(new eliminarfrm());
            hideSubMenu();
        }

        private void btnbus_Click(object sender, EventArgs e)
        {
            abrirFormHija(new provedores());

            hideSubMenu();

        }

       

        private void iconButton2_Click(object sender, EventArgs e)
        {
            showSubMenu(panbtnpro);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            showSubMenu(panbtnpe);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
   
            showSubMenu(panbtnin);
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            abrirFormHija(new NuevoUsuario());
            hideSubMenu();
        }
    }
}
