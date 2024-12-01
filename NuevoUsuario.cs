using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginCRUMAR
{
    public partial class NuevoUsuario : Form
    {

        ConexionUsuarios coBD = new ConexionUsuarios();

        public NuevoUsuario()
        {
            InitializeComponent();
            cbRoles.DataSource = coBD.getRoles();
        }

        private void limpiarCampos()
        {
            //uTbId.Clear();
            uTbRFC.Clear();
            uTbNombres.Clear();
            uTbApellidos.Clear();
            uTbHorario.Clear();
            uTbUsuario.Clear();
            uTbContra.Clear();
            uRbSi.Checked = false;
            uRbNo.Checked = false;
            cbRoles.SelectedIndex = 1;
        }

        private void uBtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea registrar un nuevo empleado?", "Confirmar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool activo = false;
                    if (uRbSi.Checked)
                    {
                        activo = true;
                    }
                    if (uRbNo.Checked)
                    {
                        activo = false;
                    }

                    bool res = coBD.agregarUsuario(
                        uTbRFC.Text.Trim(),
                        uTbNombres.Text.Trim(),
                        uTbApellidos.Text.Trim(),
                        //Convert.ToInt32(uTbId.Text.Trim()),
                        uTbHorario.Text.Trim(),
                        cbRoles.Text.Trim(),
                        uTbUsuario.Text.Trim(),
                        uTbContra.Text.Trim(),
                        activo);

                    if (res)
                    {
                        limpiarCampos();
                        MessageBox.Show("Empleado Registrado");
                    }
                    else
                    {
                        MessageBox.Show("Fallo la operacion");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                /*
            if (uTbUsuario.Text != "") { 
            CapturarFoto editInven = new CapturarFoto(uTbUsuario.Text);
            AddOwnedForm(editInven);
            editInven.TopLevel = false;
            editInven.Dock = DockStyle.Fill;
            this.Controls.Add(editInven);
            this.Tag = editInven;
            editInven.BringToFront();
            editInven.Show();
            }
            else
            {
                MessageBox.Show("Agrega el usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                 */
        }
    }
}
