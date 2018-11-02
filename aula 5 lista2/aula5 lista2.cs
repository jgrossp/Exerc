using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_5_lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            int  X = 0, NumNega = 0, NumPosi = 0, NumNeu = 0;
            while (X <= 10)
            {
                X = int.Parse(Console.ReadLine());
                Console.WriteLine("O valor é: {0} ", X );
                X += 1;
                
                if (X %2 == 1) NumNega++;
                else if (X %2 == 0) NumPosi++;
                
                X++;
            }
            Console.WriteLine("Quantidade de numeros Negativos: " + NumNega + "\n") ;
            Console.WriteLine("Quantidade de numeros Positivos: " + NumPosi + "\n");
            
            Console.ReadKey();
        }
    }
}
