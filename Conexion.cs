using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginCRUMAR
{
    public class Conexion
    {
        public Conexion()
        {
        }

        static string cadena = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=db_CRUMAR;Integrated Security=True";

        public SqlConnection conexion = new SqlConnection(cadena);

        SqlCommand comando = new SqlCommand();

        SqlDataReader lector;

        string sentencia = "";

        #region Usuarios

        public bool actualizarUsuario(string usuario, string contra, string nombre, string apellido, bool activo)
        {
            try
            {
                sentencia = "update usuariosAdmin.tbUsuarios set pass = @contra, nombre = @nombre, apellidos = @apellido, activo = @activo where usuario = @usuario;";
                comando = new SqlCommand(sentencia, conexion);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contra", contra);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@activo", activo);

                conexion.Open();

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

            }
            finally
            {
                conexion.Close();
            }
            return false;
        }

        public bool eliminarUsuario(int id)
        {
            try
            {
                sentencia = "delete from usuariosAdmin.tbUsuarios where idUsuario = @id;";
                comando = new SqlCommand(sentencia, conexion);
                comando.Parameters.AddWithValue("@id", id);

                conexion.Open();

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
            }
            finally
            {
                conexion.Close();
            }
            return false;
        }

        public bool agregarUsuario(int id, string usuario, string contra, string nombre, string apellido, bool activo)
        {
            try
            {
                conexion.Open();
                //sentencia = "insert into usuariosAdmin.tbUsuarios values(@id, @usuario, @contra, @nombre, @apellido, @activo);";
                //sentencia = "exec spInsertarUsuario2 @id, @usuario, @contra, @nombre, @apellido, @activo;";
                comando.Connection = conexion;
                comando.CommandText = "spInsertarUsuario";
                comando.CommandType = CommandType.StoredProcedure;

                //comando = new SqlCommand(sentencia, conexion);

                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contra", contra);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@activo", activo);

                conexion.Open();

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

            } finally {
                conexion.Close();
            }
            return false;
        }

        public DataSet consultarUsuario(string usuario)
        {
            try
            {
                /*
                 */
                comando.Connection = conexion;
                comando.CommandText = "spBuscarUsuario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@usrName", usuario);

                SqlDataReader leer = comando.ExecuteReader();
                //sentencia = "SELECT * FROM usuariosAdmin.tbUsuarios where usuario = '"+usuario+"';";

                //comando = new SqlCommand(sentencia, conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet datos = new DataSet();
                adapter.Fill(datos, "tbUsuarios");
                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message);
            }
            finally
            {
                comando.Parameters.Clear();
                conexion.Close();
            }
            return null;
        }

        public DataSet ConsultaUsuarios()
        {
            try
            {
                sentencia = "SELECT * FROM usuariosAdmin.tbUsuarios";
                comando = new SqlCommand(sentencia, conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet datos = new DataSet();
                adapter.Fill(datos, "tbUsuarios");
                return datos;
            }
            catch (Exception ex) {
                MessageBox.Show("Error de SQL: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return null;
        }

        //public bool AutenticarUsuarios(string usuario, string pass)
        //{
        //    try
        //    {
        //        bool bandera = false;

        //        sentencia = "SELECT * FROM dbo.tbEmpleados WHERE usuario = @usuario AND pass = @contrasenha AND activo = 1";

        //        comando = new SqlCommand(sentencia, conexion);

        //        comando.Parameters.AddWithValue("@usuario", usuario);
        //        comando.Parameters.AddWithValue("@contrasenha", pass);
        //        conexion.Open();
        //        lector = comando.ExecuteReader();
        //        if (lector.Read())
        //        {
        //            bandera = true;
        //        }
        //        else
        //        {
        //            bandera = false;

        //        }
        //        return bandera;
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show("Error de SQL: " + ex.Message);
        //        return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error general: " + ex.Message);
        //        return false;
        //    }

        //    finally
        //    {
        //        conexion.Close();
        //    }
        //}
        public bool AutenticarUsuarios(string usuario, string pass)
        {
            try
            {
                bool bandera = false;

                sentencia = "SELECT * FROM dbo.tbEmpleados WHERE usuario = @usuario AND contraseña = @contrasenha AND activo = 1";

                comando = new SqlCommand(sentencia, conexion);

                // Agregar parámetros
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contrasenha", pass);

                conexion.Open();
                lector = comando.ExecuteReader();

                if (lector.Read()) // Si encuentra un registro
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
        #endregion
        public bool agregarproveedor( string nombre, string numtelefono, int ladapais, string correo, bool activo, DataGridView dgv)
        {
            try
            {
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandText = "InsertarProveedorYContacto";
                comando.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros al comando
                comando.Parameters.Clear();
               
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@numTelefono", numtelefono);
                comando.Parameters.AddWithValue("@ladaPais", ladapais);
                comando.Parameters.AddWithValue("@correoElectronico", correo);
                comando.Parameters.AddWithValue("@activo", activo);

                // Ejecutar el comando
                int filasAfectadas = comando.ExecuteNonQuery();
               
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                // Registrar o mostrar el error
                MessageBox.Show($"Error al agregar proveedor: {ex.Message}");
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
        public DataTable obtenerProveedores()
        {
            using (SqlConnection conn = new SqlConnection(cadena))
            {
                try
                {

                    DataTable dt = new DataTable();
                    using (SqlCommand cmd = new SqlCommand("sp_ObtenerProveedoresContactos2", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            conn.Open();
                            adapter.Fill(dt);
                            return dt;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener proveedores: {ex.Message}");
                    return null;
                }


            }
        }
        public DataTable obtenerProveedores2(string idpro)
        {
            using (SqlConnection conn = new SqlConnection(cadena))
            {
                try
                {
                    DataTable dt = new DataTable();
                    using (SqlCommand cmd = new SqlCommand("sp_ObtenerProveedoresContactos3", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar parámetro al procedimiento almacenado
                        cmd.Parameters.AddWithValue("@idpro", idpro);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            conn.Open();
                            adapter.Fill(dt);
                        }
                    }

                    return dt; // Retorna el DataTable con los datos
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener proveedores: {ex.Message}");
                    return null;
                }
            }
        }



        public bool actualizarProveedor(int idprovee, string nombre, string numtelefono, string ladapais, string correo, bool activo, DataGridView dgv)
        {
            try
            {
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandText = "sp_ActualizarProveedorYContacto";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idproveedor", idprovee);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@numTelefono", numtelefono);
                comando.Parameters.AddWithValue("@ladaPais", ladapais);
                comando.Parameters.AddWithValue("@correoElectronico", correo);
                comando.Parameters.AddWithValue("@activo", activo);

                int filasAfectadas = comando.ExecuteNonQuery();
                
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar proveedor: {ex.Message}");
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
        public bool eliminarProveedor(int idprovee, DataGridView dgv)
        {
            try
            {
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandText = "EliminarProveedoryContacto";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idproveedor", idprovee);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                  
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar proveedor: {ex.Message}");
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }


        // Método privado para actualizar el grid
        // Método que actualiza el DataGridView
      

    }

}

