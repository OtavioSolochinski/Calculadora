using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculadora
    {


        public static decimal Divisao(decimal numero1, decimal numero2)
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
    }
}