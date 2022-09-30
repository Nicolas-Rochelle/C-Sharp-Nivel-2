using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {// programa de ventas con sus ventas y articulos.

            Articulo[] articulos = new Articulo[10];

            for (int x = 0; x < 10; x++)
            {
                articulos[x] = new Articulo();

                Console.WriteLine("ingrese los datos del producto..");
                Console.WriteLine("codigo:");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio: ");
                articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("marca del 1 al 10");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());   
            }
            //vector cargado con lo pedido

            Venta venta = new Venta();
            Console.WriteLine("ingrese la venta");
            Console.WriteLine("codigo cliente");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            while(venta.CodigoCliente != 0)
            {
                Console.WriteLine("Codigo articulo");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("cantidad");
                venta.Cantidad = int.Parse(Console.ReadLine());
                //trabajamos...

                //pido cliente nuevamente
                Console.WriteLine("ingrese la venta");
                Console.WriteLine("codigo cliente");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }
            




        }
    }
}
