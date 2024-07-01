using System;
using System.Text;

namespace EditorHTML
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo Editor");
            Console.WriteLine("----------------");
            Start();

        }

        public static void Start()
        {
            var file = new StringBuilder();

            do{
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("----------------");
            Console.WriteLine(" Deseja salvar o arquivo? ");
            Viewer.Show(file.ToString());
            Console.WriteLine("1 - Salvar");
            Console.WriteLine("2 - Descartar");

            short edit = short.Parse(Console.ReadLine());
            switch (edit)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Console.WriteLine("Salvar"); break;
                case 2: Console.WriteLine("Não Salvar"); break;
                default: Menu.Show(); break;
            }

        }
    }
    
}