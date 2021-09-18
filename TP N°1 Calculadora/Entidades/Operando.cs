using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        public Operando()
        {
            this.numero = 0;
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        /// <summary>
        /// Comprobará que el valor recibido sea numérico
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>Retornará el valor numérico, o un 0</returns>
        private static double ValidarOperando(string strNumero)
        {
            double retorno;

            if(!double.TryParse(strNumero, out retorno))
            {
                retorno = 0;
            }

            return retorno;
        }

        /// <summary>
        /// Validará que el valor esté compuesto solamente por 0 o 1
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Retornará true si el valor es binario, o false</returns>
        private bool EsBinario(string binario)
        {
            bool retorno = true;

            foreach (char letra in binario)
            {
                if(letra != '0' && letra != '1')
                {
                    retorno = false;
                    break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Convertirá el valor del sistema binario al decimal
        /// /// </summary>
        /// <param name="binario"></param>
        /// <returns>En caso de éxito retornará el valor decimal, o "Valor inválido"</returns>
        public string BinarioDecimal(string binario)
        {
            string retorno = "Valor inválido";
            int aux = 0;
            int cantidadCaracteres = binario.Length;

            if(this.EsBinario(binario))
            {
                foreach (char caracter in binario)
                {
                    cantidadCaracteres--;
                    if(caracter == '1')
                    {
                        aux += (int)Math.Pow(2, cantidadCaracteres);
                    }
                }
                retorno = aux.ToString();
            }
            
            return retorno;
        }

        /// <summary>
        /// Convertirá el valor del sistema decimal al binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Retornará el valor binario</returns>
        public string DecimalBinario(double numero)
        {
            int resultado = (int)Math.Abs(numero);
            string retorno = string.Empty;
            int resto;

            if(resultado >= 0)
            {
                do
                {
                    resto = resultado % 2;
                    resultado /= 2;
                    retorno = resto.ToString() + retorno;
                } while (resultado > 0);
            }

            return retorno;

        }

        /// <summary>
        /// LLamará a su sobrecarga y convertirá el valor de decimal a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>En caso de éxito retornará el valor binario, o 0</returns>
        public string DecimalBinario(string numero)
        {
            if(numero == "Valor inválido")
            {
                numero = "0";
            }
            
            return this.DecimalBinario(Convert.ToDouble(numero));
        }

        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Operando n1, Operando n2)
        {
            double retorno = n1.numero / n2.numero;
            
            if(n2.numero == 0)
            {
                retorno = double.MinValue;
            }

            return retorno;
        }
    }
}
