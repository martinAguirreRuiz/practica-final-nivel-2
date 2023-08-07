using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class TipoEdicionNegocio
    {
        List<TipoEdicion> listaEdicion = new List<TipoEdicion>();
        public List<TipoEdicion> listarEdicion()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, Descripcion from TIPOSEDICION");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    TipoEdicion aux = new TipoEdicion();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    
                    listaEdicion.Add(aux);
                }

                return listaEdicion;
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
