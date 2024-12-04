using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginCRUMAR
{
    public partial class FrmRegistrarVenta : Form
    {
        private Venta ventaActual;
        private BindingList<DetalleVenta> detallesVenta;
        private int idEmpleado;
        private readonly VentaDAL ventaDAL;
        private int idVentaActual;
        private List<DetalleVenta> listaDetalles = new List<DetalleVenta>();

        public FrmRegistrarVenta()
        {
            InitializeComponent();
            ventaDAL = new VentaDAL();
            InicializarVenta();

        }
        private void InicializarVenta()
        {
            detallesVenta = new BindingList<DetalleVenta>();
        }

        private void ActualizarTotal()
        {
            decimal total = listaDetalles.Sum(d => d.subtotal);
            txtTotal.Text = total.ToString("");
        }

        private void CalcularTotales()
        {
            using (SqlConnection conn = DBConnection.ObtenerConexion())
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_CalcularTotalVenta", conn, transaction))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@idVenta", idVentaActual); // ID de la venta actual

                            // Parámetro de salida para el total
                            var totalParam = new SqlParameter("@total", SqlDbType.Money)
                            {
                                Direction = ParameterDirection.Output
                            };
                            cmd.Parameters.Add(totalParam);

                            cmd.ExecuteNonQuery(); // Ejecutamos el procedimiento

                            // Mostrar el total en la caja de texto
                            txtTotal.Text = totalParam.Value.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al calcular el total: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }


        private int ObtenerIdVenta()
        {
            using (SqlConnection conn = DBConnection.ObtenerConexion())
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    int idVenta = 0;

                    // Usar el procedimiento almacenado para obtener el último ID de venta
                    using (SqlCommand cmd = new SqlCommand("sp_ObtenerUltimoIdVenta", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Ejecutar el procedimiento y obtener el resultado
                        idVenta = (int)cmd.ExecuteScalar();
                    }

                    return idVenta;

                }
            }

        }



        //private void ActualizarTabla()
        //{
        //    dgvDetalles.Rows.Clear(); // Limpiar filas existentes

        //    foreach (var detalle in detallesVenta)
        //    {
        //        dgvDetalles.Rows.Add(detalle.codigoBarras, detalle.nombre, detalle.marca, detalle.cantidad, detalle.precioVenta, detalle.subtotal);
        //    }
        //}


        private void LimpiarFormulario()
        {
            // Limpiar los campos de texto
            txtTotal.Text = "0";
            txtCambio.Text = "0";
            txtPagaCon.Clear();
            dgvDetalles.Rows.Clear(); // Para limpiar el DataGridView
            nudCantidad.Value = 1; // Resetear cantidad
                                   // También puedes limpiar cualquier otro control necesario
        }



        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text.Trim();
                if (string.IsNullOrEmpty(codigo)) return;

                var producto = ProductoDAL.BuscarProducto(codigo);
                if (producto != null)
                {
                    txtProducto.Text = producto.nombre;
                    txtPrecio.Text = producto.precioVenta.ToString();
                    nudCantidad.Maximum = producto.existencia;
                    nudCantidad.Enabled = true;
                    btnAgregar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el campo de código de barras no esté vacío
                if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                {
                    MessageBox.Show("Debes ingresar un código de barras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que la cantidad sea mayor a 0
                if (nudCantidad.Value <= 0)
                {
                    MessageBox.Show("La cantidad debe ser mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que el precio sea un número válido
                if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
                {
                    MessageBox.Show("El precio del producto no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear un nuevo DetalleVenta
                DetalleVenta detalle = new DetalleVenta
                {
                    codigoBarras = Convert.ToInt32(txtCodigo.Text),
                    cantidad = (int)nudCantidad.Value,
                    precioVenta = precio,
                    subtotal = (int)nudCantidad.Value * precio,
                    nombre = txtProducto.Text,
                };

                // Agregar el detalle a la lista global
                listaDetalles.Add(detalle);

                // Agregar una nueva fila al DataGridView
                dgvDetalles.Rows.Add(detalle.codigoBarras, detalle.nombre, detalle.cantidad, detalle.precioVenta, detalle.subtotal);

                // Actualizar el total
                txtTotal.ForeColor = Color.LightGray;
                ActualizarTotal();
                nudCantidad.Value = 0;
                labelTotal.Visible = true;

               

                // Limpiar los campos después de agregar
                //LimpiarCampos();
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show($"Error al agregar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Verificar si hay productos en la lista de detalles
                if (listaDetalles.Count == 0)
                {
                    MessageBox.Show("Debe agregar productos antes de registrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2. Verificar que el cliente haya pagado lo suficiente
                if (!decimal.TryParse(txtPagaCon.Text, out decimal pagoCliente))
                {
                    MessageBox.Show("El monto ingresado en 'Paga con' no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal totalVenta = listaDetalles.Sum(d => d.subtotal); // Sumar los subtotales
                if (pagoCliente < totalVenta)
                {
                    MessageBox.Show("El monto pagado no es suficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. Verificar stock de productos
                foreach (var detalle in listaDetalles)
                {
                    using (SqlConnection conn = DBConnection.ObtenerConexion())
                    {
                        conn.Open();
                        string query = "SELECT existencia FROM tbProductos WHERE codigoBarras = @codigoBarras";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@codigoBarras", detalle.codigoBarras);
                            int existencia = (int)cmd.ExecuteScalar();
                            if (existencia < detalle.cantidad)
                            {
                                MessageBox.Show($"No hay suficiente stock para el producto: {detalle.codigoBarras}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }

                // Crear el objeto de venta con los detalles
                Venta venta = new Venta
                {
                    descuento = 0, // Asume el descuento que desees
                    iva = 0.16m,   // Asume el IVA que desees
                    monto = totalVenta, // Suma de los subtotales
                    Detalles = listaDetalles // Los detalles de los productos
                };

                int idEmpleado = 1; // Asume un valor adecuado para el empleado que realiza la venta

                // Crear la instancia de VentaDAL y registrar la venta
                VentaDAL ventaDAL = new VentaDAL();
                int idVentaGenerada = ventaDAL.RegistrarVenta(venta, idEmpleado); // No pases idVenta

                if (idVentaGenerada == 0)
                {
                    MessageBox.Show("Error al generar el ID de la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Mostrar mensaje de éxito
                MessageBox.Show($"Venta registrada exitosamente con el ID: {idVentaGenerada}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Confirmar si el usuario quiere imprimir el ticket
                DialogResult result = MessageBox.Show("¿Desea imprimir el ticket?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ImprimirTicket(idVentaGenerada); // Método para generar e imprimir el ticket
                }

                // Limpiar el formulario y el DataGridView
                LimpiarFormulario2();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarFormulario2()
        {
            // Limpiar lista de detalles
            listaDetalles.Clear();

            // Limpiar el DataGridView
            dgvDetalles.Rows.Clear(); // Elimina todas las filas sin alterar las columnas del diseñador

            // Reiniciar valores de los controles
            txtTotal.Text = "Total";
            txtPagaCon.Text= "Paga con";
            txtCambio.Text="Cambio";
            nudCantidad.Value = 1;
            txtCodigo.Text="Codigo";
            txtProducto.Text="Nombre";
            txtPrecio.Text="Precio";
            nudCantidad.Enabled = false;
            btnAgregar.Enabled = false;

            txtCambio.ForeColor = Color.DimGray;
            txtPagaCon.ForeColor = Color.DimGray;
            txtPrecio.ForeColor = Color.DimGray;
            txtTotal.ForeColor = Color.DimGray; 
            txtProducto.ForeColor = Color.DimGray;

            labelCodigo.Visible = false;
            labelCambio.Visible = false;
            labelNombre.Visible = false;
            labelPagaC.Visible = false;
            labelPrecio.Visible = false;
            labelTotal.Visible = false;

            nudCantidad.Value = 0;
        }


        private void ImprimirTicket(int idVenta)
        {
            // Crear documento de impresión
            PrintDocument printDoc = new PrintDocument();

            // Asignar el controlador de eventos para el manejo de la impresión
            printDoc.PrintPage += (sender, e) =>
            {
                // Definir la fuente
                Font font = new Font("Arial", 10);

                // Definir el área de impresión
                float yPos = 0;

                // Título y detalles de la venta
                e.Graphics.DrawString("TIENDA CRUMAR", font, Brushes.Black, 10, yPos);
                yPos += 20;
                e.Graphics.DrawString($"ID Venta: {idVenta}", font, Brushes.Black, 10, yPos);
                yPos += 20;
                e.Graphics.DrawString($"Fecha: {DateTime.Now}", font, Brushes.Black, 10, yPos);
                yPos += 20;
                e.Graphics.DrawString("=====================================", font, Brushes.Black, 10, yPos);
                yPos += 20;

                // Agregar los productos de la venta
                foreach (var detalle in listaDetalles)
                {
                    string line = $"{detalle.codigoBarras} - {detalle.cantidad} x {detalle.precioVenta:C} = {detalle.subtotal:C}";
                    e.Graphics.DrawString(line, font, Brushes.Black, 10, yPos);
                    yPos += 20;
                }

                // Total de la venta
                decimal totalVenta = listaDetalles.Sum(d => d.subtotal);
                e.Graphics.DrawString($"Total: {totalVenta:C}", font, Brushes.Black, 10, yPos);
                yPos += 20;

                // Mensaje de agradecimiento
                e.Graphics.DrawString("¡Gracias por su compra!", font, Brushes.Black, 10, yPos);
            };

            // Configuración de la impresora predeterminada
            printDoc.PrinterSettings.PrinterName = "Generic / Text Only"; // Especifica el nombre de tu impresora de tickets

            // Imprimir el documento
            try
            {
                printDoc.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir el ticket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmRegistrarVenta_Load(object sender, EventArgs e)
        {

        }
        //private void CalcularTotales()
        //{
        //    decimal subtotal = detallesVenta.Sum(d => d.precioVenta * d.cantidad);
        //    decimal iva = subtotal * 0.16m; // Ajusta según tu porcentaje de IVA
        //    decimal descuento = 0; // Implementa la lógica de descuentos según tus necesidades

        //    ventaActual.monto = subtotal;
        //    ventaActual.iva = iva;
        //    ventaActual.descuento = descuento;

        //    txtTotal.Text = (subtotal + iva - descuento).ToString("C");
        //}

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtProducto.Clear();
            txtPrecio.Clear();
            nudCantidad.Value = 1;
            nudCantidad.Enabled = false;
            btnAgregar.Enabled = false;
            
            txtCodigo.Focus();

        }

        private void txtCambio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (decimal.TryParse(txtPagaCon.Text, out var pago) && decimal.TryParse(txtTotal.Text, out var total))
            {
                try
                {
                    using (SqlConnection conn = DBConnection.ObtenerConexion())
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand("sp_CalcularCambio", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@total", total);
                            cmd.Parameters.AddWithValue("@pago", pago);

                            var cambioParam = new SqlParameter("@cambio", SqlDbType.Money)
                            {
                                Direction = ParameterDirection.Output
                            };
                            cmd.Parameters.Add(cambioParam);

                            cmd.ExecuteNonQuery();

                            // Mostrar el cambio
                            txtCambio.Text = cambioParam.Value.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al calcular el cambio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtCambio.Text = "0";
            }


        }

        private void txtTotal_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            using (SqlConnection conn = DBConnection.ObtenerConexion())
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_CalcularTotalVenta", conn, transaction))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@idVenta", idVentaActual);

                            var totalParam = new SqlParameter("@total", SqlDbType.Money)
                            {
                                Direction = ParameterDirection.Output
                            };
                            cmd.Parameters.Add(totalParam);

                            cmd.ExecuteNonQuery();

                            txtTotal.Text = totalParam.Value.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al calcular el total: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void txtPagaCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // Si se presiona Enter
            {
                if (decimal.TryParse(txtPagaCon.Text, out decimal pagaCon) &&
                    decimal.TryParse(txtTotal.Text, out decimal total))
                {
                    // Calcular el cambio
                    decimal cambio = pagaCon - total;

                    // Mostrar el cambio
                    txtCambio.Text = cambio >= 0 ? cambio.ToString("0.00") : "0.00";

                    labelCambio.Visible = true;
                    txtCambio.ForeColor = Color.LightGray;
                }
                else
                {
                    txtCambio.Text = "0.00"; // Si los valores no son válidos
                }
            }

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay una fila seleccionada en el DataGridView
                if (dgvDetalles.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvDetalles.SelectedRows[0];

                // Verificar si la columna "codigoBarras" existe y tiene un valor
                if (filaSeleccionada.Cells["codigoBarras"] == null || filaSeleccionada.Cells["codigoBarras"].Value == null)
                {
                    MessageBox.Show("No se pudo identificar el producto seleccionado. Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener el código de barras del producto seleccionado
                string codigoBarrasSeleccionado = filaSeleccionada.Cells["codigoBarras"].Value.ToString();

                // Buscar el producto en la lista listaDetalles por su código de barras
                var detalleAEliminar = listaDetalles.FirstOrDefault(d => d.codigoBarras == Convert.ToInt32(codigoBarrasSeleccionado));

                // Verificar si el producto existe en la lista
                if (detalleAEliminar == null)
                {
                    MessageBox.Show("No se pudo identificar el producto en la lista de detalles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirmar la eliminación
                DialogResult result = MessageBox.Show(
                    $"¿Está seguro de que desea eliminar el producto con código de barras: {codigoBarrasSeleccionado}?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    // Eliminar el producto de la lista
                    listaDetalles.Remove(detalleAEliminar);

                    // Actualizar el DataGridView
                    dgvDetalles.DataSource = null;
                    dgvDetalles.DataSource = listaDetalles;

                    // Actualizar el total
                    ActualizarTotal();

                    MessageBox.Show("Producto eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }

        
        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay una fila seleccionada en el DataGridView
                if (dgvDetalles.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvDetalles.SelectedRows[0];

                // Verificar si la columna "codigoBarras" existe y tiene un valor
                if (filaSeleccionada.Cells["codigoBarras"] == null || filaSeleccionada.Cells["codigoBarras"].Value == null)
                {
                    MessageBox.Show("No se pudo identificar el producto seleccionado. Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener el código de barras del producto seleccionado
                string codigoBarrasSeleccionado = filaSeleccionada.Cells["codigoBarras"].Value.ToString();

                // Buscar el producto en la lista listaDetalles por su código de barras
                var detalleAEliminar = listaDetalles.FirstOrDefault(d => d.codigoBarras == Convert.ToInt32(codigoBarrasSeleccionado));

                // Verificar si el producto existe en la lista
                if (detalleAEliminar == null)
                {
                    MessageBox.Show("No se pudo identificar el producto en la lista de detalles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirmar la eliminación
                DialogResult result = MessageBox.Show(
                    $"¿Está seguro de que desea eliminar el producto con código de barras: {codigoBarrasSeleccionado}?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    // Eliminar el producto de la lista
                    listaDetalles.Remove(detalleAEliminar);

                    // Eliminar la fila manualmente del DataGridView
                    dgvDetalles.Rows.Remove(filaSeleccionada);


                    // Actualizar el total
                    ActualizarTotal();

                    MessageBox.Show("Producto eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "Codigo")
            {
                txtCodigo.Text = "";
                txtCodigo.ForeColor = Color.LightGray;
                labelCodigo.Visible = true;
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                txtCodigo.Text = "Codigo";
                txtCodigo.ForeColor = Color.DimGray;
                labelCodigo.Visible = false;
                labelMensaje.Visible = false;
            }
        }

        private void txtPrecio_Enter(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "Precio")
            {
                txtPrecio.Text = "";
                txtPrecio.ForeColor = Color.LightGray;
                labelPrecio.Visible = true;
            }
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "")
            {
                txtPrecio.Text = "Precio";
                txtPrecio.ForeColor = Color.DimGray;
                labelPrecio.Visible = false;
            }
        }

        private void txtProducto_Enter(object sender, EventArgs e)
        {
            if (txtProducto.Text == "Nombre")
            {
                txtProducto.Text = "";
                txtProducto.ForeColor = Color.LightGray;
                labelNombre.Visible = true;
            }
        }

        private void txtProducto_Leave(object sender, EventArgs e)
        {
            if (txtProducto.Text == "")
            {
                txtProducto.Text = "Nombre";
                txtProducto.ForeColor = Color.DimGray;
                labelNombre.Visible = false;
            }
        }

        private void txtTotal_Enter(object sender, EventArgs e)
        {
            if (txtTotal.Text == "Total")
            {
                txtTotal.Text = "";
                txtTotal.ForeColor = Color.LightGray;
                labelTotal.Visible = true;
            }
        }

        private void txtTotal_Leave(object sender, EventArgs e)
        {
            if (txtTotal.Text == "")
            {
                txtTotal.Text = "Total";
                txtTotal.ForeColor = Color.DimGray;
                labelTotal.Visible = false;
            }
        }

        private void txtPagaCon_Enter(object sender, EventArgs e)
        {
            if (txtPagaCon.Text == "Paga con")
            {
                txtPagaCon.Text = "";
                txtPagaCon.ForeColor = Color.LightGray;
                labelPagaC.Visible = true;
            }
        }

        private void txtPagaCon_Leave(object sender, EventArgs e)
        {
            if (txtPagaCon.Text == "")
            {
                txtPagaCon.Text = "Paga con";
                txtPagaCon.ForeColor = Color.DimGray;
                labelPagaC.Visible = false;
            }
        }

        private void txtCambio_Enter(object sender, EventArgs e)
        {
            if (txtCambio.Text == "Cambio")
            {
                txtCambio.Text = "";
                txtCambio.ForeColor = Color.LightGray;
                labelCambio.Visible = true;
            }
        }

        private void txtCambio_Leave(object sender, EventArgs e)
        {
            if (txtCambio.Text == "")
            {
                txtCambio.Text = "Cambio";
                txtCambio.ForeColor = Color.DimGray;
                labelCambio.Visible = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text.Trim();
                if (string.IsNullOrEmpty(codigo)) return;

                var producto = ProductoDAL.BuscarProducto(codigo);
                if (producto != null)
                {
                    txtProducto.Text = producto.nombre;
                    txtPrecio.Text = producto.precioVenta.ToString();
                    nudCantidad.Maximum = producto.existencia;
                    nudCantidad.Enabled = true;
                    btnAgregar.Enabled = true;

                    labelPrecio.Visible = true;
                    labelNombre.Visible = true;

                    txtPrecio.ForeColor = Color.LightGray;
                    txtProducto.ForeColor = Color.LightGray;

                    labelMensaje.Visible = false;
                }
                else
                {

                    labelMensaje.Text= "Producto no encontrado";
                    labelMensaje.Visible= true;

                    //MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                if (txtCodigo.Text=="Codigo")
                {
                    txtCodigo.ForeColor = Color.DimGray;
                }
                else
                {
                    MessageBox.Show($"Error al buscar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }

        }
    }
}

