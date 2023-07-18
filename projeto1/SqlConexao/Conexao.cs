using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistente_de_Instalação.SqlConexao
{
    internal class Conexao
    {
        SqlConnection con = new SqlConnection();
        //Construtor
        public Conexao()
        {
            con.ConnectionString = "Data Source=bd-rodrigosrv.ddns.net;Initial Catalog=Rodrigo;Persist Security Info=True;User ID=sqlrodrigo;Password=231114;TrustServerCertificate=true";
        }
        //Metodo Conectar
        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //Metodo Desconectar
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
