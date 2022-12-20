using System.Windows.Forms;

namespace Teu_Assistente_HABITACAO
{
    internal class Deficiente : BDComprovantes
    {
        public void anexarComprovanteDeficiencia(int cpf, string nomeclatura)
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
                        MessageBox.Show("Erro ao anexar comprovante de deficiência\nContate o Desenvolvedor", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Criar_log
                        break;
                    }
            }
        }
    }
}
