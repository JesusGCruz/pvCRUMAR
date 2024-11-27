using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginCRUMAR
{
    public partial class GestionarUsuarios : Form
    {

        private ConexionUsuarios coBD;
        public GestionarUsuarios()
        {
            InitializeComponent();
            coBD = new ConexionUsuarios();
            cbRoles.DataSource = coBD.getRoles();
            
        }

        private void limpiarEmpleados()
        {
            this.vEmpleadosTableAdapter.Fill(this.cRUMARpvDataSet.vEmpleados);
            uTbId.Clear();
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

        
        private void gestionInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cRUMARpvDataSet.vEmpleados' Puede moverla o quitarla según sea necesario.
            this.vEmpleadosTableAdapter.Fill(this.cRUMARpvDataSet.vEmpleados);

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarUsuarios editInven = Owner as EditarUsuarios;
            //editInven.tbIdFab.Text =      dgvProductos.CurrentRow.Cells[0].Value.ToString();
            //editInven.tbIdProducto.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            //editInven.tbDescrip.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            //editInven.tbPrecio.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            //editInven.tbExis.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
            this.Close();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            uTbId.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
            uTbRFC.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            uTbNombres.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
            uTbApellidos.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
            uTbHorario.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
            cbRoles.SelectedItem = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
            uTbUsuario.Text = dgvEmpleados.CurrentRow.Cells[6].Value.ToString();
            uTbContra.Text = dgvEmpleados.CurrentRow.Cells[7].Value.ToString();
            bool activo = bool.Parse(dgvEmpleados.CurrentRow.Cells[8].Value.ToString());
            if (activo)
            {
                uRbSi.Checked = true;
            }
            else
            {
                uRbNo.Checked = true;
            }
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
                            limpiarEmpleados();
                            MessageBox.Show("Usuario Actualizado");
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
                        limpiarEmpleados();
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

        private void uBtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarEmpleados();
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
                            limpiarEmpleados();
                            MessageBox.Show("Empleado Eliminado");
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
