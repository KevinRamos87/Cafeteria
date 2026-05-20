using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Bebida
    {
        private string nombre;
        private string tamano;
        private float precio;

        public Bebida(string nombre, string tamano, float precio)
        {
            this.nombre = nombre;
            this.tamano = tamano;
            this.precio = precio;
        }

        public string preparar()
        {
            return ( "Preparando un  " + nombre + " de  tamaño " + tamano); 
        }

        public void Descuento(float porcentaje)
        {
            if (porcentaje > 0 && porcentaje <= 100)
            {
                float descu = precio * (porcentaje / 100);

                precio = precio - descu;
            }
            else
            {
                Console.WriteLine("Porcentaje inválido");
            }
        }

        public string Descripcion()
        {
            return ("Se preparo un:  " + nombre + " de tamaño " + tamano + "De precio $" + precio);
        }
    }
}
