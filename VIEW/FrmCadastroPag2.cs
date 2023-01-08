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
    public partial class FrmCadEnderecoPag2 : Form
    {
        public FrmCadEnderecoPag2()
        {
            InitializeComponent();
        }
        private void btnCadProximo_Click(object sender, EventArgs e)
        {
            TratarDados tratarDados = new TratarDados();         
            if(tratarDados.naoAceitaNuloOuVazio(txtBxCadEndereco.Text))
            {
                MessageBox.Show("CAMPO OBRIGATÓRIO:\n- ENDEREÇO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(tratarDados.naoAceitaNumero(txtBxCadEndereco.Text))
            {
                MessageBox.Show("DIGITE APENAS LETRAS NO CAMPO:\n- ENDEREÇO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }        
            else if (tratarDados.naoAceitaNuloOuVazio(comboBoxCadEndBairro.Text))
            {
                MessageBox.Show("CAMPO OBRIGATÓRIO:\n- BAIRRO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tratarDados.naoAceitaNumero(comboBoxCadEndBairro.Text))
            {
                MessageBox.Show("DIGITE APENAS LETRAS NO CAMPO:\n- BAIRRO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tratarDados.naoAceitaNuloOuVazio(comboBoxCadEndCidade.Text))
            {
                MessageBox.Show("CAMPO OBRIGATÓRIO:\n- CIDADE", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tratarDados.naoAceitaNumero(comboBoxCadEndCidade.Text))
            {
                MessageBox.Show("DIGITE APENAS LETRAS NO CIDADE:\n- BAIRRO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
            else if (tratarDados.naoAceitaNuloOuVazio(mkdTxtBxCadEndCep.Text))
            {
                MessageBox.Show("CAMPO OBRIGATÓRIO:\n- CEP", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                VarGlobaisFrmCadastro.dadosCadPag2Endereco = txtBxCadEndereco.Text;
                VarGlobaisFrmCadastro.dadosCadPag2Complemento = txtBxCadEndComplemento.Text;
                VarGlobaisFrmCadastro.dadosCadPag2Numero = int.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadEndNumero.Text));
                VarGlobaisFrmCadastro.dadosCadPag2Bairro = comboBoxCadEndBairro.Text;
                VarGlobaisFrmCadastro.dadosCadPag2Cidade = comboBoxCadEndCidade.Text;
                VarGlobaisFrmCadastro.dadosCadPag2Uf = comboBoxCadEndUf.Text;
                VarGlobaisFrmCadastro.dadosCadPag2Cep = int.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadEndCep.Text));

                Hide();
                FrmCadCompConjungePag3 frmCadCompConjungePag3 = new FrmCadCompConjungePag3();
                frmCadCompConjungePag3.ShowDialog();
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
