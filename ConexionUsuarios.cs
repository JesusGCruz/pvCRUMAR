using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Documents;
using System.Windows.Forms;

namespace LoginCRUMAR
{
    public class ConexionUsuarios
    {
        static string cadena;
        
        public SqlConnection conexion;

        SqlCommand comando;

        string sentencia = "";
        public ConexionUsuarios()
        {
            cadena = @"Data Source=JesusCruz\SQLEXPRESS;Initial Catalog=Crumarpv;Integrated Security=True";
            conexion = new SqlConnection(cadena);
            comando = new SqlCommand();
        }

        //static string cadena = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=dbEmpresaWX;Integrated Security=True";


        public bool actualizarUsuario(string rfc, string nombres, string apellidos, string horario, string rolNom, string usuario, string contrasenha, bool activo)
        {
            try
            {
                sentencia = "spActualizarEmpleado";
                comando = new SqlCommand(sentencia,conexion);
                conexion.Open();


                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@RFC", rfc);
                comando.Parameters.AddWithValue("@Nombres", nombres);
                comando.Parameters.AddWithValue("@Apellidos", apellidos);
                comando.Parameters.AddWithValue("@Horario", horario);
                comando.Parameters.AddWithValue("@RolNom", rolNom);
                comando.Parameters.AddWithValue("@Usuario", usuario);
                comando.Parameters.AddWithValue("@Contrasenha", contrasenha);
                comando.Parameters.AddWithValue("@Activo", activo);

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
                comando.Parameters.Clear();
                conexion.Close();
            }
            return false;
        }

        public bool eliminarUsuario(string rfc)
        {
            try
            {
                sentencia = "spEliminarEmpleado";
                comando = new SqlCommand(sentencia, conexion);
                conexion.Open();


                comando.CommandType = CommandType.StoredProcedure;


                comando.Parameters.AddWithValue("RFC", rfc);
                
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

        public bool agregarUsuario(string rfc, string nombres, string apellidos, string horario, string rolNom, string usuario, string contrasenha, bool activo)
        {
            try
            {
                sentencia = "spRegistrarEmpleado";
                comando = new SqlCommand(sentencia, conexion);
                conexion.Open();


                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@RFC", rfc);
                comando.Parameters.AddWithValue("@Nombres", nombres);
                comando.Parameters.AddWithValue("@Apellidos", apellidos);
                //comando.Parameters.AddWithValue("@idEmpleado", id);
                comando.Parameters.AddWithValue("@Horario", horario);
                comando.Parameters.AddWithValue("@RolNom", rolNom);
                comando.Parameters.AddWithValue("@Usuario", usuario);
                comando.Parameters.AddWithValue("@Contrasenha", contrasenha);
                comando.Parameters.AddWithValue("@Activo", activo);


                if (comando.ExecuteNonQuery() != -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            /*
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.Class.ToString());
            }
             */
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                comando.Parameters.Clear();
                conexion.Close();
            }
            return false;
        }

        public DataSet consultarUsuario(string usuario)
        {
            try
            {
                DataSet datos = new DataSet();
                
                sentencia = "spBuscarUsuario";
                SqlDataAdapter da = new SqlDataAdapter(sentencia, conexion);
                conexion.Open();

                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //da.SelectCommand.Parameters.Add("@usrName", SqlDbType.VarChar).Value = usuario;
                da.SelectCommand.Parameters.AddWithValue("@usrName", usuario);

                da.Fill(datos);
                
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

        public bool Existente(string rfc)
        {
            try
            {
                sentencia = "select dbo.fEmpleadoExis(@RFC)";

                comando = new SqlCommand();

                comando.Connection = conexion;

                comando.CommandType = CommandType.Text;

                comando.CommandText = sentencia;

                comando.Parameters.AddWithValue("@RFC", rfc);

                conexion.Open();
                object resultado = comando.ExecuteScalar();



                if (DBNull.Value != resultado)
                {
                    return Convert.ToBoolean(resultado);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return false;
        }

        public ArrayList getDatosPerfil(string usuario)
        {
            try
            {
                ArrayList list = new ArrayList();

                sentencia = "select * from dbo.fDatosPerfil(@Usuario)";
                comando = new SqlCommand(sentencia, conexion);
                comando.Parameters.AddWithValue("@Usuario", usuario);
                conexion.Open();

                SqlDataReader reader = comando.ExecuteReader();
                reader.Read();
                list.Add(reader.GetString(reader.GetOrdinal("nombres")));
                list.Add(reader.GetString(reader.GetOrdinal("apellidos")));
                list.Add(reader.GetString(reader.GetOrdinal("usuario")));
                list.Add(reader.GetString(reader.GetOrdinal("contrasenha")));

                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally    { conexion.Close(); }
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

        public ArrayList getRoles()
        {
            try
            {
                conexion.Open();
                sentencia = "select nombre from tbRoles;";
                comando = new SqlCommand(sentencia, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                ArrayList roles = new ArrayList();
                while (reader.Read())
                {
                    roles.Add(reader.GetString(0));
                }

                return roles;
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


        public int AutenticarUsuarios(string usuario, string pass)
        {
            try
            {

                sentencia = "select dbo.spAutenticarUsuario(@urs,@pass)";

                comando = new SqlCommand();

                comando.Connection = conexion;

                comando.CommandType = CommandType.Text;

                comando.CommandText = sentencia;

                comando.Parameters.AddWithValue("@urs", usuario);
                comando.Parameters.AddWithValue("@pass", pass);

                conexion.Open();
                object resultado = comando.ExecuteScalar();


                
                if(DBNull.Value != resultado)
                {
                    return Convert.ToInt32(resultado);
                }
                else
                {
                    return 0;
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message);
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message);
                return 0;
            }

            finally
            {
                conexion.Close();
            }
        }
        /*
         */

        internal bool agregarUsuario(int v, string text1, string text2, string text3, string text4, bool @checked)
        {
            throw new NotImplementedException();
        }

    }
}
