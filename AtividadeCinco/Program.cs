using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeCinco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opcao;
            double res=0;
            int diarias;
            double valor;
            double totalEstadia=0;
            bool ConsumoInterno;
            double gastosVariados=0;

           
            double taxaServico=10;
            

            
                Console.WriteLine("Selecione um dos apartamentos no qual a tarifa deve ser " +
                    "calculada : a, b ,c ou d");
                opcao=char.Parse(Console.ReadLine());

            switch (opcao)
            {

                case 'a':
                    res= 150.00;
                    Console.WriteLine(res);
                    break;

                case 'b':
                    res =100.00;
                    Console.WriteLine(res);
                    break;

                case 'c':
                    res=75.00;
                    Console.WriteLine(res);
                    break;

                case 'd':
                    res=50.00;
                    Console.WriteLine(res);
                    break;

            }
            
            Console.WriteLine("Informe a quantidade de diárias : ");
            diarias = int.Parse(Console.ReadLine());



            Console.WriteLine("Houve despesas de Consumo Interno true/false");
            ConsumoInterno = bool.Parse(Console.ReadLine());
            if (ConsumoInterno != true)
            {
                valor= ((diarias * res)/100)*taxaServico;
                totalEstadia = valor+(diarias*res);
                Console.WriteLine("Valor total R$ " + totalEstadia);
            }
            else 
            {
                Console.WriteLine("Informe o valor do consumo interno");
                gastosVariados = double.Parse(Console.ReadLine());
                valor = ((diarias * res) / 100)*taxaServico;
                totalEstadia = (diarias*res)+valor + gastosVariados;

                Console.WriteLine("Valor total R$ " + totalEstadia );

            }

            Console.WriteLine("Após a execução tecle ENTER ");

            Console.ReadLine();


            }
        }
    }


