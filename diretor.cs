using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1)	Em uma eleição para diretor de uma escola, existem dois candidatos. 
             * Sabe-se que o número de votantes é 300, mas nem todos votaram. 
             * Os votos são informados pelo código conforme a tabela:
                Código	Voto para
                                    1	João
                                    2	Maria
                                    3	Branco
                                    4 	Nulo
                                Elabore um programa em C# que calcule e escreva:
                                -	Total e percentual de votos para cada candidato; 
                                -	Total e percentual de votos brancos;
                                -	Total e percentual de votos nulos;
                                -	Total e percentual de votos lidos;
                                -	Mostre o candidato vencedor.                */

            int joão = 0, maria = 0, branco = 0, nulo = 0, escolha;
            //no momento faremos a escolha do eleitor fazendo Do

            do
            {
                Console.WriteLine("Eleição para o diretor da escola para dois candidatos, faça a sua escolha: ");
                Console.WriteLine("\t \t 1 - João  \n");
                Console.WriteLine("\t \t 2 - Maria  \n");
                Console.WriteLine("\t \t 3 - Branco \n");
                Console.WriteLine("\t \t 4 - Nulo \n");
                Console.WriteLine("\t \t 5 - Sair da eleição \n");
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 1)
                {
                    joão++;
                }
                else if (escolha == 2)
                {
                    maria++;
                }
                else if (escolha == 3)
                {
                    branco++;
                }
                else if (escolha == 4)
                {
                    nulo++;
                }
                else if (escolha == 5)
                {
                    Console.Write("A opçõe foi sair da eleição!!! \a\a\a");
                }
                else
                {
                    Console.Write("Nenhuma das opções");
                    Console.ReadKey();
                }
                //agora vamos colocar até 300 pessoas, mas muitos não irão votar
                //como consta no inuciado
            } while (escolha != 5);
            Console.WriteLine("Total de votos Geral é: " + (joão + maria + branco + nulo));
            Console.WriteLine("Total de votos do  João: " + joão);
            Console.WriteLine("Total de votos do  Maria: " + maria);
            Console.WriteLine("Percentual do João: " + (joão * 100 / (joão + maria)));
            Console.WriteLine("Percentual do Maria: " + (maria * 100 / (joão + maria)));

            if (joão > maria)
            {
                Console.WriteLine("Parabéns ao novo diretor João");
            }
            else if (joão < maria)
            {
                Console.WriteLine("Parabéns ao novo presidente Maria");
            }
            else
            {
                Console.WriteLine("Empatados, vamos para um segundo turno, preparados?");
            }
                Console.ReadKey();
        }
    }
}
