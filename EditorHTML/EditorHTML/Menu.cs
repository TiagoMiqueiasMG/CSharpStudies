using System;

namespace EditorHTML
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
        }

        // função para desenhar a tela
        public static void DrawScreen()
        {
            LineDraw();

            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 50; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }

            LineDraw();
        }
        public static void LineDraw()
        {
            Console.Write("+");
            for (int i = 0; i <= 50; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        public static void WriteOptions()
        {
            // Para escrever algo em um lugar especifico da tela
            // usamos o SetCursorPosition
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("============");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo: ");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo Arquivo ");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("1 - Abrir ");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("1 - Sair ");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");

        }

    }
}