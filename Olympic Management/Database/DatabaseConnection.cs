using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Olympic_Management.Database
{
     public class DatabaseConnection
     {
        private SqlConnection connection;

        public DatabaseConnection()
        {
            // Obtener la cadena de conexión desde App.config
            string connectionString = ConfigurationManager.ConnectionStrings["OlympicDBConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        public SqlConnection OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
            return connection;
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public SqlDataReader ExecuteQuery(string query)
        {
            SqlCommand command = new SqlCommand(query, OpenConnection());
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public int ExecuteNonQuery(string commandText)
        {
            SqlCommand command = new SqlCommand(commandText, OpenConnection());
            int rowsAffected = command.ExecuteNonQuery();
            CloseConnection();
            return rowsAffected;
        }
     }
}
