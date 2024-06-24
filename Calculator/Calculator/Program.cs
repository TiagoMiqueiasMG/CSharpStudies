using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Divisao();
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = valor1 + valor2;

            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.WriteLine("O resultado da Soma é " + resultado);
            Console.WriteLine($"O resultado da soma é {valor1 + valor2}");
            Console.WriteLine("O resuldado da soma é " + (valor1 + valor2));

            // Usamos o ReadKey para não sair da tela
            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor ");
            float valor2 = float.Parse(Console.ReadLine());

            // Para ter um espacinho no terminal
            Console.WriteLine("");

            float resultado = valor1 - valor2;
            Console.WriteLine($"O resultado da subração é: {resultado}");

            // Usamos o ReadKey para não sair da tela
            Console.ReadKey();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 * valor2;
            Console.WriteLine($"O resultado da multiplicação é : {resultado}");

            // Usamos o ReadKey para não sair da tela
            Console.ReadKey();
        }
    
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            
            float resultado = valor1 / valor2;
            Console.WriteLine($"O Resultado da divisão é: {resultado}");

            // Usamos o ReadKey para não sair da tela
            Console.ReadKey();
        }
    }


}