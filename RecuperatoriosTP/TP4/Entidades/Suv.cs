using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Suv : Vehiculo
    {
        public enum ESuv
        {
            Ecosport, Territory, Kuga, BroncoSport
        }

        private ESuv modelo;
        private string origen;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Suv()
        {
        }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="nroChasis"></param>
        /// <param name="color"></param>
        /// <param name="esUsado"></param>
        /// <param name="modelo"></param>
        public Suv(int nroChasis, ConsoleColor color, bool esUsado, ESuv modelo)
            : base(nroChasis, color, esUsado)
        {
            this.modelo = modelo;
            this.origen = this.Origen;
        }

        /// <summary>
        /// Get y Set del modelo
        /// </summary>
        public ESuv Modelo
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
                    case ESuv.Ecosport:
                        precio = 3000000f;
                        break;
                    case ESuv.Territory:
                        precio = 5000000f;
                        break;
                    case ESuv.Kuga:
                        precio = 6000000f;
                        break;
                    case ESuv.BroncoSport:
                        precio = 7000000f;
                        break;
                }

                if (this.EsUsado)
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
        /// Get y set del origen
        /// </summary>
        public string Origen
        {
            get
            {
                string pais = string.Empty;
                
                switch (this.modelo)
                {
                    case ESuv.Ecosport:
                        pais = "India";
                        break;
                    case ESuv.Territory:
                        pais = "China";
                        break;
                    case ESuv.Kuga:
                        pais = "EE.UU";
                        break;
                    case ESuv.BroncoSport:
                        pais = "México";
                        break;
                }

                return pais;
            }
            set { this.origen = value; }
        }

        /// <summary>
        /// Sobreescritura del método ToString
        /// </summary>
        /// <returns></returns> Retornará los datos del Suv
        public override string ToString()
        {
            return $"{base.ToString()} - Modelo: {this.modelo} - Origen: {this.origen} - Precio: {this.PrecioVenta}\n";
        }
    }
}
