using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CamposVaciosException : Exception
    {
        /// <summary>
        /// Constructor por defecto que invoca al que recibe parámetros. Tendrá hardcodeado un mensaje
        /// </summary>
        public CamposVaciosException() : this("Por favor, complete todos los campos")
        {
        }

        /// <summary>
        /// Constructor con parámetros que recibe un mensaje
        /// </summary>
        /// <param name="mensaje"></param>
        public CamposVaciosException(string mensaje) : base(mensaje)
        {
        }
    }
}
