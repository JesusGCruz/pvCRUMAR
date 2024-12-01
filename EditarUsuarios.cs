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
    public partial class EditarUsuarios : Form
    {

        ConexionUsuarios coBD = new ConexionUsuarios();
        GestionarUsuarios ges = new GestionarUsuarios();
        public EditarUsuarios()
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

        private void uBtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (coBD.Existente(uTbRFC.Text.Trim()))
                {
                    if (MessageBox.Show("¿Desea guardar los datos editados?", "Confirmar Actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                        bool res = coBD.actualizarUsuario(
                            uTbRFC.Text.Trim(),
                            uTbNombres.Text.Trim(),
                            uTbApellidos.Text.Trim(),
                            uTbHorario.Text.Trim(),
                            cbRoles.Text.Trim(),
                            uTbUsuario.Text.Trim(),
                            uTbContra.Text.Trim(),
                            activo);

                        if (res)
                        {
                            MessageBox.Show("Usuario Actualizado");
                            
                            limpiarCampos();
                            cerrarForm();
                        }
                        else
                        {
                            MessageBox.Show("Fallo la operacion");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("RFC de empleado no encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cerrarForm();
        }

        private void cerrarForm()
        {
            GestionarUsuarios editInven = Owner as GestionarUsuarios;
            editInven.extraerEmpleados();
            this.Hide();
        }

        private void uBtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (coBD.Existente(uTbRFC.Text.Trim()))
                {
                    if (MessageBox.Show("¿Desea eliminar el empleado seleccionado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool res = coBD.eliminarUsuario(uTbRFC.Text);
                        if (res)
                        {
                            MessageBox.Show("Empleado Eliminado");
                            limpiarCampos();
                            cerrarForm();
                        }
                        else
                        {
                            MessageBox.Show("Fallo la operacion");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("RFC de empleado no encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message);
            }
        }
    }
}
