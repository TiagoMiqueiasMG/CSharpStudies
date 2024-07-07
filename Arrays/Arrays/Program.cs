using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // declara como [] e sempre começa pelo 0
            // Sempre que trabalha com listas em C# é preciso usar o new
            // Pois são objetos de referência - diferente dos value types
            var meuArrayEx = new int[5];

            // // Por estar acessando um valueType, aqui sempre vai retornar 0
            // Console.WriteLine(meuArray[0]);
            // Console.WriteLine(meuArray[1]);
            // Console.WriteLine(meuArray[2]);

            // Se tentar acessar o valor 5 vai dar um erro
            // pois já passou do comprimento da lista
            // Console.WriteLine(meuArray[5]);

            // Setando atributos
            // Podemos usar modificações de ações
            // Fazendo uma assimiliação direta
            // Claro, dentro da tipagem
            meuArrayEx[0] = 12;
            Console.WriteLine(meuArrayEx[0]);

            // Iniciando um valor do array
            var meuArray1 = new int[5] {1, 5, 10, 15, 20};
            Console.WriteLine(meuArray1[0]);
            Console.WriteLine(meuArray1[1]);
            Console.WriteLine(meuArray1[2]);
            Console.WriteLine(meuArray1[3]);

            // Outro ponto importante do array é que não estão limitados pelo tipo primitivos
            // Aceita string, boolean, Struct
            // É preciso sempre inicializar 
            // Array de structs Teste
            var arrayStruct = new Teste[2] { new Teste(), new Teste() };

            // Imprime o array como um todo (não é muito útil)
            // Console.WriteLine(arrayStruct);

            // Acessa e imprime o Id de cada elemento do array
            Console.WriteLine(arrayStruct[0].Id);
            Console.WriteLine(arrayStruct[1].Id);


            // Podendo ser especificado dessa forma: 
            // Aqui não precisa especificar a quantidade de itens que serão passados no array
            int[] meuArray2 = new int[] { 1, 2, 3, 4, 5 };             
            Console.WriteLine(meuArray2[0]);

            // --------------------------------------------------
            // --------------------------------------------------
            // Percorrendo um array
            // Se for preciso copiar um array, é preciso clocar e se for preciso copiar os valroes use o 
            // CopyTo
            var meuArray = new int[5] {1, 2, 3, 4, 5};
            
            for(var index = 0; index < meuArray.Length; index++){
                Console.WriteLine(meuArray[index]);
            }


        
        }

        // Definição da struct Teste
        public struct Teste
        {
            public int Id { get; set; }
        }
    }
}