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

namespace Practica_2
{
    internal class Empleado
    {
        int categoria, numTrienios, numHijos;
        string nombre, nif;
        public Empleado()
        {

        }
        public Empleado(int categoria, int numTrienios, int numHijos, string nombre, string nif)
        {
            this.categoria = categoria;
            this.numTrienios = numTrienios;
            this.numHijos = numHijos;
            this.nombre = nombre;
            this.nif = nif;
        }
        public int Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public string Nif
        {
            get { return nif; }
            set { nif = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int NumHijos
        {
            get { return numHijos; }
            set { numHijos = value; }
        }
        public int NumTrienios
        {
            get { return numTrienios; }
            set { numTrienios = value; }
        }
    }
}
