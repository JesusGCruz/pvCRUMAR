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

        static string cadena = @"Data source=DEYDEY\SQLSERVERY;Initial Catalog=db_CRUMAR;Integrated Security=True";

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
            
            }finally {
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

        public bool AutenticarUsuarios(string usuario, string pass)
        {
            try
            {
                bool bandera = false;

                sentencia = "SELECT * FROM usuariosAdmin.tbUsuarios WHERE usuario = @urs AND pass = @pass AND activo = 1";

                comando = new SqlCommand(sentencia, conexion);

                comando.Parameters.AddWithValue("@urs", usuario);
                comando.Parameters.AddWithValue("@pass", pass);
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

        public System.Collections.Generic.List<global::CapaEn.Producto> Listar()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
