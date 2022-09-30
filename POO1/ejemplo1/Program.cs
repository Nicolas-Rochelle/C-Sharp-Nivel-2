using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Persona p1 = new Persona("pepe");

            //p1.setEdad(20);
            //Console.WriteLine(p1.saludar());
            //Console.WriteLine("la edad es: " + p1.getEdad());

            Botella b1 = new Botella("Rojo","Plastico");
           // Botella b2 = new Botella();
            //b1.Capacidad = 200;

            Console.WriteLine("capacidad botella" +b1.Capacidad);
            Console.WriteLine("la cantidad actual es:" + b1.CantidadActual);

            b1.recargar();
            Console.WriteLine("luego de recargar, la cantidad actual es:" + b1.CantidadActual);

            //Perro perr1 = new Perro();
            // perr1.Edad = 4;

            //Console.WriteLine("la edad es" + perr1.Edad);
            Console.ReadKey();
        }
    }
}
