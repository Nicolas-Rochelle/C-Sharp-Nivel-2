using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace dominio
{
    public class Disco
    {
        public int id { get; set; }
        [DisplayName("Título")]
        public string Titulo { get; set; }

        [DisplayName("Cantidad de Canciones")] 
        public int CantidadCanciones { get; set; }
        [DisplayName("UrlImagenTapa")]
        public string UrlImagenTapa { get; set; }
        public Estilo Estilo { get; set; }
        public TipoEdicion Edicion { get; set; }




    }
}
