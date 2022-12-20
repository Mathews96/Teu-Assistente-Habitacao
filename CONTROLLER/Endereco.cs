using System.Windows.Forms;

namespace Teu_Assistente_HABITACAO
{
    internal class Endereco : BDEndereco
    {
        public void definirEndereco(int cpf)
        {
            switch (getEndereco(cpf))
            {
                case false:
                    {
                        inserirEndereco(cpf);
                        //Criar_log                        
                        break;
                    }
                case true:
                    {
                        setEndereco(cpf);
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
    }
}
