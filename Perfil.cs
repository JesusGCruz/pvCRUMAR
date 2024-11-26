using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginCRUMAR
{
    public partial class Perfil : Form
    {
        static private string usuario;
        ConexionUsuarios coBD = new ConexionUsuarios();
        public Perfil(string uss)
        {
            InitializeComponent();
            usuario = uss;
            pLblRol.Text = coBD.getDatosPerfil(usuario)[0].ToString();
            pTbNombre.Text = coBD.getDatosPerfil(usuario)[0].ToString();
            pTbApellidos.Text = coBD.getDatosPerfil(usuario)[1].ToString();
            pTbUsuario.Text = coBD.getDatosPerfil(usuario)[2].ToString();
            pTbPassActual.Text = coBD.getDatosPerfil(usuario)[3].ToString();
            pPbUsuario.Image = Image.FromFile(@"C:\Users\jgarr\source\repos\LoginCRUMAR\EmpleadosFotos\" + usuario + ".jpeg");
        }


        private void iconButton2_Click(object sender, EventArgs e)
        {
            if(pTbPass.UseSystemPasswordChar)
            {
                pTbPass.UseSystemPasswordChar = false;
                pBtnEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                pTbPass.UseSystemPasswordChar = true;
                pBtnEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void pBtnEye2_Click(object sender, EventArgs e)
        {
            if (pTbConfirmarPass.UseSystemPasswordChar)
            {
                pTbConfirmarPass.UseSystemPasswordChar = false;
                pBtnEye2.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                pTbConfirmarPass.UseSystemPasswordChar = true;
                pBtnEye2.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void uBtnLimpiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Actualizar datos en proceso.");
        }

        private void pBtnEyeActual_Click(object sender, EventArgs e)
        {
            if (pTbPassActual.UseSystemPasswordChar)
            {
                pTbPassActual.UseSystemPasswordChar = false;
                pBtnEyeActual.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                pTbPassActual.UseSystemPasswordChar = true;
                pBtnEyeActual.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            fPanelContenedor.Visible = true;
            pPbUsuario.Image = null;
            abrirFormHija(new CapturarFoto(usuario, fPanelContenedor, pPbUsuario));
        }

        private void abrirFormHija(object formHija)
        {
            if (this.fPanelContenedor.Controls.Count > 0)
            {
                this.fPanelContenedor.Controls.RemoveAt(0);
            }
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.fPanelContenedor.Controls.Add(fh);
            this.fPanelContenedor.Tag = fh;
            fh.Show();
        }

        private void pPbUsuario_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
    }
}
