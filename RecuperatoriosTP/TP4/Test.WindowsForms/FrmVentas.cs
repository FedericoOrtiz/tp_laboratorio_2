using System;
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
    public partial class FrmVentas : Form
    {

        public VehiculoADO ado;
        public float porcentajeAutos = 0;
        public float porcentajeSuvs = 0;

        /// <summary>
        /// Inicializa el formulario
        /// </summary>
        public FrmVentas()
        {
            InitializeComponent();
            ado = new VehiculoADO();
        }

        /// <summary>
        /// Carga el formulario con los vehículos vendidos, si es que los hay. Realiza un análisis de ventas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVentas_Load(object sender, EventArgs e)
        {
            float cantidad = FrmConcesionario.ventas.Vehiculos.Count;
            float cantidadAutos = 0;
            float cantidadSuvs = 0;


            if (cantidad > 0)
            {
                foreach (Vehiculo v in FrmConcesionario.ventas.Vehiculos)
                {
                    if(v is Auto)
                    {
                        cantidadAutos++;
                    }
                    else
                    {
                        cantidadSuvs++;
                    }

                    this.lstVehiculos.Items.Add(v);
                }

                this.txtTotales.Text = cantidad.ToString();
                this.txtAutos.Text = cantidadAutos.ToString();
                this.txtSuvs.Text = cantidadSuvs.ToString();
                this.txtPorcentajeAutos.Text = ((cantidadAutos / cantidad) * 100).ToString("0.00");
                this.txtPorcentajeSuvs.Text = ((cantidadSuvs / cantidad) * 100).ToString("0.00");
                this.txtModeloMasVendido.Text = ado.ObtenerModeloMasVendido();
            }
        }
    }
}
