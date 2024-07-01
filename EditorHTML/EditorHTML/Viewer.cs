using System;
using System.Text.RegularExpressions;

namespace EditorHTML
{
    public class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo Visualização");
            Console.WriteLine("----------------");
            Replace(text);
            Console.WriteLine("----------------");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            // Regex tem vários caracteres
            // Ele funciona em sua essência como uma string que substitui por outra string 
            // Mas de n formas diferente, cria se uma expressão e essa string converte em uma 
            // determinada string que foi passada
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            words[i].LastIndexOf('<') - 1 - words[i].IndexOf('>')
                        )
                    );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }

        }
    }
}