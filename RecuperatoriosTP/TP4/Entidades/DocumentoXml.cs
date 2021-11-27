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
    public class DocumentoXml<T> : ICargarGuardarArchivo<T>
    {
        /// <summary>
        /// Implementación genérica de la interfaz para cargar un archivo
        /// </summary>
        /// <param name="path"></param>
        /// <param name="datos"></param>
        /// <returns></returns> Retornará true si pudo cargar, false si NO pudo
        public bool Cargar(string path, out T datos)
        {
            bool pudoCargar = false;
            datos = default;
            
            try
            {
                if(path is not null)
                {
                    using (XmlTextReader reader = new XmlTextReader(path))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(T));
                        datos = (T)ser.Deserialize(reader);
                    }
                    pudoCargar = true;
                }
                
            }
            catch (Exception)
            {
                throw new Exception("Error al leer el archivo");
            }

            return pudoCargar;
        }

        /// <summary>
        /// Implementación genérica de la interfaz para guardar un archivo
        /// </summary>
        /// <param name="datos"></param>
        /// <returns></returns> Retornará true si pudo guardar, false si NO pudo
        public bool Guardar(T datos)
        {
            bool pudoGuardar = false;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\StockConcecionario\";

            try
            {
                if(!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                
                path += @"Stock del día_" + DateTime.Now.ToString("dd-MM.yyyy") + ".xml";

                using (XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(T)));
                    ser.Serialize(writer, datos);
                    pudoGuardar = true;
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }

            return pudoGuardar;
        }
    }
}
