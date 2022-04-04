using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            Console.WriteLine("Favor escolher uma das opções : ");
            Console.WriteLine("Opção 1 :");
            Console.WriteLine("Opção 2: ");
            Console.WriteLine("Opção 3: ");
            Console.WriteLine("Opção 4: ");
            Console.WriteLine("Opção 5: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Escriturário");
                    break;

                case 2:
                    Console.WriteLine("Secretária");
                    break;

                case 3:
                    Console.WriteLine("Caixa");
                    break;
                case 4:
                    Console.WriteLine("Gerente");
                    break;
                case 5:
                    Console.WriteLine("Diretor");
                    break;

                    default:

                        Console.WriteLine("Operação invalida!" + "Favor repita a operação");
                    
                    break;


            }
            Console.WriteLine("Após a execução tecle Enter");
            Console.ReadLine();
        }
    }
}
