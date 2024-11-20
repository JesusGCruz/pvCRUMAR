using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginCRUMAR
{
    public partial class test : Form
    {
        Conexion coBD = new Conexion();
        public test()
        {
            InitializeComponent();
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbEmpresaWXDataSet.tbClientes' Puede moverla o quitarla según sea necesario.
            //this.tbClientesTableAdapter.Fill(this.dbEmpresaWXDataSet.tbClientes);
            //frm_Principal.Exit();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvUsuarios.DataSource = coBD.ConsultaUsuarios();
                dgvUsuarios.DataMember = "tbUsuarios";

            }
            catch (Exception ex) {
                MessageBox.Show("Error de SQL: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = coBD.agregarUsuario(int.Parse(txtId.Text),
                    tbUser.Text,
                    tbPass.Text,
                    tbName.Text,
                    tbLastName.Text,
                    rbActivo.Checked);
                if (res)
                {
                    MessageBox.Show("Usuario Agregado");
                }
                else
                {
                    MessageBox.Show("Fallo la operacion");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = coBD.eliminarUsuario(int.Parse(tbIdUssE.Text));
                if (res)
                {
                    MessageBox.Show("Usuario Eliminado");
                }
                else
                {
                    MessageBox.Show("Fallo la operacion");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarAct_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsUser = coBD.consultarUsuario(txtUserAct.Text);
                //Arreglar
                if (dsUser.Tables[0].Rows.Count < 1)
                {
                    MessageBox.Show("Usuario no encontrado.");
                    limpiarBuscar();
                }
                else
                {
                    DataRow fila = dsUser.Tables[0].Rows[0];
                    txtUssAct.Text = fila["usuario"].ToString();
                    txtUssAct.Enabled = false;
                    txtContraAct.Text = fila["pass"].ToString();
                    txtNombreAct.Text = fila["nombre"].ToString();
                    txtApellidoAct.Text = fila["apellidos"].ToString();
                    bool activo = bool.Parse(fila["activo"].ToString());
                    if (!activo)
                    {
                        rbActivoSA.Checked = true;
                    }
                    else
                    {
                        rbActivoNA.Checked = true;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message);
            }
        }

        public void limpiarBuscar()
        {
            txtUssAct.Text = "";
            txtContraAct.Text = "";
            txtNombreAct.Text = "";
            txtApellidoAct.Text = "";
            rbActivoNA.Checked = false;
        }

        private void btnActuAct_Click(object sender, EventArgs e)
        {
            try
            {
                bool activo = false;
                if (!rbActivoSA.Checked)
                {
                    activo = true;
                }
                if(!rbActivoNA.Checked)
                {
                    activo = false;
                }

                bool res = coBD.actualizarUsuario(
                    txtUserAct.Text,
                    txtContraAct.Text,
                    txtNombreAct.Text,
                    txtApellidoAct.Text,
                    activo);
                if (res)
                {
                    MessageBox.Show("Usuario Actualizado");
                }
                else
                {
                    MessageBox.Show("Fallo la operacion");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            gestionEmpleados gu = new gestionEmpleados();
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                gu.tbId.Text = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                gu.tbUsuario.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
                gu.tbContra.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                gu.tbNombre.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
                gu.tbApellido.Text = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
                gu.rbActivo.Checked = bool.Parse(dgvUsuarios.CurrentRow.Cells[5].Value.ToString());
                gu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Se debe seleccionar una fila");
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
