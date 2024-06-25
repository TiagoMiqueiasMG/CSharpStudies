using System;
using System.Threading;

namespace Stopwatch
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
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Munuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?: ");

            // ToLower para converter os inputs em minúsculas
            string data = Console.ReadLine().ToLower();
            // Para pegar o último caracter 
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            // Para pegar todos os caracteres menos 1(final)
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
            {
                multiplier = 60;
            }
            if (time == 0)
            {
                // para sair da aplicação
                System.Environment.Exit(0);
            }
            PreStart(time * multiplier);

        }

        // criando uma animação antes de começar o cronomêtro
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                // Vamos usar o console.clear para limpar a tela e mostrar
                // só o valor atual
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                // para pedir a aplicação para esperar um 
                // segundo antes de ir para o próximo valor
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finished");
            Thread.Sleep(1500);
            Menu();
        }
    }
}