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
            //cbRoles.DataSource = coBD.getRoles();
            
        }

        public void extraerEmpleados()
        {
            this.vEmpleadosTableAdapter.Fill(this.cRUMARpvDataSet.vEmpleados);
        }

        private void abrirEditor()
        {
            try
            {
                if (dgvEmpleados.CurrentRow != null)
                {

                    EditarUsuarios editUss = new EditarUsuarios();

                    editUss.uTbRFC.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
                    editUss.uTbNombres.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
                    editUss.uTbApellidos.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
                    editUss.uTbHorario.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
                    editUss.cbRoles.SelectedItem = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
                    editUss.uTbUsuario.Text = dgvEmpleados.CurrentRow.Cells[6].Value.ToString();
                    editUss.uTbContra.Text = dgvEmpleados.CurrentRow.Cells[7].Value.ToString();
                    bool activo = bool.Parse(dgvEmpleados.CurrentRow.Cells[8].Value.ToString());
                    if (activo)
                    {
                        editUss.uRbSi.Checked = true;
                    }
                    else
                    {
                        editUss.uRbNo.Checked = true;
                    }

                    AddOwnedForm(editUss);
                    editUss.TopLevel = false;
                    editUss.Dock = DockStyle.Fill;
                    this.Controls.Add(editUss);
                    this.Tag = editUss;
                    editUss.BringToFront();
                    editUss.Show();
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una fila.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void gestionInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cRUMARpvDataSet.vEmpleados' Puede moverla o quitarla según sea necesario.
            this.vEmpleadosTableAdapter.Fill(this.cRUMARpvDataSet.vEmpleados);
            foreach (DataGridViewColumn columna in dgvEmpleados.Columns)
            {
                if (columna.Visible == true && columna.Name != "selec")
                {
                    cboBusqueda.Items.Add(columna.HeaderText);
                }

            }
            cboBusqueda.DisplayMember = "Text";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            abrirEditor();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
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
             */
        }

        private void uBtnLimpiar_Click(object sender, EventArgs e)
        {
            abrirEditor();
        }

        

        private void GestionarUsuarios_VisibleChanged(object sender, EventArgs e)
        {
            extraerEmpleados();
        }

        private void btnbusque_Click(object sender, EventArgs e)
        {
            if (cboBusqueda.SelectedItem == null || string.IsNullOrWhiteSpace(txtbusque.Text))
            {
                MessageBox.Show("Por favor, selecciona un filtro y escribe un texto para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                buscarGrid(dgvEmpleados,cboBusqueda.SelectedIndex);
            }

        }

        private void buscarGrid(DataGridView d, int col)
        {
            string valor = "";
            d.CurrentCell = null; // Esto desconecta la celda seleccionada
            d.SuspendLayout();    // Suspende el diseño para evitar errores gráficos
            for (int i = 0; i < d.Rows.Count - 1; i++)
            {
                valor = d.Rows[i].Cells[col].Value.ToString();
                if (valor.Contains(txtbusque.Text.Trim()))
                {
                    d.Rows[i].Visible = true;
                }
                else
                {
                    d.Rows[i].Visible = false;
                }
            }
        }

        private void btlim_Click(object sender, EventArgs e)
        {
            limpiarBuscador();
        }

        private void limpiarBuscador()
        {
            for (int i = 0; i < dgvEmpleados.Rows.Count - 1; i++)
            {
                dgvEmpleados.Rows[i].Visible = true;
            }
            dgvEmpleados.ResumeLayout(); // Reanudar el diseño después de procesar
            txtbusque.Clear();
            cboBusqueda.SelectedIndex = 0;
            dgvEmpleados.Rows[0].Selected = true;
        }

        private void txtbusque_TextChanged(object sender, EventArgs e)
        {
            if (cboBusqueda.SelectedItem == null || string.IsNullOrWhiteSpace(txtbusque.Text))
            {
                limpiarBuscador();
            }
            else
            {
                buscarGrid(dgvEmpleados, cboBusqueda.SelectedIndex);
            }
        }
    }
}
