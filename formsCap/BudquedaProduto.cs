using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClosedXML.Excel;
using System.IO;

namespace LoginCRUMAR
{
    public partial class BudquedaProduto : Form
    {
        ConexionProductos coBD = new ConexionProductos();
        public BudquedaProduto()
        {
            InitializeComponent();
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

        private void buscarP(object sender, EventArgs e)
        {
            try
            {
                string columnaFiltro = ((OpcionCombo)cboBusqueda.SelectedItem).Valor.ToString();
                string textoBuscar = txtBuscar.Text.Trim().ToUpper();

                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    if (row.Cells[columnaFiltro].Value != null)
                    {
                        string valor = row.Cells[columnaFiltro].Value.ToString().ToUpper();
                        row.Visible = valor.Contains(textoBuscar);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLimpiar2_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "Busca Aqui";
            txtBuscar.ForeColor = Color.DimGray;
            CargarProductos();
        }

        private void BudquedaProduto_Load(object sender, EventArgs e)
        {
            CargarProductos();
            foreach (DataGridViewColumn column in dgvProductos.Columns)
            {
                if (column.Visible == true)
                {
                    cboBusqueda.Items.Add(new OpcionCombo() { Valor = column.Name, Texto = column.HeaderText });

                }

            }
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Busca Aqui")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.LightGray;
              

            }

        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Busca Aqui";
                txtBuscar.ForeColor = Color.DimGray;
                CargarProductos();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscarP(sender, e);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Guardar como";
                saveFileDialog.FileName = "Productos.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = saveFileDialog.FileName;
                    ExportarAExcel(dgvProductos, rutaArchivo);
                }
            }

        }

        private void ExportarAExcel(DataGridView dataGridView, string rutaArchivo)
        {
            try
            {
                // Validar que el DataGridView tenga filas
                if (dataGridView.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear un nuevo libro de Excel
                using (var workbook = new XLWorkbook())
                {
                    // Agregar una hoja de cálculo
                    var worksheet = workbook.Worksheets.Add("Datos");

                    // Escribir encabezados de las columnas
                    for (int col = 0; col < dataGridView.Columns.Count; col++)
                    {
                        worksheet.Cell(1, col + 1).Value = dataGridView.Columns[col].HeaderText;
                    }

                    // Escribir datos de las filas
                    for (int row = 0; row < dataGridView.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataGridView.Columns.Count; col++)
                        {
                            // Obtener el valor de la celda
                            var value = dataGridView.Rows[row].Cells[col].Value;

                            // Validar y convertir el valor antes de asignarlo a la celda de Excel
                            worksheet.Cell(row + 2, col + 1).Value = value != null ? value.ToString() : string.Empty;
                        }
                    }

                    // Guardar el archivo en la ruta especificada
                    workbook.SaveAs(rutaArchivo);
                }

                MessageBox.Show("Archivo Excel generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Mostrar cualquier error que ocurra
                MessageBox.Show($"Ocurrió un error al exportar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}


