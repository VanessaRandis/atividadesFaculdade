using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeSeis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p=0;
            double e = 50;
            double m = 0;


            Console.WriteLine("Insira o peso do peixe para que efetuar o calculo");
            p = double.Parse(Console.ReadLine());


            if (p >= 50)

            {
                e=(p-e);
                m = e * 4.00;
                Console.WriteLine("Será cobrada uma multada no valor de R$ " + m +" " +
                    " referente a  "+e+"  kg de excesso" );


            }else
            {

                Console.WriteLine("O peso foi inferior a 50 kg não será cobrado multa");
            }

            Console.WriteLine("No final da execução tecle ENTER");
            Console.ReadLine();
        }
    }
}
