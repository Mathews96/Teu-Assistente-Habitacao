using System;

namespace Teu_Assistente_HABITACAO
{
    internal class CadastroHabitaciona
    {
        new BDCadastro cadastro = new BDCadastro();
        public void cadastrar(int cpf)
        {
            cadastro.NomeCompleto = "";
            cadastro.Cpf = int.Parse("");
            cadastro.Nis = int.Parse("");
            cadastro.DataDeNascimento = DateTime.Parse("");
            cadastro.Email = "";
            cadastro.Telefone = int.Parse("");
            cadastro.WhatsApp = int.Parse("");
            cadastro.NomeDaMae = "";
            cadastro.DataCadastro = DateTime.Parse("");
            cadastro.inserirCadastro(cpf);

            Deficiente comprovanteDeficiencia = new Deficiente();
            comprovanteDeficiencia.anexarComprovanteDeficiencia(cpf, "");


        }
        public void editar(int cpf)
        {
            cadastro.NomeCompleto = "";
            cadastro.Cpf = int.Parse("");
            cadastro.Nis = int.Parse("");
            cadastro.DataDeNascimento = DateTime.Parse("");
            cadastro.Email = "";
            cadastro.Telefone = int.Parse("");
            cadastro.WhatsApp = int.Parse("");
            cadastro.NomeDaMae = "";
            cadastro.DataCadastro = DateTime.Parse("");
            cadastro.setCadastro(cpf);
        }
        public void excluir(int cpf)
        {
            cadastro.deletarCadastro(cpf);
        }
        public void consultar(int cpf)
        {
            cadastro.getCadastro(cpf);
        }
        public void download(int cpf)
        {

        }
    }
}
