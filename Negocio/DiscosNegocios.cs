using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using dominio;
using Negocio;

namespace negocio
{
     public class DiscosNegocios
    {
        public List<Discos>listar()
        {
            List<Discos>lista=new List<Discos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=DESKTOP-PHQLRTP;database=DISCOS_DB;integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                //comando.CommandText = "Select Id,Titulo,FechaLanzamiento,CantidadCanciones From DISCOS;\r\n";
                //comando.CommandText="Select Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa From DISCOS;";
                comando.CommandText = "Select D.Id,D.Titulo,D.FechaLanzamiento,D.CantidadCanciones,D.UrlImagenTapa,E.Descripcion,TE.Descripcion From DISCOS D, ESTILOS E, TIPOSEDICION TE\r\nWhere D.IdEstilo=E.Id And D.IdTipoEdicion=TE.Id";
                comando.Connection= conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while(lector.Read())
                {
                    Discos aux= new Discos();
                    aux.Id = lector.GetInt32(0);
                    aux.Titulo = (string)lector["Titulo"];
                    aux.fechaLanzamiento = (DateTime)lector["FechaLanzamiento"];
                    aux.cantidadCanciones = lector.GetInt32(3);
                    aux.urlImagen = (string)lector["UrlImagenTapa"];
                    aux.IdEstilos=new Estilos();
                    aux.IdEstilos.Descripcion = (string)lector["Descripcion"];
                    aux.IdTipoEdicion=new TipoEdicion();
                    aux.IdTipoEdicion.Descripcion = (string)lector["Descripcion"];

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }

            

        }

        public void agregar(Discos nuevo)
        {
            AccesoDatos datos= new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into DISCOS (Titulo,FechaLanzamiento,CantidadCanciones,IdEstilo,IdTipoEdicion) values ('" + nuevo.Titulo + "', '" + nuevo.fechaLanzamiento + "', " + nuevo.cantidadCanciones + ",@IdEstilo,@IdTipoEdicion)");
                datos.setearParametro("@IdEstilo", nuevo.IdEstilos.Id);
                datos.setearParametro("@IdTipoEdicion", nuevo.IdTipoEdicion.Id);

                datos.ejecutarAccion();
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

        public void modificar(Discos modificar)
        {

        }
    }


    
}
