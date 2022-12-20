using System.Windows.Forms;

namespace Teu_Assistente_HABITACAO
{
    internal class EstadoCivil : BDComprovantes
    {
        public void anexarCertidaoEstadoCiviL(int cpf, string nomeClatura)
        {
            switch(getComprovante(cpf))
            {
                case false:
                    {
                        inserirComprovante(cpf);
                        //Criar_log
                        break;
                    }
                case true:
                    {
                        setComprovante(cpf);
                        //Criar_log
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Erro ao anexar certidão de estado civil\nContate o Desenvolvedor", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Criar_log
                        break;
                    }
            }
        }
    }
}
