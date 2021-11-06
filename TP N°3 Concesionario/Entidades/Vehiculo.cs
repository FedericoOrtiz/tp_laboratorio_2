using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Auto))]
    [XmlInclude(typeof(Suv))]

    public abstract class Vehiculo
    {
        private int nroChasis;
        private ConsoleColor color;
        private bool esUsado;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Vehiculo()
        {
        }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="nroChasis"></param>
        /// <param name="color"></param>
        /// <param name="esUsado"></param>
        public Vehiculo(int nroChasis, ConsoleColor color, bool esUsado)
        {
            this.nroChasis = nroChasis;
            this.color = color;
            this.esUsado = esUsado;
        }

        /// <summary>
        /// Get y Set del número de chasis
        /// </summary>
        public int NroChasis
        {
            get { return this.nroChasis; }
            set { this.nroChasis = value; }
        }

        /// <summary>
        /// Get y Set del color
        /// </summary>
        public ConsoleColor Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        /// <summary>
        /// Get y Set de usado
        /// </summary>
        public bool EsUsado
        {
            get { return this.esUsado; }
            set { this.esUsado = value; }
        }

        /// <summary>
        /// Firma de la propiedad precio de compra
        /// </summary>
        public abstract float PrecioCompra { get;}

        /// <summary>
        /// Firma de la propiedad precio de venta
        /// </summary>
        public abstract float PrecioVenta { get;}

        /// <summary>
        /// Dos vehículos serán iguales si son del mismo tipo y si comparten el número de chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns> Retornará true si son iguales, false si son distintos
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool iguales = false;

            if(v1 is null && v2 is null)
            {
                iguales = true;
            }
            else if(v1 is not null && v2 is not null)
            {
                iguales = v1.GetType() == v2.GetType() && v1.nroChasis == v2.nroChasis;
            }

            return iguales;
        }

        /// <summary>
        /// Dos vehículos serán distintos si son del mismo tipo y si comparten el número de chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns> Retornará true si son distintos, false si son iguales
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        /// <summary>
        /// Sobreescritura del método ToString()
        /// </summary>
        /// <returns></returns> Retornará los datos campos del Vehiculo
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Número Chasis: {this.nroChasis} - Color: {this.color.ToString()} - ");


            if (this.esUsado)
            {
                sb.Append($"Usado");

            }
            else
            {
                sb.Append($"0KM");

            }

            return sb.ToString();
        }

        /// <summary>
        /// Sobreescritura del método Equals. Invoca a la sobrecarga del operador == entre vehículos
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns> Retornará true si son iguales, false si son distintos
        public override bool Equals(object obj)
        {
            Vehiculo v = obj as Vehiculo;

            return this == v;
        }

        /// <summary>
        /// Ordenará los vehículos por precio en orden ascendente
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns> Retornará 1 si el precio del primero es mayor al segundo, caso contrario -1. 0 si son iguales
        public static int OrdenarPorPrecioMenor(Vehiculo v1, Vehiculo v2)
        {
            int criterio = 0;

            if(v1.PrecioVenta > v2.PrecioVenta)
            {
                criterio = 1;
            }
            else
            {
                criterio = -1;
            }

            return criterio;
        }

        /// <summary>
        /// Ordenará los vehículos por precio en orden descendente. Invoca al método OrdenarPorPrecioMenor y agrega el signo menos
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns> Retornará 1 si el precio del primero es menor al segundo, caso contrario -1. 0 si son iguales
        public static int OrdenarPorPrecioMayor (Vehiculo v1, Vehiculo v2)
        {
            return (-1) * Vehiculo.OrdenarPorPrecioMenor(v1, v2);
        }
    }
}
