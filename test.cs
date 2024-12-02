using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Repositorio
{
    public partial class test : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        private List<(string nombre, decimal precio)> productosSeleccionados = new List<(string, decimal)>(); // Lista para almacenar productos seleccionados
        public test()
        {
            
            InitializeComponent();
            // printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            this.txtProductos.Enter += new System.EventHandler(this.txtProductos_Enter);
            this.txtProductos.Leave += new System.EventHandler(this.txtProductos_Leave);
            txtProductos.Text = "Producto";
            txtProductos.ForeColor = Color.White;
            lblnom.Visible = false;

           btnPrint.Click += new EventHandler(btnPrint_Click);
        }
        static string cadena = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=CRUMARpv;Integrated Security=True;";

        public object CRUMARpvDataSet1 { get; private set; }

        private void CargarMarcas()
        {
            try
            {
                // Consulta para obtener todas las marcas de la tabla tbProductos
                string query = "SELECT DISTINCT marca FROM tbProductos";

                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dtMarcas = new DataTable();
                    adapter.Fill(dtMarcas);

                    // Llenar el ComboBox con las marcas disponibles
                    cbMarca.DataSource = dtMarcas;
                    cbMarca.DisplayMember = "marca";  // Mostramos la columna "marca"
                    cbMarca.SelectedIndex = -1; // Sin selección inicial
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las marcas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void test_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cRUMARpvDataSet.spConsultarProducto' Puede moverla o quitarla según sea necesario.
            this.spConsultarProductoTableAdapter.Fill(this.cRUMARpvDataSet.spConsultarProducto);

            // TODO: esta línea de código carga datos en la tabla 'cRUMARpvDataSet.tbProductos' Puede moverla o quitarla según sea necesario.
            this.tbProductosTableAdapter.Fill(this.cRUMARpvDataSet.tbProductos);
            try
            {
                string query = "SELECT codigoBarras, nombre, marca, precioVenta, existencia, fechaCaducidad FROM tbProductos";
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvProducts.DataSource = dt;
                }
                dgvProducts.ReadOnly = true;
                CargarMarcas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FiltrarProductos()
        {
            try
            {
                string query = string.Empty;
                DateTime fechaActual = DateTime.Now;

                // Verifica si el ComboBox tiene un elemento seleccionado
                if (cbCaducidad.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecciona una opción en el ComboBox.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbCaducidad.SelectedItem.ToString() == "Próximos a caducar")
                {
                    query = "SELECT codigoBarras, nombre, marca, precioVenta, fechaCaducidad " +
                            "FROM tbProductos WHERE fechaCaducidad > @fechaActual AND fechaCaducidad <= @fechaLimite";
                }
                else if (cbCaducidad.SelectedItem.ToString() == "Caducados")
                {
                    query = "SELECT codigoBarras, nombre, marca, precioVenta, fechaCaducidad " +
                            "FROM tbProductos WHERE fechaCaducidad < @fechaActual";
                }

                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@fechaActual", fechaActual);
                    adapter.SelectCommand.Parameters.AddWithValue("@fechaLimite", fechaActual.AddDays(7));

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvProducts.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnFechas_Click(object sender, EventArgs e)
        {
            try
            {
                // Mostrar las fechas de caducidad de todos los productos en el DataGridView
                string query = "SELECT codigoBarras, nombre, marca, precioVenta, existencia ,fechaCaducidad FROM tbProductos";

                using (SqlConnection connection = new SqlConnection(cadena ))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "tbProductos");

                    // Asignar los resultados al DataGridView
                    dgvProducts.DataSource = ds;
                    dgvProducts.DataMember = "tbProductos";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las fechas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si se ha seleccionado una marca
                if (cbMarca.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, selecciona una marca", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Filtrar los productos por la marca seleccionada
                FiltrarProductosPorMarca();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FiltrarProductosPorMarca()
        {
            try
            {
                string marcaSeleccionada = cbMarca.Text;
                string query = "SELECT codigoBarras, nombre, marca, existencia FROM tbProductos WHERE marca = @marca";

                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@marca", marcaSeleccionada);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvProducts.DataSource = dt;
                    ColorearStock();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ColorearStock()
        {
            try
            {
                // Primero imprimir los nombres de las columnas para debug
                string columnNames = string.Join(", ", dgvProducts.Columns.Cast<DataGridViewColumn>().Select(c => c.Name));
                Console.WriteLine($"Columnas disponibles: {columnNames}");

                // Usar el nombre correcto de la columna (debe coincidir con tu consulta SQL)
                string columnName = "existencia"; // O "existenciaP" según corresponda

                if (!dgvProducts.Columns.Contains(columnName))
                {
                    throw new Exception($"No se pudo encontrar la columna denominada {columnName}");
                }

                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    if (row.Cells[columnName].Value != DBNull.Value && row.Cells[columnName].Value != null)
                    {
                        int existencia = Convert.ToInt32(row.Cells[columnName].Value);

                        if (existencia == 0)
                        {
                            row.DefaultCellStyle.BackColor = Color.Red;
                        }
                        else if (existencia < 5)
                        {
                            row.DefaultCellStyle.BackColor = Color.Orange;
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.Green;
                        }
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.Gray;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aplicar los colores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtProductos_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtProductos.Text.Trim();

                // Si el texto es el placeholder "Producto", no filtrar
                if (filtro == "Producto")
                    return;

                string query = @"SELECT codigoBarras, nombre, marca, precioVenta, existencia, fechaCaducidad 
                        FROM tbProductos 
                        WHERE nombre LIKE @filtro 
                        OR codigoBarras LIKE @filtro 
                        OR marca LIKE @filtro";

                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvProducts.DataSource = dt;
                }

                // Si estás usando el filtro de stock, aplicar el coloreado
                if (cbMarca.SelectedIndex != -1)
                {
                    ColorearStock();
                }
            }
            catch (Exception ex)
            {
                // En lugar de mostrar un MessageBox que podría ser molesto durante la escritura,
                // podrías registrar el error o manejarlo de otra manera
                Console.WriteLine($"Error al filtrar: {ex.Message}");
            }
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvProducts.Rows.Count > 0)
            {
                ImpresionTicket impresion = new ImpresionTicket(dgvProducts);
                impresion.ImprimirTicket();
            }
            else
            {
                MessageBox.Show("No hay datos para imprimir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Aplicar el filtro seleccionado en el ComboBox y actualizar el DataGridView
                FiltrarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aplicar el filtro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si se ha seleccionado una marca
                if (cbMarca.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, selecciona una marca", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Filtrar los productos por la marca seleccionada
                FiltrarProductosPorMarca();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtProductos_Enter(object sender, EventArgs e)
        {
            if (txtProductos.Text == "Producto")
            {
                txtProductos.Text = "";
                txtProductos.ForeColor = Color.White; // Cambia a negro cuando está activo
                lblnom.Visible = true;
            }
        }

        private void txtProductos_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductos.Text))
            {
                txtProductos.Text = "Producto";
                txtProductos.ForeColor = Color.White;
                // Recargar todos los datos cuando el campo está vacío
                CargarDatosIniciales();
            }
        }
        private void CargarDatosIniciales()
        {
            try
            {
                string query = "SELECT codigoBarras, nombre, marca, precioVenta, existencia, fechaCaducidad FROM tbProductos";
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvProducts.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}