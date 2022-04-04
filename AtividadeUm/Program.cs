using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota1;
            int nota2;
            Console.WriteLine("Digite a primeira nota  :");
            nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota :");
            nota2 = int.Parse(Console.ReadLine());

            int notaFinal = (nota1 +( nota2*2))/ 3;

            Console.WriteLine("Média final: " + notaFinal);
            Console.WriteLine("");


            Console.WriteLine("No final da execução tecle ENTER");
            Console.Read();
        }
    }
}
