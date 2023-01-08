using System.Windows.Forms;

namespace Teu_Assistente_HABITACAO
{
    internal class Conjuge : BDConjuge
    {
        public void definirComprovanteConjunge(int cpf)
        {
            switch (getComprovanteConjunge(cpf))
            {
                case false:
                    {
                        inserirComprovanteConjunge(cpf);
                        //Criar_log                        
                        break;
                    }
                case true:
                    {
                        setComprovanteConjunge(cpf);
                        //Criar_log
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Erro no comprovante do cônjunge\nContate o Desenvolvedor", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Criar_log
                        break;
                    }
            }
        }
    }
}
