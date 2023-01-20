using System;
using System.Globalization;

namespace Teu_Assistente_HABITACAO
{
    internal class VarGlobaisFrmCadastro
    {      
        public static string dadosCadPag1NomeCompleto = "";
        public static long? dadosCadPag1Cpf = null;
        public static long? dadosCadPag1Nis = null;
        public static DateTime dadosCadPag1Nascimento = DateTime.ParseExact("01012023", "ddMMyyyy", CultureInfo.InvariantCulture);
        public static string dadosCadPag1Email = "";
        public static long? dadosCadPag1Telefone = null;
        public static long? dadosCadPag1Whatsapp = null;
        public static string dadosCadPag1NomeDaMae = "";

        public static string dadosCadPag2Endereco = "";
        public static string dadosCadPag2Complemento = "";
        public static int? dadosCadPag2Numero = null;
        public static string dadosCadPag2Bairro = "ANTARES";
        public static string dadosCadPag2Cidade = "MACEIÓ";
        public static string dadosCadPag2Uf = "AL";
        public static int? dadosCadPag2Cep = null;

        public static string dadosCadPag3EstadoCivil = "SOLTEIRO(A)";
        public static string dadosCadPag3NomeCompleto = "";
        public static long? dadosCadPag3Cpf = null;
        public static long? dadosCadPag3Nis = null;
        public static string dadosCadPag3Email = "";
        public static long? dadosCadPag3Telefone = null;
        public static long? dadosCadPag3Whatsapp = null;
    }
}
