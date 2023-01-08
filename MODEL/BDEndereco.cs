using System.Data.SqlClient;
using System.Windows.Forms;

namespace Teu_Assistente_HABITACAO
{
    internal class BDEndereco
    {
        internal int Cep { get; set; }
        internal string Endereco { get; set; }
        internal int Numero { get; set; }
        internal string Complemento { get; set; }
        internal string Bairro { get; set; }
        internal string Cidade { get; set; }
        internal string Uf { get; set; }
        public void inserirEndereco(long cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO ENDERECOS(CPFSEC, CEP, ENDERECO, NUMERO, COMPLEMENTO, BAIRRO, CIDADE, UF)" +
                "VALUES(@CPFSEC, @CEP, @ENDERECO, @NUMERO, @COMPLEMENTO, @BAIRRO, @CIDADE, @UF);";
            cmd.Parameters.AddWithValue("@CPFSEC", cpf);
            cmd.Parameters.AddWithValue("CEP", this.Cep);
            cmd.Parameters.AddWithValue("@ENDERECO", this.Endereco);
            cmd.Parameters.AddWithValue("@NUMERO", this.Numero);
            cmd.Parameters.AddWithValue("@COMPLEMENTO", this.Complemento);
            cmd.Parameters.AddWithValue("@BAIRRO", this.Bairro);
            cmd.Parameters.AddWithValue("@CIDADE", this.Cidade);
            cmd.Parameters.AddWithValue("@UF", this.Uf);
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
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDEnderecos\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log                            
            }
        }
        public bool getEndereco(long cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT CPFSEC, CEP, ENDERECO, NUMERO, COMPLEMENTO, BAIRRO, CIDADE, UF FROM ENDERECOS WHERE CPFSEC=@CPFSEC";
            cmd.Parameters.AddWithValue("@CPFSEC", cpf);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.Read())
            {
                MessageBox.Show("Não existe nenhum endereco\nreferente ao cpf:" + cpf, "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
                return false;
            }
            try
            {
                this.Cep = int.Parse(reader["CEP"].ToString());
                this.Endereco = reader["ENDERECO"].ToString();
                this.Numero = int.Parse(reader["NUMERO"].ToString());
                this.Complemento = reader["COMPLEMENTO"].ToString();
                this.Bairro = reader["BAIRRO"].ToString();
                this.Cidade = reader["CIDADE"].ToString();
                this.Uf = reader["UF"].ToString();
                conexao.desconectar();
                cmd.Parameters.Clear();
                //Criar_log
                return true;
            }
            catch(SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDEnderecos\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
                return false;
            }
        }
        public void setEndereco(long cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE ENDERECOS SET CPFSEC=@CPFSEC, CEP=@CEP, ENDERECO=@ENDERECO, NUMERO=@NUMERO, COMPLEMENTO=@COMPLEMENTO, BAIRRO=@BAIRRO, CIDADE=@CIDADE, UF=@UF WHERE CPF=@CPF";
            try
            {
                cmd.Parameters.AddWithValue("@CPFSEC", cpf);
                cmd.Parameters.AddWithValue("@CEP", this.Cep);
                cmd.Parameters.AddWithValue("@ENDERECO", this.Endereco);
                cmd.Parameters.AddWithValue("@NUMERO", this.Numero);
                cmd.Parameters.AddWithValue("@BAIRRO", this.Bairro);
                cmd.Parameters.AddWithValue("@CIDADE", this.Cidade);
                cmd.Parameters.AddWithValue("@UF", this.Uf);
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                cmd.Parameters.Clear();
            }
            catch(SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDEnderecos\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
            }
        }
        public void deletarEndereco(long cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM ENDERECOS WHERE CPFSEC=@CPFSEC";
            try
            {
                cmd.Parameters.AddWithValue("@CPFSEC", cpf);
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                cmd.Parameters.Clear();
                MessageBox.Show("Endereco referente ao CPF:" + cpf + ", excluído com sucesso!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Criar_log
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao se conectar com o Banco de Dados\nErro: BDEnderecos\ncontate o DESENVOLVEDOR", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Criar_log
            }
        }
    }
}
