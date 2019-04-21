using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            int i, j, busca = 0, lin = 0, col = 0;
            Boolean achou = false;

            for(i = 0; i < 3; i++)
                for(j = 0; j < 3; j++)
                {
                    Console.Write("\nEntre com um inteiro na linha {0} e coluna {1}: ", i, j);
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            Console.Write("\nEntre com um valor para busca: ", busca);
            busca = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < 3; i++)
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Elemento {0},{1}={2}\t", i, j, matriz[i, j]);
                    if (busca == matriz[i, j])
                    {
                        achou = true;
                        lin = i;
                        col = j;
                    }
                }

            if (achou == true)
                Console.Write("\nElemento encontrado na posição {0}x{1}", lin, col);
            else
                Console.Write("\nElemento nao encontrado!");

            Console.Write("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
