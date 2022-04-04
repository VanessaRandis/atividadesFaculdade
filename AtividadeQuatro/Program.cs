using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeQuatro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double res;
            int opcao;

            Console.WriteLine("Informe um número :");
            double num_1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número :");
            double num_2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escola uma opção:");

            Console.WriteLine("Opção 1 para somar");

            Console.WriteLine("Opção 2 para multiplicar");

            Console.WriteLine("Opção 3 para subtrair");

            Console.WriteLine("Opção 4 para dividir");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao) {
                case 1:
                    res = num_1 + num_2;
                    Console.WriteLine("Resultado : "+res);
                    break;

                case 2:
                    res = num_1 * num_2;
                    Console.WriteLine("Resultado : "+res);
                    break;
                case 3:
                    res = num_1 - num_2;
                    Console.WriteLine("Resultado : "+res);
                    break;

                case 4:
                    res = num_1 / num_2;
                    Console.WriteLine("Resultado :" + res);
                    break;

     
            }
           
            Console.WriteLine("Após a execução tecle ENTER");
            Console.ReadLine();



        } 
        }
    }

