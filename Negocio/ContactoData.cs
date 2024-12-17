using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Dominios;

namespace Negocio
{
    public class ContactoData
    {
        public List<Contacto> listar()
        {

            List<Contacto> listaContacto = new List<Contacto>();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT ContactoID, Nombre, Telefono,Email,Direccion,FechaCreacion FROM Contactos");

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Contacto aux = new Contacto();

                    aux.Id = (int)datos.Lector["ContactoID"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Telefono = (string)datos.Lector["Telefono"];
                    aux.Email = (string)datos.Lector["Email"];
                    aux.Direccion = (string)datos.Lector["Direccion"];
                    aux.FechaCreacion = (DateTime)datos.Lector["FechaCreacion"];
      
                    listaContacto.Add(aux);
                }

                return listaContacto;

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
        
        public void AgregarContacto(Contacto nuevo)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearConsulta("insert into Contactos(Nombre,Telefono,Email,Direccion) values(@Nombre,@Telefono,@Email,@Direccion)");
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Telefono", nuevo.Telefono);
                datos.setearParametro("@Email", nuevo.Email);
                datos.setearParametro("@Direccion", nuevo.Direccion);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { 
            
                datos.cerrarConexion();
            
            }

        }

        public void modificar(Contacto cont)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearConsulta("update Contactos set Nombre = @Nombre,Telefono = @Telefono,Email = @Email,Direccion = @Direccion WHERE ContactoID = @ContactoID");
                datos.setearParametro("@Nombre", cont.Nombre);
                datos.setearParametro("@Telefono", cont.Telefono);
                datos.setearParametro("@Email", cont.Email);
                datos.setearParametro("@IdMarca", cont.Direccion);
            
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

    }
}
