using System;
using System.Globalization;

namespace Teu_Assistente_HABITACAO
{
    internal class varGlobaisFrmCadastroUsuario
    {
        public static string dadosCadUsuNomeCompleto = "";
        public static long? dadosCadUsuCpf = null;
        public static long? dadosCadUsuMatricula = null;
        public static DateTime dadosCadUsuDataDeNascimento = DateTime.ParseExact("01012023", "ddMMyyyy", CultureInfo.InvariantCulture);
        public static long? dadosCadUsuTelefone = null;
        public static long? dadosCadUsuWhatsapp = null;
        public static string dadosCadUsuEmail = "";
        public static string dadosCadUsuEntidade = "";
        public static string dadosCadUsuSetor = "";
        public static string dadosCadUsuCargo = "";
        public static string dadosCadUsuSenha = "";
        public static int? dadosCadUsuNivel = 1;
    }
}
