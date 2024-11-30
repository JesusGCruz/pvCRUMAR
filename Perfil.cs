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
        string imagePath = @"C:\Users\jgarr\source\repos\LoginCRUMAR\EmpleadosFotos\";
        public Perfil(string uss)
        {
            InitializeComponent();
            usuario = uss;
            pLblName.Text = coBD.getDatosPerfil(usuario)[0].ToString();
            pTbNombre.Text = coBD.getDatosPerfil(usuario)[0].ToString();
            pTbApellidos.Text = coBD.getDatosPerfil(usuario)[1].ToString();
            pTbUsuario.Text = coBD.getDatosPerfil(usuario)[2].ToString();
            pTbPassActual.Text = coBD.getDatosPerfil(usuario)[3].ToString();
            cargarImg();
        }

        private void cargarImg()
        {
            try
            {
                pPbUsuario.Image = Image.FromFile(imagePath + usuario + ".jpeg");
            }
            catch (Exception)
            {
                pPbUsuario.Image = null;
            }
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
            try
            {
                    if (MessageBox.Show("¿Desea guardar los datos editados?", "Confirmar Actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (pTbPass.Text == pTbConfirmarPass.Text)
                        {
                            bool res = coBD.actualizarPerfil(
                                pTbNombre.Text.Trim(),
                                pTbApellidos.Text.Trim(),
                                pTbUsuario.Text.Trim(),
                                pTbPass.Text.Trim()
                                );

                            if (res)
                            {
                                MessageBox.Show("Cambios guardados.");
                            }
                            else
                            {
                                MessageBox.Show("Fallo la operacion");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Las contraseñas no coinciden.");
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message);
            }
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
            pPbUsuario.Image = null;
            CapturarFoto editInven = new CapturarFoto(usuario);
            AddOwnedForm(editInven);
            editInven.TopLevel = false;
            editInven.Dock = DockStyle.Fill;
            this.Controls.Add(editInven);
            this.Tag = editInven;
            editInven.BringToFront();
            editInven.Show();
        }
    }
}
