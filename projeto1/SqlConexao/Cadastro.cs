using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistente_de_Instalação.SqlConexao
{
    internal class Cadastro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem= "";
        public Cadastro(string NOME, string CPF, string TEL, bool ATIVO)
        {
            //Comando SQL 
            cmd.CommandText = "insert into Clientes (NOME, CPF, TEL, ATIVO) values(@NOME, @CPF, @TEL, @ATIVO)";

            //Paramewtros
            cmd.Parameters.AddWithValue("@NOME", NOME);
            cmd.Parameters.AddWithValue("@CPF", CPF);
            cmd.Parameters.AddWithValue("@TEL", TEL);
            cmd.Parameters.AddWithValue("@ATIVO", ATIVO);
            try
            {
                //Conectar com o banco
                cmd.Connection = conexao.conectar();
                //Executar comando
                cmd.ExecuteNonQuery();
                //Desconectar
                conexao.desconectar();
                //mostra msn de erro ou sucesso
                this.mensagem = "Cadastrado com sucesso!!";
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
