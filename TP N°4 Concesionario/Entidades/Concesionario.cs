using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Concesionario<T>
        where T : Vehiculo
    {
        private List<T> vehiculos;
        private int capacidad;

        public enum ETipoVehiculo
        {
            Auto, Suv
        }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Concesionario()
        {
        }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="capacidad"></param>
        public Concesionario(int capacidad)
        {
            this.vehiculos = new List<T>();
            this.capacidad = capacidad;
        }

        /// <summary>
        /// Get y Set de la lista de vehículos
        /// </summary>
        public List<T> Vehiculos
        {
            get { return this.vehiculos; }
            set { this.vehiculos = value; }
        }

        /// <summary>
        /// Get y Set de capacidad
        /// </summary>
        public int Capacidad
        {
            get { return this.capacidad; }
            set { this.capacidad = value; }
        }

        /// <summary>
        /// Un concesionario será igual a un vehículo si este se encuentra en la misma
        /// </summary>
        /// <param name="concesionario"></param>
        /// <param name="v"></param>
        /// <returns></returns> Retornará true si son iguales, false si son distintos
        public static bool operator ==(Concesionario<T> concesionario, T v)
        {
            bool esta = false;

            if(concesionario.vehiculos is not null && v is not null)
            {
                foreach (T vehiculo in concesionario.vehiculos)
                {
                    if(vehiculo.Equals(v))
                    {
                        esta = true;
                        break;
                    }
                }
            }
            
            return esta;
        }

        /// <summary>
        /// Un concesionario será distinto a un vehículo si este NO se encuentra en la misma
        /// </summary>
        /// <param name="concesionario"></param>
        /// <param name="v"></param>
        /// <returns></returns> Retornará true si son distintos, false si son iguales
        public static bool operator !=(Concesionario<T> concesionario, T v)
        {
            return !(concesionario == v);
        }

       /// <summary>
       /// Intentará agregar un vehículo siempre y cuando haya lugar o no se encuentre en el concesionario
       /// </summary>
       /// <param name="concesionario"></param>
       /// <param name="v"></param>
       /// <returns></returns> Retornará true si pudo agregar, false si NO pudo 
        public static bool operator +(Concesionario<T> concesionario, T v)
        {
            bool pudoAgregar = false;
            
            if(concesionario.vehiculos.Count < concesionario.capacidad && concesionario != v)
            {
                concesionario.vehiculos.Add(v);
                pudoAgregar = true;
            }

            return pudoAgregar;
        }

        /// <summary>
        /// Intentará remover un vehículo siempre y cuando este se encuentre en el concesionario
        /// </summary>
        /// <param name="concesionario"></param>
        /// <param name="v"></param>
        /// <returns></returns> Retornará el concesionario
        public static Concesionario<T> operator -(Concesionario<T> concesionario, T v)
        {
            if (concesionario == v)
            {
                concesionario.vehiculos.Remove(v);
            }

            return concesionario;
        }
    }
}
