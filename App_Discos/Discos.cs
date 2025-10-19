using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Discos
{
    internal class Discos
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime fechaLanzamiento { get; set; }
        public int cantidadCanciones { get; set; }
        public string urlImagen {  get; set; }

    }
}
