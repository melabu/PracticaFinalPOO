using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Server
{
    internal static class AdminDB
    {
        internal static SqlConnection ConectarBase()
        {
            string cadena = Entidades.Properties.Settings.Default.KeyDBClub;
            SqlConnection connection = new SqlConnection(cadena);

            connection.Open();
            return connection;
        }
    }
}
