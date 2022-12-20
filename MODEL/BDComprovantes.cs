using System.Windows.Forms;
using System.Data.SqlClient;

namespace Teu_Assistente_HABITACAO
{
    internal class BDComprovantes
    {
        private string TipoDeComprovante { get; set; }
        private string SalvoNoDestino { get; set; }
        private string DataSalvamento { get; set; }
        public void inserirComprovante(int cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO COMPROVANTES(CPF, TIPO_DE_COMPROVANTE, SALVO_NO_DESTINO, DATA_SAVALMENTO)" +
                "VALUES(@CPF, @TIPO_DE_COMPROVANTE, @SALVO_NO_DESTINO, @DATA_SAVALMENTO) WHERE CPF=@CPF";
            cmd.Parameters.AddWithValue("@CPF", cpf);
            cmd.Parameters.AddWithValue("@TIPO_DE_COMPROVANTE", this.TipoDeComprovante);
            cmd.Parameters.AddWithValue("@SALVO_NO_DESTINO", this.SalvoNoDestino);
            cmd.Parameters.AddWithValue("@DATA_SAVALMENTO", this.DataSalvamento);
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                cmd.Parameters.Clear();
                //Criar_log
            }
            catch(SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDComprovantes\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
            }
        }
        public bool getComprovante(int cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT TIPO_DE_COMPROVANTE, SALVO_NO_DESTINO, DATA_SAVALMENTO FROM COMPROVANTES WHERE CPF=@CPF";
            cmd.Parameters.AddWithValue("@CPF", cpf);
            cmd.Connection = conexao.conectar();
            SqlDataReader reader = cmd.ExecuteReader();
            if(!reader.Read())
            {
                MessageBox.Show("Não existe nenhum comprovante\nreferente ao cpf:" + cpf, "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
                return false;
            }
            try
            {
                this.TipoDeComprovante = reader["TIPO_DE_COMPROVANTE"].ToString();
                this.SalvoNoDestino = reader["SALVO_NO_DESTINO"].ToString();
                this.DataSalvamento = reader["DATA_SAVALMENTO"].ToString();
                conexao.desconectar();
                cmd.Parameters.Clear();
                //Criar_log
                return true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDComprovantes\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
                return false;
            }
        }
        public void setComprovante(int cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDAT COMPROVANTES TIPO_DE_COMPROVANTE=@TIPO_DE_COMPROVANTE, SALVO_NO_DESTINO=@SALVO_NO_DESTINO, DATA_SAVALMENTO=@DATA_SAVALMENTO WHERE CPF=@CPF";
            try
            {
                cmd.Parameters.AddWithValue("@CPF", cpf);
                cmd.Parameters.AddWithValue("@TIPO_DE_COMPROVANTE", this.TipoDeComprovante);
                cmd.Parameters.AddWithValue("@SALVO_NO_DESTINO", this.SalvoNoDestino);
                cmd.Parameters.AddWithValue("@DATA_SAVALMENTO", this.DataSalvamento);
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                cmd.Parameters.Clear();
                //Criar_log
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDComprovantes\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
            }
        }
        public void deletarComprovante(int cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM COMPROVANTES WHERE CPF=@CPF";
            try
            {
                cmd.Parameters.AddWithValue("@CPF", cpf);
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                cmd.Parameters.Clear();
                MessageBox.Show("Comprovantes referente ao CPF:" + cpf + ", excluído com sucesso!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Criar_log
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDComprovantes\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
            }
        }
    }
}
