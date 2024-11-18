using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    internal class conexion
    {

        private MySqlConnection conexion1;
        private string server = "127.0.0.1";
        private string database = "users";
        private string user = "root";
        private string password = "Santino12mas.";
        private string port = "3306";
        private string cadenaConexion;

        public conexion()
        {
            cadenaConexion = $"Server={server};Database={database};User ID={user};Password={password};Port={port};";

        }
        public MySqlConnection GetConnection() 
        {
            if (conexion1 == null) 
            {
                conexion1 = new MySqlConnection(cadenaConexion);
                conexion1.Open();
            }
            return conexion1;
        }

    }
}
