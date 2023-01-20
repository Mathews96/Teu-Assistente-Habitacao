using System;
using System.Windows.Forms;

namespace Teu_Assistente_HABITACAO
{
    internal class CadastroUsuario : BDCadastroUsuario
    {
        public void cadastrar(long cpf)
        {
            switch (this.getCadastroUsu(cpf))
            {
                case false:
                    {
                        this.inserirCadastroUsu(cpf);
                        //Criar_log                        
                        break;
                    }
                case true:
                    {
                        MessageBox.Show("Já existe um cadastro com esse número de CPF: " + cpf + "\nContate o Desenvolvedor", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Criar_log
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Erro ao definir um endereço\nContate o Desenvolvedor", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Criar_log
                        break;
                    }
            }
        }
        public void editar(long cpf)
        {
            this.Cpf = long.Parse("");
            this.NomeCompleto = "";
            this.DataDeNascimento = DateTime.Parse("");
            this.Matricula = long.Parse("");
            this.Entidade = "";
            this.Setor = "";
            this.Cargo = "";
            this.Telefone = long.Parse("");
            this.Whatsapp = long.Parse("");
            this.Email = "";
            this.Senha = "";
            this.Nivel = 0;
            this.DataCadastro = DateTime.Parse("");
            this.setCadastroUsu(cpf);
        }
        public void excluir(long cpf)
        {
            this.deletarCadastroUsu(cpf);
        }
        public void consultar(long cpf)
        {
            this.getCadastroUsu(cpf);
        }
        public void download(long cpf)
        {

        }
    }
}
