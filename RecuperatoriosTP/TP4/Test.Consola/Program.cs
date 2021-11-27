using System;
using Entidades;

namespace Test.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string si = "Pudo agregar";
            string no = "No pudo agregar";
            Auto a1 = new Auto(18736849, ConsoleColor.Red, true, Auto.EAutos.Fiesta);
            Auto a2 = new Auto(18736849, ConsoleColor.Red, false, Auto.EAutos.Focus);
            Auto a3 = new Auto(16738239, ConsoleColor.Red, true, Auto.EAutos.Ka);
            Suv s1 = new Suv(18736850, ConsoleColor.Red, false, Suv.ESuv.BroncoSport);
            Suv s2 = new Suv(18736850, ConsoleColor.Red, false, Suv.ESuv.BroncoSport);
            Concesionario<Vehiculo> concesionario = new Concesionario<Vehiculo>(3);

            if(concesionario + a1)
            {
                Console.WriteLine(si);
            }

            // Iguales. No podrá agregar
            if (!(concesionario + a2))
            {
                Console.WriteLine(no);
            }

            if (concesionario + a3)
            {
                Console.WriteLine(si);
            }

            if (concesionario + s1)
            {
                Console.WriteLine(si);
            }

            // No hay lugar. No podrá agregar
            if (!(concesionario + s2))
            {
                Console.WriteLine(no);
            }

            Console.WriteLine("\n---------------------------");
            Console.WriteLine("LISTADO DE VEHÍCULOS");

            foreach (Vehiculo v in concesionario.Vehiculos)
            {
                Console.Write(v.ToString());
            }

            Console.ReadKey();
        }
    }
}
