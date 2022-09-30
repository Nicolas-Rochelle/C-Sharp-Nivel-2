using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Articulo
    { //- codigo de articulo (3 digitos no correlativos
      //- precio
      //- codigo de marca (1 a 10)

        // private int codArticulo;

        public int CodigoArticulo { get; set; }
        //en esta forma corta no puedo manipular el get y set.

        //private float precio;
        public float Precio { get; set; }

        private int codMarca;
        public int CodigoMarca
        {
            get { return codMarca; }
            set
            {
                if (value > 0 && value < 11)
                    codMarca = value;
                else
                    codMarca = -1;
            }
            // esta es la forma 'larga' que si se puede cargar modificando get y set.
        }





    }
}
