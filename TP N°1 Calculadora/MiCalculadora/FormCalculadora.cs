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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando resultado = new Operando();
            string aux = resultado.DecimalBinario(this.lblResultado.Text);

            if (aux == "Valor invalido")
            {
                aux = "0";
            }

            this.lblResultado.Text = aux;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando resultado = new Operando();
            string aux = resultado.BinarioDecimal(this.lblResultado.Text);

            if(aux == "Valor invalido")
            {
                aux = "0";
            }

            this.lblResultado.Text = aux;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string auxCmbOperador = this.cmbOperador.Text.ToString();
            string resultado = FormCalculadora.Operar(this.txtNumero1.Text.ToString(), this.txtNumero2.Text.ToString(), auxCmbOperador).ToString();

            if(auxCmbOperador == string.Empty)
            {
                this.cmbOperador.Text = "+";
            }
            string operacion = $"{this.txtNumero1.Text.ToString()} {this.cmbOperador.Text.ToString()} {this.txtNumero2.Text.ToString()} = {resultado}";
            this.lblResultado.Text = resultado;
            this.lstOperaciones.Items.Add(operacion);
        }

        /// <summary>
        /// Borrará los datos de los textbox, combobox y label de la pantalla
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.ResetText();
            this.lblResultado.ResetText();
        }

        /// <summary>
        /// Realizará una determinada operación entre los números de acuerdo al operador
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>Retornará el resultadode la operación</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);

            char auxOperador;
            char.TryParse(operador, out auxOperador);

            double retorno = Calculadora.Operar(operando1, operando2, auxOperador);

            if(retorno == double.MinValue)
            {
                MessageBox.Show("Math Error", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return retorno;
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }

    
}
