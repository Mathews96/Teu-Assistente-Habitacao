using System.Windows.Forms;
using System.Data.SqlClient;

namespace Teu_Assistente_HABITACAO
{
    internal class BDConjunge
    {
        private string NomeCompleto { get; set; }
        private int Cpf { get; set; }
        private int Nis { get; set; }
        private string Email { get; set; }
        private int Telefone { get; set; }
        private int Whatsapp { get; set; }

        public void inserirComprovanteConjunge(int cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO CONJUNGES(CPF, CPFSEC, NOME_COMPLETO, NIS, EMAIL, TELEFONE, WHATSAPP)" +
                "VALUES(@CPF, @CPFSEC, @NOME_COMPLETO, @NIS, @EMAIL, @TELEFONE, @WHATSAPP) WHERE CPF=@CPF";
            cmd.Parameters.AddWithValue("CPF", cpf);
            cmd.Parameters.AddWithValue("CPFSEC", cpf);
            cmd.Parameters.AddWithValue("NOME_COMPLETO", this.NomeCompleto);
            cmd.Parameters.AddWithValue("NIS", this.Nis);
            cmd.Parameters.AddWithValue("EMAIL", this.Email);
            cmd.Parameters.AddWithValue("TELEFONE", this.Telefone);
            cmd.Parameters.AddWithValue("WHATSAPP", this.Whatsapp);
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                cmd.Parameters.Clear();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDConjunge\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
            }
        }
        public bool getComprovanteConjunge(int cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT CPF, CPFSEC, NOME_COMPLETO, NIS, EMAIL, TELEFONE, WHATSAPP FROM CONJUNGES WHERE CPF=@CPF";
            cmd.Parameters.AddWithValue("CPF", cpf);
            cmd.Connection = conexao.conectar();
            SqlDataReader reader = cmd.ExecuteReader();
            if(!reader.Read())
            {
                MessageBox.Show("Não existe nenhum comprovante de cônjunge\nreferente ao cpf:" + cpf, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
                return false;
            }
            try
            {
                this.Cpf = int.Parse(reader["CPF"].ToString());
                this.NomeCompleto = reader["NOME_COMPLETO"].ToString();
                this.Nis = int.Parse(reader["NIS"].ToString());
                this.Email = reader["EMAIL"].ToString();
                this.Telefone = int.Parse(reader["TELEFONE"].ToString());
                this.Whatsapp = int.Parse(reader["WHATSAPP"].ToString());
                conexao.desconectar();
                cmd.Parameters.Clear();
                //Criar_log
                return true;
            }
            catch(SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDConjunge\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
                return false;
            }
        }
        public void setComprovanteConjunge(int cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE CONJUNGES SET CPF=@CPF, CPFSEC=@CPFSEC, NOME_COMPLETO=@NOME_COMPLETO, NIS=@NIS, EMAIL=@EMAIL, TELEFONE=@TELEFONE, WHATSAPP=@WHATSAPP WHERE CPF=@CPF";
            try
            {
                cmd.Parameters.AddWithValue("CPF", cpf);
                cmd.Parameters.AddWithValue("CPFSEC", cpf);
                cmd.Parameters.AddWithValue("NOME_COMPLETO", this.NomeCompleto);
                cmd.Parameters.AddWithValue("NIS", this.Nis);
                cmd.Parameters.AddWithValue("EMAIL", this.Email);
                cmd.Parameters.AddWithValue("TELEFONE", this.Telefone);
                cmd.Parameters.AddWithValue("WHATSAPP", this.Whatsapp);
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                cmd.Parameters.Clear();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDConjunge\ncontate o DESENVOLVEDOR", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
            }
        }
        public void deletarComprovanteConjunge(int cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM CONJUNGES WHERE CPF=@CPF";
            try
            {
                cmd.Parameters.AddWithValue("CPF", cpf);
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                cmd.Parameters.Clear();
                MessageBox.Show("Comprovante de cônjunge referente ao CPF:" + cpf + ", excluído com sucesso!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Criar_log
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDConjunge\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
            }
        }
    }
}
