using System;
using System.Windows.Forms;

namespace Teu_Assistente_HABITACAO
{
    internal class SituacaoCadastral : BDAgendamento
    {
        public string situacao { get; set; }
        public void definirSituacao(int cpf, string situacao)
        {
            this.setAgendamento(cpf);
        }
        public void consultarSituacao(int cpf)
        {
            this.getAgendamento(cpf);
        }
    }
}
