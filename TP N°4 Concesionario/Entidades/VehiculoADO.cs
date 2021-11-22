using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoADO
    {
        private static string connectionString;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        /// <summary>
        /// Constructor estático que determina la ruta de conexión de la base de datos
        /// </summary>
        static VehiculoADO()
        {
            VehiculoADO.connectionString = @"Data Source = .\;Initial Catalog = VEHICULOS_DB;Integrated Security=True";
        }

        /// <summary>
        /// Constructor sin parámetros que inicializa la conexión SQL
        /// </summary>
        public VehiculoADO()
        {
            this.connection = new SqlConnection(connectionString);
        }

        /// <summary>
        /// Método que devuelve la lista de vehículos en stock de la base de datos
        /// </summary>
        /// <returns></returns>
        public Concesionario<Vehiculo> LeerVehiculos_Stock()
        {
            Concesionario<Vehiculo> listaVehiculos = new Concesionario<Vehiculo>();
            bool aux;

            try
            {
                this.command = new SqlCommand();
                this.command.CommandType = CommandType.Text;
                this.command.CommandText = "SELECT * FROM VEHICULOS_STOCK";
                this.command.Connection = this.connection;
                this.connection.Open();
                this.reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["origen"].ToString() is not null)
                    {
                        Suv s = new Suv((int)reader["CHASIS"], (ConsoleColor)reader["COLOR"], (bool)reader["USADO"], (Suv.ESuv)reader["MODELO"]);
                        aux = listaVehiculos + s;
                    }
                    else
                    {
                        Auto a = new Auto((int)reader["CHASIS"], (ConsoleColor)reader["COLOR"], (bool)reader["USADO"], (Auto.EAutos)reader["MODELO"]);
                        aux = listaVehiculos + a;
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return listaVehiculos;
        }

        /// <summary>
        /// Método que devuelve la lista de vehículos vendidos de la base de datos
        /// </summary>
        /// <returns></returns>
        public Concesionario<Vehiculo> LeerVehiculos_Vendidos()
        {
            Concesionario<Vehiculo> listaVehiculos = new Concesionario<Vehiculo>();
            bool aux;

            try
            {
                this.command = new SqlCommand();
                this.command.CommandType = CommandType.Text;
                this.command.CommandText = "SELECT * FROM VEHICULOS_VENDIDOS";
                this.command.Connection = this.connection;
                this.connection.Open();
                this.reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["origen"].ToString() is not null)
                    {
                        Suv s = new Suv((int)reader["CHASIS"], (ConsoleColor)reader["COLOR"], (bool)reader["USADO"], (Suv.ESuv)reader["MODELO"]);
                        aux = listaVehiculos + s;
                    }
                    else
                    {
                        Auto a = new Auto((int)reader["CHASIS"], (ConsoleColor)reader["COLOR"], (bool)reader["USADO"], (Auto.EAutos)reader["MODELO"]);
                        aux = listaVehiculos + a;
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return listaVehiculos;
        }

        /// <summary>
        /// Método que agrega un vehículo a la lista de vehículos en stock de la base de datos
        /// </summary>
        /// <returns></returns>
        public bool AgregarVehiculoComprado(Vehiculo vehiculo)
        {
            bool pudoAgregar = true;

            try
            {
                string sql = string.Empty;
                int bit = 0;

                if(vehiculo is Auto)
                {
                    Auto a = vehiculo as Auto;
                    if(a.EsUsado)
                    {
                        bit = 1;
                    }
                    sql = $"INSERT INTO VEHICULOS_STOCK (CHASIS, MODELO, COLOR, USADO, ORIGEN, PRECIO) VALUES ({a.NroChasis}, '{a.Modelo.ToString()}', '{a.Color.ToString()}', {bit}, 'NULL', {a.PrecioVenta})";
                }
                else
                {
                    Suv s = vehiculo as Suv;
                    if (s.EsUsado)
                    {
                        bit = 1;
                    }
                    sql = $"INSERT INTO VEHICULOS_STOCK (CHASIS, MODELO, COLOR, USADO, ORIGEN, PRECIO) VALUES ({s.NroChasis}, '{s.Modelo.ToString()}', '{s.Color.ToString()}', {bit}, '{s.Origen.ToString()}', {s.PrecioVenta})";
                }

                this.command = new SqlCommand();

                this.command.CommandType = CommandType.Text;
                this.command.CommandText = sql;
                this.command.Connection = this.connection;

                this.connection.Open();

                int filasAfectadas = this.command.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    pudoAgregar = false;
                }

            }
            catch (Exception e)
            {
                pudoAgregar = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return pudoAgregar;
        }

        /// <summary>
        /// Método que agrega un vehículo a la lista de vehículos vendidos de la base de datos
        /// </summary>
        /// <returns></returns>
        public bool AgregarVehiculoVendido(Vehiculo vehiculo)
        {
            bool pudoAgregar = true;

            try
            {
                string sql = string.Empty;
                int bit = 0;

                if (vehiculo is Auto)
                {
                    Auto a = vehiculo as Auto;
                    if (a.EsUsado)
                    {
                        bit = 1;
                    }
                    sql = $"INSERT INTO VEHICULOS_VENDIDOS (CHASIS, MODELO, COLOR, USADO, ORIGEN, PRECIO) VALUES ({a.NroChasis}, '{a.Modelo.ToString()}', '{a.Color.ToString()}', {bit}, 'NULL', {a.PrecioVenta})";
                }
                else
                {
                    Suv s = vehiculo as Suv;
                    if (s.EsUsado)
                    {
                        bit = 1;
                    }
                    sql = $"INSERT INTO VEHICULOS_VENDIDOS (CHASIS, MODELO, COLOR, USADO, ORIGEN, PRECIO) VALUES ({s.NroChasis}, '{s.Modelo.ToString()}', '{s.Color.ToString()}', {bit}, '{s.Origen.ToString()}', {s.PrecioVenta})";
                }

                this.command = new SqlCommand();

                this.command.CommandType = CommandType.Text;
                this.command.CommandText = sql;
                this.command.Connection = this.connection;

                this.connection.Open();

                int filasAfectadas = this.command.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    pudoAgregar = false;
                }

            }
            catch (Exception)
            {
                pudoAgregar = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return pudoAgregar;
        }

        /// <summary>
        /// Método que elimina un vehículo a la lista de vehículos en stock de la base de datos
        /// </summary>
        /// <returns></returns>
        public bool EliminarVehiculoComprado(int chasis)
        {
            bool pudoEliminar = true;

            try
            {
                this.command = new SqlCommand();

                string sql = "DELETE FROM VEHICULOS_STOCK WHERE CHASIS = @CHASIS";
                this.command.Parameters.AddWithValue("@CHASIS", chasis);

                this.command.CommandType = CommandType.Text;
                this.command.CommandText = sql;
                this.command.Connection = this.connection;

                this.connection.Open();

                int filasAfectadas = this.command.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    pudoEliminar = false;
                }

            }
            catch (Exception)
            {
                pudoEliminar = false;
            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

            return pudoEliminar;
        }

        /// <summary>
        /// Método que limpia los registros de la base de datos
        /// </summary>
        /// <returns></returns>
        public void LimpiarBD()
        {

            try
            {
                this.command = new SqlCommand();

                string sql = "DELETE FROM VEHICULOS_STOCK";

                this.command.CommandType = CommandType.Text;
                this.command.CommandText = sql;
                this.command.Connection = this.connection;

                this.connection.Open();
                this.command.ExecuteNonQuery();

                sql = "DELETE FROM VEHICULOS_VENDIDOS";

                this.command.CommandType = CommandType.Text;
                this.command.CommandText = sql;
                this.command.Connection = this.connection;

                this.command.ExecuteNonQuery();

            }
            finally
            {
                if (this.connection.State == ConnectionState.Open)
                {
                    this.connection.Close();
                }
            }

        }
    }
}
