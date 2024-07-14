using System;

namespace Exceptions
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
                // for (var index = 0; index < 10; index++)
                // {
                //     // Aqui vai dar o erro: System.IndexOutOfRangeException
                //     Console.WriteLine(arr[index]);
                // }

                Cadastrar("");

            }
            // Temos duas tratativas de erro, porque se a trativa der  um IndexOutOfRangeException, 
            // vai passar na primeira tentativa, senão passará na segunda tentativa
            // O IndexOutOfRangeException tem tudo que o exception tem, e mais outras informações

            // Na nossa tratativa de erro, podemos ter vários catch's       
            // Você sempre vai tratar seus erros do mais especifico para o mais genérico

            catch (IndexOutOfRangeException ex)
            {
                // Chame o ex aqui e busque através do método o que deseja no retorno
                // Usamos isso para gerar algum tipo de controle
                // PAra ajudar a visualizar em um arquivo de texto o que aconteceu
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encontrei o índice na lista");
            }
            //Criando um catch para o ArgumentNull Exception  
            catch (ArgumentNullException ex)
            {
                // Chame o ex aqui e busque através do método o que deseja no retorno
                // Usamos isso para gerar algum tipo de controle
                // PAra ajudar a visualizar em um arquivo de texto o que aconteceu
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Falha ao cadastrar texto");
            }

            // Para obter informações do erro, podemos usar o Exception e declarar um nome para ele
            catch (Exception ex)
            {
                // Chame o ex aqui e busque através do método o que deseja no retorno
                // Usamos isso para gerar algum tipo de controle
                // PAra ajudar a visualizar em um arquivo de texto o que aconteceu
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops, algo deu errado");
            } 
           //Criando um catch para o ArgumentNull Exception    
        }
        // Disparando erros

        private static void Cadastrar(string texto)
        {
            // IsNullEmpty = para chegar se o texto é nulo ou vazio
            if (string.IsNullOrEmpty(texto))
            {
                // ArgumentNullException é um argumento para tipo nulos ou vazios
                throw new ArgumentNullException("O texto não pode ser nulo ou vazio");
            }
        }
    }
}