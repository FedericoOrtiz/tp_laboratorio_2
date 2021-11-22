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
        public VehiculoADO ado;

        /// <summary>
        /// Inicializa el formulario
        /// </summary>
        public FrmVehiculo()
        {
            InitializeComponent();
            ado = new VehiculoADO();
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
                bool flag = true;

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
                        flag = false;
                        this.DialogResult = DialogResult.Cancel;
                        MessageBox.Show("No hay más lugar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if(flag)
                    {
                        ado.AgregarVehiculoComprado(this.vehiculo);
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

        private void cboModelo_SelectedValueChanged(object sender, EventArgs e)
        {
            string modelo = this.cboModelo.Text.ToString();
            this.lblMotorizacion.ResetText();

            if(modelo is not null)
            {
                if(this.cboTipoVehiculo.Text.ToString() == "Auto")
                {
                    Auto a = new Auto(1, ConsoleColor.Red, false, (Auto.EAutos)this.cboModelo.SelectedItem);
                    this.lblMotorizacion.Text = a.Motorizacion();
                }
                else if(this.cboTipoVehiculo.Text.ToString() == "Suv")
                {
                    Suv s = new Suv(1, ConsoleColor.Red, false, (Suv.ESuv)this.cboModelo.SelectedItem);
                    this.lblMotorizacion.Text = s.Motorizacion();
                }
                this.CambiarImagen_Evento(modelo);
            }
        }

        /// <summary>
        /// Evento que se dispara cada vez que el usuario selecciona un modelo de vehículo, muestra una imagen del mismo
        /// </summary>
        /// <param name="modelo"></param>
        private void CambiarImagen_Evento(string modelo)
        {
            string path = string.Empty;
            this.lblLeyenda.Text = "Imagen a modo ilustrativo";
            this.picVGAModelos.Image = null;

            switch (modelo)
            {
                case "Ka":
                    this.picVGAModelos.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\FotosModelos\ka.png");
                    break;
                case "Fiesta":
                    this.picVGAModelos.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\FotosModelos\fiesta.png");
                    break;
                case "Focus":
                    this.picVGAModelos.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\FotosModelos\focus.png");
                    break;
                case "Ecosport":
                    this.picVGAModelos.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\FotosModelos\ecosport.png");
                    break;
                case "Territory":
                    this.picVGAModelos.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\FotosModelos\territory.png");
                    break;
                case "Kuga":
                    this.picVGAModelos.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\FotosModelos\kuga.png");
                    break;
                case "BroncoSport":
                    this.picVGAModelos.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\FotosModelos\broncosport.png");
                    break;
            }
        }
    }
}
