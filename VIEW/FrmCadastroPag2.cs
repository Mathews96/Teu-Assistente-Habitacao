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
            this.retornarDados();
        }
        private void retornarDados()
        {
            txtBxCadEndereco.Text = VarGlobaisFrmCadastro.dadosCadPag2Endereco;
            txtBxCadEndComplemento.Text = VarGlobaisFrmCadastro.dadosCadPag2Complemento;
            mkdTxtBxCadEndNumero.Text = VarGlobaisFrmCadastro.dadosCadPag2Numero.ToString();
            comboBoxCadEndBairro.Text = VarGlobaisFrmCadastro.dadosCadPag2Bairro;
            comboBoxCadEndCidade.Text = VarGlobaisFrmCadastro.dadosCadPag2Cidade;
            comboBoxCadEndUf.Text = VarGlobaisFrmCadastro.dadosCadPag2Uf;
            mkdTxtBxCadEndCep.Text = VarGlobaisFrmCadastro.dadosCadPag2Cep.ToString();
        }
        private void guardarDados()
        {
            TratarDados tratarDados = new TratarDados();
            VarGlobaisFrmCadastro.dadosCadPag2Endereco = txtBxCadEndereco.Text;
            VarGlobaisFrmCadastro.dadosCadPag2Complemento = txtBxCadEndComplemento.Text;
            //VarGlobaisFrmCadastro.dadosCadPag2Numero = int.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadEndNumero.Text));
            if (string.IsNullOrEmpty(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadEndNumero.Text)))
            {
                VarGlobaisFrmCadastro.dadosCadPag2Numero = null;
            }
            else
            {
                VarGlobaisFrmCadastro.dadosCadPag2Numero = int.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadEndNumero.Text));
            }
            VarGlobaisFrmCadastro.dadosCadPag2Bairro = comboBoxCadEndBairro.Text;
            VarGlobaisFrmCadastro.dadosCadPag2Cidade = comboBoxCadEndCidade.Text;
            VarGlobaisFrmCadastro.dadosCadPag2Uf = comboBoxCadEndUf.Text;
            //VarGlobaisFrmCadastro.dadosCadPag2Cep = int.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadEndCep.Text));
            if (string.IsNullOrEmpty(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadEndCep.Text)))
            {
                VarGlobaisFrmCadastro.dadosCadPag2Cep = null;
            }
            else
            {
                VarGlobaisFrmCadastro.dadosCadPag2Cep = int.Parse(tratarDados.retirarLetrasECaracteres(mkdTxtBxCadEndCep.Text));
            }
        }
        private void btnCadProximo_Click(object sender, EventArgs e)
        {
            TratarDados tratarDados = new TratarDados();
            if (!tratarDados.aceitarNumeros(1, mkdTxtBxCadEndNumero.Text))
            {
                MessageBox.Show("CAMPO OBRIGATÓRIO:\n- NÚMERO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!tratarDados.aceitarNumeros(8, mkdTxtBxCadEndCep.Text))
            {
                MessageBox.Show("CAMPO OBRIGATÓRIO:\n- CEP", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (tratarDados.naoAceitaNuloOuVazio(txtBxCadEndereco.Text))
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
                    MessageBox.Show("DIGITE APENAS LETRAS NO CIDADE:\n- CIDADE", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tratarDados.naoAceitaNuloOuVazio(comboBoxCadEndUf.Text))
                {
                    MessageBox.Show("CAMPO OBRIGATÓRIO:\n- UF", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tratarDados.naoAceitaNumero(comboBoxCadEndUf.Text))
                {
                    MessageBox.Show("DIGITE APENAS LETRAS NO UF:\n- CIDADE", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this. guardarDados();
                    Hide();
                    FrmCadCompConjungePag3 frmCadCompConjungePag3 = new FrmCadCompConjungePag3();
                    frmCadCompConjungePag3.ShowDialog();
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

        private void btnCadVoltar_Click(object sender, EventArgs e)
        {
            this.guardarDados();
            Hide();
            FrmCadastroPag1 frmCadastroPag1 = new FrmCadastroPag1();
            frmCadastroPag1.ShowDialog();
        }
    }
}
