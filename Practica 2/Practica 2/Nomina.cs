/*
* PRÁCTICA.............: Práctica 2.
* NOMBRE y APELLIDOS...: Alejandro López Aguilar
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Definición de Clases. Uso de Métodos.
* FECHA de ENTREGA.....: 26 de octubre de 2022
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Practica_2
{
    internal class Nomina
    {
        private static ArrayList listaEmpleados = new ArrayList();
        private static ArrayList listaNominas = new ArrayList();
        Empleado empleadoNomina;
        DateTime fechaNomina;
        int numHorasExtras;
 
        public Nomina()
        {
 

        }
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

        public void hojaSalarial()
        {
            Console.Clear();
            int index = 0;

            if (Aplicacion.comprobarSizeEmpleados() == false)
            {
                Console.WriteLine("Elige uno de los siguientes empleados para visualizar su Nómina");


                for (int i = 0; i < listaEmpleados.Count; i++)
                {
                    Console.WriteLine(index + " - " + ((Empleado)listaEmpleados[i]).Nombre + "\n");
                    index++;
                }
                try
                {
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    // Esta nomina tiene guardado al empleado
                    Nomina n = (Nomina)listaNominas[opcion];

                    Console.WriteLine(string.Format("{0,6} {1,36}", "DEVENGOS", "DESCUENTOS"));
                    Console.WriteLine(string.Format("{0,6} {1,34}", "------------------", "------------------"));
                    Console.WriteLine(string.Format("{0,6} {1,15} {2,25} {3,21} ", "Salario Base", n.salarioBase(), "Cotización Seg.Soc.", n.cotizacionSegSoc()));
                    Console.WriteLine(string.Format("{0,6} {1,16} {2,26} {3,21}", "Antiguedad", n.importeAntiguedad(), "Cotización Seg.Des.", n.cotizacionSegDes()));
                    Console.WriteLine(string.Format("{0,6} {1,8} {2,22} {3,25}", "Importe Hor.Extras", n.importeHorasExtras(), "Retención IRPF.", n.retencionIRPF()));
                    Console.WriteLine(string.Format("{0,6} {1,17} ", "Paga Extra", n.devengosPagaExtra()));
                    Console.WriteLine(string.Format("{0,6} {1,12} {2,22} {3,24}", "\nTotal Devengado", n.totalDevengado(), "Total Descuentos", n.totalDescuentos()));
                    Console.WriteLine("\n--------------------------------------");
                    Console.WriteLine(string.Format("{0,6} {1,12}", "Líquido a Percibir ", liquidoPercibir(n)));

                    Console.WriteLine("\nPresiona cualquier tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();

                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se encuentra esa opción en la lista\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Introduzca una opción correcta\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (OverflowException)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sobrecarga del programa\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
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
        public ArrayList ListaEmpleados
        {
            get { return listaEmpleados; }
        }
        public ArrayList ListaNominas
        {
            get { return listaNominas; }
        }
    }
}
