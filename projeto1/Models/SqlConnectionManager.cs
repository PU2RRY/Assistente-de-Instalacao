using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assistente_de_Instalação.Models
{
    public class SqlConnectionManager
    {
        private SqlConnection connection;
        public SqlConnectionManager()
        {
            string connectionString = $"Server=(local);Database=master;TrustServerCertificate=True;Trusted_Connection=True";
            this.connection = new SqlConnection(connectionString);
        }

        public bool TestaConexaoLocal()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception sqlex)
            {
                throw new Exception(sqlex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
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
                string backupCommand = $"BACKUP DATABASE vc TO DISK = '{backupPath}'";
                SqlCommand command = new SqlCommand(backupCommand, connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer o backup do banco de dados: " + ex.Message);
                return false;
            }
        }
        public bool killConection()
        {
            try
            {
                var sb = new StringBuilder();
                sb.Append("USE master;");
                sb.Append("DECLARE @kill varchar(8000); SET @kill = '';");
                sb.Append("SELECT @kill = @kill + 'kill ' + CONVERT(varchar(5), spid) + ';' ");
                sb.Append("FROM master..sysprocesses ");
                sb.Append("WHERE dbid = db_id('vc')");
                sb.Append("EXEC(@kill); ");
                SqlCommand command = new SqlCommand(sb.ToString(), connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar usuario SQL: " + ex.Message);
                return false;
            }
        }
        public bool CriaUsuarioSql()
        {
            try
            {
                var sb = new StringBuilder();
                sb.AppendLine("USE master;");
                sb.Append("IF EXISTS (SELECT * FROM sys.server_principals WHERE name = N'sqlVirtualNet')");
                sb.Append("DROP LOGIN [sqlVirtualNet];");
                sb.Append("CREATE LOGIN [sqlVirtualNet] WITH PASSWORD=N'n14e5t20', DEFAULT_DATABASE=[vc], DEFAULT_LANGUAGE=[Português (Brasil)], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF;");
                SqlCommand command = new SqlCommand(sb.ToString(), connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar usuario SQL: " + ex.Message);
                return false;
            }
        }
        public bool DefinirPermissoes()
        {
            try
            {
                var sb = new StringBuilder();
                sb.AppendLine("USE [vc];");
                sb.Append("IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = N'sqlVirtualNet')");
                sb.Append("DROP USER [sqlVirtualNet];");

                sb.AppendLine("USE [vc];");
                sb.Append("CREATE USER [sqlVirtualNet] FOR LOGIN [sqlVirtualNet] WITH DEFAULT_SCHEMA=[dbo];");
                sb.Append("EXEC sp_addrolemember N'db_owner', N'sqlVirtualNet';");
                sb.Append("EXEC sp_addrolemember N'db_backupoperator', N'sqlVirtualNet'");
                SqlCommand command = new SqlCommand(sb.ToString(), connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao definir permições do usuario SQL: " + ex.Message);
                return false;
            }
        }
        public bool RestoreDatabase(string backupFilePath)
        {
            try
            {
                string query = $"USE master; RESTORE DATABASE vc FROM DISK = '{backupFilePath}' WITH REPLACE;";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao restaurar o banco de dados: " + ex.Message);
                return false;
            }
        }
    }
}
