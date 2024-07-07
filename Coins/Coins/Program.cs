using System;
using System.Globalization;

namespace Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // Qual é o melhor tipo para trabalhar com valor?
            // A maioria das vezes usamos o decimal 
            // Por causa da precisão
            // Mas ele é maior que o float e double
            // Mas é preciso avaliar a performance, mas isso em caso de muitas requisições
            decimal valor = 10.25m;
            // Console.WriteLine(valor);

            // formatando o valor para uma cultura específica
            // Usando o CultureInfo
            Console.WriteLine(valor.ToString(
                CultureInfo.CreateSpecificCulture("en-US")));

            // Usando formatadores ( Alguns exemplos)
            // Usando o C usa a forma que a moeda é chamada
            // Exemplo R$ ou €
            Console.WriteLine(valor.ToString(
                "C",
                CultureInfo.CreateSpecificCulture("pt-BR")));

            //A expressão "E04" dentro do método ToString() de um valor decimal serve para 
            // formatar esse valor usando a notação científica com quatro casas decimais.
            Console.WriteLine(valor.ToString(
                "E04",
                CultureInfo.CreateSpecificCulture("pt")));

            // Formata só o número
            Console.WriteLine(valor.ToString(
                "N",
                CultureInfo.CreateSpecificCulture("pt")));

            // Exibe a porcentagem
            Console.WriteLine(valor.ToString(
                "P",
                CultureInfo.CreateSpecificCulture("pt")));

            // 3 tipos de conversão de moedas mais usados
            // Para arrendodar na média
            decimal formatvalue = 1546.10m;
            Console.WriteLine(
                Math.Round(formatvalue)
            );

            // Ceiling(telhado) - arrendonda para cima 
            Console.WriteLine(
                Math.Ceiling(formatvalue)
            );

            // Floor - arrendonda para baixo 
            Console.WriteLine(
                Math.Floor(formatvalue)
            );

        }
    }
}