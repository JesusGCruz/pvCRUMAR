using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginCRUMAR
{
    internal class VentaDAL
    {

        public int IdVenta { get; set; }
        public decimal Monto { get; set; }
        public decimal Descuento { get; set; }
        public decimal Iva { get; set; }
        public DateTime Fecha { get; set; }
        public List<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();

        public int RegistrarVenta(Venta venta, int idEmpleado)
        {

            using (SqlConnection conn = DBConnection.ObtenerConexion())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    int idVenta; // Aquí se almacenará el ID generado

                    // Llamada al procedimiento almacenado para registrar la venta
                    using (SqlCommand cmd = new SqlCommand("usp_RegistrarVenta", conn, transaction))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@descuento", venta.descuento);
                        cmd.Parameters.AddWithValue("@iva", venta.iva);
                        cmd.Parameters.AddWithValue("@monto", venta.monto);
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now);

                        // Parámetro de salida para obtener el ID de la venta
                        SqlParameter idVentaParam = new SqlParameter("@idVenta", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(idVentaParam);

                        // Ejecutar el procedimiento
                        cmd.ExecuteNonQuery();

                        // Obtener el ID generado
                        idVenta = (int)idVentaParam.Value;
                    }

                    // Registrar los productos de la venta
                    foreach (var detalle in venta.Detalles)
                    {
                        using (SqlCommand cmdProducto = new SqlCommand("sp_AgregarProductoVenta", conn, transaction))
                        {
                            cmdProducto.CommandType = CommandType.StoredProcedure;
                            cmdProducto.Parameters.AddWithValue("@idVenta", idVenta);
                            cmdProducto.Parameters.AddWithValue("@codigoBarras", detalle.codigoBarras);
                            cmdProducto.Parameters.AddWithValue("@cantidad", detalle.cantidad);

                            cmdProducto.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    return idVenta;  // Retorna el ID de la venta registrada
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }


        }
    }
}