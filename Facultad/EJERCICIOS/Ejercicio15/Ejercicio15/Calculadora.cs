using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {
        private static bool Validar(int num)
        {
            if (num != 0)
            {
                return true;
            }

            else
            {
                Console.WriteLine("No se puede dividir por cero.");
                return false;
            }
        }

        public static int Calcular(int num1, int num2, char operando)
        {
            int resultado = 0;
            switch (operando)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    if (Validar(num2))
                    {
                        resultado = num1 / num2;
                    }
                    break;
            }
            return resultado;
        }
    }
}
