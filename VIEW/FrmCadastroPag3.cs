using System;
using System.Windows.Forms;

namespace Teu_Assistente_HABITACAO
{
    public partial class FrmCadCompConjungePag3 : Form
    {
        public FrmCadCompConjungePag3()
        {
            InitializeComponent();
            this.retornarDados();
        }
        private void retornarDados()
        {
            cmbBxCadEstadoCivil.Text = VarGlobaisFrmCadastro.dadosCadPag3EstadoCivil;

            //Se estado civil for diferente de SOLTEIRO(A), será obrigatório
            txtBxCadConjugeNomeCompleto.Text = VarGlobaisFrmCadastro.dadosCadPag3NomeCompleto.ToString();
            mkdTxtBxCadConjugeCPF.Text = VarGlobaisFrmCadastro.dadosCadPag3Cpf.ToString();
            mkdTxtBxCadConjugeNIS.Text = VarGlobaisFrmCadastro.dadosCadPag3Nis.ToString();
            txtBxCadConjugeEmail.Text = VarGlobaisFrmCadastro.dadosCadPag3Email;
            mkdTxtBxCadConjugeTelefone.Text = VarGlobaisFrmCadastro.dadosCadPag3Telefone.ToString();
            mkdTxtBxCadConjugeWhatsApp.Text = VarGlobaisFrmCadastro.dadosCadPag3Whatsapp.ToString();

        }
        private void guardarDados()
        {
            TratarDados tratarDados = new TratarDados();
            VarGlobaisFrmCadastro.dadosCadPag3EstadoCivil = cmbBxCadEstadoCivil.Text;

            //Se estado civil for diferente de SOLTEIRO(A), será obrigatório                
            VarGlobaisFrmCadastro.dadosCadPag3NomeCompleto = txtBxCadConjugeNomeCompleto.Text;
            //VarGlobaisFrmCadastro.dadosCadPag3Cpf = long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadConjugeCPF.Text));
            if (string.IsNullOrEmpty(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadConjugeCPF.Text)))
            {
                VarGlobaisFrmCadastro.dadosCadPag3Cpf = null;
            }
            else
            {
                VarGlobaisFrmCadastro.dadosCadPag3Cpf = long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadConjugeCPF.Text));
            }
            //VarGlobaisFrmCadastro.dadosCadPag3Nis = long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadConjugeNIS.Text));
            if (string.IsNullOrEmpty(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadConjugeNIS.Text)))
            {
                VarGlobaisFrmCadastro.dadosCadPag3Nis = null;
            }
            else
            {
                VarGlobaisFrmCadastro.dadosCadPag3Nis = long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadConjugeNIS.Text));
            }
            VarGlobaisFrmCadastro.dadosCadPag3Email = txtBxCadConjugeEmail.Text;
            //VarGlobaisFrmCadastro.dadosCadPag3Telefone = long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadConjugeTelefone.Text));
            if (string.IsNullOrEmpty(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadConjugeTelefone.Text)))
            {
                VarGlobaisFrmCadastro.dadosCadPag3Telefone = null;
            }
            else
            {
                VarGlobaisFrmCadastro.dadosCadPag3Telefone = long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadConjugeTelefone.Text));
            }
            //VarGlobaisFrmCadastro.dadosCadPag3Whatsapp = long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadConjugeWhatsApp.Text));
            if (string.IsNullOrEmpty(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadConjugeWhatsApp.Text)))
            {
                VarGlobaisFrmCadastro.dadosCadPag3Whatsapp = null;
            }
            else
            {
                VarGlobaisFrmCadastro.dadosCadPag3Whatsapp = long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadConjugeWhatsApp.Text));
            }
        }
        private void btnCadCadastrar_Click(object sender, EventArgs e)
        {
            TratarDados tratarDados = new TratarDados();
            if (tratarDados.naoAceitaNuloOuVazio(cmbBxCadEstadoCivil.Text))
            {
                MessageBox.Show("CAMPO OBRIGATÓRIO:\n- ESTADO_CIVIL", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tratarDados.naoAceitaNumero(txtBxCadConjugeNomeCompleto.Text))
            {
                MessageBox.Show("DIGITE APENAS LETRAS NO CAMPO:\n- NOME_COMPLETO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tratarDados.naoAceitaNumero(txtBxCadConjugeEmail.Text))
            {
                MessageBox.Show("DIGITE APENAS LETRAS NO CAMPO:\n- E-MAIL", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.guardarDados();
                var confirmarDados = MessageBox.Show("» DADOS CADASTRAIS" + DateTime.Now +
                    "\n\n\n» PÁGINA - 1 [ DADOS PESSOAIS ]" +
                    "\n\n- NOME_COMPLETO: " + VarGlobaisFrmCadastro.dadosCadPag1NomeCompleto +
                    "\n- DATA_DE_NASCIMENTO: " + VarGlobaisFrmCadastro.dadosCadPag1Nascimento +
                    "\n- ESTADO_CIVIL: " + VarGlobaisFrmCadastro.dadosCadPag3EstadoCivil +
                    "\n- CPF: " + VarGlobaisFrmCadastro.dadosCadPag1Cpf +
                    "\n- NIS: " + VarGlobaisFrmCadastro.dadosCadPag1Nis +
                    "\n- E-MAIL: " + VarGlobaisFrmCadastro.dadosCadPag1Email +
                    "\n- TELEFONE: " + VarGlobaisFrmCadastro.dadosCadPag1Telefone +
                    "\n- WHATSAPP: " + VarGlobaisFrmCadastro.dadosCadPag1Whatsapp +
                    "\n- NOME_DA_MÃE: " + VarGlobaisFrmCadastro.dadosCadPag1NomeDaMae +
                    "\n\n\n» PÁGINA - 2 [ ENDEREÇO ]" +
                    "\n\n- ENDEREÇO: " + VarGlobaisFrmCadastro.dadosCadPag2Endereco +
                    "\n- COMPLEMENTO: " + VarGlobaisFrmCadastro.dadosCadPag2Complemento +
                    "\n- NÚMERO: " + VarGlobaisFrmCadastro.dadosCadPag2Numero +
                    "\n- BAIRRO: " + VarGlobaisFrmCadastro.dadosCadPag2Bairro +
                    "\n- CIDADE: " + VarGlobaisFrmCadastro.dadosCadPag2Cidade +
                    "\n- UF: " + VarGlobaisFrmCadastro.dadosCadPag2Uf +
                    "\n- CEP: " + VarGlobaisFrmCadastro.dadosCadPag2Cep +
                    "\n\n\n» PÁGINA - 3 [ CÔNJUGE ]" +
                    "\n\n- (CONJUNGE)NOME_COMPLETO: " + VarGlobaisFrmCadastro.dadosCadPag3NomeCompleto +
                    "\n- (CONJUNGE)CPF: " + VarGlobaisFrmCadastro.dadosCadPag3Cpf +
                    "\n- (CONJUNGE)NIS: " + VarGlobaisFrmCadastro.dadosCadPag3Nis +
                    "\n- (CONJUNGE)E-MAIL: " + VarGlobaisFrmCadastro.dadosCadPag3Email +
                    "\n- (CONJUNGE)TELEFONE: " + VarGlobaisFrmCadastro.dadosCadPag3Telefone +
                    "\n- (CONJUNGE)WHATSAPP: " + VarGlobaisFrmCadastro.dadosCadPag3Whatsapp, "CONFIRME OS DADOS", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if (confirmarDados == DialogResult.OK)
                {
                    CadastroHabitacional cadastro = new CadastroHabitacional();

                    cadastro.NomeCompleto = VarGlobaisFrmCadastro.dadosCadPag1NomeCompleto;
                    cadastro.EstadoCivil = VarGlobaisFrmCadastro.dadosCadPag3EstadoCivil;
                    cadastro.Cpf = (long)VarGlobaisFrmCadastro.dadosCadPag1Cpf;
                    cadastro.Nis = (long)VarGlobaisFrmCadastro.dadosCadPag1Nis;
                    cadastro.DataDeNascimento = VarGlobaisFrmCadastro.dadosCadPag1Nascimento;
                    cadastro.Email = VarGlobaisFrmCadastro.dadosCadPag1Email;
                    cadastro.Telefone = (long)VarGlobaisFrmCadastro.dadosCadPag1Telefone;
                    cadastro.WhatsApp = (long)VarGlobaisFrmCadastro.dadosCadPag1Whatsapp;
                    cadastro.NomeDaMae = VarGlobaisFrmCadastro.dadosCadPag1NomeDaMae;
                    cadastro.DataCadastro = DateTime.Now;

                    Endereco endereco = new Endereco();
                    endereco.Endereco = VarGlobaisFrmCadastro.dadosCadPag2Endereco;
                    endereco.Complemento = VarGlobaisFrmCadastro.dadosCadPag2Complemento;
                    endereco.Numero = (int)VarGlobaisFrmCadastro.dadosCadPag2Numero;
                    endereco.Bairro = VarGlobaisFrmCadastro.dadosCadPag2Bairro;
                    endereco.Cidade = VarGlobaisFrmCadastro.dadosCadPag2Cidade;
                    endereco.Uf = VarGlobaisFrmCadastro.dadosCadPag2Uf;
                    endereco.Cep = (int)VarGlobaisFrmCadastro.dadosCadPag2Cep;

                    cadastro.Endereco = endereco;

                    Conjuge conjuge = new Conjuge();
                    conjuge.NomeCompleto = VarGlobaisFrmCadastro.dadosCadPag3NomeCompleto;
                    conjuge.Cpf = (long)VarGlobaisFrmCadastro.dadosCadPag3Cpf;
                    conjuge.Nis = (long)VarGlobaisFrmCadastro.dadosCadPag3Nis;
                    conjuge.Email = VarGlobaisFrmCadastro.dadosCadPag3Email;
                    conjuge.Telefone = (long)VarGlobaisFrmCadastro.dadosCadPag3Telefone;
                    conjuge.Whatsapp = (long)VarGlobaisFrmCadastro.dadosCadPag3Whatsapp;

                    cadastro.Conjuge = conjuge;

                    cadastro.cadastrar((long)VarGlobaisFrmCadastro.dadosCadPag1Cpf);

                    Hide();
                    FrmCadastroPag1 frmCadastroPag1 = new FrmCadastroPag1();
                    frmCadastroPag1.ShowDialog();
                }
            }
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

        private void lkLblCadLinkedinDevMathews_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnNissLinkUteis_Click(object sender, EventArgs e)
        {

        }

        private void btnCadmutLinkUteis_Click(object sender, EventArgs e)
        {

        }

        private void btnCadVoltar_Click(object sender, EventArgs e)
        {
            this.guardarDados();
            Hide();
            FrmCadEnderecoPag2 frmCadEnderecoPag2 = new FrmCadEnderecoPag2();
            frmCadEnderecoPag2.ShowDialog();
        }
    }
}
