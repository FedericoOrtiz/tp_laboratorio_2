using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Auto : Vehiculo
    {
        public enum EAutos
        {
            Ka, Fiesta, Focus,
        }

        private EAutos modelo;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Auto()
        {
        }

        /// <summary>
        /// Constructor con parámetros que invoca a la clase base Vehiculo
        /// </summary>
        /// <param name="nroChasis"></param>
        /// <param name="color"></param>
        /// <param name="esUsado"></param>
        /// <param name="modelo"></param>
        public Auto(int nroChasis, ConsoleColor color, bool esUsado, EAutos modelo)
            : base(nroChasis, color, esUsado)
        {
            this.modelo = modelo;
        }

        /// <summary>
        /// Get y Set del modelo
        /// </summary>
        public EAutos Modelo
        {
            get { return this.modelo; }
            set { this.modelo = value; }
        }

        /// <summary>
        /// Get del precio de compra
        /// </summary>
        public override float PrecioCompra
        {
            get
            {
                float precio = 0;
                
                switch (this.modelo)
                {
                    case EAutos.Ka:
                        precio = 1500000f;
                        break;
                    case EAutos.Fiesta:
                        precio = 2000000f;
                        break;
                    case EAutos.Focus:
                        precio = 2500000f;
                        break;
                }

                if(this.EsUsado)
                {
                    precio = precio * 0.8f;
                }

                return precio;
            }
        }

        /// <summary>
        /// Get del precio de venta
        /// </summary>
        public override float PrecioVenta
        {
            get { return this.PrecioCompra * 1.5f; }
        }



        /// <summary>
        /// Sobreescritura del método ToString
        /// </summary>
        /// <returns></returns>Retornará los campos del Auto
        public override string ToString()
        {
            return $"{base.ToString()} - Modelo: {this.modelo} - Precio: {this.PrecioVenta}\n";
        }
    }
}
