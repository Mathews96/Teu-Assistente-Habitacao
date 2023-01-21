using System;
using System.Windows.Forms;

namespace Teu_Assistente_HABITACAO
{
    public partial class FrmCadastroUsuario : Form
    {
        bool editando = false;
        public FrmCadastroUsuario()
        {
            InitializeComponent();
            this.cadastroUsuario = new CadastroUsuario();
        }
        internal CadastroUsuario cadastroUsuario { get; set; }
        private void setarDados()
        {
            this.txtBxCadUseNomeCompleto.Text = this.cadastroUsuario.NomeCompleto;
            this.mkdTxtBxCadUseCPF.Text = this.cadastroUsuario.Cpf.ToString();
            this.mkdTxtBxCadUseMatricula.Text = this.cadastroUsuario.Matricula.ToString();
            this.dtTmPckCadUseNascimento.Text = this.cadastroUsuario.DataDeNascimento.ToString();
            this.mkdTxtBxCadUseTelefone.Text = this.cadastroUsuario.Telefone.ToString();
            this.mkdTxtBxCadUseWhatsApp.Text = this.cadastroUsuario.Whatsapp.ToString();
            this.txtBxCadUseEmail.Text = this.cadastroUsuario.Email;
            this.cmbBxCadUseEntidade.Text = this.cadastroUsuario.Entidade;
            this.cmbBxCadUseSetor.Text = this.cadastroUsuario.Setor;
            this.cmbBoxCadUseCargo.Text = this.cadastroUsuario.Cargo;
            this.txtBxCadUseSenha.Text = this.cadastroUsuario.Senha;
            this.cmbBxCadUseNivel.Text = this.cadastroUsuario.Nivel.ToString();
        }
        private void guardarDados()
        {
            TratarDados tratarDados = new TratarDados();
            this.cadastroUsuario.NomeCompleto = this.txtBxCadUseNomeCompleto.Text;
            if (string.IsNullOrEmpty(tratarDados.retirarLetrasECaracteres(this.mkdTxtBxCadUseCPF.Text)))
            {
                this.cadastroUsuario.Cpf = null;
            }
            else
            {
                this.cadastroUsuario.Cpf = long.Parse(tratarDados.retirarLetrasECaracteres(this.mkdTxtBxCadUseCPF.Text));
            }
            if (string.IsNullOrEmpty(tratarDados.retirarLetrasECaracteres(this.mkdTxtBxCadUseMatricula.Text)))
            {
                this.cadastroUsuario.Matricula = null;
            }
            else
            {
                this.cadastroUsuario.Matricula = long.Parse(tratarDados.retirarLetrasECaracteres(this.mkdTxtBxCadUseMatricula.Text));
            }
            this.cadastroUsuario.DataDeNascimento = DateTime.Parse(this.dtTmPckCadUseNascimento.Text);
            this.cadastroUsuario.Email = this.txtBxCadUseEmail.Text;
            if (string.IsNullOrEmpty(tratarDados.retirarLetrasECaracteres(this.mkdTxtBxCadUseTelefone.Text)))
            {
                this.cadastroUsuario.Telefone = null;
            }
            else
            {
                this.cadastroUsuario.Telefone = long.Parse(tratarDados.retirarLetrasECaracteres(this.mkdTxtBxCadUseTelefone.Text));
            }
            if (string.IsNullOrEmpty(tratarDados.retirarLetrasECaracteres(this.mkdTxtBxCadUseWhatsApp.Text)))
            {
                this.cadastroUsuario.Whatsapp = null;
            }
            else
            {
                this.cadastroUsuario.Whatsapp = long.Parse(tratarDados.retirarLetrasECaracteres(this.mkdTxtBxCadUseWhatsApp.Text));
            }
            this.cadastroUsuario.Entidade = this.cmbBxCadUseEntidade.Text;
            this.cadastroUsuario.Setor = this.cmbBxCadUseSetor.Text;
            this.cadastroUsuario.Cargo = this.cmbBoxCadUseCargo.Text;
            this.cadastroUsuario.Senha = this.txtBxCadUseSenha.Text;
            if (string.IsNullOrEmpty(tratarDados.retirarLetrasECaracteres(this.cmbBxCadUseNivel.Text)))
            {
                this.cadastroUsuario.Nivel = null;
            }
            else
            {
                this.cadastroUsuario.Nivel = int.Parse(tratarDados.retirarLetrasECaracteres(this.cmbBxCadUseNivel.Text));
            }
        }
        private void limparCampos()
        {
            this.txtBxCadUseNomeCompleto.Clear();
            this.mkdTxtBxCadUseCPF.Clear();
            this.mkdTxtBxCadUseMatricula.Clear();
            this.dtTmPckCadUseNascimento.ResetText();
            this.mkdTxtBxCadUseTelefone.Clear();
            this.mkdTxtBxCadUseWhatsApp.Clear();
            this.txtBxCadUseEmail.Clear();
            this.cmbBxCadUseEntidade.ResetText();
            this.cmbBxCadUseSetor.ResetText();
            this.cmbBoxCadUseCargo.ResetText();
            this.txtBxCadUseSenha.Clear();
            this.cmbBxCadUseNivel.ResetText();
        }
        private bool dadosObrigatorios()
        {
            TratarDados tratarDados = new TratarDados();
            if (tratarDados.naoAceitaNuloOuVazio(this.txtBxCadUseNomeCompleto.Text))
            {
                MessageBox.Show("CAMPO OBRIGATÓRIO:\n- NOME_COMPLETO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tratarDados.naoAceitaNumero(this.txtBxCadUseNomeCompleto.Text))
            {
                MessageBox.Show("DIGITE APENAS LETRAS NO CAMPO:\n- NOME_COMPLETO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!tratarDados.aceitarNumeros(11, this.mkdTxtBxCadUseCPF.Text))
            {
                MessageBox.Show("CAMPO OBRIGATÓRIO:\n- CPF", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!tratarDados.aceitarNumeros(7, this.mkdTxtBxCadUseMatricula.Text))
            {
                MessageBox.Show("CAMPO OBRIGATÓRIO:\n- MATRÍCULA", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            /*else if (tratarDados.naoAceitaNuloOuVazio(this.dtTmPckCadUseNascimento.Text))
            {
                MessageBox.Show("CAMPO OBRIGATÓRIO:\n- DATA_DE_NASCIMENTO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
            else if (!tratarDados.aceitarNumeros(11, this.mkdTxtBxCadUseTelefone.Text))
            {
                MessageBox.Show("CAMPO OBRIGATÓRIO:\n- TELEFONE", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!tratarDados.aceitarNumeros(11, this.mkdTxtBxCadUseWhatsApp.Text))
            {
                MessageBox.Show("CAMPO OBRIGATÓRIO:\n- WHATSAPP", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tratarDados.naoAceitaNuloOuVazio(this.cmbBxCadUseEntidade.Text))
            {
                MessageBox.Show("CAMPO OBRIGATÓRIO:\n- ENTIDADE", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tratarDados.naoAceitaNuloOuVazio(this.cmbBxCadUseSetor.Text))
            {
                MessageBox.Show("CAMPO OBRIGATÓRIO:\n- SETOR", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tratarDados.naoAceitaNuloOuVazio(this.cmbBoxCadUseCargo.Text))
            {
                MessageBox.Show("CAMPO OBRIGATÓRIO:\n- CARGO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tratarDados.naoAceitaNuloOuVazio(this.txtBxCadUseSenha.Text))
            {
                MessageBox.Show("CAMPO OBRIGATÓRIO:\n- SENHA", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tratarDados.naoAceitaNuloOuVazio(this.cmbBxCadUseNivel.Text))
            {
                MessageBox.Show("CAMPO OBRIGATÓRIO:\n- NÍVEL", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.guardarDados();
                return true;
            }
            return false;
        }        
        private void btnCadUseConfirmar_Click(object sender, EventArgs e)
        {           

            if(this.dadosObrigatorios())
            {
                TratarDados tratarDados = new TratarDados();
                if (!this.cadastroUsuario.getCadastroUsu(long.Parse(tratarDados.retirarLetrasECaracteres(this.mkdTxtBxCadUseCPF.Text))))
                {
                    var confirmarDados = MessageBox.Show("» DADOS CADASTRAIS - " + DateTime.Now +
                        "\n\n\n» PÁGINA - 1 [ DADOS PESSOAIS ]" +
                        "\n\n- NOME_COMPLETO: " + this.txtBxCadUseNomeCompleto.Text +
                        "\n- DATA_DE_NASCIMENTO: " + this.dtTmPckCadUseNascimento.Text +
                        "\n- CPF: " + this.mkdTxtBxCadUseCPF.Text +
                        "\n- MATRÍCULA: " + this.mkdTxtBxCadUseMatricula.Text +
                        "\n- E-MAIL: " + this.txtBxCadUseEmail.Text +
                        "\n- TELEFONE: " + this.mkdTxtBxCadUseTelefone.Text +
                        "\n- WHATSAPP: " + this.mkdTxtBxCadUseWhatsApp.Text +
                        "\n\n\n» PÁGINA - 2 [ ENDEREÇO ]" +
                        "\n\n- ENTIDADE: " + this.cmbBxCadUseEntidade.Text +
                        "\n- SETOR: " + this.cmbBxCadUseSetor.Text +
                        "\n- CARGO: " + this.cmbBoxCadUseCargo.Text +
                        "\n- NÍVEL: " + this.cmbBxCadUseNivel.Text +
                        "\n- SENHA: " + this.txtBxCadUseSenha.Text, "CONFIRME OS DADOS", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                    if (confirmarDados == DialogResult.OK)
                    {
                        this.guardarDados();
                        this.cadastroUsuario.DataCadastro = DateTime.Now;
                        this.cadastroUsuario.cadastrar((long)this.cadastroUsuario.Cpf);
                        this.limparCampos();
                    }
                }
                else
                {                    
                    if(this.editando == false)
                    {
                        var confirmarEdicao = MessageBox.Show("Já existe um cadastro com esse número de CPF:\n " + this.mkdTxtBxCadUseCPF.Text + "\n\nDESEJA EDITAR?", "ATENÇÃO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (confirmarEdicao == DialogResult.OK)
                        {
                            this.setarDados();
                            this.editando = true;
                        }
                    }
                    else if(this.editando == true)
                    {
                        this.guardarDados();
                        //this.cadastroUsuario.DataCadastro = DateTime.Now;Data atualização
                        this.cadastroUsuario.cadastrar((long)this.cadastroUsuario.Cpf);
                        this.limparCampos();
                    }
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
            FrmCadastroUsuario FrmCadastroUsuario = new FrmCadastroUsuario();
            FrmCadastroUsuario.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmConsultar frmConsultar = new FrmConsultar();
            frmConsultar.ShowDialog();
        }

        private void btnCadUseLimpar_Click(object sender, EventArgs e)
        {
            this.limparCampos();
        }
        private void mkdTxtBxCadUseCPF_TextChanged(object sender, EventArgs e)
        {
            TratarDados tratarDados = new TratarDados();
            if(tratarDados.aceitarNumeros(11, this.mkdTxtBxCadUseCPF.Text))
            {
                MessageBox.Show("XSXCAMPO OBRIGATÓRIO:\n- CPF", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
