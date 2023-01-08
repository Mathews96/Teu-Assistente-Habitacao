using System;
using System.Globalization;

namespace Teu_Assistente_HABITACAO
{
    internal class VarGlobaisFrmCadastro
    {      
        public static string dadosCadPag1NomeCompleto;
        public static long dadosCadPag1Cpf = 00000000000;
        public static long dadosCadPag1Nis = 00000000000;
        public static DateTime dadosCadPag1Nascimento = DateTime.ParseExact("01012023", "ddMMyyyy", CultureInfo.InvariantCulture);
        public static string dadosCadPag1Email = "S/N";
        public static long dadosCadPag1Telefone = 00000000;
        public static long dadosCadPag1Whatsapp = 00000000;
        public static string dadosCadPag1NomeDaMae = "S/N";

        public static string dadosCadPag2Endereco = "S/N";
        public static string dadosCadPag2Complemento = "S/N";
        public static int dadosCadPag2Numero = 00;
        public static string dadosCadPag2Bairro = "S/N";
        public static string dadosCadPag2Cidade = "S/N";
        public static string dadosCadPag2Uf = "S/N";
        public static int dadosCadPag2Cep = 00;

        public static string dadosCadPag3EstadoCivil = "Solteiro";
        public static string dadosCadPag3NomeCompleto = "S/N";
        public static long dadosCadPag3Cpf = 00000000000;
        public static long dadosCadPag3Nis = 00000000000;
        public static string dadosCadPag3Email = "S/N";
        public static long dadosCadPag3Telefone = 00000000;
        public static long dadosCadPag3Whatsapp = 00000000;
    }
}
