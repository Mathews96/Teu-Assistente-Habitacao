using System;
using System.Windows.Forms;

namespace Teu_Assistente_HABITACAO
{
    internal class SituacaoCadastral : BDAgendamento
    {
        public string situacao { get; set; }
        public void definirSituacao(long cpf, string situacao)
        {
            this.setAgendamento(cpf);
        }
        public void consultarSituacao(long cpf)
        {
            this.getAgendamento(cpf);
        }
    }
}
