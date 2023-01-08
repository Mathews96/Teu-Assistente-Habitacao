using System;
using System.Windows.Forms;

namespace Teu_Assistente_HABITACAO
{
    public partial class FrmCadastroPag1 : Form
    {
        public FrmCadastroPag1()
        {
            InitializeComponent();            
        }
        private void btnCadProximo_Click(object sender, EventArgs e)
        {
            CadastroHabitacional cadastro = new CadastroHabitacional();
            TratarDados tratarDados = new TratarDados();
            if (!cadastro.getCadastro(long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadCPF.Text))))
            {                
                if (tratarDados.naoAceitaNuloOuVazio(txtBxCadNomeCompleto.Text))
                {
                    MessageBox.Show("CAMPO OBRIGATÓRIO:\n- NOME_COMPLETO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tratarDados.naoAceitaNumero(txtBxCadNomeCompleto.Text))
                {
                    MessageBox.Show("DIGITE APENAS LETRAS NO CAMPO:\n- NOME_COMPLETO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tratarDados.naoAceitaNuloOuVazio(mkdTxtBxCadCPF.Text))
                {
                    MessageBox.Show("CAMPO OBRIGATÓRIO:\n- CPF", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tratarDados.naoAceitaNuloOuVazio(mkdTxtBxCadNIS.Text))
                {
                    MessageBox.Show("CAMPO OBRIGATÓRIO:\n- NIS", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tratarDados.naoAceitaNuloOuVazio(txtBxCadEmail.Text))
                {
                    MessageBox.Show("CAMPO OBRIGATÓRIO:\n- E-MAIL", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tratarDados.naoAceitaNuloOuVazio(mkdTxtBxCadTelefone.Text))
                {
                    MessageBox.Show("CAMPO OBRIGATÓRIO:\n- TELEFONE", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tratarDados.naoAceitaNuloOuVazio(mkdTxtBxCadWhatsApp.Text))
                {
                    MessageBox.Show("CAMPO OBRIGATÓRIO:\n- WHATSAPP", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tratarDados.naoAceitaNuloOuVazio(txtBxCadNomeMae.Text))
                {
                    MessageBox.Show("CAMPO OBRIGATÓRIO:\n- NOME_DA_MÃE", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tratarDados.naoAceitaNumero(txtBxCadNomeMae.Text))
                {
                    MessageBox.Show("DIGITE APENAS LETRAS NO CAMPO:\n- NOME_DA_MÃE", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    VarGlobaisFrmCadastro.dadosCadPag1NomeCompleto = txtBxCadNomeCompleto.Text;
                    VarGlobaisFrmCadastro.dadosCadPag1Cpf = long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadCPF.Text));
                    VarGlobaisFrmCadastro.dadosCadPag1Nis = long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadNIS.Text));
                    VarGlobaisFrmCadastro.dadosCadPag1Nascimento = DateTime.Parse(dtTmPckCadNascimento.Text);
                    VarGlobaisFrmCadastro.dadosCadPag1Email = txtBxCadEmail.Text;
                    VarGlobaisFrmCadastro.dadosCadPag1Telefone = long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadTelefone.Text));
                    VarGlobaisFrmCadastro.dadosCadPag1Whatsapp = long.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadWhatsApp.Text));
                    VarGlobaisFrmCadastro.dadosCadPag1NomeDaMae = txtBxCadNomeMae.Text;

                    Hide();
                    FrmCadEnderecoPag2 frmCadEnderecoPag2 = new FrmCadEnderecoPag2();
                    frmCadEnderecoPag2.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Já existe um cadastro com esse número de CPF: " + mkdTxtBxCadCPF.Text, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBxCadNomeCompleto.Clear();
                mkdTxtBxCadCPF.Clear();
                mkdTxtBxCadNIS.Clear();
                dtTmPckCadNascimento.ResetText();
                txtBxCadEmail.Clear();
                mkdTxtBxCadTelefone.Clear();
                mkdTxtBxCadWhatsApp.Clear();
                txtBxCadNomeMae.Clear();
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
