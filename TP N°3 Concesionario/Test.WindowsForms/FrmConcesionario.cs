﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Test.WindowsForms
{
    public partial class FrmConcesionario : Form
    {
        public static Concesionario<Vehiculo> concesionario;
        public float ingresosTotales = 0;
        public float egresosTotales = 0;
        public float ingresosPorAuto = 0;
        public float egresosPorAuto = 0; 
        public float ingresosPorSuv = 0;
        public float egresosPorSuv = 0;

        /// <summary>
        /// Inicializa el formulario. Inicializa el concesionario.
        /// </summary>
        public FrmConcesionario()
        {
            InitializeComponent();
            concesionario = new Concesionario<Vehiculo>(10);
        }

        /// <summary>
        /// Inicializa el formulario de vehículos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComprar_Click(object sender, EventArgs e)
        {
            FrmVehiculo frm = new FrmVehiculo();

            DialogResult rta = frm.ShowDialog();

            if (rta == DialogResult.OK)
            {
                this.egresosTotales += frm.vehiculo.PrecioCompra;

                if (frm.vehiculo is Auto)
                {
                    this.egresosPorAuto += frm.vehiculo.PrecioCompra;
                }
                else
                {
                    this.egresosPorSuv += frm.vehiculo.PrecioCompra;
                }

                this.ActualizarLista(sender, e);
            }
            else if (rta == DialogResult.Retry)
            {
                this.btnComprar_Click(sender, e);
            }
         }

        /// <summary>
        /// Removerá un vehículo de la lista, si es que hay alguno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVender_Click(object sender, EventArgs e)
        {
            if(this.lstVehiculos.SelectedItem != null)
            {
                if(MessageBox.Show($"¿Confirma venta?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Vehiculo vehiculo = (Vehiculo)this.lstVehiculos.SelectedItem;
                    concesionario -= vehiculo;
                    
                    this.ingresosTotales += vehiculo.PrecioVenta;

                    if(vehiculo is Auto)
                    {
                        this.ingresosPorAuto += vehiculo.PrecioVenta;
                    }
                    else
                    {
                        this.ingresosPorSuv += vehiculo.PrecioVenta;
                    }

                    this.ActualizarLista(sender, e);
                } 
            }
        }

        /// <summary>
        /// Carga el formulario y deserializa el archivo de stock inicial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConcesionaria_Load(object sender, EventArgs e)
        {
            List<Vehiculo> lista = new List<Vehiculo>();
            DocumentoXml<List<Vehiculo>> xml = new DocumentoXml<List<Vehiculo>>();

            try
            {
                xml.Cargar(Environment.CurrentDirectory + @"\ArchivoInicial\StockInicial.xml", out lista);
                MessageBox.Show("Archivo cargado con éxito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            concesionario.Vehiculos = lista;

            this.cboCriterio.Items.Add("Totales");
            this.cboCriterio.Items.Add("Por Auto");
            this.cboCriterio.Items.Add("Por Suv");
            this.cboCriterio.SelectedItem = "Totales";

            this.cboOrdenamiento.Items.Add("Precio más Bajo");
            this.cboOrdenamiento.Items.Add("Precio más Alto");
            this.cboOrdenamiento.Items.Add("Autos");
            this.cboOrdenamiento.Items.Add("Suvs");
            this.cboOrdenamiento.SelectedItem = "Precio más Bajo";
        }

        /// <summary>
        /// Método que carga los vehículos del concesionario en el formualrio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActualizarLista(object sender, EventArgs e)
        {
            this.lstVehiculos.Items.Clear();

            foreach (Vehiculo vehiculo in concesionario.Vehiculos)
            {
                switch (this.cboOrdenamiento.SelectedItem.ToString())
                {
                    case "Autos":
                        if(vehiculo is Auto)
                        {
                            this.lstVehiculos.Items.Add(vehiculo);
                        }
                        break;
                    case "Suvs":
                        if(vehiculo is Suv)
                        {
                            this.lstVehiculos.Items.Add(vehiculo);
                        }
                        break;
                    default:
                        this.lstVehiculos.Items.Add(vehiculo);
                        break;
                }

            }

            this.cboCriterio_SelectedValueChanged(sender, e);
        }

        /// <summary>
        /// Actualiza los valores de los ingresos y egresos de acuerdo al criterio seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboCriterio_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (this.cboCriterio.SelectedItem.ToString())
            {
                case "Totales":
                    this.txtIngresos.Text = String.Format($"{this.ingresosTotales}");
                    this.txtEgresos.Text = String.Format($"{this.egresosTotales}");
                    break;
                case "Por Auto":
                    this.txtIngresos.Text = String.Format($"{this.ingresosPorAuto}");
                    this.txtEgresos.Text = String.Format($"{this.egresosPorAuto}");
                    break;
                case "Por Suv":
                    this.txtIngresos.Text = String.Format($"{this.ingresosPorSuv}");
                    this.txtEgresos.Text = String.Format($"{this.egresosPorSuv}");
                    break;
            }
        }

        /// <summary>
        /// Ordenará los vehículos de acuerdo al criterio seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboOrdenamiento_SelectedValueChanged(object sender, EventArgs e)
        {
            if(this.cboOrdenamiento.SelectedItem.ToString() == "Precio más Alto")
            {
                concesionario.Vehiculos.Sort(Vehiculo.OrdenarPorPrecioMayor);
            }
            else
            {
                concesionario.Vehiculos.Sort(Vehiculo.OrdenarPorPrecioMenor);
            }

            this.ActualizarLista(sender, e);
        }

        /// <summary>
        /// Confirma la salida del programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConcesionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Serializa la lista de vehículos y la guarda en MisDocumentos/StockConcesionario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                DocumentoXml<List<Vehiculo>> xml = new DocumentoXml<List<Vehiculo>>();
                
                if(concesionario.Vehiculos.Count > 0 && xml.Guardar(concesionario.Vehiculos))
                {
                    MessageBox.Show("Archivo guardado con éxito\nPuede encontrarlo en MisDocumentos/StockConcesionario", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar\nLa lista debe contener vehículos", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
