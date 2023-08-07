using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class DiscoNegocio
    {
        public List<Disco> listarDiscos()
        {
            List<Disco> list = new List<Disco>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select D.Id as Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion as Estilo, T.Descripcion as TipoEdicion from DISCOS D, ESTILOS E, TIPOSEDICION T where IdEstilo = E.Id and IdTipoEdicion = T.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];

                    if (datos.Lector["UrlImagenTapa"] != null)
                    {
                        aux.UrlImagen = (string)datos.Lector["UrlImagenTapa"];
                    }

                    aux.Estilo = new Estilo();
                    aux.Estilo.Descripcion = (string)datos.Lector["Estilo"];
                    aux.TipoEdicion = new TipoEdicion();
                    aux.TipoEdicion.Descripcion = (string)datos.Lector["TipoEdicion"];

                    list.Add(aux);
                }

                return list;

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

        public void agregarDisco(Disco nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into Discos (Titulo, CantidadCanciones, FechaLanzamiento, UrlImagenTapa, IdEstilo, IdTipoEdicion) values (@titulo, @cantidad, @fecha, @imagen, @idEstilo, @idEdicion)");
                datos.setearParametro("@titulo", nuevo.Titulo);
                datos.setearParametro("@cantidad", nuevo.CantidadCanciones);
                datos.setearParametro("@fecha", nuevo.FechaLanzamiento);
                datos.setearParametro("@imagen", nuevo.UrlImagen);
                datos.setearParametro("@idEstilo", nuevo.Estilo.Id);
                datos.setearParametro("@idEdicion", nuevo.TipoEdicion.Id);
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

        public void modificarDisco(Disco modificado)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Update Discos set Titulo = @titulo, FechaLanzamiento = @fecha, CantidadCanciones = @canciones, UrlImagenTapa = @imagen, IdEstilo = @idEstilo, IdTipoEdicion = @idTipoEdicion where id = @id");
                datos.setearParametro("@titulo", modificado.Titulo);
                datos.setearParametro("@fecha", modificado.FechaLanzamiento);
                datos.setearParametro("@canciones", modificado.CantidadCanciones);
                datos.setearParametro("@imagen", modificado.UrlImagen);
                datos.setearParametro("@idEstilo", modificado.Estilo.Id);
                datos.setearParametro("@idTipoEdicion", modificado.TipoEdicion.Id);
                datos.setearParametro("@id", modificado.Id);

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

        public void eliminarDisco(Disco eliminado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete from Discos where id = @id");
                datos.setearParametro("@id", eliminado.Id);
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

        public List<Disco> filtrar(string campo, string criterio, string texto)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Disco> list = new List<Disco>();
            try
            {

                string consulta = "Select D.Id as Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, E.Descripcion as Estilo, T.Descripcion as TipoEdicion from DISCOS D, ESTILOS E, TIPOSEDICION T where IdEstilo = E.Id and IdTipoEdicion = T.Id and ";
                if (campo == "Título")
                {
                    consulta += "Titulo like ";

                    switch (criterio)
                    {
                        case "Empieza con":

                            consulta += "'" + texto + "%'";

                            break;

                        case "Termina con":

                            consulta += "'%" + texto + "'";

                            break;

                        default:
                            
                            consulta += "'%" + texto + "%'";
                            
                            break;
                    }
                }
                else if (campo == "Fecha de Lanzamiento")
                {

                    consulta += "FechaLanzamiento ";

                    switch (criterio)
                    {
                        case "Antes de":

                            consulta += "< @parametro";

                            break;

                        case "Después de":
                            
                            consulta += "> @parametro";

                            break;

                        default:
                            
                            consulta += "= @parametro";

                            break;
                    }
                }
                else
                {
                    consulta += "CantidadCanciones ";

                    switch (criterio)
                    {
                        case "Más de":
                            
                            consulta += "> @parametro";

                            break;

                        case "Menos de":
                            
                            consulta += "< @parametro";

                            break;

                        default:
                            
                            consulta += "= @parametro";

                            break;
                    }
                }
                datos.setearConsulta(consulta);
                datos.setearParametro("@parametro", texto);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];

                    if (datos.Lector["UrlImagenTapa"] != null)
                    {
                        aux.UrlImagen = (string)datos.Lector["UrlImagenTapa"];
                    }

                    aux.Estilo = new Estilo();
                    aux.Estilo.Descripcion = (string)datos.Lector["Estilo"];
                    aux.TipoEdicion = new TipoEdicion();
                    aux.TipoEdicion.Descripcion = (string)datos.Lector["TipoEdicion"];

                    list.Add(aux);
                }

                return list;
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
