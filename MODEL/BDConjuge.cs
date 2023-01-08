using System.Windows.Forms;
using System.Data.SqlClient;

namespace Teu_Assistente_HABITACAO
{
    internal class BDConjuge
    {
        internal string NomeCompleto { get; set; }
        internal long Cpf { get; set; }
        internal long Nis { get; set; }
        internal string Email { get; set; }
        internal long Telefone { get; set; }
        internal long Whatsapp { get; set; }

        public void inserirComprovanteConjunge(long cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO CONJUGES(CPFSEC, CPF, NIS, NOME_COMPLETO, EMAIL, TELEFONE, WHATSAPP)" +
                "VALUES(@CPFSEC, @CPF, @NIS, @NOME_COMPLETO, @EMAIL, @TELEFONE, @WHATSAPP)";
            cmd.Parameters.AddWithValue("CPFSEC", cpf);
            cmd.Parameters.AddWithValue("CPF", this.Cpf);
            cmd.Parameters.AddWithValue("NIS", this.Nis);
            cmd.Parameters.AddWithValue("NOME_COMPLETO", this.NomeCompleto);
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
        public bool getComprovanteConjunge(long cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT CPFSEC, CPF, NIS, NOME_COMPLETO, EMAIL, TELEFONE, WHATSAPP FROM CONJUGES WHERE CPFSEC=@CPFSEC";
            cmd.Parameters.AddWithValue("CPFSEC", cpf);
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
                this.Nis = int.Parse(reader["NIS"].ToString());
                this.NomeCompleto = reader["NOME_COMPLETO"].ToString();
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
        public void setComprovanteConjunge(long cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE CONJUGES SET CPFSEC=@CPFSEC, CPF=@CPF, NIS=@NIS, NOME_COMPLETO=@NOME_COMPLETO, EMAIL=@EMAIL, TELEFONE=@TELEFONE, WHATSAPP=@WHATSAPP WHERE CPFSEC=@CPFSEC";
            try
            {
                cmd.Parameters.AddWithValue("CPFSEC", cpf);
                cmd.Parameters.AddWithValue("CPF", this.Cpf);
                cmd.Parameters.AddWithValue("NIS", this.Nis);
                cmd.Parameters.AddWithValue("NOME_COMPLETO", this.NomeCompleto);
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
        public void deletarComprovanteConjunge(long cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM CONJUGES WHERE CPFSEC=@CPFSEC";
            try
            {
                cmd.Parameters.AddWithValue("CPFSEC", cpf);
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
