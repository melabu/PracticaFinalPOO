using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades.Models;
using Entidades.Server;

namespace Entidades.Admin
{
    public static class AdmJugador
    {
        public static List<Jugador> Listar()
        {
            string querySql = "SELECT Id,Nombre,Apellido,FechaNacimiento,Puesto FROM dbo.Jugador";
            SqlCommand command = new SqlCommand(querySql, AdminDB.ConectarBase());

            SqlDataReader reader;
            reader = command.ExecuteReader();

            List<Jugador> listaJugadores = new List<Jugador>();

            while (reader.Read())
            {
                listaJugadores.Add
                    (
                    new Jugador
                    {
                        Id = (int)reader["Id"],
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        FechaNacimiento = (DateTime)reader["FechaNacimiento"],
                        Puesto = reader["Puesto"].ToString()
                    }
                    );
            }

            AdminDB.ConectarBase().Close();
            reader.Close();

            return listaJugadores;
        }

        public static DataTable ListarPuestos()
        {
            string querySql = "SELECT DISTINCT Puesto FROM dbo.Jugador";

            SqlDataAdapter adapter = new SqlDataAdapter(querySql, AdminDB.ConectarBase());

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Puesto");

            return ds.Tables["Puesto"];
        }

        public static DataTable Listar(string puesto)
        {
            string querySql = "SELECT Id,Nombre,Apellido,FechaNacimiento,Puesto FROM dbo.Jugador WHERE Puesto = @Puesto";

            SqlDataAdapter adapter = new SqlDataAdapter(querySql, AdminDB.ConectarBase());

            adapter.SelectCommand.Parameters.Add("@Puesto", SqlDbType.VarChar, 50).Value = puesto;

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Jugadores");


            return ds.Tables["Jugadores"];
        }

        public static int Insertar(Jugador jugador)
        {
            string querySql = "INSERT INTO dbo.Jugador (Nombre,Apellido,FechaNacimiento,Puesto) VALUES (@Nombre, @Apellido, @FechaNacimiento,@Puesto)";

            SqlDataAdapter adapter = new SqlDataAdapter(querySql, AdminDB.ConectarBase());

            adapter.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = jugador.Nombre;
            adapter.SelectCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = jugador.Apellido;
            adapter.SelectCommand.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = jugador.FechaNacimiento;
            adapter.SelectCommand.Parameters.Add("@Puesto", SqlDbType.VarChar, 50).Value = jugador.Puesto;

            int filasAfectadas = adapter.SelectCommand.ExecuteNonQuery();
            AdminDB.ConectarBase().Close();
            return filasAfectadas;
        }

        public static int Modificar(Jugador jugador)
        {
            string querySql = "UPDATE dbo.Jugador SET Nombre = @Nombre, Apellido = @Apellido, FechaNacimiento = @FechaNacimiento, Puesto = @Puesto WHERE Id = @Id";

            SqlDataAdapter adapter = new SqlDataAdapter(querySql, AdminDB.ConectarBase());

            adapter.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = jugador.Nombre;
            adapter.SelectCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = jugador.Apellido;
            adapter.SelectCommand.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = jugador.FechaNacimiento;
            adapter.SelectCommand.Parameters.Add("@Puesto", SqlDbType.VarChar, 50).Value = jugador.Puesto;
            adapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = jugador.Id;

            int filasAfectadas = adapter.SelectCommand.ExecuteNonQuery();
            AdminDB.ConectarBase().Close();
            return filasAfectadas;
        }

        public static int Eliminar(int idJugador)
        {
            string querySql = "DELETE FROM dbo.Jugador WHERE Id = @Id";

            SqlDataAdapter adapter = new SqlDataAdapter(querySql, AdminDB.ConectarBase());

            adapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = idJugador;

            int filasAfectadas = adapter.SelectCommand.ExecuteNonQuery();

            AdminDB.ConectarBase().Close();
            return filasAfectadas;
        }


    }
}
