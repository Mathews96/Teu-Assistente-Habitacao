using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Teu_Assistente_HABITACAO.MODEL
{
    internal class BDCadastro
    {
        private string NomeCompleto { get; set; }
        private int Cpf { get; set; }
        private int Nis { get; set; }
        private DateTime DataDeNascimento { get; set; }
        private string Email { get; set; }
        private int Telefone { get; set; }
        private int WhatsApp { get; set; }
        private string NomeDaMae { get; set; }
        private DateTime DataCadastro { get; set; }

        public void inserirCadastro(int cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO CADASTRADOS(CPF, NIS, NOME_COMPLETO, DATA_DE_NASCIMENTO, EMAIL, TELEFONE, WHATSAPP, NOME_DA_MAE, DATA_CADASTRO)" +
                "VALUES(@CPF, @NIS, @NOME_COMPLETO, @DATA_DE_NASCIMENTO, @EMAIL, @TELEFONE, @WHATSAPP, @NOME_DA_MAE, @DATA_CADASTRO) WHERE CPF!=@CPF";
            cmd.Parameters.AddWithValue("@CPF", cpf);
            cmd.Parameters.AddWithValue("@NIS", this.Nis);
            cmd.Parameters.AddWithValue("@NOME_COMPLETO", this.NomeCompleto);
            cmd.Parameters.AddWithValue("@DATA_DE_NASCIMENTO", this.DataDeNascimento);
            cmd.Parameters.AddWithValue("@EMAIL", this.Email);
            cmd.Parameters.AddWithValue("@TELEFONE", this.Telefone);
            cmd.Parameters.AddWithValue("@WHATSAPP", this.WhatsApp);
            cmd.Parameters.AddWithValue("@NOME_DA_MAE", this.NomeDaMae);
            cmd.Parameters.AddWithValue("@DATA_CADASTRO", this.DataCadastro);
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                cmd.Parameters.Clear();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDCadastro\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log                
            }
        }
        public bool getCadastro(int cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT CPF, NIS, NOME_COMPLETO, DATA_DE_NASCIMENTO, EMAIL, TELEFONE, WHATSAPP, NOME_DA_MAE, DATA_CADASTRO FROM CADASTRADOS WHERE CPF=@CPF";
            cmd.Parameters.AddWithValue("@CPF", cpf);
            cmd.Connection = conexao.conectar();
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.Read())
            {
                MessageBox.Show("Não existe nenhum agendamento\nreferente ao cpf:" + cpf, "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
                return false;
            }
            try
            {
                this.Cpf = int.Parse(reader["CPF"].ToString());
                this.Nis = int.Parse(reader["NIS"].ToString());
                this.NomeCompleto = reader["NOME_COMPLETO"].ToString();
                this.DataDeNascimento = DateTime.Parse(reader["DATA_DE_NASCIMENTO"].ToString());
                this.Email = reader["EMAIL"].ToString(); ;
                this.Telefone = int.Parse(reader["TELEFONE"].ToString());
                this.WhatsApp = int.Parse(reader["WHATSAPP"].ToString());
                this.NomeDaMae = reader["NOME_DA_MAE"].ToString();
                this.DataCadastro = DateTime.Parse(reader["DATA_CADSATRO"].ToString());
                //Criar_log
                return true;
            }
            catch(SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDCadastro\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
                return false;
            }
        }
        public void setCadastro(int cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE CADASTRADOS SET CPF=@CPF, NIS=@NIS, NOME_COMPLETO=@NOME_COMPLETO, DATA_DE_NASCIMENTO=@DATA_DE_NASCIMENTO, EMAIL=@EMAIL, TELEFONE=@TELEFONE, WHATSAPP=@WHATSAPP, NOME_DA_MAE=@NOME_DA_MAE, DATA_CADASTRO=@DATA_CADASTRO WHERE CPF=@CPF";
            try
            {
                cmd.Parameters.AddWithValue("@CPF", cpf);
                cmd.Parameters.AddWithValue("@NIS", this.Nis);
                cmd.Parameters.AddWithValue("@NOME_COMPLETO", this.NomeCompleto);
                cmd.Parameters.AddWithValue("@DATA_DE_NASCIMENTO", this.DataDeNascimento);
                cmd.Parameters.AddWithValue("@EMAIL", this.Email);
                cmd.Parameters.AddWithValue("@TELEFONE", this.Telefone);
                cmd.Parameters.AddWithValue("WHATSAPP", this.WhatsApp);
                cmd.Parameters.AddWithValue("NOME_DA_MAE", this.NomeDaMae);
                cmd.Parameters.AddWithValue("DATA_CADASTRO", this.DataCadastro);
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                cmd.Parameters.Clear();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDCadastro\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
            }
        }
        public void deletarCadastro(int cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM CADASTROS WHERE CPF=@CPF";
            try
            {
                cmd.Parameters.AddWithValue("@CPF", cpf);
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                cmd.Parameters.Clear();
                MessageBox.Show("Cadastro referente ao CPF:" + cpf + ", excluído com sucesso!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Criar_log
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDCadastro\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
            }
        }
    }
}
