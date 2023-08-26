using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistente_de_Instalação.Models
{
    public class SqlConnectionManager
    {
        private SqlConnection connection;
        public SqlConnectionManager()
        {
            string connectionString = $"Server=(local);Database=vc;User Id=sqlvirtualnet;Password=n14e5t20;TrustServerCertificate=true";
            this.connection = new SqlConnection(connectionString);
        }
        public bool OpenConnection()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir a conexão: " + ex.Message);
                return false;
            }
        }
        public bool CloseConnection()
        {
            try
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fechar a conexão: " + ex.Message);
                return false;
            }
        }
        public SqlDataReader ExecuteQuery(string query)
        {
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                return command.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar a consulta: " + ex.Message);
                return null;
            }
        }
        public bool BackupDatabase(string backupPath)
        {
            try
            {
                string backupCommand = $"BACKUP DATABASE [{connection.Database}] TO DISK = '{backupPath}'";
                SqlCommand command = new SqlCommand(backupCommand, connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao fazer o backup do banco de dados: " + ex.Message);
                return false;
            }
        }
    }
}
