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

            // SartsWith/EndsWith
            // Retorna um booleano
            Console.WriteLine(texto.StartsWith("este"));
            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("texto"));

            Console.WriteLine(texto.EndsWith("Texto"));
            Console.WriteLine(texto.EndsWith("testo"));
            Console.WriteLine(texto.EndsWith("xpro"));

            


        }
    }
}