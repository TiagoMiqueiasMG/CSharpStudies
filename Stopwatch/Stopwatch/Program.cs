using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Start(6);
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

        }

    }


}