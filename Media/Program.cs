using System;

namespace media
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo!");
            float somaMedia = 0; // Definindo a variável somaMedia como float
            int cont = 0; // Definindo a variável cont como int
            
            while(true)
            {
                Console.WriteLine($"Digite a nota {cont + 1}: ");
                float n = float.Parse(Console.ReadLine()); // Pegando o valor da nota na variável n e depois acumulando ela em somaMedia
                somaMedia += n; //somaMedia = somaMedia + n;
                cont++; // cont = cont + 1;

                string sair = " ";

                while (sair != "S" || sair != "N")
                {
                    Console.WriteLine("Você quer sair do programa? [S/N]");
                    sair = Console.ReadLine().ToUpper();
                    if (sair == "S")
                    {
                        break; // Quebrando o laço de repetição while (sair == "S" || sair == "N")
                    }
                    else if (sair == "N")
                    {
                        break; // Quebrando o laço de repetição while (sair == "S" || sair == "N")
                    }
                    else
                    {
                        Console.WriteLine("Digite uma opção válida!");
                    }
                }
                if (sair == "S")
                {
                    break; // Quebrando o laço de repetição while(true)
                }   
            }
                float r = somaMedia/cont;
                if(somaMedia > 7)
                {
                    Console.WriteLine($"Aprovado, com média igual à {r}");
                }
                else
                {
                    Console.WriteLine($"Reprovado, com média igual à {r}");
                }
            
        }
    }

}
