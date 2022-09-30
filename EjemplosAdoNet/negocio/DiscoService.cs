using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{

    public class DiscoService
    { //Conexion a base de datos//
        public List<Disco> Listar()
        {
            List<Disco> lista = new List<Disco>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true; ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select  D.id, D.Titulo, D.CantidadCanciones , D.UrlImagenTapa , E.Descripcion Estilo,T.Descripcion Edicion, D.IdEstilo, D.IdTipoEdicion From DISCOS D ,ESTILOS E , TIPOSEDICION T where D.IdEstilo = E.Id and T.Id = D.IdTipoEdicion";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Disco aux = new Disco();
                    aux.id = lector.GetInt32(0);
                    aux.Titulo = (string)lector["Titulo"];
                    aux.CantidadCanciones = lector.GetInt32(2);
                    if (!(lector["UrlImagenTapa"] is DBNull))
                         aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];

                    aux.Estilo = new Estilo();
                    aux.Estilo.id = (int)lector["IdEstilo"];
                    aux.Estilo.Descripcion = (string)lector["Estilo"];
                    aux.Edicion = new TipoEdicion();
                    aux.Edicion.id = (int)lector["IdTipoEdicion"];
                    aux.Edicion.Descripcion = (string)lector["Edicion"];

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

        public void agregar(Disco nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into DISCOS (Titulo , CantidadCanciones, UrlImagenTapa, IdEstilo, IdTipoEdicion )values('" + nuevo.Titulo + "','" + nuevo.CantidadCanciones + "','" + nuevo.UrlImagenTapa + "',@idEstilo, @idTipoEdicion)");
                datos.setearParametro("@idEstilo", nuevo.Estilo.id);
                datos.setearParametro("@idTipoEdicion", nuevo.Edicion.id);
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

        public void modificar(Disco disk)
        {   AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update DISCOS set Titulo = @Titulo, CantidadCanciones = @CantidadCanciones, UrlImagenTapa = @UrlImagenTapa, IdEstilo = @IdEstilo , IdTipoEdicion = @IdTipoEdicion where id = @id");
                datos.setearParametro("@Titulo", disk.Titulo);
                datos.setearParametro("@CantidadCanciones", disk.CantidadCanciones);
                datos.setearParametro("@UrlImagenTapa", disk.UrlImagenTapa);
                datos.setearParametro("@IdEstilo", disk.Estilo.id);
                datos.setearParametro("@IdTipoEdicion", disk.Edicion.id);
                datos.setearParametro("id", disk.id);


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
        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from DISCOS where id = @id");
                datos.setearParametro("id",id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Disco> filtrar(string campo, string criterio, string filtro)
        {   
            List<Disco> lista = new List<Disco>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select  D.id, D.Titulo, D.CantidadCanciones , D.UrlImagenTapa , E.Descripcion Estilo,T.Descripcion Edicion, D.IdEstilo, D.IdTipoEdicion From DISCOS D ,ESTILOS E , TIPOSEDICION T where D.IdEstilo = E.Id and T.Id = D.IdTipoEdicion And ";
                switch (campo)
                {
                    case "CantidadCanciones":
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += "D.CantidadCanciones > " + filtro;
                                break;
                            case "Menor a":
                                consulta += "D.CantidadCanciones < " + filtro;
                                break;
                            default:
                                consulta += "D.CantidadCanciones = " + filtro;
                                break;
                        }
                        break;

                    case "Titulo":
                        switch (criterio)
                        {
                            case "Comienza Con":
                                consulta += "D.Titulo like '" + filtro+ "%' ";
                                break;
                            case "Termina Con":
                                consulta += "D.Titulo like '%" +filtro+ "'";
                                break ;
                            
                            default:
                                consulta += "D.Titulo like '%"+filtro+"%'";
                                break;
                        }
                        break;

                    default:
                        switch (criterio)
                        {
                            case "Comienza Con":
                                consulta += "E.Descripcion like '" + filtro + "%' ";
                                break;
                            case "Termina Con":
                                consulta += "E.Descripcion like '%" + filtro + "'";
                                break;

                            default:
                                consulta += "E.Descripcion like '%" + filtro + "%'";
                                break;

                        }
                        break;
                    
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.id = datos.Lector.GetInt32(0);
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.CantidadCanciones = datos.Lector.GetInt32(2);
                    if (!(datos.Lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];

                    aux.Estilo = new Estilo();
                    aux.Estilo.id = (int)datos.Lector["IdEstilo"];
                    aux.Estilo.Descripcion = (string)datos.Lector["Estilo"];
                    aux.Edicion = new TipoEdicion();
                    aux.Edicion.id = (int)datos.Lector["IdTipoEdicion"];
                    aux.Edicion.Descripcion = (string)datos.Lector["Edicion"];

                    lista.Add(aux);

                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void eliminarLogico(int id) 
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta(""); //consulta a db
                datos.setearParametro("id",id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
            
}   }
