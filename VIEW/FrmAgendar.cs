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
            this.Hide();
            FrmAgendar frmAgendar = new FrmAgendar();
            frmAgendar.ShowDialog();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCadastroPag1 frmCadastroPag1 = new FrmCadastroPag1();
            frmCadastroPag1.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConsultar frmConsultar = new FrmConsultar();
            frmConsultar.ShowDialog();
        }

        private void desabilitarCampos()
        {
            this.txtBxAgNomeCompleto.Enabled = false;
            this.mkdTxtBxAgCPF.Enabled = false;
            this.mkdTxtBxAgContato.Enabled = false;
            this.cmbBxAgDemanda.Enabled = false;
            this.mkdTxtBxAgNumero.Enabled = false;
            this.dtTmPickrDataAg.Enabled = false;
        }
        private void habilitarCampos()
        {
            this.txtBxAgNomeCompleto.Enabled = true;
            this.mkdTxtBxAgCPF.Enabled = true;
            this.mkdTxtBxAgContato.Enabled = true;
            this.cmbBxAgDemanda.Enabled = true;
            this.mkdTxtBxAgNumero.Enabled = true;
            this.dtTmPickrDataAg.Enabled = true;
        }
        private void limparCampos()
        {
            this.txtBxAgNomeCompleto.Clear();
            this.mkdTxtBxAgCPF.Clear();
            this.mkdTxtBxAgContato.Clear();
            this.cmbBxAgDemanda.Refresh();
            this.mkdTxtBxAgNumero.Clear();
            this.dtTmPickrDataAg.Refresh();
            this.cmbBoxAgSituacao.SelectedItem = null;
            this.txtBxAgNomeCompleto.Text = "";
            this.mkdTxtBxAgCPF.Text = "";
            this.mkdTxtBxAgContato.Text = "";
            this.cmbBxAgDemanda.Text = "";
            this.mkdTxtBxAgNumero.Text = "";
            this.dtTmPickrDataAg.Text = "";
            this.cmbBoxAgSituacao.Text = "";
        }
        private void btnAgAgendar_Click(object sender, EventArgs e)
        {
            if(this.mkdTxtBxAgCPF.Enabled == true)
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
                else if (tratarDados.naoAceitaNuloOuVazio(this.mkdTxtBxAgNumero.Text))
                {
                    this.mkdTxtBxAgNumero.Text = "000000";
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
                            {
                                this.btnCadEditar.Show();
                                switch (this.btnAgAgendar.Text)
                                {
                                    case "AGENDAR":
                                        {
                                            this.txtBxAgNomeCompleto.Text = agendamento.NomeCompleto;
                                            this.mkdTxtBxAgCPF.Text = agendamento.Cpf.ToString();
                                            this.mkdTxtBxAgContato.Text = agendamento.Contato.ToString();
                                            this.cmbBxAgDemanda.Text = agendamento.Demanda;
                                            this.mkdTxtBxAgNumero.Text = agendamento.Numero.ToString();
                                            this.dtTmPickrDataAg.Text = agendamento.DataAgendamento.ToString();
                                            this.cmbBoxAgSituacao.Text = agendamento.Situacao;
                                            this.desabilitarCampos();
                                            break;
                                        }
                                    case "REAGENDAR":
                                        {
                                            this.btnCadEditar.Hide();
                                            agendamento.NomeCompleto = txtBxAgNomeCompleto.Text;
                                            agendamento.Cpf = long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxAgCPF.Text));
                                            agendamento.Contato = long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxAgContato.Text));
                                            agendamento.Demanda = cmbBxAgDemanda.Text;
                                            agendamento.Numero = long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxAgNumero.Text));
                                            agendamento.DataAgendamento = DateTime.Parse(dtTmPickrDataAg.Text);
                                            agendamento.Situacao = "AGENDADO";

                                            var confirmarDados = MessageBox.Show("» CONFIRMAR DADOS" +
                                                "\n\n\n» [ REAGENDAMENTO ]" +
                                                "\n\n- NOME_COMPLETO: " + agendamento.NomeCompleto +
                                                "\n- CPF: " + agendamento.Cpf +
                                                "\n- CONTATO: " + agendamento.Contato +
                                                "\n- DEMANDA: " + agendamento.Demanda +
                                                "\n- NÚMERO DA DEMANDA: " + agendamento.Numero +
                                                "\n- DATA_AGENDAMENTO: " + agendamento.DataAgendamento, "CONFIRME O AGENDAMENTO", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                                            if (confirmarDados == DialogResult.OK)
                                            {
                                                agendamento.reagendar(long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxAgCPF.Text)));
                                                MessageBox.Show(agendamento.NomeCompleto + " FOI REAGENDADO PARA A DATA "+ agendamento.DataAgendamento, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                this.limparCampos();
                                                this.btnAgAgendar.Text = "AGENDAR";
                                                this.habilitarCampos();
                                                //Criar_log
                                            }
                                            break;
                                        }
                                    default:
                                        {
                                            break;
                                        }
                                }                                
                                //Criar_log
                                break;
                            }
                        case "FALTOSO":
                            {
                                this.btnCadEditar.Show();
                                this.txtBxAgNomeCompleto.Text = agendamento.NomeCompleto;
                                this.mkdTxtBxAgCPF.Text = agendamento.Cpf.ToString();
                                this.mkdTxtBxAgContato.Text = agendamento.Contato.ToString();
                                this.cmbBxAgDemanda.Text = agendamento.Demanda;
                                this.mkdTxtBxAgNumero.Text = agendamento.Numero.ToString();
                                this.dtTmPickrDataAg.Text = agendamento.DataAgendamento.ToString();
                                this.cmbBoxAgSituacao.Text = agendamento.Situacao;

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
                                this.btnCadEditar.Hide();

                                agendamento.NomeCompleto = this.txtBxAgNomeCompleto.Text;
                                agendamento.Cpf = long.Parse(tratarDados.retirarLetrasECaracteres(this.mkdTxtBxAgCPF.Text));
                                agendamento.Contato = long.Parse(tratarDados.retirarLetrasECaracteres(this.mkdTxtBxAgContato.Text));
                                agendamento.Demanda = this.cmbBxAgDemanda.Text;
                                agendamento.Numero = long.Parse(tratarDados.retirarLetrasECaracteres(this.mkdTxtBxAgNumero.Text));
                                agendamento.DataAgendamento = DateTime.Parse(this.dtTmPickrDataAg.Text);
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
                                    agendamento.inserirAgendamento(long.Parse(tratarDados.retirarLetrasECaracteres(this.mkdTxtBxAgCPF.Text)));
                                    MessageBox.Show(agendamento.NomeCompleto+ " FOI AGENDADO PARA A DATA "+ agendamento.DataAgendamento, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    this.limparCampos();
                                    //Criar_log
                                }
                                break;
                            }
                    }
                }
            }
        }

        private void btnCadEditar_Click(object sender, EventArgs e)
        {
            switch(this.cmbBoxAgSituacao.Text)
            {
                case "AGENDADO":
                    {
                         this.habilitarCampos();
                        this.btnAgAgendar.Text = "REAGENDAR";
                        //Criar_log
                        break;
                    }
                case "FALTOSO":
                    {
                           this.habilitarCampos();
                        this.btnAgAgendar.Text = "REAGENDAR";
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

        }

        private void btnCadCancelar_Click(object sender, EventArgs e)
        {
            this.limparCampos();
            if(this.mkdTxtBxAgCPF.Enabled == false)
            {
                this.habilitarCampos();
            }            
        }
    }
}
