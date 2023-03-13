using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Menu
    {
        static private TV miTelevision = new TV("Sanyo", 28, 15, 500);

        static void Main(string[] args)
        {
            int opcion = 0, canalSolicitado;
            miTelevision.informacionTecnica();
            miTelevision.pulsarOnOff();
            Console.Clear();

            // Bucle while(true) para poder encender la television cuando este apagada
            while (true)
            {
                Console.Clear();
                miTelevision.informacionTecnica();
                while (miTelevision.OnOff == true)
                {
                    Console.Clear();
                    miTelevision.informacionTecnica();
                    try
                    {
                        Console.WriteLine("1 - Apagar \n2 - Subir Volumen\n3 - Bajar Volumen\n4 - Poner Canal\n5 - Cambiar Canal Anterior\n6 - Desconectar el televisor\n[Enter] Opción Anterior");
                        datosActuales();
                        opcion = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        miTelevision.informacionTecnica();
                    }
                    catch (OverflowException)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Se ha sobrecargado el programa\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            miTelevision.pulsarOnOff();
                            break;

                        case 2:
                            miTelevision.subirVolumen();
                            break;

                        case 3:
                            miTelevision.bajarVolumen();
                            break;

                        case 4:
                            canalSolicitado = solicitarCanal();
                            miTelevision.ponerCanal(canalSolicitado);
                            break;

                        case 5:
                            miTelevision.cambiarCanalAnterior();
                            break;

                        case 6:
                            Environment.Exit(0);
                            break;
                    }
                }
                miTelevision.pulsarOnOff();
                Console.Clear();
            }
        }

        public static int solicitarCanal()
        {
            int canal = 0;
            try
            {
                Console.WriteLine("Introduce el canal a poner: ");
                canal = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Introduce una opcion correcta\n");
                Console.ResetColor();
            }
            catch (OverflowException e)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Se ha sobrecargado el programa\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return canal;
        }

        public static void datosActuales()
        {
            string encendido;

            if (miTelevision.OnOff)
            {
                encendido = "Encendido";
            }
            else
            {
                encendido = "Apagado";
            }

            Console.Write(new string('\n', 10));
            Console.Write("".PadRight(25));
            Console.Write("Volumen: " + miTelevision.Volumen + "".PadRight(5) + "Canal: " + miTelevision.Canal + "".PadRight(5) +
                "Canal Anterior: " + miTelevision.CanalAnterior + "".PadRight(5) + "Estado: " + encendido);
            Console.SetCursorPosition(0, 15);
        }
    }
}

