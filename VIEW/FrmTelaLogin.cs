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

        }

        private void btnInfoContato_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contato - Desenvolvedor\n\n» Desenvolvedor: Mathews Freire Barbosa" +
                "\n» Telefone/Whatsapp: (82)9 9990-1016\n» E-mail: mathewsfreire@gmail.com", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
