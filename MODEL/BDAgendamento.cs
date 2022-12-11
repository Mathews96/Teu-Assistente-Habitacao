using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Teu_Assistente_HABITACAO.MODEL
{
    internal class BDAgendamento
    {
        protected int Cpf { get; set; }
        protected string NomeCompleto { get; set; }
        protected DateTime DataAgendamento { get; set; }
        protected string Situacao { get; set; }
        protected string Demanda { get; set; }

        public void inserirAgendamento(int cpf, DateTime dataAgendado)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO AGENDADOS(CPF, NOME_COMPLETO, SITUACAO, DEMANDA, DATA_AGENDAMENTO) VALUES(@CPF, @NOME_COMPLETO, @SITUACAO, @DEMANDA, @DATA_AGENDAMENTO) WHERE CPF!=@CPF";
            cmd.Parameters.AddWithValue("@CPF", this.Cpf);
            cmd.Parameters.AddWithValue("@NOME_COMPLETO", this.NomeCompleto);
            cmd.Parameters.AddWithValue("@SITUACAO", this.Situacao);
            cmd.Parameters.AddWithValue("@DEMANDA", this.Demanda);
            cmd.Parameters.AddWithValue("@DATA_AGENDAMENTO", dataAgendado);
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
        public bool getAgendamento(int cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT NOME_COMPLETO, SITUACAO, DEMANDA, DATA_AGENDAMENTO FROM AGENDADOS WHERE CPF=@CPF";
            cmd.Parameters.AddWithValue("@CPF", cpf);
            cmd.Connection = conexao.conectar();
            SqlDataReader reader = cmd.ExecuteReader();
            if(!reader.Read())
            {
                MessageBox.Show("Não existe nenhum agendamento\nreferente ao cpf:" + cpf, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
                return false;
            }
            try
            {
                this.NomeCompleto = reader["NOME_COMPLETO"].ToString();
                this.Situacao = reader["SITUACAO"].ToString();
                this.Demanda = reader["DEMANDA"].ToString();
                this.DataAgendamento = DateTime.Parse(reader["DATA_AGENDAMENTO"].ToString());
                //Criar_loge
                return true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDAgendamento\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
                return false;
            }
        }
        public void setAgendamento(int cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE AGENDADOS SET NOME_COMPLETO=@NOME_COMPLETO, SITUACAO=@SITUACAO, DEMANDA=@DEMANDA, DATA_AGENDAMENTO=@DATA_AGENDAMENTO WHERE CPF=@CPF";
            try
            {
                cmd.Parameters.AddWithValue("NOME_COMPLETO", this.NomeCompleto);
                cmd.Parameters.AddWithValue("@SITUACAO", this.Situacao);
                cmd.Parameters.AddWithValue("@DEMANDA", this.Demanda);
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
        public void deletarAgendamento(int cpf)
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
