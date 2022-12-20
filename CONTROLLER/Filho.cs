using System;
using System.Windows.Forms;

namespace Teu_Assistente_HABITACAO
{
    internal class Filho : BDComprovantes
    {
        public void anexarCertidaoDeNascimento(int cpf, string nomenClatura)
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
                        MessageBox.Show("Erro ao anexar certidão do filho(a)\nContate o Desenvolvedor", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Criar_log
                        break;
                    }
            }
        }
    }
}
