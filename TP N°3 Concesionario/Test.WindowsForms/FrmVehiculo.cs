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
    public partial class FrmVehiculo : Form
    {
        public Vehiculo vehiculo;
        
        /// <summary>
        /// Inicializa el formulario
        /// </summary>
        public FrmVehiculo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga el formulario con las posibles opciones para comprar un vehículo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            foreach (Concesionario<Vehiculo>.ETipoVehiculo item in Enum.GetValues(typeof(Concesionario<Vehiculo>.ETipoVehiculo)))
            {
                this.cboTipoVehiculo.Items.Add(item);
            }

            foreach (ConsoleColor item in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.cboColor.Items.Add(item);
            }
        }

        /// <summary>
        /// Actualiza los modelos de acuerdo al tipo de vehículo seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboTipoVehiculo_SelectedValueChanged(object sender, EventArgs e)
        {
            this.cboModelo.Items.Clear();
            string tipoVehiculo = this.cboTipoVehiculo.SelectedItem.ToString();


            if(tipoVehiculo == "Auto")
            {
                foreach (Auto.EAutos item in Enum.GetValues(typeof(Auto.EAutos)))
                {
                    this.cboModelo.Items.Add(item);
                }
            }
            else if (tipoVehiculo == "Suv")
            {
                foreach (Suv.ESuv item in Enum.GetValues(typeof(Suv.ESuv)))
                {
                    this.cboModelo.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Añadirá un vehículo al concesionario si completó los campos y si hay lugar. Preguntará si confirma la compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.cboTipoVehiculo.SelectedItem is null || this.cboModelo.SelectedItem is null || this.cboColor.SelectedItem is null)
                {
                    this.DialogResult = DialogResult.Retry;
                    throw new CamposVaciosException();
                }

                string tipoVehiculo = this.cboTipoVehiculo.SelectedItem.ToString();
                ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), this.cboColor.Text);

                Random rnd = new Random();
                int nroChasis = 0;
                bool usado = this.chkUsado.Checked;

                do
                {
                    nroChasis = rnd.Next(10000000, 99999999);
                    if (tipoVehiculo == "Auto")
                    {
                        this.vehiculo = new Auto(nroChasis, color, this.chkUsado.Checked, (Auto.EAutos)this.cboModelo.SelectedItem);
                    }
                    else if (tipoVehiculo == "Suv")
                    {
                        this.vehiculo = new Suv(nroChasis, color, this.chkUsado.Checked, (Suv.ESuv)this.cboModelo.SelectedItem);
                    }
                } while (FrmConcesionario.concesionario == this.vehiculo);

                if (MessageBox.Show($"Precio: {this.vehiculo.PrecioCompra}\n¿Confirma compra?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(!(FrmConcesionario.concesionario + this.vehiculo))
                    {
                        this.DialogResult = DialogResult.Cancel;
                        MessageBox.Show("No hay más lugar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (CamposVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Cerrará el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
