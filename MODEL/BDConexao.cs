using System.Data.SqlClient;

namespace Teu_Assistente_HABITACAO.MODEL
{
    internal class BDConexao
    {
        SqlConnection con = new SqlConnection();
        public BDConexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-MV50K62\SQLEXPRESS;Initial Catalog=HABITACAOMCZ;Integrated Security=True";
        }
        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
