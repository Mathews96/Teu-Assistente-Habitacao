using System;
using System.Windows.Forms;

namespace Teu_Assistente_HABITACAO
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void lkLblInicialLinkedinDevMathews_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnCadmutLinkUteis_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://acessoseguro.caixa.gov.br/internet.do?segmento=CONVENIADO01&urlCallback=https://www.cadastromutuarios.caixa.gov.br/sicdm/ReceberParametros");
            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL ACEESAR O LINK, ALGO DEU ERRADO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNissLinkUteis_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://login.caixa.gov.br/auth/realms/internet/protocol/openid-connect/auth?response_type=code&client_id=cli-web-dun&redirect_uri=https%3A%2F%2Fwww.cadastrounico.caixa.gov.br%2Fcadun%2FabrirAplicacao.do&state=0856d92c-2e20-4ad9-81fe-62369b73f969&login=true&scope=openid");
            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL ACEESAR O LINK, ALGO DEU ERRADO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfUsuario_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCadastroUsuario frmCadastroUsuario = new FrmCadastroUsuario();
            frmCadastroUsuario.ShowDialog();
        }
    }
}
