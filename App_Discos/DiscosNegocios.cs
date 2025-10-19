using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Discos
{
    internal class DiscosNegocios
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
                comando.CommandText="Select Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa From DISCOS;";
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
    }
}
