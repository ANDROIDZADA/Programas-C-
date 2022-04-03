using System;

namespace Teste
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bem-Vindo!");
            float somaMedia = 0;
            int cont = 1;
            while (true) 
            {  
                Console.WriteLine($"Digite a nota {cont}: ");
                float n = float.Parse(Console.ReadLine());
                somaMedia += n;
                float r = somaMedia/cont;
                cont++;

                string sair = " ";
            
                while (sair != "S" || sair != "N")
                {
                    Console.WriteLine("Você quer sair do programa [S/N]");
                    sair = Console.ReadLine().ToUpper();
                    if (sair == "S")
                    {
                        break;
                    } 
                    else if (sair == "N")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Digite uma opção válida!");
                    }
                }
                if (sair == "S")
                {
                    break;
                }
            }
            if(somaMedia < 7)
            {
                Console.WriteLine($"Aprovado a média é {r}");
            }
            else 
            {
                Console.WriteLine($"Reprovado!");
            }
            Console.WriteLine("Você saiu do programa!");
        }
    }
}