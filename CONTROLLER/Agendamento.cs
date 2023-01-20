using System;
using System.Windows.Forms;

namespace Teu_Assistente_HABITACAO
{
    internal class Agendamento : SituacaoCadastral
    {
        public void agendar(long cpf)
        {
            inserirAgendamento(cpf);
        }
        public void reagendar(long cpf)
        {
            this.setAgendamento(cpf);
        }
        public void desagendar(long cpf)
        {
            /*if (getAgendamento(cpf))
            {
                deletarAgendamento(cpf);
            }*/
        }
        public string consultar(long cpf)
        {
            consultarSituacao(cpf);
            string situacao = this.Situacao;
            if(!string.IsNullOrEmpty(this.Situacao) && this.Situacao != "CADASTRADO" && this.DataAgendamento < DateTime.Now)
            {
                situacao = "FALTOSO";
            }
            else if (!string.IsNullOrEmpty(this.Situacao) && this.Situacao != "CADASTRADO" && this.DataAgendamento >= DateTime.Now)
            {
                situacao = "AGENDADO";
            }
            else if(!string.IsNullOrEmpty(this.Situacao))
            {
                situacao = this.Situacao;
            }
            return situacao;
        }
        public void downloadAgendamento()
        {

        }
    }
}
