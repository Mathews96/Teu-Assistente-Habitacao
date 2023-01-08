using System;
using System.Windows.Forms;

namespace Teu_Assistente_HABITACAO
{

    internal class CadastroHabitacional : BDCadastro
    {
        internal Endereco Endereco { get; set; }

        internal Conjuge Conjuge { get; set; }
        //internal Deficiente ComprovanteDeficiente { get; set; }
        //internal EstadoCivil ComprovanteEstadoCivil { get; set; }
        //internal Filho ComprovanteFilho { get; set; }
        //internal Renda ComprovanteRenda { get; set; }

        //Adicionas agregação das classes/objetos comprovantes (Deficiente, filho, renda)
        public void cadastrar(long cpf)
        {
            switch (this.getCadastro(cpf))
            {
                case false:
                    {
                        this.inserirCadastro(cpf);
                        this.Endereco.inserirEndereco(cpf);
                        this.Conjuge.inserirComprovanteConjunge(cpf);

                        //Criar_log                        
                        break;
                    }
                case true:
                    {
                        MessageBox.Show("Já existe um cadastro com esse número de CPF: "+ cpf +"\nContate o Desenvolvedor", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.NomeCompleto = "";
            this.Cpf = int.Parse("");
            this.Nis = int.Parse("");
            this.DataDeNascimento = DateTime.Parse("");
            this.Email = "";
            this.Telefone = int.Parse("");
            this.WhatsApp = int.Parse("");
            this.NomeDaMae = "";
            this.DataCadastro = DateTime.Parse("");
            this. setCadastro(cpf);
            this.Endereco.setEndereco(cpf);            
        }
        public void excluir(long cpf)
        {
            this.deletarCadastro(cpf);
        }
        public void consultar(long cpf)
        {
            this.getCadastro(cpf);
            this.Endereco.getEndereco(cpf);
        }
        public void download(long cpf)
        {

        }
    }
}
