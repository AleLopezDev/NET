using Practica_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
* PRÁCTICA.............: Práctica 6.
* NOMBRE Y APELLIDOS...: Alejandro López Aguilar
* CURSO Y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Aplicaciones de Formulario. Controles Básicos.
* FECHA DE ENTREGA.....: 07 de Diciembre de 2022
*/

namespace Practica_6
{
    public partial class FormularioHojaSaslarial : Form
    {
        public FormularioHojaSaslarial()
        {
            InitializeComponent();
            comboCategoria.SelectedIndex = 0;
        }
        static bool CheckDNI(string dni)
        {
            //Comprobamos si el DNI tiene 9 digitos
            if (dni.Length != 9)
            {
                //No es un DNI Valido
                return false;
            }

            //Extraemos los números y la letra
            string dniNumbers = dni.Substring(0, dni.Length - 1);
            string dniLeter = dni.Substring(dni.Length - 1, 1);
            //Intentamos convertir los números del DNI a integer
            var numbersValid = int.TryParse(dniNumbers, out int dniInteger);
            if (!numbersValid)
            {
                //No se pudo convertir los números a formato númerico
                return false;
            }
            if (CalculateDNILeter(dniInteger) != dniLeter)
            {
                //La letra del DNI es incorrecta
                return false;
            }
            //DNI Valido 🙂
            return true;
        }
        static string CalculateDNILeter(int dniNumbers)
        {
            //Cargamos los digitos de control
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            var mod = dniNumbers % 23;
            return control[mod];
        }
        private void cajaDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char)e.KeyChar == ((Char)Keys.Enter))
            {
                e.Handled = true;
                if (CheckDNI(cajaDni.Text) == false)
                {
                    MessageBox.Show("Recuerda rellenar el campo correctamente ( 9 - Dígitos ) / Última letra en mayúscula", "Error DNI", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    cajaDni.Text = "";
                }
                else
                {
                    SendKeys.Send("{TAB}");
                }
            }
        }

        private void cajaDni_Leave(object sender, EventArgs e)
        {
            if (cajaDni.Text == "" || CheckDNI(cajaDni.Text) == false)
            {
                MessageBox.Show("Recuerda rellenar el campo correctamente ( 9 - Digitos ) / Última letra en mayúscula", "Error DNI", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                cajaDni.Focus();
            }
        }

        private void cajaNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char)e.KeyChar == ((Char)Keys.Enter) || (Char)e.KeyChar == (Char)Keys.Back)
            {
                e.Handled = true;
                bool contieneDigito = cajaNombre.Text.All(Char.IsDigit);
                if (contieneDigito == true)
                {
                    MessageBox.Show("Introduce correctamente los datos [Carácteres Alfanuméricos]", "Error Nombre", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    cajaNombre.Text = "";
                    cajaNombre.Focus();
                }
                else
                {
                    SendKeys.Send("{TAB}");
                }
            }
        }
        private void cajaNombre_Leave(object sender, EventArgs e)
        {
            if (cajaNombre.Text == "")
            {
                MessageBox.Show("No puedes dejar el campo vacio", "Error Nombre", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                cajaNombre.Focus();
            }
        }
        private void cajaHijos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char)e.KeyChar == ((Char)Keys.Enter) || (Char)e.KeyChar == (Char)Keys.Back)
            {
                e.Handled = true;
                try
                {
                    if (Convert.ToInt32(cajaHijos.Text) < 0 || Convert.ToInt32(cajaHijos.Text) > 50)
                    {
                        MessageBox.Show("Introduce un número entre 0 - 50", "Error Número Hijos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                        cajaHijos.Text = "";
                        cajaHijos.Focus();
                    }
                    else
                    {
                        SendKeys.Send("{TAB}");
                    }

                }
                catch (FormatException eo)
                {
                    MessageBox.Show("Introduce un número", "Error Número Hijos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    cajaHijos.Text = "";
                    cajaHijos.Focus();
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show("Introduce un número correcto", "Error Número Hijos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    cajaHijos.Text = "";
                    cajaHijos.Focus();
                }
            }
        }

        private void cajaHijos_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cajaHijos.Text == "")
                {
                    cajaHijos.Text = "0";
                }
                else if ((Convert.ToInt32(cajaHijos.Text) < 0 || Convert.ToInt32(cajaHijos.Text) > 50))
                {
                    cajaHijos.Text = "";
                    cajaHijos.Focus();
                }
            }
            catch (FormatException eo)
            {
                MessageBox.Show("Introduce un número", "Error Número Hijos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                cajaHijos.Text = "";
                cajaHijos.Focus();
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Introduce un número correcto", "Error Número Hijos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                cajaHijos.Text = "";
                cajaHijos.Focus();
            }
        }

        private void cajaTrienios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char)e.KeyChar == ((Char)Keys.Enter) || (Char)e.KeyChar == (Char)Keys.Back)
            {
                e.Handled = true;
                try
                {
                    if (Convert.ToInt32(cajaTrienios.Text) > 12 || Convert.ToInt32(cajaTrienios.Text) < 0)
                    {
                        MessageBox.Show("Introduce un número entre 0 - 12", "Error Número Trienios", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                        cajaTrienios.Text = "";
                        cajaTrienios.Focus();
                    }
                    else
                    {
                        SendKeys.Send("{TAB}");
                    }
                }
                catch (FormatException eo)
                {
                    MessageBox.Show("Introduce un número", "Error Número Hijos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    cajaTrienios.Text = "";
                    cajaTrienios.Focus();
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show("Introduce un número correcto", "Error Número Hijos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    cajaTrienios.Text = "";
                    cajaTrienios.Focus();
                }
            }
        }

        private void cajaTrienios_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cajaTrienios.Text == "")
                {
                    cajaTrienios.Text = "0";
                }
                else if (Convert.ToInt32(cajaTrienios.Text) > 12 || Convert.ToInt32(cajaTrienios.Text) < 0)
                {
                    MessageBox.Show("Introduce un número entre 0 - 12", "Error Número Trienios", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    cajaTrienios.Text = "";
                    cajaTrienios.Focus();
                }
            }
            catch (FormatException eo)
            {
                MessageBox.Show("Introduce un número", "Error Número Hijos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                cajaTrienios.Text = "";
                cajaTrienios.Focus();
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Introduce un número correcto", "Error Número Hijos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                cajaTrienios.Text = "";
                cajaTrienios.Focus();
            }
        }

        private void cajaHorasExtras_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool contieneDigito = cajaNombre.Text.All(Char.IsDigit);
            if ((Char)e.KeyChar == ((Char)Keys.Enter) || (Char)e.KeyChar == (Char)Keys.Back)
            {
                e.Handled = true;
                try
                {
                    if (contieneDigito == false || Convert.ToInt32(cajaHorasExtras.Text) > 9000)
                    {
                        MessageBox.Show("Introduce un número", "Error Número Horas Extras", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                        cajaHorasExtras.Text = "";
                        cajaHorasExtras.Focus();
                    }
                    else
                    {
                        SendKeys.Send("{TAB}");
                    }
                }
                catch (FormatException eo)
                {
                    MessageBox.Show("Introduce un número", "Error Número Horas Extras", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    cajaHorasExtras.Text = "";
                    cajaHorasExtras.Focus();
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show("Introduce un número correcto", "Error Número Horas Extras", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    cajaHorasExtras.Text = "";
                    cajaHorasExtras.Focus();
                }
            }
        }

        private void cajaHorasExtras_Leave(object sender, EventArgs e)
        {  
            try
            {
                if (cajaHorasExtras.Text == "" || Convert.ToInt32(cajaHorasExtras.Text) > 9000)
                {
                    cajaHorasExtras.Text = "0";
                }
            }
            catch (FormatException eo)
            {
                MessageBox.Show("Introduce un número", "Error Número Horas Extras", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                cajaHorasExtras.Text = "";
                cajaHorasExtras.Focus();
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Introduce un número correcto", "Error Número Horas Extras", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                cajaHorasExtras.Text = "";
                cajaHorasExtras.Focus();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            activarDesactivar(true);

            // Redimensionamos
            this.Width = 680;
            this.Height = 750;

            Empleado emp = new Empleado(Convert.ToInt32(comboCategoria.Text), Convert.ToInt32(cajaTrienios.Text), Convert.ToInt32(cajaHijos.Text), cajaNombre.Text, cajaDni.Text);

            Nomina n = new Nomina(emp, dateTime.Value.Date, Convert.ToInt32(cajaHorasExtras.Text));

            textBoxSBase.Text = n.salarioBase().ToString("#.##");
            textBoxAntiguedad.Text = n.importeAntiguedad().ToString("#.##");
            textBoxHExtras.Text = n.importeHorasExtras().ToString("#.##");
            textBoxPagasEx.Text = n.devengosPagaExtra().ToString("#.##");
            textBoxDeveng.Text = n.totalDevengado().ToString("#.##");
            textBoxLiquido.Text = n.liquidoPercibir(n).ToString("#.##");
            textBoxSegSocial.Text = n.cotizacionSegSoc().ToString("#.##");
            textBoxSegDesempleo.Text = n.cotizacionSegDes().ToString("#.##");
            textBoxIRPF.Text = n.retencionIRPF().ToString("#.##");
            textBoxDescuentos.Text = n.totalDescuentos().ToString("#.##");
        }
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            activarDesactivar(false);
        }
        public void activarDesactivar(bool activo)
        {
            cajaDni.ReadOnly = activo;
            cajaNombre.ReadOnly = activo;
            comboCategoria.Enabled = activo;
            cajaHijos.ReadOnly = activo;
            cajaTrienios.ReadOnly = activo;
            cajaHorasExtras.ReadOnly = activo;
        }

        private void labelCategoria_Click(object sender, EventArgs e)
        {

        }
    }
}

