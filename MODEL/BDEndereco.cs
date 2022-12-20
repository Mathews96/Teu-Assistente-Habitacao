using System.Data.SqlClient;
using System.Windows.Forms;

namespace Teu_Assistente_HABITACAO
{
    internal class BDEndereco
    {
        private int Cep { get; set; }
        private string Endereco { get; set; }
        private int Numero { get; set; }
        private string Complemento { get; set; }
        private string Bairro { get; set; }
        private string Cidade { get; set; }
        private string Uf { get; set; }
        public void inserirEndereco(int cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO ENDERECOS(CPF, CEP, ENDERECO, NUMERO, COMPLEMENTO, BAIRRO, CIDADE, UF)" +
                "VALUES(@CPF, @CEP, @ENDERECO, @NUMERO, @COMPLEMENTO, @BAIRRO, @CIDADE, @UF); WHERE=@CPF";
            cmd.Parameters.AddWithValue("@CPF", cpf);
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
        public bool getEndereco(int cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT CPF, CEP, ENDERECO, NUMERO, COMPLEMENTO, BAIRRO, CIDADE, UF FROM ENDERECOS WHERE CPF=@CPF";
            cmd.Parameters.AddWithValue("@CPF", cpf);
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
        public void setEndereco(int cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE ENDERECOS SET CPF=@CPF, CEP=@CEP, ENDERECO=@ENDERECO, NUMERO=@NUMERO, COMPLEMENTO=@COMPLEMENTO, BAIRRO=@BAIRRO, CIDADE=@CIDADE, UF=@UF WHERE CPF=@CPF";
            try
            {
                cmd.Parameters.AddWithValue("@CPF", cpf);
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
        public void deletarEndereco(int cpf)
        {
            BDConexao conexao = new BDConexao();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM ENDERECOS WHERE CPF=@CPF";
            try
            {
                cmd.Parameters.AddWithValue("@CPF", cpf);
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
