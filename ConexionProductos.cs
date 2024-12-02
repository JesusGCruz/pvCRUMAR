using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LoginCRUMAR
{
    public class ConexionProductos
    {
        public ConexionProductos()
        {

        }
        static string cadena = @"Data Source=JesusCruz\SQLEXPRESS;Initial Catalog=Crumarpv;Integrated Security=True";

        public SqlConnection conexion = new SqlConnection(cadena);

        SqlCommand comando = new SqlCommand();

        SqlDataReader lector;

        string sentencia = "";
        public bool agregarProducto(int codigoBarras, string nombre, string marca, string iva, string existencias, double precioC, double precioV, DateTime fechaCad)
        {
            try
            {
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandText = "spInsertarProducto";
                comando.CommandType = CommandType.StoredProcedure;


                comando.Parameters.AddWithValue("@codigoBarras", codigoBarras);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@marca", marca);
                comando.Parameters.AddWithValue("@iva", iva);
                comando.Parameters.AddWithValue("@existencia", existencias);
                comando.Parameters.AddWithValue("@precioCompra", precioC);
                comando.Parameters.AddWithValue("@precioVenta", precioV);
                comando.Parameters.AddWithValue("@fechaCaducidad", fechaCad);

                if (comando.ExecuteNonQuery() != -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                comando.Parameters.Clear();

            }
            finally
            {
                conexion.Close();
            }
            return false;
        }

        public bool AutenticarUsuarioP(string usuario, string contraseña)
        {
            try
            {

                bool bandera = false;

                
                comando.Connection = conexion;
                comando.CommandText = "spAutenticarUsuarioP";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contraseña", contraseña);
                conexion.Open();
                lector = comando.ExecuteReader();

                if (lector.Read())
                {
                   bandera = true;
                }
                else
                {
                    bandera = false;
                }
                return bandera;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message);
                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message);
                return false;

            }
            finally
            {
                conexion.Close();

            }
            
        }

        public bool actualizarProducto(int codigoBarras, string nombre, string marca, string iva, string existencias, double precioC, double precioV, DateTime fechaCad)
        {
            try
            {
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandText = "spActualizarProducto";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@codigoBarras", codigoBarras);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@marca", marca);
                comando.Parameters.AddWithValue("@iva", iva);
                comando.Parameters.AddWithValue("@existencia", existencias);
                comando.Parameters.AddWithValue("@precioCompra", precioC);
                comando.Parameters.AddWithValue("@precioVenta", precioV);
                comando.Parameters.AddWithValue("@fechaCaducidad", fechaCad);

                if (comando.ExecuteNonQuery() != -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                comando.Parameters.Clear();
            }
            finally
            {
                conexion.Close();
            }
            return false;
        }

        public string eliminarProducto(int codigoBarras)
        {
            string mensaje = "";
            try
            {
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandText = "spEliminarProducto";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear(); 
                comando.Parameters.AddWithValue("@codigoBarras", codigoBarras);

                
                object result = comando.ExecuteScalar();
                if (result != null)
                {
                    mensaje = result.ToString();
                    return mensaje;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mensaje = "Error al eliminar el producto: " + ex.Message;
                comando.Parameters.Clear();
            }
            finally
            {
                conexion.Close();
            }
            return mensaje;
        }

        public DataSet ConsultarProductos()
        {
            try
            {
                
                sentencia = "spConsultarProducto";
                comando = new SqlCommand(sentencia, conexion);
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet datos = new DataSet();
                adapter.Fill(datos, "tbProductos");
                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return null;
        }

        //Metodos par los Pedidos
        public DataSet ConsultarPedidos()
        {
            try
            {

                sentencia = "spConsultarProductosProveedores";
                comando = new SqlCommand(sentencia, conexion);
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet datos = new DataSet();
                adapter.Fill(datos, "tbProductos_Proveedores");
                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return null;
        }

        public bool agregarPedido(int idProveedor, int codigoBarras, DateTime fecha, int cantidadPro)
        {
            try
            {
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandText = "spInsertarProductoProveedor";
                comando.CommandType = CommandType.StoredProcedure;


                comando.Parameters.AddWithValue("@idProveedor", idProveedor);
                comando.Parameters.AddWithValue("@codigpBarras", codigoBarras);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.Parameters.AddWithValue("@cantidadProducto", cantidadPro);
               

                if (comando.ExecuteNonQuery() != -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                comando.Parameters.Clear();

            }
            finally
            {
                conexion.Close();
            }
            return false;
        }

        public string eliminarPedido(int numPedido)
        {
            string mensaje = "";
            try
            {
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandText = "sp_EliminarProductoProveedor";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idProductoProve", numPedido);


                object result = comando.ExecuteScalar();
                if (result != null)
                {
                    mensaje = result.ToString();
                    return mensaje;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mensaje = "Error al eliminar el producto: " + ex.Message;
                comando.Parameters.Clear();
            }
            finally
            {
                conexion.Close();
            }
            return mensaje;
        }


        public bool actualizarPedido(int idProveedor, int codigoBarras, DateTime fechaP, int ProductoPro, int cantidadPro)
        {
            try
            {
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandText = "spActualizarProductoProveedor";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idProveedor", idProveedor);
                comando.Parameters.AddWithValue("@codigpBarras", codigoBarras);
                comando.Parameters.AddWithValue("@fecha", fechaP);
                comando.Parameters.AddWithValue("@idProductoProve", ProductoPro);
                comando.Parameters.AddWithValue("@cantidadProducto", cantidadPro);

                if (comando.ExecuteNonQuery() != -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                comando.Parameters.Clear();
            }
            finally
            {
                conexion.Close();
            }
            return false;
        }




    }

}
