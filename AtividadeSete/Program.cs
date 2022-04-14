using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeSete
{
    internal class Program
    {
        static void Main(string[] args)
           
        {
            int a;
            int b;
            int c;
            int media;

            Console.WriteLine("Digite um número inteiro positivo");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um outro número inteiro positivo");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um terceiro número inteiro");
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c) 
                {

                    Console.WriteLine("O maior número inteiro é " + a);
                }
            else if (b > c && b > a)
                {

                    Console.WriteLine("O maior número inteiro é " + b);
                }
                else
                {
                    Console.WriteLine(" O maior número inteiro é " + c);
                }
            

            if(a<b && a < c)
            {
                Console.WriteLine("O menor número inteiro é " + a);
            }
            else if(b>c && b < a)
            {
                Console.WriteLine("O menor número inteiro é " + b);
            }
            else
            {
                Console.WriteLine("O menor número inteiro é " + c);
            }
            media = (a + b + c) / 3;
            Console.WriteLine("A media dos 3 número inteiros é " + media);

            Console.WriteLine("No final da execução tecle ENTER");
            Console.ReadLine();
        }
    }
}
