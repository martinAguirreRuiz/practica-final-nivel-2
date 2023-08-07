using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class EstiloNegocio
    {
        List<Estilo> listaEstilos = new List<Estilo>();

        public List<Estilo> listarEstilo()
        {
            AccesoDatos datos = new AccesoDatos();
            

            try
			{
                datos.setearConsulta("Select Id, Descripcion from ESTILOS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Estilo aux = new Estilo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    listaEstilos.Add(aux);
                }

                return listaEstilos;
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
