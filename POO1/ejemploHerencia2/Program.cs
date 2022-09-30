using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploHerencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {   // camioneta si es un vehiculo 
            //Vehiculo v2 = new Camioneta();

            //Pero vehiculo no sabe si es una camioneta
            //Camioneta c2 = new Vehiculo();


            //Vehiculo v1 = new Vehiculo();
            //Camioneta c1 = new Camioneta();
            //Camioneta c2 = new Camioneta();
            //Camioneta c3 = new Camioneta();
            //c1.Color = "Amarillo";
            //c2.Color = "Roja";
            //c3.Color = "Blanca";



            //esto es una coleccion tipo lista, de camionetas
            //List<Camioneta> listaCamionetas = new List<Camioneta>();
            //listaCamionetas.Add(c1);
            //listaCamionetas.Add (c2);
            //listaCamionetas.Add(c3);

            //Console.WriteLine("la cantidad de camionetas es: " + listaCamionetas.Count);
            //listaCamionetas[1].Color = "negra";
            //c2.Color = "Verde";
            //Console.WriteLine("el Color es :" + listaCamionetas[1].Color); //parecido al vector, entre corchetes te paras en la posicion de la lista
            //listaCamionetas.Remove(c3); //remove se usa para remover 
            //Console.WriteLine("la cantidad de camionetas es: " + listaCamionetas.Count);

            //foreach (Camioneta item in listaCamionetas)
            //{
            //    Console.WriteLine("Color:" + item.Color);

            //}

            //asociasion por agregacion
            Auto a1 = new Auto();   

            a1.Motor = new Motor(); 

            Console.ReadKey();
        }
    }
}
