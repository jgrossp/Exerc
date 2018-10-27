using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2)	Faça um programa em C# que calcule a tabuada de multiplicação de um número fornecido pelo usuário.*/

            int tab, num1, num2 = 0;

            Console.WriteLine("Digite um número para realizarmos a tabuada de multiplicação: ");
            num1 = int.Parse(Console.ReadLine());
            
            while (num2<=10)
            {
                tab = num1 * num2;
                Console.WriteLine("A tabuada {0}",num1+"x"+ num2+"=" +tab);
                num2++;
            }
            Console.ReadKey();
        }
    }
}
