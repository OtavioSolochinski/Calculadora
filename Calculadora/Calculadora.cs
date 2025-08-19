using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculadora
    {
        public static void Iniciar()
        {
            Console.WriteLine("Seja bem vindo a calculadora!");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Utilize:\n+ para somar\n- para subtrair\n* para multiplicar\n/ para dividir");
            Console.WriteLine("Digite SAIR para encerrar o programa!");
            bool continuar = false;
            do
            {
                Console.WriteLine("\nDigite a operação:");
                string entrada = Console.ReadLine();

                if (entrada.ToLower() == "sair")
                {
                    continuar = false;
                }
                else
                {

                    char[] operadores = { '+', '-', '*', '/'};

                    char operador = entrada.First(c => operadores.Contains(c));
        
                    string[] partes = entrada.Split(operador);

                    decimal numero1 = decimal.Parse(partes[0]);
                    decimal numero2 = decimal.Parse(partes[1]);

                    decimal resultado = 0;

                    switch (operador)
                        {
                         case '+':
                            Console.WriteLine($"O resultado é {Somar(numero1, numero2)}");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                         case '-':
                            Console.WriteLine($"O resultado é {Subtrair(numero1, numero2)}");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                         case '*':
                             Console.WriteLine($"O resultado é {Multiplicar(numero1,numero2)}");
                             Thread.Sleep(2000);
                             Console.Clear();
                             break;
                         case '/':
                            Console.WriteLine($"O resultado é {Dividir(numero1, numero2)}");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;

                        }
                    continuar = true;
                }





            } while (continuar);
        }

        public static decimal Multiplicar(decimal numero1, decimal numero2)
        {
            return numero1 * numero2;
        }

        public static decimal Somar(decimal numero1, decimal numero2)
        {
            return numero1 + numero2;
        }


        public static decimal Dividir(decimal numero1, decimal numero2)
        {
            if (numero1 == 0 || numero2 ==0)
            {
                throw new DivideByZeroException("Impossível dividir por zero.");
            }
            else
            {
                return numero1 / numero2;
            }


        }
        public static decimal Subtrair(decimal numero1, decimal numero2)
        {
            return numero1 - numero2;
        }


    }
}