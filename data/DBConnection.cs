using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nenita.Data
{
    internal class DBConnection
    {

        private static string cadenaConexion = @"Data Source=localhost\SQLExpress;Initial Catalog=CRUMARpv;Integrated Security=True;";
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}

 




