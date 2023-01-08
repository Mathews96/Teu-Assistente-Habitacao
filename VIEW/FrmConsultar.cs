using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teu_Assistente_HABITACAO
{
    public partial class FrmConsultar : Form
    {
        public FrmConsultar()
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
            if(rdBtmConAgendado.Checked == true || rdBtmConCadastro.Checked == false)
            {

            }
            else if(rdBtmConAgendado.Checked == false || rdBtmConCadastro.Checked == true)
            {

            }
            else
            {
                MessageBox.Show("MARQUE APENAS UMA OPÇÃO (AGENDADO OU CADASTRADO)", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lkLblConLinkedinDevMathews_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                lkLblConLinkedinDevMathews.LinkVisited = true;
                System.Diagnostics.Process.Start("https://www.linkedin.com/in/mathews-freire-02654211a/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL ACEESAR O LINK, ALGO DEU ERRADO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
