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
    public partial class FrmTelaLogin : Form
    {
        public FrmTelaLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void lkLblLogLinkedinDevMathews_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            try
            {
                lkLblLogLinkedinDevMathews.LinkVisited = true;
                System.Diagnostics.Process.Start("https://www.linkedin.com/in/mathews-freire-02654211a/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL ACEESAR O LINK, ALGO DEU ERRADO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
