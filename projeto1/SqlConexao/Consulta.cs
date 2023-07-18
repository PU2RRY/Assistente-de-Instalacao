using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistente_de_Instalação.SqlConexao
{
    public class Consulta
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public DataTable dt =new();

        public Consulta(string tebela)
        {
            cmd.CommandText = "select * from " + tebela;
            cmd.Connection = conexao.conectar();
            var dr = cmd.ExecuteReader();
            dt.Load(dr);
            conexao.desconectar();
        }
    }
}
