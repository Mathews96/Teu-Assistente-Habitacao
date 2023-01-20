using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Teu_Assistente_HABITACAO
{
    internal class BDDataGridViewCadastro
    {
        SqlCommand cmd = new SqlCommand();
        BDConexao conexao = new BDConexao();
        SqlDataAdapter adapter;
        DataTable dtTabela = new DataTable();
        public DataTable getTabelaDados(string condicao)
        {
            conexao.conectar();
            string strSQL = string.Empty;
            if(condicao.Contains("WHERE"))
            {
                strSQL = "SELECT CPF, NIS, NOME_COMPLETO, DATA_DE_NASCIMENTO, ESTADO_CIVIL, EMAIL, TELEFONE, WHATSAPP, NOME_DA_MAE, DATA_CADASTRO FROM CADASTRADOS " + condicao;
            }
            else
            {
                strSQL = "SELECT CPF, NIS, NOME_COMPLETO, DATA_DE_NASCIMENTO, ESTADO_CIVIL, EMAIL, TELEFONE, WHATSAPP, NOME_DA_MAE, DATA_CADASTRO FROM CADASTRADOS";
            }
            cmd = new SqlCommand(strSQL, conexao.conectar());
            try
            {
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtTabela);
                return dtTabela;
            }
            catch(SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDDataGridViewCadastro\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dtTabela;
        }
    }
}
