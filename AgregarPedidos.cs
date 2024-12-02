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
    public partial class AgregarPedidos : Form
    {
        ConexionProductos coBD = new ConexionProductos();
        SoloNumyFech nf =   new SoloNumyFech(); 
        public AgregarPedidos()
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
            txtFechaP.Text = "Fecha de Pedido";
            txtFechaP.ForeColor = Color.DimGray;

            lblNumPro.Visible = false;
            lblCodB.Visible = false;
            lblCantP.Visible = false;
            lblFecha.Visible = false;
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

        private void Pedidos_Load(object sender, EventArgs e)
        {
            CargarPedidos();
          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaVencimiento;
                if (!DateTime.TryParse(txtFechaP.Text, out fechaVencimiento))
                {
                    MessageBox.Show("La fecha ingresada no es válida.");
                    return;
                }
                bool res = coBD.agregarPedido(int.Parse(txtNumpro.Text),
                    int.Parse(txtCodigoB.Text),
                    fechaVencimiento,
                    int.Parse(txtCantidadP.Text));
                if (res)
                {
                    MessageBox.Show("Pedido Agregado");
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void txtFechaP_Enter(object sender, EventArgs e)
        {
            if (txtFechaP.Text == "Fecha de Pedido")
            {

                DateTime fechaActual = DateTime.Now;
                txtFechaP.Text = fechaActual.ToShortDateString();
                txtFechaP.ForeColor = Color.LightGray;
                lblFecha.Visible = true;

            }
        }

        private void txtFechaP_Leave(object sender, EventArgs e)
        {
            if (txtFechaP.Text == "")
            {
                txtFechaP.Text = "Fecha de Pedido";
                txtFechaP.ForeColor = Color.DimGray;
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

        private void txtNumpro_KeyPress(object sender, KeyPressEventArgs e)
        {
            nf.solonum(sender,e);
        }

        private void txtCodigoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            nf.solonum(sender, e);
        }

        private void txtCantidadP_KeyPress(object sender, KeyPressEventArgs e)
        {
            nf.solonum(sender, e);
        }

        private void txtFechaP_KeyPress(object sender, KeyPressEventArgs e)
        {
            nf.soloFecha(sender, e);
        }
    }
}
