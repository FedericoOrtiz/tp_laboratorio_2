using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Validará el operador recibido por parámetro sea +, -, / ó *
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>Retornará el operador validado, o un +</returns> 
        private static char ValidarOperador(char operador)
        {
            char retorno;

            switch (operador)
            {
                case '+':
                    retorno = operador;
                    break;
                case '-':
                    retorno = operador;
                    break;
                case '*':
                    retorno = operador;
                    break;
                case '/':
                    retorno = operador;
                    break;
                default:
                    retorno = '+';
                    break;
            }

            return retorno;
        }

        /// <summary>
        /// Validará y realizará la operación pedida entre ambos números
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>Retornará el resultado</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;
            operador = ValidarOperador(operador);

            switch(operador)
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
                    resultado = num1 / num2;
                    break;
                default:
                    resultado = num1 + num2;
                    break;
            }

            return resultado;
        }
    }
}
