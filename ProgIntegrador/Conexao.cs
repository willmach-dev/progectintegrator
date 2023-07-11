using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgIntegrador
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        
        
        //Constructor

        public Conexao()
        {
            con.ConnectionString = @"Data Source=GTW;Initial Catalog=progintegra;Integrated Security=True";
        }
        //metodo conectar
        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
       
        //metodo Desconectar
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
