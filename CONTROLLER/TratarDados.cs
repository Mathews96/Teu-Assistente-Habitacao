
namespace Teu_Assistente_HABITACAO
{
    internal class TratarDados
    {
        public bool naoAceitaNuloOuVazio(string texto)
        {
            bool resultadoTexto = false;
            resultadoTexto = string.IsNullOrEmpty(texto) ? true : false;
            return resultadoTexto;
        }
        public bool naoAceitaNumero(string texto)
        {
            bool resultadoTexto = false;
            for(int passarCaracter = 0; passarCaracter < texto.Length; passarCaracter++)
            {
                if(char.IsNumber(texto, passarCaracter))
                {
                    resultadoTexto = true;
                }
                texto = texto.Remove(passarCaracter, 1);
                passarCaracter--;                
            }                     
            return resultadoTexto;
        }
        public bool naoAceitaLetras(string texto)
        {
            bool resultadoTexto = false;
            for (int passarCaracter = 0; passarCaracter < texto.Length; passarCaracter++)
            {
                if (!char.IsNumber(texto, passarCaracter))
                {
                    resultadoTexto = true;
                }
                texto = texto.Remove(passarCaracter, 1);
                passarCaracter--;
            }
            return resultadoTexto;
        }
        public string retirarLetrasECaracteres(string texto)
        {//Aceitar somente números
            for (int passarCaracter = 0; passarCaracter < texto.Length; passarCaracter++)
            {
                if (!char.IsNumber(texto, passarCaracter))
                {
                    texto = texto.Remove(passarCaracter, 1);
                    passarCaracter--;
                }
            }
            return texto;
        }
        public bool aceitarQntNumeros(int quantidade, string numero)
        {
            bool resultado = false;
            return numero.Length != quantidade ? true : false;
        }
    }
}
