using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja Calcular? :  ");

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-----------");
            Console.WriteLine("Selecione uma opção: ");

            // Neste caso como o resultado é basico
            // Iremos usar o short, o menor tipo numérico
            // Que podemos ter

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                // E uma função default, neste caso 
                // usaremos o menu para voltar para o Menu
                // Caso o usuário digite uma função inválida
                default: Menu(); break;
            }

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
            // Console.WriteLine("O resultado da Soma é " + resultado);
            // Console.WriteLine($"O resultado da soma é {valor1 + valor2}");
            // Console.WriteLine("O resuldado da soma é " + (valor1 + valor2));

            // Usamos o ReadKey para não sair da tela
            Console.ReadKey();
            Menu();
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
            Menu();
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
            Menu();
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
            Menu();
        }
    
    }

}