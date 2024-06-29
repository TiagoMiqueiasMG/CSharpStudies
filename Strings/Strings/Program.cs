﻿using System;

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
            // // Ele também é case sensitive
            Console.WriteLine(texto.Contains("Teste"));
            // // Para ignorar o case sensitive use: StringComparison.OrdinalIgnoreCase
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));
            // // Comparando com objto inválido
            // Console.WriteLine(texto.Contains(null));

            // // SartsWith/EndsWith
            // // Retorna um booleano
            Console.WriteLine(texto.StartsWith("este"));
            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("texto"));

            Console.WriteLine(texto.EndsWith("Texto"));
            Console.WriteLine(texto.EndsWith("testo"));
            Console.WriteLine(texto.EndsWith("xpro"));

            // Equals - ele existe em vários outros objetos do .Net
            // Esse Equals estende para outros objetos sempre para comparar o tipo de objeto com ele mesmo do mesmo tipo

            // Ele compara aqui se o texto é igual ( no sentido exato)
            Console.WriteLine(texto.Equals("Este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));


            // Index ( Posição deste item no array)
            // Em C# vai começar do 0
            // Nosso String é um array de caracteres
            var textoExemplo = "Este é o texto de exemplo";


            // IndexOf = Ele sempre vai pedir um objeto do mesmo tipo
            // Se for uma string, tem que passar uma string
            // Se for um inteiro, você precisa passar um inteiro
            Console.WriteLine(textoExemplo.IndexOf("é"));
            Console.WriteLine(textoExemplo.IndexOf("texto"));
            // LastIndexOf
            // último indice que ele encotrar de letra ou palavra
            Console.WriteLine(textoExemplo.IndexOf("l"));

            // ToUpper ou ToLower
            // Converter para maiúsculo ou minúsculo
            Console.WriteLine(textoExemplo.ToLower());
            Console.WriteLine(textoExemplo.ToUpper());

            // Inserir um caracter usando o Insert
            Console.WriteLine(textoExemplo.Insert(5, "Aqui "));

            // Remove para remover, é preciso passar o inicio e fim que deseja renover
            Console.WriteLine(textoExemplo.Remove(7, 11));

            // Length
            // Trás a quantidade de caracteres que uma string tem
            Console.WriteLine(textoExemplo.Length);

            var textoExemplo2 = "Este é o texto de exemplo";
            // Replace
            // Ele pede um carcter um antigo e um novo para substituição
            // É case sensitive
            Console.WriteLine(textoExemplo2.Replace("Este", "Isto"));
            Console.WriteLine(textoExemplo2.Replace("e", "X"));

            

        }
    }
}