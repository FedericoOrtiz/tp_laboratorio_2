using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class VehiculoExtension
    {
        /// <summary>
        /// Método de extensión que devuelve la motorización de acuerdo al modelo de vehículo
        /// </summary>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static string Motorizacion(this Vehiculo vehiculo)
        {
            string datos = string.Empty;

            if(vehiculo is Auto)
            {
                Auto a = vehiculo as Auto;
                switch (a.Modelo.ToString())
                {
                    case "Ka":
                        datos = "Motorización disponible: 1.5 105 CV 4Cil";
                        break;
                    case "Fiesta":
                        datos = "Motorización disponible: 1.6 120 CV 4Cil";
                        break;
                    case "Focus":
                        datos = "Motorización disponible: 2.0 170 CV 4Cil";
                        break;
                }
            }
            else
            {
                Suv s = vehiculo as Suv;
                switch (s.Modelo.ToString())
                {
                    case "Ecosport":
                        datos = "Motorización disponible: 1.5 123 CV 3Cil";
                        break;
                    case "Territory":
                        datos = "Motorización disponible: 2.0 143 CV 4Cil"; 
                        break;
                    case "Kuga":
                        datos = "Motorización disponible: 2.0T 240 CV 4Cil"; 
                        break;
                    case "BroncoSport":
                        datos = "Motorización disponible: 1.5 175 CV 4Cil"; 
                        break;
                }
            }

            return datos;
        }
    }
}
