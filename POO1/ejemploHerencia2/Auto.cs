using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploHerencia2
{
    internal class Auto : Vehiculo  
    {   public Auto()
        {
            Chasis = new Chasis();  
        }
        public int anio { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }

        //composicion 
        public Chasis Chasis { get; set; }

        //agregaciom
        public Motor Motor { get; set; }
    }
}
