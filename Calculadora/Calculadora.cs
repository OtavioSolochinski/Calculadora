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

                    char[] operadores = { '+', '-', '*', '/' };

                    char operador = entrada.First(c => operadores.Contains(c));
        
                    string[] partes = entrada.Split(operador);

                    decimal numero1 = decimal.Parse(partes[0]);
                    decimal numero2 = decimal.Parse(partes[1]);

                    decimal resultado = 0;

                    switch (operador)
                        {
                         case '+':
                             //Somar(numero1,numero2);
                             break;
                         case '-':
                             Subtrair(numero1, numero2);
                             break;
                         case '*':
                             Console.WriteLine($"O resultado é {Multiplicar(numero1,numero2)}");
                             Thread.Sleep(2000);
                             Console.Clear();
                             break;
                         case '/':
                            Dividir(numero1, numero2);
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