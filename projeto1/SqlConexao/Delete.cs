using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistente_de_Instalação.SqlConexao
{
    internal class Delete
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem= "";
        public Delete(int id)
        {
            //Comando SQL 
            cmd.CommandText = "delete from Clientes where ID_CLIENTE = @id";

            //Paramewtros
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                //Conectar com o banco
                cmd.Connection = conexao.conectar();
                //Executar comando
                cmd.ExecuteNonQuery();
                //Desconectar
                conexao.desconectar();
                //mostra msn de erro ou sucesso
                this.mensagem = "Deletado com sucesso!!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao executar ação";
            }
            catch (Exception ex)
            {
                this.mensagem = "Erro inesperado";
            }
        }
    }
}
