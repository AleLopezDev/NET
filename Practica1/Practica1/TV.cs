using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
* PRÁCTICA.............: Práctica 1.
* NOMBRE y APELLIDOS...: Alejandro López Aguilar
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: P.O.O. Abstracción. Definición de Clases.
* FECHA de ENTREGA.....: 19 de octubre de 2022
*/

namespace Practica1
{
    internal class TV
    {
        string marca;
        double pulgadas, consumo;
        float precio;
        bool onOff = false;
        int canal, canalAnterior, volumen;
        public TV(String marca, Double pulgadas, Double consumo, float precio)
        {
            this.marca = marca;
            this.pulgadas = pulgadas;
            this.consumo = consumo;
            this.precio = precio;

        }
        public void pulsarOnOff()
        {
            if (OnOff == false)
            {
                Console.WriteLine("Presiona F1 para encender la Televisión");

                while (Console.ReadKey().Key != ConsoleKey.F1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Dispositivo apagado - F1 para encender su Televisión");
                    Console.Beep();
                    Console.ResetColor();
                }

                onOff = true;
                canal = canalAnterior = 1;
                volumen = 1;

            }
            else
            {
                OnOff = false;
                canal = canalAnterior = volumen = 0;
            }
        }

        public void subirVolumen()
        {
            if (volumen < 100)
            {
                volumen++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                var prevX = Console.CursorLeft;
                var prevY = Console.CursorTop;

                Console.SetCursorPosition(45, 22);
                Console.WriteLine("No puedes subir más el volumen");

                Console.SetCursorPosition(prevX, prevY);
                Console.ResetColor();
            }
            informacionTecnica();
        }

        public void bajarVolumen()
        {
            if (volumen > 0)
            {
                volumen--;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                var prevX = Console.CursorLeft;
                var prevY = Console.CursorTop;

                Console.SetCursorPosition(45, 22);
                Console.WriteLine("No puedes bajar más el volumen");

                Console.SetCursorPosition(prevX, prevY);
                Console.ResetColor();
            }
            informacionTecnica();
        }

        public void ponerCanal(int nuevoCanal)
        {
            if (nuevoCanal >= 0 && nuevoCanal <= 99)
            {
                canalAnterior = canal;
                canal = nuevoCanal;
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Introduce un canal entre 0 y 99");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
            informacionTecnica();
        }

        public void cambiarCanalAnterior()
        {
            if (canal > 0)
            {
                canalAnterior = canal--;
            }

            informacionTecnica();
        }

        public void informacionTecnica()
        {
            Console.WriteLine("***********************\r\n* Informacion Tecnica *\r\n***********************");
            Console.WriteLine("Marca: " + marca + ".\nTamaño en pulgadas: " + pulgadas + "\nPrecio: " + precio);
            Console.WriteLine();
        }

        public bool OnOff
        {
            get { return onOff; }
            set { onOff = value; }
        }

        public int Volumen
        {
            get { return volumen; }
        }

        public int Canal
        {
            get { return canal; }
        }

        public int CanalAnterior
        {
            get { return canalAnterior; }
        }

    }
}
