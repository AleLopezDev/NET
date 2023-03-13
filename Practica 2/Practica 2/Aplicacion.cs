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
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    internal class Aplicacion
    {

        private static Nomina n = new Nomina();
        private static int opcion = 0;
        private static List<int> numeros = new List<int>();
        private static List<DateTime> numerosFecha = new List<DateTime>();
        public static void Main(string[] args)
        {
            while (opcion != 9)
            {
                try
                {
                    Console.WriteLine("1 - Crear Nuevo Empleado\n2 - Visualizar Hoja Salarial\n3 - Visualizar empleado y su nomina\n4 - Modificar empleado\n5 - Eliminar empleado\n9 - Salir");
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Introduzca una opción correcta\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (OverflowException e)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sobrecarga del programa\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                switch (opcion)
                {
                    case 1:
                        crearEmpleado();
                        break;
                    case 2:
                        n.hojaSalarial();
                        break;
                    case 3:
                        visualizarEmpleado();
                        break;
                    case 4:
                        modificarEmpleado();
                        break;
                    case 5:
                        eliminarEmpleado();
                        break;
                    case 9:
                        Console.Clear();
                        break;
                }
            }
        }
        public static void crearEmpleado()
        {
            int categoria = 0, nTrienios = 0;
            string nombreEmpleado = "", nif = "";

            Console.Clear();

            Console.WriteLine("Introduce el nombre de empleado: ");
            nombreEmpleado = Console.ReadLine();

            while (nombreEmpleado == "")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Introduce correctamente el nombre del empleado: ");
                Console.ResetColor();
                nombreEmpleado = Console.ReadLine();
            }

            Console.WriteLine("Introduce el NIF: ");
            nif = Console.ReadLine();

            while (nif == "" || nif.Length != 9)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Introduce correctamente el NIF (9 dígitos, incluida la letra): ");
                Console.ResetColor();
                nif = Console.ReadLine();
                Console.Clear();
            }

            categoria = solicitarNumero("Introduce la categoría: ");

            while (categoria <= 0 || categoria > 3)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                categoria = solicitarNumero("Introduce la categoría, tiene que ser un número entre 1 - 3: ");
                Console.ResetColor();
                Console.Clear();
            }


            nTrienios = solicitarNumero("Introduce el número de trienios: ");

            while (nTrienios <= 0 || nTrienios > 12)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                nTrienios = solicitarNumero("Introduce el número de trienios, no puede ser mayor de 12, o menor de 0: ");
                Console.ResetColor();
                Console.Clear();
            }

            int nHijos = solicitarNumero("Introduce el numero de Hijos: ");

            if (nHijos < 0)
            {
                nHijos = 0;
            }

            Empleado e = new Empleado(categoria, nTrienios, nHijos, nombreEmpleado, nif);

            crearNomina(e);

            Console.Clear();
        }
        public static void crearNomina(Empleado e)
        {
            int horasExtras = 0;
            DateTime dt = solicitarFecha("Introduce la fecha de liquidación: ");

            while (horasExtras <= 0)
            {
                horasExtras = solicitarNumero("Introduce las horas extras: ");
                Console.Clear();
            }

            //Evitar que se añada el empleado si la nomina no esta bien puesta
            n.ListaEmpleados.Add(e);
            n.ListaNominas.Add(new Nomina(e, dt, horasExtras));
        }
        public static void visualizarEmpleado()
        {
            Console.Clear();
            int index = 0;

            if (comprobarSizeEmpleados() == false)
            {
                Console.WriteLine("Elige uno de los siguientes empleados para Visualizar");
                for (int i = 0; i < n.ListaEmpleados.Count; i++)
                {
                    Console.WriteLine(index + " - " + ((Empleado)n.ListaEmpleados[i]).Nombre + "\n");
                    index++;
                }

                try
                {
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Nombre: " + ((Nomina)n.ListaNominas[opcion]).EmpleadoNomina.Nombre);
                    Console.WriteLine("Categoría: " + ((Nomina)n.ListaNominas[opcion]).EmpleadoNomina.Categoria);
                    Console.WriteLine("Número de trienios: " + ((Nomina)n.ListaNominas[opcion]).EmpleadoNomina.NumTrienios);
                    Console.WriteLine("Num Hijos: " + ((Nomina)n.ListaNominas[opcion]).EmpleadoNomina.NumHijos);
                    Console.WriteLine("NIF: " + ((Nomina)n.ListaNominas[opcion]).EmpleadoNomina.Nif);
                    Console.WriteLine("\nDatos Nómina\n----------------");
                    Console.WriteLine("Fecha Nómina: " + ((Nomina)n.ListaNominas[opcion]).FechaNomina);
                    Console.WriteLine("Número Horas Extras: " + ((Nomina)n.ListaNominas[opcion]).NumHorasExtras);
                    Console.WriteLine("\n");
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
        public static void modificarEmpleado()
        {
            Console.Clear();
            int index = 0;

            if (comprobarSizeEmpleados() == false)
            {
                //Nuevas variables
                string newName = "", newNif = "";
                int newCategoria = 0, newTrienios = 0, opcionCambiar = 0, opcion = 0;

                Console.WriteLine("Elige uno de los siguientes empleados para Modificar");
                for (int i = 0; i < n.ListaEmpleados.Count; i++)
                {
                    Console.WriteLine(index + " - " + ((Empleado)n.ListaEmpleados[i]).Nombre + "\n");
                    index++;
                }

                try
                {
                    opcion = solicitarNumero("");

                    while (opcion < 0 || opcion > (n.ListaEmpleados.Count - 1))
                    {
                        limpiar();
                        escribirRojo("Esa opción no existe, elige una opción de las siguientes: ");
                        for (int i = 0; i < n.ListaEmpleados.Count; i++)
                        {
                            Console.WriteLine(i + " - " + ((Empleado)n.ListaEmpleados[i]).Nombre + "\n");
                        }
                        opcion = solicitarNumero("");              
                    }

                    limpiar();

                    Console.WriteLine("Selecciones alguna de las siguientes opciones a cambiar\n1 - Nombre\n2 - NIF\n3 - Categoría\n4 - Número Trienios\n5 - Número de Hijos\n6 - Cambiar Fecha\n7 - Cambiar Horas Extras");
                    opcionCambiar = Convert.ToInt32(Console.ReadLine());
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
                switch (opcionCambiar)
                {
                    case 1:
                        while (newName == "")
                        {
                            Console.WriteLine("Introduce un nuevo nombre: ");
                            newName = Console.ReadLine();
                        }
                          ((Nomina)n.ListaNominas[opcion]).EmpleadoNomina.Nombre = newName;
                        break;
                    case 2:
                        while (newNif == "" || newNif.Length != 9)
                        {
                            Console.WriteLine("Introduce correctamente el NIF (9 dígitos): ");
                            newNif = Console.ReadLine();
                        }
                          ((Nomina)n.ListaNominas[opcion]).EmpleadoNomina.Nif = newNif;
                        break;
                    case 3:
                        while (newCategoria <= 0 || newCategoria > 3)
                        {
                            limpiar();
                            newCategoria = solicitarNumero("Introduce la categoría, tiene que ser un número entre 1 - 3: ");
                        }
                        ((Nomina)n.ListaNominas[opcion]).EmpleadoNomina.Categoria = newCategoria;
                        break;
                    case 4:
                        while (newTrienios <= 0 || newTrienios > 12)
                        {
                            limpiar();
                            newTrienios = solicitarNumero("Introduce el número de trienios, no puede ser mayor de 12, o menor de 0: ");
                        }
                          ((Nomina)n.ListaNominas[opcion]).EmpleadoNomina.NumTrienios = newTrienios;
                        break;
                    case 5:
                        int numHijos = solicitarNumero("Introduce el número de Hijos");

                        if (numHijos < 0)
                        {
                            ((Nomina)n.ListaNominas[opcion]).EmpleadoNomina.NumHijos = 0;
                        }
                        else
                        {
                            ((Nomina)n.ListaNominas[opcion]).EmpleadoNomina.NumHijos = numHijos;
                        }
                        break;

                    case 6:
                        int horasExtras = 0;
                        DateTime newDt = solicitarFecha("Introduce la fecha de liquidación: ");

                        ((Nomina)n.ListaNominas[opcion]).FechaNomina = newDt;
                        break;
                    case 7:
                        int newHorasExtras = 0;
                        while (newHorasExtras <= 0)
                        {
                            newHorasExtras = solicitarNumero("Introduce las horas extras: ");
                            Console.Clear();
                        }
                          ((Nomina)n.ListaNominas[opcion]).NumHorasExtras = newHorasExtras;
                        break;
                }
                limpiar();
                escribirVerde("Datos cambiados con éxito\n");
            }
        }
        public static void eliminarEmpleado()
        {
            Console.Clear();
            if (comprobarSizeEmpleados() == false)
            {
                int index = 0;
                Console.WriteLine("Elige uno de los siguientes empleados para Modificar");
                for (int i = 0; i < n.ListaEmpleados.Count; i++)
                {
                    Console.WriteLine(index + " - " + ((Empleado)n.ListaEmpleados[i]).Nombre + "\n");
                    index++;
                }

                try
                {
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    n.ListaEmpleados.RemoveAt(opcion);
                    n.ListaNominas.RemoveAt(opcion);
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
        public static bool comprobarSizeEmpleados()
        {
            bool estaVacio;

            if (n.ListaEmpleados.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("No existe ningún empleado");
                Console.ResetColor();
                Console.WriteLine("\nPresiona cualquier tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
                estaVacio = true;
            }
            else
            {
                estaVacio = false;
            }
            return estaVacio;
        }

        public string controlarLetraDni(int dni)
        {
            //Cargamos los digitos de control
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            var mod = dni % 23;
            return control[mod];
        }
        public static int solicitarNumero(string mensaje)
        {
            numeros.Clear();
            int numero = 0;
            Console.Write(mensaje);
            try
            {
                numero = Convert.ToInt32(Console.ReadLine());
                numeros.Add(numero);
                return numero;
            }
            catch (OverflowException e)
            {
                limpiar();
                escribirRojo("Vuelte a introducir el número");
                solicitarNumero(mensaje);
            }
            catch (FormatException e)
            {
                limpiar();
                escribirRojo("Vuelte a introducir el número");
                solicitarNumero(mensaje);
            }
            return numeros[0];
        }

        public static DateTime solicitarFecha(string mensaje)
        {
            numerosFecha.Clear();
            Console.WriteLine(mensaje);
            try
            {
                DateTime dt = DateTime.Parse(Console.ReadLine());
                numerosFecha.Add(dt);
                return dt;
            }
            catch (OverflowException e)
            {
                limpiar();
                escribirRojo("Vuelte a introducir la fecha");
                solicitarFecha(mensaje);
            }
            catch (FormatException e)
            {
                limpiar();
                escribirRojo("Vuelte a introducir la fecha");
                solicitarFecha(mensaje);
            }
            return numerosFecha[0];
        }
        public static void limpiar()
        {
            Console.Clear();
        }
        public static void escribirRojo(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensaje);
            Console.ResetColor();
        }

        public static void escribirVerde(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(mensaje);
            Console.ResetColor();
        }

    }
}
