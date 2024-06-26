using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Comparação de textos
            var texto = "Este texto é um teste";
            // Contains vai verificar se a string contem um pedaço de texto
            Console.WriteLine(texto.Contains("teste"));
            // Ele também é case sensitive
            Console.WriteLine(texto.Contains("Teste"));
            // Para ignorar o case sensitive use: StringComparison.OrdinalIgnoreCase
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));
            // Comparando com objto inválido
            Console.WriteLine(texto.Contains(null));

        }
    }
}