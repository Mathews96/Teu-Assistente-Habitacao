using System;
using System.Windows.Forms;
using System.Drawing;

namespace Teu_Assistente_HABITACAO
{
    public partial class FrmAgendar : Form
    {
        public FrmAgendar()
        {
            InitializeComponent();
        }
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAgendar frmAgendar = new FrmAgendar();
            frmAgendar.ShowDialog();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCadastroPag1 frmCadastroPag1 = new FrmCadastroPag1();
            frmCadastroPag1.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmConsultar frmConsultar = new FrmConsultar();
            frmConsultar.ShowDialog();
        }

        private void desabilitarCampos()
        {
            txtBxAgNomeCompleto.Enabled = false;
            mkdTxtBxAgCPF.Enabled = false;
            mkdTxtBxAgContato.Enabled = false;
            cmbBxAgDemanda.Enabled = false;
            mkdTxtBxAgNumero.Enabled = false;
            dtTmPickrDataAg.Enabled = false;
        }
        private void habilitarCampos()
        {
            txtBxAgNomeCompleto.Enabled = true;
            mkdTxtBxAgCPF.Enabled = true;
            mkdTxtBxAgContato.Enabled = true;
            cmbBxAgDemanda.Enabled = true;
            mkdTxtBxAgNumero.Enabled = true;
            dtTmPickrDataAg.Enabled = true;
        }
        private void limparCampos()
        {
            txtBxAgNomeCompleto.Clear();
            mkdTxtBxAgCPF.Clear();
            mkdTxtBxAgContato.Clear();
            cmbBxAgDemanda.Refresh();
            mkdTxtBxAgNumero.Clear();
            dtTmPickrDataAg.Refresh();
            cmbBoxAgSituacao.Refresh();
        }
        private void btnAgAgendar_Click(object sender, EventArgs e)
        {
            Agendamento agendamento = new Agendamento();
            TratarDados tratarDados = new TratarDados();

            if (tratarDados.naoAceitaNuloOuVazio(txtBxAgNomeCompleto.Text))
            {
                MessageBox.Show("CAMPO OBRIGATÓRIO:\n- *NOME_COMPLETO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tratarDados.naoAceitaNumero(txtBxAgNomeCompleto.Text))
            {
                MessageBox.Show("DIGITE APENAS LETRAS NO CAMPO:\n- *NOME_COMPLETO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tratarDados.naoAceitaNuloOuVazio(tratarDados.retirarLetrasECaracteres(mkdTxtBxAgCPF.Text)) || tratarDados.retirarLetrasECaracteres(mkdTxtBxAgCPF.Text).Length != 11)
            {
                MessageBox.Show("CAMPO OBRIGATÓRIO:\n- *CPF", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tratarDados.naoAceitaNuloOuVazio(tratarDados.retirarLetrasECaracteres(mkdTxtBxAgContato.Text)) || tratarDados.retirarLetrasECaracteres(mkdTxtBxAgContato.Text).Length != 11)
            {
                MessageBox.Show("CAMPO OBRIGATÓRIO:\n- *CONTATO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tratarDados.naoAceitaNuloOuVazio(cmbBxAgDemanda.Text))
            {
                MessageBox.Show("CAMPO OBRIGATÓRIO:\n- *DEMANDA", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tratarDados.naoAceitaNuloOuVazio(tratarDados.retirarLetrasECaracteres(dtTmPickrDataAg.Text)))
            {
                MessageBox.Show("CAMPO OBRIGATÓRIO:\n- *DATA_AGENDAMENTO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                switch (agendamento.consultar(long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxAgCPF.Text))))
                {

                    case "AGENDADO":
                        {//AGENDADO = AGENDAMENTO AINDA ESTÁ EM DIA
                            btnCadEditar.Show();
                            txtBxAgNomeCompleto.Text = agendamento.NomeCompleto;
                            mkdTxtBxAgCPF.Text = agendamento.Cpf.ToString();
                            mkdTxtBxAgContato.Text = agendamento.Contato.ToString();
                            cmbBxAgDemanda.Text = agendamento.Demanda;
                            mkdTxtBxAgNumero.Text = agendamento.Numero.ToString();
                            dtTmPickrDataAg.Text = agendamento.DataAgendamento.ToString();
                            cmbBoxAgSituacao.Text = agendamento.Situacao;

                            this.desabilitarCampos();
                            //Criar_log
                            break;
                        }
                    case "FALTOSO":
                        {//FALTOSO = AGENDAMENTO PASSOU DA DATA
                            btnCadEditar.Show();
                            txtBxAgNomeCompleto.Text = agendamento.NomeCompleto;
                            mkdTxtBxAgCPF.Text = agendamento.Cpf.ToString();
                            mkdTxtBxAgContato.Text = agendamento.Contato.ToString();
                            cmbBxAgDemanda.Text = agendamento.Demanda;
                            mkdTxtBxAgNumero.Text = agendamento.Numero.ToString();
                            dtTmPickrDataAg.Text = agendamento.DataAgendamento.ToString();
                            cmbBoxAgSituacao.Text = agendamento.Situacao;

                            this.desabilitarCampos();
                            //Criar_log
                            break;
                        }
                    case "CADASTRADO":
                        {
                            MessageBox.Show("JÁ EXISTE UM AGENDAMENTO COM ESSE CPF: !"+ mkdTxtBxAgCPF.Text, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.limparCampos();
                            //Criar_log
                            break;
                        }
                    default:
                        {                       
                            btnCadEditar.Hide();

                            agendamento.NomeCompleto = txtBxAgNomeCompleto.Text;
                            agendamento.Cpf = long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxAgCPF.Text));
                            agendamento.Contato = long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxAgContato.Text));
                            agendamento.Demanda = cmbBxAgDemanda.Text;
                            agendamento.Numero = long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxAgNumero.Text));
                            agendamento.DataAgendamento = DateTime.Parse(dtTmPickrDataAg.Text);
                            agendamento.Situacao = "AGENDADO";

                            var confirmarDados = MessageBox.Show("» CONFIRMAR DADOS"+
                                "\n\n\n» [ AGENDAMENTO ]" +
                                "\n\n- NOME_COMPLETO: " + agendamento.NomeCompleto +
                                "\n- CPF: " + agendamento.Cpf +
                                "\n- CONTATO: " + agendamento.Contato +
                                "\n- DEMANDA: " + agendamento.Demanda +
                                "\n- NÚMERO DA DEMANDA: " + agendamento.Numero +
                                "\n- DATA_AGENDAMENTO: " + agendamento.DataAgendamento, "CONFIRME O AGENDAMENTO", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                            if (confirmarDados == DialogResult.OK)
                            {
                                agendamento.inserirAgendamento(long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxAgCPF.Text)));
                                MessageBox.Show(agendamento.NomeCompleto+ " FOI AGENDADO COM SUCESSO!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                this.limparCampos();
                                //Criar_log
                            }
                            break;
                        }
                }
            }
        }

        private void btnCadEditar_Click(object sender, EventArgs e)
        {
            /*Agendamento agendamento = new Agendamento();
            TratarDados tratarDados = new TratarDados();
            switch (agendamento.consultar(long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxAgCPF.Text))))*/
            switch(this.cmbBoxAgSituacao.Text)
            {//Verificar se existe agendamento ou cadastro
                case "AGENDADO":
                    {
                        this.habilitarCampos();
                        //Criar_log
                        break;
                    }
                case "FALTOSO":
                    {
                        this.habilitarCampos();
                        //Criar_log
                        break;
                    }
                case "CADASTADO":
                    {
                        this.desabilitarCampos();
                        //Criar_log
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                lkLblAgLinkedinDevMathews.LinkVisited = true;
                System.Diagnostics.Process.Start("https://www.linkedin.com/in/mathews-freire-02654211a/");
            }
            catch(Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL ACEESAR O LINK, ALGO DEU ERRADO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                      
        }
    }
}
