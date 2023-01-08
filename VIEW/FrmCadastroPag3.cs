using System;
using System.Windows.Forms;

namespace Teu_Assistente_HABITACAO
{
    public partial class FrmCadCompConjungePag3 : Form
    {
        public FrmCadCompConjungePag3()
        {
            InitializeComponent();
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
                VarGlobaisFrmCadastro.dadosCadPag3EstadoCivil = cmbBxCadEstadoCivil.Text;
                
                //Se estado civil for diferente de SOLTEIRO(A), será obrigatório
                VarGlobaisFrmCadastro.dadosCadPag3NomeCompleto = txtBxCadConjugeNomeCompleto.Text;
                VarGlobaisFrmCadastro.dadosCadPag3Cpf = long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadConjugeCPF.Text));
                VarGlobaisFrmCadastro.dadosCadPag3Nis = long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadConjugeNIS.Text));
                VarGlobaisFrmCadastro.dadosCadPag3Email = txtBxCadConjugeEmail.Text;
                VarGlobaisFrmCadastro.dadosCadPag3Telefone = long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadConjugeTelefone.Text));
                VarGlobaisFrmCadastro.dadosCadPag3Whatsapp = long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadConjugeWhatsApp.Text));

                var confirmarDados = MessageBox.Show("» DADOS CADASTRAIS" + DateTime.Now +
                    "\n\n\n» PÁGINA - 1 [ DADOS PESSOAIS ]" +
                    "\n\n- NOME_COMPLETO: " + VarGlobaisFrmCadastro.dadosCadPag1NomeCompleto +
                    "\n- DATA_DE_NASCIMENTO: "+ VarGlobaisFrmCadastro.dadosCadPag1Nascimento+
                    "\n- ESTADO_CIVIL: " + VarGlobaisFrmCadastro.dadosCadPag3EstadoCivil +
                    "\n- CPF: " + VarGlobaisFrmCadastro.dadosCadPag1Cpf +
                    "\n- NIS: " + VarGlobaisFrmCadastro.dadosCadPag1Nis +
                    "\n- E-MAIL: " + VarGlobaisFrmCadastro.dadosCadPag1Email +
                    "\n- TELEFONE: " + VarGlobaisFrmCadastro.dadosCadPag1Telefone +
                    "\n- WHATSAPP: " + VarGlobaisFrmCadastro.dadosCadPag1Whatsapp +
                    "\n- NOME_DA_MÃE: " + VarGlobaisFrmCadastro.dadosCadPag1NomeDaMae+
                    "\n\n\n» PÁGINA - 2 [ ENDEREÇO ]" +
                    "\n\n- ENDEREÇO: " + VarGlobaisFrmCadastro.dadosCadPag2Endereco+
                    "\n- COMPLEMENTO: " + VarGlobaisFrmCadastro.dadosCadPag2Complemento+
                    "\n- NÚMERO: " + VarGlobaisFrmCadastro.dadosCadPag2Numero+
                    "\n- BAIRRO: " + VarGlobaisFrmCadastro.dadosCadPag2Bairro+
                    "\n- CIDADE: " + VarGlobaisFrmCadastro.dadosCadPag2Cidade+
                    "\n- UF: " + VarGlobaisFrmCadastro.dadosCadPag2Uf+
                    "\n- CEP: " + VarGlobaisFrmCadastro.dadosCadPag2Cep+
                    "\n\n\n» PÁGINA - 3 [ CÔNJUGE ]" +
                    "\n\n- (CONJUNGE)NOME_COMPLETO: " + VarGlobaisFrmCadastro.dadosCadPag3NomeCompleto +
                    "\n- (CONJUNGE)CPF: " + VarGlobaisFrmCadastro.dadosCadPag3Cpf +
                    "\n- (CONJUNGE)NIS: " + VarGlobaisFrmCadastro.dadosCadPag3Nis +
                    "\n- (CONJUNGE)E-MAIL: " + VarGlobaisFrmCadastro.dadosCadPag3Email +
                    "\n- (CONJUNGE)TELEFONE: " + VarGlobaisFrmCadastro.dadosCadPag3Telefone +
                    "\n- (CONJUNGE)WHATSAPP: " + VarGlobaisFrmCadastro.dadosCadPag3Whatsapp, "CONFIRME OS DADOS", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if(confirmarDados == DialogResult.OK)
                {
                    CadastroHabitacional cadastro = new CadastroHabitacional();

                    cadastro.NomeCompleto = VarGlobaisFrmCadastro.dadosCadPag1NomeCompleto;
                    cadastro.EstadoCivil = VarGlobaisFrmCadastro.dadosCadPag3EstadoCivil;
                    cadastro.Cpf = VarGlobaisFrmCadastro.dadosCadPag1Cpf;
                    cadastro.Nis = VarGlobaisFrmCadastro.dadosCadPag1Nis;
                    cadastro.DataDeNascimento = VarGlobaisFrmCadastro.dadosCadPag1Nascimento;
                    cadastro.Email = VarGlobaisFrmCadastro.dadosCadPag1Email;
                    cadastro.Telefone = VarGlobaisFrmCadastro.dadosCadPag1Telefone;
                    cadastro.WhatsApp = VarGlobaisFrmCadastro.dadosCadPag1Whatsapp;
                    cadastro.NomeDaMae = VarGlobaisFrmCadastro.dadosCadPag1NomeDaMae;
                    cadastro.DataCadastro = DateTime.Now;
                    
                    Endereco endereco = new Endereco();
                    endereco.Endereco = VarGlobaisFrmCadastro.dadosCadPag2Endereco;
                    endereco.Complemento = VarGlobaisFrmCadastro.dadosCadPag2Complemento;
                    endereco.Numero = VarGlobaisFrmCadastro.dadosCadPag2Numero;
                    endereco.Bairro = VarGlobaisFrmCadastro.dadosCadPag2Bairro;
                    endereco.Cidade = VarGlobaisFrmCadastro.dadosCadPag2Cidade;
                    endereco.Uf = VarGlobaisFrmCadastro.dadosCadPag2Uf;
                    endereco.Cep = VarGlobaisFrmCadastro.dadosCadPag2Cep;
                
                    cadastro.Endereco = endereco;

                    Conjuge conjuge = new Conjuge();
                    conjuge.NomeCompleto = VarGlobaisFrmCadastro.dadosCadPag3NomeCompleto;
                    conjuge.Cpf = VarGlobaisFrmCadastro.dadosCadPag3Cpf;
                    conjuge.Nis = VarGlobaisFrmCadastro.dadosCadPag3Nis;
                    conjuge.Email = VarGlobaisFrmCadastro.dadosCadPag3Email;
                    conjuge.Telefone = VarGlobaisFrmCadastro.dadosCadPag3Telefone;
                    conjuge.Whatsapp = VarGlobaisFrmCadastro.dadosCadPag3Whatsapp;

                    cadastro.Conjuge = conjuge;

                    cadastro.cadastrar(VarGlobaisFrmCadastro.dadosCadPag1Cpf);
                    
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
            try
            {
                lkLblCadLinkedinDevMathews.LinkVisited = true;
                System.Diagnostics.Process.Start("https://www.linkedin.com/in/mathews-freire-02654211a/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL ACEESAR O LINK, ALGO DEU ERRADO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
