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
    public partial class EditarProducto : Form
    {
        ConexionProductos coBD = new ConexionProductos();
        SoloNumyFech nf = new SoloNumyFech();
        private ToolTip toolTip;

        public EditarProducto()
        {
            InitializeComponent();
        }
        private void limpiarCampos()
        {
            txtCodigoB.Text = "Codigo de Barras";
            txtCodigoB.ForeColor = Color.DimGray;
            txtNombre.Text = "Nombre";
            txtNombre.ForeColor = Color.DimGray;
            txtMarca.Text = "Marca";
            txtMarca.ForeColor = Color.DimGray;
            txtIva.Text = "Iva";
            txtIva.ForeColor = Color.DimGray;
            txtExistencias.Text = "Existencias";
            txtExistencias.ForeColor = Color.DimGray;
            txtPrecioC.Text = "Precio de Compra";
            txtPrecioC.ForeColor = Color.DimGray;
            txtPrecioV.Text = "Precio de Venta";
            txtPrecioV.ForeColor = Color.DimGray;
            txtFechaV.Text = "Fecha de Caducidad";
            txtFechaV.ForeColor = Color.DimGray;

            lblFechaC.Visible = false;
            lblCodigoBarras.Visible = false;
            lblnombre.Visible = false;
            lblMarca.Visible = false;
            lblIva.Visible = false;
            lblExistencia.Visible = false;
            lblPrecioC.Visible = false;
            lblPrecioV.Visible = false;
        }
        private void CargarProductos()
        {
            try
            {

                DataSet ds = coBD.ConsultarProductos();

                dgvProductos.Rows.Clear();


                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        int indice = dgvProductos.Rows.Add();
                        DataGridViewRow row = dgvProductos.Rows[indice];


                        row.Cells["codigoBarras"].Value = fila["codigoBarras"].ToString();
                        row.Cells["nombre"].Value = fila["nombre"].ToString();
                        row.Cells["marca"].Value = fila["marca"].ToString();
                        row.Cells["iva"].Value = fila["iva"].ToString();
                        row.Cells["existencia"].Value = fila["existencia"].ToString();
                        row.Cells["precioCompra"].Value = fila["precioCompra"].ToString();
                        row.Cells["precioVenta"].Value = fila["precioVenta"].ToString();
                        row.Cells["fechaCaducidad"].Value = fila["fechaCaducidad"].ToString();

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaVencimiento;
                if (!DateTime.TryParse(txtFechaV.Text, out fechaVencimiento))
                {
                    MessageBox.Show("La fecha ingresada no es válida.");
                    return;
                }
                bool res = coBD.actualizarProducto(int.Parse(txtCodigoB.Text),
                    txtNombre.Text,
                    txtMarca.Text,
                    txtIva.Text,
                    txtExistencias.Text,
                    double.Parse(txtPrecioC.Text),
                    double.Parse(txtPrecioV.Text),
                    fechaVencimiento);
                if (res)
                {
                    MessageBox.Show("Producto Actualizado");
                    CargarProductos();
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

        private void EditarProducto_Load(object sender, EventArgs e)
        {
            CargarProductos();
            toolTip = new ToolTip();
            toolTip.ShowAlways = true;
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 0;
            toolTip.ReshowDelay = 0;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvProductos.Rows[e.RowIndex];


                    txtCodigoB.Text = row.Cells[0].Value.ToString();
                    txtCodigoB.ForeColor = Color.LightGray;
                    txtNombre.Text = row.Cells[1].Value.ToString();
                    txtNombre.ForeColor = Color.LightGray;
                    txtMarca.Text = row.Cells[2].Value.ToString();
                    txtMarca.ForeColor = Color.LightGray;
                    txtIva.Text = row.Cells[3].Value.ToString();
                    txtIva.ForeColor = Color.LightGray;
                    txtExistencias.Text = row.Cells[4].Value.ToString();
                    txtExistencias.ForeColor = Color.LightGray;
                    txtPrecioC.Text = row.Cells[5].Value.ToString();
                    txtPrecioC.ForeColor = Color.LightGray;
                    txtPrecioV.Text = row.Cells[6].Value.ToString();
                    txtPrecioV.ForeColor = Color.LightGray;

                    lblCodigoBarras.Visible = true;
                    lblnombre.Visible = true;
                    lblMarca.Visible = true;
                    lblIva.Visible = true;
                    lblExistencia.Visible = true;
                    lblPrecioC.Visible = true;
                    lblPrecioV.Visible = true;
                    lblFechaC.Visible = true;




                    if (row.Cells[7].Value != null && row.Cells[7].Value != DBNull.Value)
                    {
                        DateTime fecha = Convert.ToDateTime(row.Cells[7].Value);
                        txtFechaV.Text = fecha.ToString("dd/MM/yyyy");
                        txtFechaV.ForeColor = Color.LightGray;

                    }
                    else
                    {
                        txtFechaV.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la fila: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtFechaV.ForeColor = Color.LightGray;
            txtFechaV.Text = e.Start.ToString("dd/MM/yyyy");
            calendario.Visible = false;
            lblFechaC.Visible = true;
        }

        private void btncalendaario_Click(object sender, EventArgs e)
        {
            Point location = txtFechaV.PointToScreen(Point.Empty);
            location.Y += txtFechaV.Height;
            calendario.Location = this.PointToClient(location);
            calendario.Visible = !calendario.Visible;
        }

        private void txtCodigoB_Enter(object sender, EventArgs e)
        {
            if (txtCodigoB.Text == "Codigo de Barras")
            {
                txtCodigoB.Text = "";
                txtCodigoB.ForeColor = Color.LightGray;
                lblCodigoBarras.Visible = true;

            }
        }

        private void txtCodigoB_Leave(object sender, EventArgs e)
        {
            if (txtCodigoB.Text == "")
            {
                txtCodigoB.Text = "Codigo de Barras";
                txtCodigoB.ForeColor = Color.DimGray;
                lblCodigoBarras.Visible = false;

            }

        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.LightGray;
                lblnombre.Visible = true;

            }

        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.DimGray;
                lblnombre.Visible = false;

            }

        }

        private void txtMarca_Enter(object sender, EventArgs e)
        {
            if (txtMarca.Text == "Marca")
            {
                txtMarca.Text = "";
                txtMarca.ForeColor = Color.LightGray;
                lblMarca.Visible = true;

            }

        }

        private void txtMarca_Leave(object sender, EventArgs e)
        {
            if (txtMarca.Text == "")
            {
                txtMarca.Text = "Marca";
                txtMarca.ForeColor = Color.DimGray;
                lblMarca.Visible = false;

            }

        }

        private void txtIva_Enter(object sender, EventArgs e)
        {
            if (txtIva.Text == "Iva")
            {
                txtIva.Text = "";
                txtIva.ForeColor = Color.LightGray;
                lblIva.Visible = true;

            }

        }

        private void txtIva_Leave(object sender, EventArgs e)
        {
            if (txtIva.Text == "")
            {
                txtIva.Text = "Iva";
                txtIva.ForeColor = Color.DimGray;
                lblIva.Visible = false;

            }
        }

        private void txtExistencias_Enter(object sender, EventArgs e)
        {
            if (txtExistencias.Text == "Existencias")
            {
                txtExistencias.Text = "";
                txtExistencias.ForeColor = Color.LightGray;
                lblExistencia.Visible = true;

            }

        }

        private void txtExistencias_Leave(object sender, EventArgs e)
        {
            if (txtExistencias.Text == "")
            {
                txtExistencias.Text = "Existencias";
                txtExistencias.ForeColor = Color.DimGray;
                lblExistencia.Visible = false;

            }

        }

        private void txtPrecioC_Enter(object sender, EventArgs e)
        {
            if (txtPrecioC.Text == "Precio de Compra")
            {
                txtPrecioC.Text = "";
                txtPrecioC.ForeColor = Color.LightGray;
                lblPrecioC.Visible = true;

            }

        }

        private void txtPrecioC_Leave(object sender, EventArgs e)
        {
            if (txtPrecioC.Text == "")
            {
                txtPrecioC.Text = "Precio de Compra";
                txtPrecioC.ForeColor = Color.DimGray;
                lblPrecioC.Visible = false;
            }
        }

        private void txtPrecioV_Enter(object sender, EventArgs e)
        {
            if (txtPrecioV.Text == "Precio de Venta")
            {
                txtPrecioV.Text = "";
                txtPrecioV.ForeColor = Color.LightGray;
                lblPrecioV.Visible = true;

            }

        }

        private void txtPrecioV_Leave(object sender, EventArgs e)
        {
            if (txtPrecioV.Text == "")
            {
                txtPrecioV.Text = "Precio de Venta";
                txtPrecioV.ForeColor = Color.DimGray;
                lblPrecioV.Visible = false;

            }

        }

        private void btnConcultar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Visible == false)
            {
                dgvProductos.Visible = true;

            }
            else
            {
                dgvProductos.Visible = false;
            }
        }

        private void txtCodigoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            nf.solonum(sender,e);
        }

        private void txtIva_KeyPress(object sender, KeyPressEventArgs e)
        {
            nf.solonum(sender, e);
        }

        private void txtExistencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            nf.solonum(sender, e);
        }

        private void txtPrecioC_KeyPress(object sender, KeyPressEventArgs e)
        {
            nf.solonum(sender, e);
        }

        private void txtPrecioV_KeyPress(object sender, KeyPressEventArgs e)
        {
            nf.solonum(sender, e);
        }

        private void txtFechaV_KeyPress(object sender, KeyPressEventArgs e)
        {
            nf.soloFecha(sender, e);
        }

        private void txtFechaV_Enter(object sender, EventArgs e)
        {
            if (txtFechaV.Text == "Fecha de Caducidad")
            {
                txtFechaV.Text = "";
                txtFechaV.ForeColor = Color.LightGray;
                lblFechaC.Visible = true;

            }
        }

        private void txtFechaV_Leave(object sender, EventArgs e)
        {
            if (txtFechaV.Text == "")
            {
                txtFechaV.Text = "Fecha de Caducidad";
                txtFechaV.ForeColor = Color.DimGray;
                lblFechaC.Visible = false;

            }
        }

        private void txtFechaV_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(txtFechaV, "dd/MM/yyyy");
        }
    }
}
