using System;
using System.Windows.Forms;

namespace Teu_Assistente_HABITACAO
{
    public partial class FrmConsultar : Form
    {
        public FrmConsultar()
        {
            InitializeComponent();
        }
        private string cpfSelecionado { get; set; }
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmAgendar frmAgendar = new FrmAgendar();
            frmAgendar.ShowDialog();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCadastroPag1 frmCadastro = new FrmCadastroPag1();
            frmCadastro.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmConsultar frmConsultar = new FrmConsultar();
            frmConsultar.ShowDialog();
        }

        private void btnConConsultar_Click(object sender, EventArgs e)
        {
            this.dtGrdViewConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGrdViewConsultas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGrdViewConsultas.AllowUserToOrderColumns = true;
            this.dtGrdViewConsultas.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            if (rdBtmConAgendado.Checked == true || rdBtmConCadastrado.Checked == false)
            {
                BDDataGridViewAgendamento bdDtGridViewAgendamento = new BDDataGridViewAgendamento();
                switch (this.cmbBxConsultarPor.Text)
                {
                    case "CPF":
                        {
                            this.dtGrdViewConsultas.DataSource = bdDtGridViewAgendamento.getTabelaDados("WHERE CPF LIKE'%" + txtBxConBarraConsulta.Text + "%'");
                            break;
                        }
                    case "NOME_COMPLETO":
                        {
                            this.dtGrdViewConsultas.DataSource = bdDtGridViewAgendamento.getTabelaDados("WHERE NOME_COMPLETO LIKE'%" + txtBxConBarraConsulta.Text + "%'");
                            break;
                        }
                    case "CONTATO":
                        {
                            this.dtGrdViewConsultas.DataSource = bdDtGridViewAgendamento.getTabelaDados("WHERE CONTATO LIKE'%" + txtBxConBarraConsulta.Text + "%'");
                            break;
                        }
                    case "SITUACAO":
                        {
                            this.dtGrdViewConsultas.DataSource = bdDtGridViewAgendamento.getTabelaDados("WHERE SITUACAO LIKE'%" + txtBxConBarraConsulta.Text + "%'");
                            break;
                        }
                    case "DEMANDA":
                        {
                            this.dtGrdViewConsultas.DataSource = bdDtGridViewAgendamento.getTabelaDados("WHERE DEMANDA LIKE'%" + txtBxConBarraConsulta.Text + "%'");
                            break;
                        }
                    case "NUMERO":
                        {
                            this.dtGrdViewConsultas.DataSource = bdDtGridViewAgendamento.getTabelaDados("WHERE NUMERO LIKE'%" + txtBxConBarraConsulta.Text + "%'");
                            break;
                        }
                    case "DATA_AGENDAMENTO":
                        {
                            this.dtGrdViewConsultas.DataSource = bdDtGridViewAgendamento.getTabelaDados("WHERE DATA_AGENDAMENTO LIKE'%" + txtBxConBarraConsulta.Text + "%'");
                            break;
                        }
                    default:
                        {
                            this.dtGrdViewConsultas.DataSource = bdDtGridViewAgendamento.getTabelaDados("");
                            break;
                        }
                }
            }
            else if (rdBtmConAgendado.Checked == false || rdBtmConCadastrado.Checked == true)
            {
                BDDataGridViewCadastro bdDtGridViewCadastro = new BDDataGridViewCadastro();
                switch (this.cmbBxConsultarPor.Text)
                {
                    case "CPF":
                        {
                            this.dtGrdViewConsultas.DataSource = bdDtGridViewCadastro.getTabelaDados("WHERE CPF LIKE'%" + txtBxConBarraConsulta.Text + "%'");
                            break;
                        }
                    case "NIS":
                        {
                            this.dtGrdViewConsultas.DataSource = bdDtGridViewCadastro.getTabelaDados("WHERE NIS LIKE'%" + txtBxConBarraConsulta.Text + "%'");
                            break;
                        }
                    case "NOME_COMPLETO":
                        {
                            this.dtGrdViewConsultas.DataSource = bdDtGridViewCadastro.getTabelaDados("WHERE NOME_COMPLETO LIKE'%" + txtBxConBarraConsulta.Text + "%'");
                            break;
                        }
                    case "DATA_DE_NASCIMENTO":
                        {
                            this.dtGrdViewConsultas.DataSource = bdDtGridViewCadastro.getTabelaDados("WHERE DATA_DE_NASCIMENTO LIKE'%" + txtBxConBarraConsulta.Text + "%'");
                            break;
                        }
                    case "ESTADO_CIVIL":
                        {
                            this.dtGrdViewConsultas.DataSource = bdDtGridViewCadastro.getTabelaDados("WHERE ESTADO_CIVIL LIKE'%" + txtBxConBarraConsulta.Text + "%'");
                            break;
                        }
                    case "EMAIL":
                        {
                            this.dtGrdViewConsultas.DataSource = bdDtGridViewCadastro.getTabelaDados("WHERE EMAIL LIKE'%" + txtBxConBarraConsulta.Text + "%'");
                            break;
                        }
                    case "TELEFONE":
                        {
                            this.dtGrdViewConsultas.DataSource = bdDtGridViewCadastro.getTabelaDados("WHERE TELEFONE LIKE'%" + txtBxConBarraConsulta.Text + "%'");
                            break;
                        }
                    case "WHATSAPP":
                        {
                            this.dtGrdViewConsultas.DataSource = bdDtGridViewCadastro.getTabelaDados("WHERE WHATSAPP LIKE'%" + txtBxConBarraConsulta.Text + "%'");
                            break;
                        }
                    case "NOME_DA_MAE":
                        {
                            this.dtGrdViewConsultas.DataSource = bdDtGridViewCadastro.getTabelaDados("WHERE NOME_DA_MAE LIKE'%" + txtBxConBarraConsulta.Text + "%'");
                            break;
                        }
                    case "DATA_CADASTRO":
                        {
                            this.dtGrdViewConsultas.DataSource = bdDtGridViewCadastro.getTabelaDados("WHERE DATA_CADASTRO LIKE'%" + txtBxConBarraConsulta.Text + "%'");
                            break;
                        }
                    default:
                        {
                            this.dtGrdViewConsultas.DataSource = bdDtGridViewCadastro.getTabelaDados("");
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("MARQUE APENAS UMA OPÇÃO (AGENDADO OU CADASTRADO)", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lkLblConLinkedinDevMathews_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void rdBtmConAgendado_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbBxConsultarPor.Items.Clear();
            this.cmbBxConsultarPor.Items.Add("");
            this.cmbBxConsultarPor.Items.Add("CPF");
            this.cmbBxConsultarPor.Items.Add("NOME_COMPLETO");
            this.cmbBxConsultarPor.Items.Add("CONTATO");
            this.cmbBxConsultarPor.Items.Add("SITUACAO");
            this.cmbBxConsultarPor.Items.Add("DEMANDA");
            this.cmbBxConsultarPor.Items.Add("NUMERO");
            this.cmbBxConsultarPor.Items.Add("DATA_AGENDAMENTO");
        }

        private void rdBtmConCadastrado_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbBxConsultarPor.Items.Clear();
            this.cmbBxConsultarPor.Items.Add("");
            this.cmbBxConsultarPor.Items.Add("CPF");
            this.cmbBxConsultarPor.Items.Add("NIS");
            this.cmbBxConsultarPor.Items.Add("NOME_COMPLETO");
            this.cmbBxConsultarPor.Items.Add("DATA_DE_NASCIMENTO");
            this.cmbBxConsultarPor.Items.Add("ESTADO_CIVIL");
            this.cmbBxConsultarPor.Items.Add("EMAIL");
            this.cmbBxConsultarPor.Items.Add("TELEFONE");
            this.cmbBxConsultarPor.Items.Add("WHATSAPP");
            this.cmbBxConsultarPor.Items.Add("NOME_DA_MAE");
            this.cmbBxConsultarPor.Items.Add("DATA_CADASTRO");
        }

        private void btnNissLinkUteis_Click(object sender, EventArgs e)
        {
            try
            {
                //btnNissLinkUteis.LinkVisited = true;
                System.Diagnostics.Process.Start("https://login.caixa.gov.br/auth/realms/internet/protocol/openid-connect/auth?response_type=code&client_id=cli-web-dun&redirect_uri=https%3A%2F%2Fwww.cadastrounico.caixa.gov.br%2Fcadun%2FabrirAplicacao.do&state=0856d92c-2e20-4ad9-81fe-62369b73f969&login=true&scope=openid");
            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL ACEESAR O LINK, ALGO DEU ERRADO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadmutLinkUteis_Click(object sender, EventArgs e)
        {
            try
            {
                //btnCadmutLinkUteis.LinkVisited = true;
                System.Diagnostics.Process.Start("https://acessoseguro.caixa.gov.br/internet.do?segmento=CONVENIADO01&urlCallback=https://www.cadastromutuarios.caixa.gov.br/sicdm/ReceberParametros");
            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL ACEESAR O LINK, ALGO DEU ERRADO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dtGrdViewConsultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cpfSelecionado = this.dtGrdViewConsultas.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private void btnConExcluir_Click(object sender, EventArgs e)
        {
            var messageBox = MessageBox.Show("DESEJA EXCLUIR O CADASTRO DO CPF: " + cpfSelecionado + "?", "ATENÇÃO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (messageBox == DialogResult.OK)
            {
                if (rdBtmConAgendado.Checked == true || rdBtmConCadastrado.Checked == true)
                {
                    BDAgendamento bdagendamento = new BDAgendamento();
                    bdagendamento.deletarAgendamento(long.Parse(cpfSelecionado));
                }
                else if (rdBtmConAgendado.Checked == false || rdBtmConCadastrado.Checked == true)
                {
                    BDCadastro bdcadastro = new BDCadastro();
                    bdcadastro.deletarCadastro(long.Parse(cpfSelecionado));
                }
            }
        }

        private void btnConEditar_Click(object sender, EventArgs e)
        {
            var messageBox = MessageBox.Show("DESEJA EDITAR O CADASTRO DO CPF: " + cpfSelecionado + "?", "ATENÇÃO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (messageBox == DialogResult.OK)
            {
                if (rdBtmConAgendado.Checked == true || rdBtmConCadastrado.Checked == false)
                {
                    /*BDAgendamento bdagendamento = new BDAgendamento();
                    bdagendamento.deletarAgendamento(long.Parse(cpfSelecionado));*/
                }
                else if (rdBtmConAgendado.Checked == false || rdBtmConCadastrado.Checked == true)
                {
                    CadastroHabitacional cadastro = new CadastroHabitacional();

                    cadastro.consultar(long.Parse(cpfSelecionado));
                    VarGlobaisFrmCadastro.dadosCadPag1Cpf = cadastro.Cpf;
                    VarGlobaisFrmCadastro.dadosCadPag1Nis = cadastro.Nis;
                    VarGlobaisFrmCadastro.dadosCadPag1NomeCompleto = cadastro.NomeCompleto;
                    VarGlobaisFrmCadastro.dadosCadPag1Nascimento = cadastro.DataDeNascimento;
                    VarGlobaisFrmCadastro.dadosCadPag1Email = cadastro.Email;
                    VarGlobaisFrmCadastro.dadosCadPag1Telefone = cadastro.Telefone;
                    VarGlobaisFrmCadastro.dadosCadPag1Whatsapp = cadastro.WhatsApp;
                    VarGlobaisFrmCadastro.dadosCadPag1NomeDaMae = cadastro.NomeDaMae;

                    VarGlobaisFrmCadastro.dadosCadPag2Endereco = cadastro.Endereco.Endereco;
                    VarGlobaisFrmCadastro.dadosCadPag2Complemento = cadastro.Endereco.Complemento;
                    VarGlobaisFrmCadastro.dadosCadPag2Numero = cadastro.Endereco.Numero;
                    VarGlobaisFrmCadastro.dadosCadPag2Bairro = cadastro.Endereco.Bairro;
                    VarGlobaisFrmCadastro.dadosCadPag2Cidade = cadastro.Endereco.Cidade;
                    VarGlobaisFrmCadastro.dadosCadPag2Uf = cadastro.Endereco.Uf;
                    VarGlobaisFrmCadastro.dadosCadPag2Cep = cadastro.Endereco.Cep;

                    VarGlobaisFrmCadastro.dadosCadPag3EstadoCivil = cadastro.EstadoCivil;
                    VarGlobaisFrmCadastro.dadosCadPag3NomeCompleto = cadastro.Conjuge.NomeCompleto;
                    VarGlobaisFrmCadastro.dadosCadPag3Cpf = cadastro.Conjuge.Cpf;
                    VarGlobaisFrmCadastro.dadosCadPag3Nis = cadastro.Conjuge.Nis;
                    VarGlobaisFrmCadastro.dadosCadPag3Email = cadastro.Conjuge.Email;
                    VarGlobaisFrmCadastro.dadosCadPag3Telefone = cadastro.Conjuge.Telefone;
                    VarGlobaisFrmCadastro.dadosCadPag3Whatsapp = cadastro.Conjuge.Whatsapp;

                    Hide();                    
                    FrmCadastroPag1 frmCadastroPag1 = new FrmCadastroPag1();
                    frmCadastroPag1.ShowDialog();
                }
            }
        }
    }
}
