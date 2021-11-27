using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;


namespace UnitTestConcecionario
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Prueba de igualdad entre vehículos que deberá retornar false ya que son de distinto tipo
        /// </summary>
        [TestMethod]
        public void IgualarVehiculos_CuandoSonDeDistintoTipo_DeberiaRetornarFalse()
        {
            //Arange
            Auto auto = new Auto(12345, ConsoleColor.Blue, false, Auto.EAutos.Focus);
            Suv suv = new Suv(12345, ConsoleColor.Blue, false, Suv.ESuv.Ecosport);

            //Act
            bool igualdad = auto.Equals(suv);

            //Assert
            Assert.IsFalse(igualdad);
        }

        /// <summary>
        /// Prueba de agregar un vehículo que deberá retornar false ya que no hay lugar en el concesionario
        /// </summary>
        [TestMethod]
        
        public void AgregarVehiculo_CuandoNoHayLugar_DeberiaRetornarFalse()
        {
            //Arrange
            Concesionario<Vehiculo> concesionario = new Concesionario<Vehiculo>(0);
            Auto auto = new Auto(12345, ConsoleColor.Blue, false, Auto.EAutos.Focus);

            //Act
            bool pudoAgregar = concesionario + auto;

            //Assert
            Assert.IsFalse(pudoAgregar);
        }
    }
}
