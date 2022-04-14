using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeOitoFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {


                double altura;
                double peso;
                char sexo;


                Console.WriteLine("Digite sua altura");
                altura = double.Parse(Console.ReadLine());


                Console.WriteLine("Por favor informe o sexo f= para feminino ou m= para masculino");
                sexo = char.Parse(Console.ReadLine());

                switch (sexo)
                {
                    case 'f':
                        Console.WriteLine("Sexo feminino ");
                        break;

                    case 'm':
                        Console.WriteLine("Sexo masculo");
                        break;

                    default:
                        Console.WriteLine("Repita a operação");
                        break;
                }

                if (sexo == 'f')
                {
                    peso = (altura - 100) * 0.85;
                    Console.WriteLine("Peso ideal " + peso);



                }
                else
                {
                    peso = (altura - 100) * 0.90;
                    Console.WriteLine("Peso ideal " + peso);




                }

                Console.WriteLine("Ao final da execução tecle ENTER");
                Console.ReadLine();


            }
        }

    }
