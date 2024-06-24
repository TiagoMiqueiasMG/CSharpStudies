using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            int time = 10;
            int currentTime = 0;

            while (currentTime != time)
            {
                // Vamos usar o console.clear para limpar a tela e mostrar
                // só o valor atual
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
            }

        }
    }
}