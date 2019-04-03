using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INV01.DO.DATA;
using INV01.UI.Clases;

namespace INV01.UI.Clases
{
    public class Acceso
    {
        public string user { get; set; }
        public string pass { get; set; }

        public Respuesta<Acceso> Acceder()
        {
            Respuesta<Acceso> result = new Respuesta<Acceso>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un error en base de datos";
            result.data = new Acceso();

            try
            {
                using (var db= new EntitiesINV01())
                {
                    //SE CONSULTA LA PROPIEDAD "USER" EN BASE DE DATOS
                    var us = (from u in db.inv01_usuario
                              where u.usuario.ToUpper() == this.user.ToUpper()
                              && u.estado_registro == "A"
                              select u).SingleOrDefault();


                    if (us != null) //SI REGRESA VALOR, PROCEDE A VALIDAR PASSWORD
                    {
                        if (SEG01_DO.Encriptor.validarPassword(this.pass, us.password))
                        {
                            result.codigo = 0;
                            result.mensaje = "Bienvenido..!!!";
                        }
                        else
                        {
                            result.codigo = -2;
                            result.mensaje = "Password Invalido..!!!";
                        }
                    }
                    else
                    {
                        result.codigo = -2;
                        result.mensaje = "Usuario Invalido..!!!";
                    }                  
                }
                return result;
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una excepcion al intentar Acceder, ref: " + ex.ToString();
                return result;
            }
        }
    }
}
