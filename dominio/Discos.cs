using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dominio
{ 
public class Discos
    {
    public int Id { get; set; }

        [DisplayName("Título")]
    public string Titulo { get; set; }
        [DisplayName("Fecha Lanzamiento")]
    public DateTime fechaLanzamiento { get; set; }
    public int cantidadCanciones { get; set; }
    public string urlImagen { get; set; }
    public Estilos IdEstilos { get; set; }
    public TipoEdicion IdTipoEdicion { get; set; }



    }
}
