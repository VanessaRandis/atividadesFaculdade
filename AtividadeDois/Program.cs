using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade <= 15) 
            {
                Console.WriteLine("Infelizmente você não poderá votar");
            }
            else if (idade >= 16 && idade < 18)
            {
                Console.WriteLine("O voto é facultativo");
            }
            else if (idade >= 18)
            {

                Console.WriteLine("O voto é obrigatório");

            }

            Console.WriteLine("");
            Console.WriteLine("No final da execução tecle ENTER");
            Console.ReadLine();
        }
    }
}
