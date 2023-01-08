using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Teu_Assistente_HABITACAO
{
    internal class BDAgendamento
    {
        internal long Cpf { get; set; }
        internal string NomeCompleto { get; set; }
        internal long Contato { get; set; }
        internal string Situacao { get; set; }
        internal string Demanda { get; set; }
        internal long Numero { get; set; }
        internal DateTime DataAgendamento { get; set; }

        public void inserirAgendamento(long cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO AGENDADOS(CPF, NOME_COMPLETO, CONTATO, SITUACAO, DEMANDA, NUMERO, DATA_AGENDAMENTO) VALUES(@CPF, @NOME_COMPLETO, @CONTATO, @SITUACAO, @DEMANDA, @NUMERO, @DATA_AGENDAMENTO)";
            cmd.Parameters.AddWithValue("@CPF", this.Cpf);
            cmd.Parameters.AddWithValue("@NOME_COMPLETO", this.NomeCompleto);
            cmd.Parameters.AddWithValue("@CONTATO", this.Contato);
            cmd.Parameters.AddWithValue("@SITUACAO", this.Situacao);
            cmd.Parameters.AddWithValue("@DEMANDA", this.Demanda);
            cmd.Parameters.AddWithValue("NUMERO", this.Numero);
            cmd.Parameters.AddWithValue("@DATA_AGENDAMENTO", this.DataAgendamento);
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                cmd.Parameters.Clear();
            }
            catch(SqlException){
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDAgendamento\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
            }
        }
        public void getAgendamento(long cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT NOME_COMPLETO, CONTATO, SITUACAO, DEMANDA, NUMERO, DATA_AGENDAMENTO FROM AGENDADOS WHERE CPF=@CPF";
            cmd.Parameters.AddWithValue("@CPF", cpf);
            cmd.Connection = conexao.conectar();
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                try
                {
                    this.Cpf = cpf;
                    this.NomeCompleto = reader["NOME_COMPLETO"].ToString();
                    this.Contato = long.Parse(reader["CONTATO"].ToString());
                    this.Situacao = reader["SITUACAO"].ToString();
                    this.Demanda = reader["DEMANDA"].ToString();
                    this.Numero = long.Parse(reader["NUMERO"].ToString());
                    this.DataAgendamento = DateTime.Parse(reader["DATA_AGENDAMENTO"].ToString());
                    conexao.desconectar();
                    cmd.Parameters.Clear();
                    //Criar_loge               
                }
                catch (SqlException)
                {
                    MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDAgendamento\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Situacao = "ERRO BD";
                    //Criar_log
                }                
            }
        }
        public void setAgendamento(long cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE AGENDADOS SET NOME_COMPLETO=@NOME_COMPLETO, CONTATO=@CONTATO, SITUACAO=@SITUACAO, DEMANDA=@DEMANDA, NUMERO=@NUMERO, DATA_AGENDAMENTO=@DATA_AGENDAMENTO WHERE CPF=@CPF";
            try
            {
                cmd.Parameters.AddWithValue("NOME_COMPLETO", this.NomeCompleto);
                cmd.Parameters.AddWithValue("CONTATO", this.Contato);
                cmd.Parameters.AddWithValue("@SITUACAO", this.Situacao);
                cmd.Parameters.AddWithValue("@DEMANDA", this.Demanda);
                cmd.Parameters.AddWithValue("NUMERO", this.Numero);
                cmd.Parameters.AddWithValue("@DATA_AGENDAMENTO", this.DataAgendamento);
                cmd.Parameters.AddWithValue("@CPF", cpf);
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                cmd.Parameters.Clear();
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDAgendamento\ncontate o DESENVOLVEDOR","ATENÇÃO",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
            }
        }
        public void deletarAgendamento(long cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM AGENDADOS WHERE CPF=@CPF";
            try
            {
                cmd.Parameters.AddWithValue("@CPF", cpf);
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                cmd.Parameters.Clear();
                MessageBox.Show("Agendamento referente ao CPF:" + cpf + ", excluído com sucesso!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Criar_log
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDAgendamento\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
            }
        }
    }
}
