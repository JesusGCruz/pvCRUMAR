using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repositorio
{
    public partial class GUIRep : Form
    {
        private Timer animationTimer;
        private Panel panelToAnimate;
        private int targetHeight;
        private const int ANIMATION_STEP = 8; // Velocidad de la animación
        private const int ANIMATION_INTERVAL = 10; // Suavidad de la animación
        private Dictionary<Panel, int> panelHeights = new Dictionary<Panel, int>();

        public GUIRep()
        {
            InitializeComponent();
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
            panelHeights[subMenuSearch] = subMenuSearch.Height;
            
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
            subMenuSearch.Visible = false;
            

        }
        private void hideSubMenu()
        {
            foreach (Panel panel in new[] { subMenuSearch})
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuSearch);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Evento para el botón que abre el formulario test

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            abrirFormHija(new test()); // Cargar en el panel
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }
    }
}