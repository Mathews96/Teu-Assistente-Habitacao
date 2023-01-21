using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Teu_Assistente_HABITACAO
{
    internal class BDCadastroUsuario
    {
        internal long? Cpf { get; set; }
        internal string NomeCompleto { get; set; }
        internal DateTime DataDeNascimento { get; set; }
        internal long? Matricula { get; set; }
        internal string Entidade { get; set; }
        internal string Setor { get; set; }
        internal string Cargo { get; set; }
        internal long? Telefone { get; set; }
        internal long? Whatsapp { get; set; }
        internal string Email { get; set; }
        internal string Senha { get; set; }
        internal int? Nivel { get; set; }
        internal DateTime DataCadastro { get; set; }
        public void inserirCadastroUsu(long cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO CADASTROSUSUARIOS(CPF, NOME_COMPLETO, DATA_DE_NASCIMENTO, MATRICULA, ENTIDADE, SETOR, CARGO, TELEFONE, WHATSAPP, EMAIL, SENHA, NIVEL, DATA_CADASTRO)" +
                "VALUES(@CPF, @NOME_COMPLETO, @DATA_DE_NASCIMENTO, @MATRICULA, @ENTIDADE, @SETOR, @CARGO, @TELEFONE, @WHATSAPP, @EMAIL, @SENHA, @NIVEL, @DATA_CADASTRO)";
            
            cmd.Parameters.AddWithValue("CPF", cpf);
            cmd.Parameters.AddWithValue("@NOME_COMPLETO", this.NomeCompleto);
            cmd.Parameters.AddWithValue("DATA_DE_NASCIMENTO", this.DataDeNascimento);
            cmd.Parameters.AddWithValue("MATRICULA", this.Matricula);
            cmd.Parameters.AddWithValue("ENTIDADE", this.Entidade);
            cmd.Parameters.AddWithValue("SETOR", this.Setor);
            cmd.Parameters.AddWithValue("CARGO", this.Cargo);
            cmd.Parameters.AddWithValue("TELEFONE", this.Telefone);
            cmd.Parameters.AddWithValue("WHATSAPP", this.Whatsapp);
            cmd.Parameters.AddWithValue("EMAIL", this.Email);
            cmd.Parameters.AddWithValue("SENHA", this.Senha);
            cmd.Parameters.AddWithValue("NIVEL", this.Nivel);
            cmd.Parameters.AddWithValue("DATA_CADASTRO", this.DataCadastro);
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
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: CADASTROSUSUARIOS\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log                
            }
        }
        public bool getCadastroUsu(long cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT CPF, NOME_COMPLETO, DATA_DE_NASCIMENTO, MATRICULA, ENTIDADE, SETOR, CARGO, TELEFONE, WHATSAPP, EMAIL, SENHA, NIVEL, DATA_CADASTRO FROM CADASTROSUSUARIOS WHERE CPF=@CPF";
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
                this.NomeCompleto = reader["NOME_COMPLETO"].ToString();
                this.DataDeNascimento = DateTime.Parse(reader["DATA_DE_NASCIMENTO"].ToString()); 
                this.Matricula = long.Parse(reader["MATRICULA"].ToString());
                this.Entidade = reader["ENTIDADE"].ToString();
                this.Setor = reader["SETOR"].ToString();
                this.Cargo = reader["CARGO"].ToString();
                this.Telefone = long.Parse(reader["TELEFONE"].ToString());
                this.Whatsapp = long.Parse(reader["WHATSAPP"].ToString());
                this.Email = reader["EMAIL"].ToString();
                this.Senha = reader["SENHA"].ToString();
                this.Nivel = int.Parse(reader["NIVEL"].ToString());
                this.DataCadastro = DateTime.Parse(reader["DATA_CADASTRO"].ToString());
                return true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDCADASTROSUSUARIOS\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
                return false;
            }
        }
        public void setCadastroUsu(long cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE CADASTROSUSUARIOS SET CPF=@CPF, NOME_COMPLETO=@NOME_COMPLETO, DATA_DE_NASCIMENTO=@DATA_DE_NASCIMENTO, MATRICULA=@MATRICULA, ENTIDADE=@ENTIDADE, " +
                "SETOR=@SETOR, CARGO=@CARGO, TELEFONE=@TELEFONE, WHATSAPP=@WHATSAPP, EMAIL=@EMAIL, SENHA=@SENHA, NIVEL=@NIVEL, DATA_CADASTRO=@DATA_CADASTRO WHERE CPF=@CPF";
            try
            {
                cmd.Parameters.AddWithValue("CPF", cpf);
                cmd.Parameters.AddWithValue("@NOME_COMPLETO", this.NomeCompleto);
                cmd.Parameters.AddWithValue("DATA_DE_NASCIMENTO", this.DataDeNascimento);
                cmd.Parameters.AddWithValue("MATRICULA", this.Matricula);
                cmd.Parameters.AddWithValue("ENTIDADE", this.Entidade);
                cmd.Parameters.AddWithValue("SETOR", this.Setor);
                cmd.Parameters.AddWithValue("CARGO", this.Cargo);
                cmd.Parameters.AddWithValue("TELEFONE", this.Telefone);
                cmd.Parameters.AddWithValue("WHATSAPP", this.Whatsapp);
                cmd.Parameters.AddWithValue("EMAIL", this.Email);
                cmd.Parameters.AddWithValue("SENHA", this.Senha);
                cmd.Parameters.AddWithValue("NIVEL", this.Nivel);
                cmd.Parameters.AddWithValue("DATA_CADASTRO", this.DataCadastro);
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                cmd.Parameters.Clear();
                //Criar_log
            }
            catch(SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDCADASTROSUSUARIOS\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
            }
        }
        public void deletarCadastroUsu(long cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM CADASTROSUSUARIOS WHERE CPF=@CPF";
            try
            {
                cmd.Parameters.AddWithValue("CPF", cpf);
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                cmd.Parameters.Clear();
                MessageBox.Show("Cadastro de Usuário referente ao CPF:" + cpf + ", excluído com sucesso!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Criar_log
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDCADASTROSUSUARIOS\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
            }
        }

    }
}
