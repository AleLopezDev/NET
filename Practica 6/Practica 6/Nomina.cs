/*
* PRÁCTICA.............: Práctica 6.
* NOMBRE Y APELLIDOS...: Alejandro López Aguilar
* CURSO Y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Aplicaciones de Formulario. Controles Básicos.
* FECHA DE ENTREGA.....: 07 de Diciembre de 2022
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Practica_2
{
    internal class Nomina
    {
        Empleado empleadoNomina;
        DateTime fechaNomina;
        int numHorasExtras;

        public Nomina(Empleado empleadoNomina, DateTime fechaNomina, int numHorasExtras)
        {
            this.empleadoNomina = empleadoNomina;
            this.fechaNomina = fechaNomina;
            this.numHorasExtras = numHorasExtras;
        }
        public double cotizacionSegDes()
        {
            return devengosPagaExtra() * 1.97 / 100;
        }
        public double cotizacionSegSoc()
        {
            // Base de Cotizacion * 4.51 / 100
            // Based de Cotizacion = Devengos Paga Extra + Devengos Paga Extra/6
            double baseCotizacion = devengosPagaExtra() + devengosPagaExtra() / 6;
            return baseCotizacion * 4.51 / 100;
        }
        public double devengosPagaExtra()
        {
            return salarioBase() + importeAntiguedad();
        }

        public double importeAntiguedad()
        {
            return empleadoNomina.NumTrienios * salarioBase() * 4 / 100;
        }
        public double importeHorasExtras()
        {
            return numHorasExtras * salarioBase() * 1 / 100;
        }
        public double retencionIRPF()
        {
            if (fechaNomina.Month == 12 || fechaNomina.Month == 6)
            {
                return (totalDevengado() + devengosPagaExtra()) * porcentajeIrpfAplicado() / 100;
            }
            else
            {
                return totalDevengado() * porcentajeIrpfAplicado() / 100;
            }
        }
        public double salarioBase()
        {
            double salarioBase = 0;

            switch (empleadoNomina.Categoria)
            {
                case 1:
                    salarioBase = 2500;
                    break;
                case 2:
                    salarioBase = 2000;
                    break;
                case 3:
                    salarioBase = 1500;
                    break;
            }
            return salarioBase;
        }
        public double totalDescuentos()
        {
            return cotizacionSegSoc() + cotizacionSegDes() + retencionIRPF();
        }
        public double totalDevengado()
        {
            return salarioBase() + importeAntiguedad() + importeHorasExtras() + devengosPagaExtra();
        }
        public double porcentajeIrpfAplicado()
        {
            switch (empleadoNomina.Categoria)
            {
                case 1:
                    return 18 - empleadoNomina.NumHijos;
                case 2:
                    return 15 - empleadoNomina.NumHijos;
                case 3:
                    return 12 - empleadoNomina.NumHijos;
            }
            return 0;
        }

        public double liquidoPercibir(Nomina n)
        {
            if (n.fechaNomina.Month == 6 || n.fechaNomina.Month == 12)
            {
                return n.totalDevengado() + n.devengosPagaExtra() - n.totalDescuentos();
            }
            else
            {
                return n.totalDevengado() - n.totalDescuentos();
            }
        }
        public Empleado EmpleadoNomina
        {
            get { return empleadoNomina; }
            set { empleadoNomina = value; }
        }
        public DateTime FechaNomina
        {
            get { return fechaNomina; }
            set { fechaNomina = value; }
        }
        public int NumHorasExtras
        {
            get { return numHorasExtras; }
            set { numHorasExtras = value; }
        }
    }
}
