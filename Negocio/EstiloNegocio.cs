using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using negocio;

namespace Negocio
{
    public class EstiloNegocio
    {
        public List<Estilos> listar()
        {
			List<Estilos>lista=new List<Estilos>();
			AccesoDatos datos=new AccesoDatos();
			try
			{
				datos.setearConsulta("select Id, Descripcion from ESTILOS");
				datos.ejecutarLectura();
				while(datos.Lector.Read())
				{
					Estilos aux=new Estilos();
					aux.Id = (int)datos.Lector["Id"];
					aux.Descripcion=(string)datos.Lector["Descripcion"];

					lista.Add(aux);

				}
				return lista;
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				datos.cerrarConexion();
			}
        }
    }
}
