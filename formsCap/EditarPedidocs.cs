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
    public partial class EditarPedidos : Form
    {
        ConexionProductos coBD = new ConexionProductos();
        private ToolTip toolTip;
        SoloNumyFech nf = new SoloNumyFech();  
        public EditarPedidos()
        {
            InitializeComponent();
        }
        private void limpiarCampos()
        {
            txtNumpro.Text = "Número de Proveedor";
            txtNumpro.ForeColor = Color.DimGray;
            txtCodigoB.Text = "Codigo de Barras";
            txtCodigoB.ForeColor = Color.DimGray;
            txtCantidadP.Text = "Cantidad de Producto";
            txtCantidadP.ForeColor = Color.DimGray;
            txtFechap.Text = "Fecha de Pedido";
            txtFechap.ForeColor = Color.DimGray;
            txtnumPe.Text = "Número de Pedido";
            txtnumPe.ForeColor = Color.DimGray;

            lblNumPro.Visible = false;
            lblCodB.Visible = false;
            lblCantP.Visible = false;
            lblFecha.Visible = false;
            lblnumPe.Visible = false;
        }
        private void CargarPedidos()
        {
            try
            {

                DataSet ds = coBD.ConsultarPedidos();

                dgvPedidos.Rows.Clear();


                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        int indice = dgvPedidos.Rows.Add();
                        DataGridViewRow row = dgvPedidos.Rows[indice];


                        row.Cells["idProveedor"].Value = fila["idProveedor"].ToString();
                        row.Cells["codigpBarras"].Value = fila["codigpBarras"].ToString();
                        row.Cells["fecha"].Value = fila["fecha"].ToString();
                        row.Cells["idProductoProve"].Value = fila["idProductoProve"].ToString();
                        row.Cells["cantidadProducto"].Value = fila["cantidadProducto"].ToString();
                        row.Cells["nombre"].Value = fila["nombre"].ToString();
                        row.Cells["nombrePro"].Value = fila["nombrePro"].ToString();


                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvPedidos.Rows[e.RowIndex];

                    // Asignar valores a los 5 TextBox
                    txtnumPe.Text = row.Cells[0].Value.ToString();
                    txtnumPe.ForeColor = Color.LightGray;
                    txtCodigoB.Text = row.Cells[1].Value.ToString();
                    txtCodigoB.ForeColor = Color.LightGray;
                    txtNumpro.Text = row.Cells[3].Value.ToString();
                    txtNumpro.ForeColor = Color.LightGray;
                    txtFechap.Text = row.Cells[4].Value?.ToString() ?? "";
                    txtFechap.ForeColor = Color.LightGray;
                    txtCantidadP.Text = row.Cells[5].Value.ToString();
                    txtCantidadP.ForeColor = Color.LightGray;

                    // Mostrar los labels relacionados
                    lblnumPe.Visible = true;
                    lblNumPro.Visible = true;
                    lblCodB.Visible = true;
                    lblCantP.Visible = true;
                    lblFecha.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la fila: " + ex.Message);
            }
        }

        private void EditarPedidos_Load(object sender, EventArgs e)
        {
            CargarPedidos();
            toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 0;
            toolTip.ReshowDelay = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void txtnumPe_Enter(object sender, EventArgs e)
        {
            if (txtnumPe.Text == "Número de Pedido")
            {
                txtnumPe.Text = "";
                txtnumPe.ForeColor = Color.LightGray;
                lblnumPe.Visible = true;

            }
        }

        private void txtnumPe_Leave(object sender, EventArgs e)
        {
            if (txtnumPe.Text == "")
            {
                txtnumPe.Text = "Número de Pedido";
                txtnumPe.ForeColor = Color.DimGray;
                lblnumPe.Visible = false;

            }

        }

        private void txtNumpro_Enter(object sender, EventArgs e)
        {
            if (txtNumpro.Text == "Número de Proveedor")
            {
                txtNumpro.Text = "";
                txtNumpro.ForeColor = Color.LightGray;
                lblNumPro.Visible = true;

            }
        }

        private void txtNumpro_Leave(object sender, EventArgs e)
        {
            if (txtNumpro.Text == "")
            {
                txtNumpro.Text = "Número de Proveedor";
                txtNumpro.ForeColor = Color.DimGray;
                lblNumPro.Visible = false;

            }
        }

        private void txtCodigoB_Enter(object sender, EventArgs e)
        {
            if (txtCodigoB.Text == "Codigo de Barras")
            {
                txtCodigoB.Text = "";
                txtCodigoB.ForeColor = Color.LightGray;
                lblCodB.Visible = true;

            }
        }

        private void txtCodigoB_Leave(object sender, EventArgs e)
        {
            if (txtCodigoB.Text == "")
            {
                txtCodigoB.Text = "Codigo de Barras";
                txtCodigoB.ForeColor = Color.DimGray;
                lblCodB.Visible = false;

            }
        }

        private void txtCantidadP_Enter(object sender, EventArgs e)
        {
            if (txtCantidadP.Text == "Cantidad de Producto")
            {
                txtCantidadP.Text = "";
                txtCantidadP.ForeColor = Color.LightGray;
                lblCantP.Visible = true;

            }

        }

        private void txtCantidadP_Leave(object sender, EventArgs e)
        {
            if (txtCantidadP.Text == "")
            {
                txtCantidadP.Text = "Cantidad de Producto";
                txtCantidadP.ForeColor = Color.DimGray;
                lblCantP.Visible = false;

            }
        }

        private void txtFechap_Enter(object sender, EventArgs e)
        {
            if (txtFechap.Text == "Fecha de Pedido")
            {

                txtFechap.Text = "";
                txtFechap.ForeColor = Color.LightGray;
                lblFecha.Visible = true;

            }
        }

        private void txtFechap_Leave(object sender, EventArgs e)
        {
            if (txtFechap.Text == "")
            {
                txtFechap.Text = "Fecha de Pedido";
                txtFechap.ForeColor = Color.DimGray;
                lblFecha.Visible = false;

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.Visible == false)
            {
                dgvPedidos.Visible = true;

            }
            else
            {
                dgvPedidos.Visible = false;
            }
        }

        private void btncalendaario_Click(object sender, EventArgs e)
        {
            Point location = txtFechap.PointToScreen(Point.Empty);
            location.Y += txtFechap.Height;
            calendario.Location = this.PointToClient(location);
            calendario.Visible = !calendario.Visible;
        }

        private void calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtFechap.ForeColor = Color.LightGray;
            txtFechap.Text = e.Start.ToString("dd/MM/yyyy");
            calendario.Visible = false;
            lblFecha.Visible = true;
        }

        private void txtFechap_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(txtFechap, "dd/MM/yyyy");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaVencimiento;
                if (!DateTime.TryParse(txtFechap.Text, out fechaVencimiento))
                {
                    MessageBox.Show("La fecha ingresada no es válida.");
                    return;
                }
                bool res = coBD.actualizarPedido(int.Parse(txtNumpro.Text),
                   int.Parse(txtCodigoB.Text),
                   fechaVencimiento,
                   int.Parse(txtnumPe.Text),
                   int.Parse(txtCantidadP.Text));
                if (res)
                {
                    MessageBox.Show("Pedido Actualizado");
                    CargarPedidos();
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("Fallo la operacion");
                    limpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message);
            }
        }

        private void txtnumPe_KeyPress(object sender, KeyPressEventArgs e)
        {
            nf.solonum(sender, e);
        }

        private void txtNumpro_KeyPress(object sender, KeyPressEventArgs e)
        {
            nf.solonum(sender, e);
        }

        private void txtCodigoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            nf.solonum(sender, e);
        }

        private void txtCantidadP_KeyPress(object sender, KeyPressEventArgs e)
        {
            nf.solonum(sender, e);
        }

        private void txtFechap_KeyPress(object sender, KeyPressEventArgs e)
        {
            nf.soloFecha(sender, e);
        }
    }
}
