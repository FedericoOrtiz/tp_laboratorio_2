using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ICargarGuardarArchivo<T>
    {
        /// <summary>
        /// Firma de la interfaz genérica para cargar un archivo
        /// </summary>
        /// <param name="path"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        bool Cargar(string path, out T datos);

        /// <summary>
        /// Fima de la interfaz genérica para guardar un archivo
        /// </summary>
        /// <param name="datos"></param>
        /// <returns></returns>
        bool Guardar(T datos);
    }
}
