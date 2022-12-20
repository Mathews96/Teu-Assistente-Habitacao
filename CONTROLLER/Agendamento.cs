using System;
using System.Windows.Forms;

namespace Teu_Assistente_HABITACAO
{
    internal class Agendamento : SituacaoCadastral
    {
        public void agendar(int cpf, DateTime dataAgendado)
        {
            if (!getAgendamento(cpf))
            {
                inserirAgendamento(cpf, dataAgendado);
                definirSituacao(cpf, "AGENDADO");
            }
            MessageBox.Show("Já existe um agendamento para o CPF informado!\n" +
                "Deseja reagendar?", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }
        public void desagendar(int cpf)
        {
            if (getAgendamento(cpf))
            {
                deletarAgendamento(cpf);
            }
        }
        public void consultar(int cpf)
        {
            if (getAgendamento(cpf))
            {
                MessageBox.Show("ESTE CPF JÁ FOI AGENDADO:"+"Nome: "+ this.NomeCompleto +
                    "CPF: "+ this.Cpf+"Demanda: "+this.Demanda+"Situação: "+ this.Situacao +
                    "Data: "+ this.DataAgendamento,"AGENDADO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void downloadAgendamento()
        {

        }
    }
}
