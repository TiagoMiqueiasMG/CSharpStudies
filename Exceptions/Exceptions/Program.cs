using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // Erros são tratados como Exception

            // Exemplo            
            var arr = new int[3];

            // Try e Catch é a base do tratamento de erros
            // use os em blocos
            
            try
            {
                for (var index = 0; index < 10; index++)
                {
                    // Aqui vai dar o erro: System.IndexOutOfRangeException
                    Console.WriteLine(arr[index]);
                }

            }
            // Para obter informações do erro, podemos usar o Exception e declarar um nome para ele
            catch(Exception ex)
            {
                // Chame o ex aqui e busque através do método o que deseja no retorno
                // Usamos isso para gerar algum tipo de controle
                // PAra ajudar a visualizar em um arquivo de texto o que aconteceu
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops, algo deu errado");
            }





        }
    }
}