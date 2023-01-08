using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Teu_Assistente_HABITACAO
{
    internal class BDCadastro
    {
        internal string NomeCompleto { get; set; }
        internal string EstadoCivil { get; set; }
        internal long Cpf { get; set; }
        internal long Nis { get; set; }
        internal DateTime DataDeNascimento { get; set; }
        internal string Email { get; set; }
        internal long Telefone { get; set; }
        internal long WhatsApp { get; set; }
        internal string NomeDaMae { get; set; }
        internal DateTime DataCadastro { get; set; }

        public void inserirCadastro(long cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO CADASTRADOS(CPF, NIS, NOME_COMPLETO, ESTADO_CIVIL, DATA_DE_NASCIMENTO, EMAIL, TELEFONE, WHATSAPP, NOME_DA_MAE, DATA_CADASTRO)" +
                "VALUES(@CPF, @NIS, @NOME_COMPLETO, @ESTADO_CIVIL, @DATA_DE_NASCIMENTO, @EMAIL, @TELEFONE, @WHATSAPP, @NOME_DA_MAE, @DATA_CADASTRO)";
            cmd.Parameters.AddWithValue("@CPF", cpf);
            cmd.Parameters.AddWithValue("@NIS", this.Nis);
            cmd.Parameters.AddWithValue("@NOME_COMPLETO", this.NomeCompleto);
            cmd.Parameters.AddWithValue("@ESTADO_CIVIL", this.EstadoCivil);
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
                //Criar_log 
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDCadastro\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log                
            }
        }
        public bool getCadastro(long cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT CPF, NIS, NOME_COMPLETO, DATA_DE_NASCIMENTO, EMAIL, TELEFONE, WHATSAPP, NOME_DA_MAE, DATA_CADASTRO FROM CADASTRADOS WHERE CPF=@CPF";
            cmd.Parameters.AddWithValue("@CPF", cpf);
            cmd.Connection = conexao.conectar();
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.Read())
            {
                //MessageBox.Show("Não existe nenhum cadastro\nreferente ao cpf:" + cpf, "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
                return false;
            }
            try
            {
                this.Cpf = long.Parse(reader["CPF"].ToString());
                this.Nis = long.Parse(reader["NIS"].ToString());
                this.NomeCompleto = reader["NOME_COMPLETO"].ToString();
                this.DataDeNascimento = DateTime.Parse(reader["DATA_DE_NASCIMENTO"].ToString());
                this.Email = reader["EMAIL"].ToString(); ;
                this.Telefone = long.Parse(reader["TELEFONE"].ToString());
                this.WhatsApp = long.Parse(reader["WHATSAPP"].ToString());
                this.NomeDaMae = reader["NOME_DA_MAE"].ToString();
                this.DataCadastro = DateTime.Parse(reader["DATA_CADASTRO"].ToString());
                conexao.desconectar();
                cmd.Parameters.Clear();
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
        public void setCadastro(long cpf)
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
                //Criar_log
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDCadastro\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
            }
        }
        public void deletarCadastro(long cpf)
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
