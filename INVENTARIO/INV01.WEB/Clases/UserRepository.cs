using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using INV01.DO.DATA;

namespace INV01.WEB.Clases
{
    public class UserRepository
    {
        public bool ValidateUser(string username, string password)
        {
            using (var db = new EntitiesINV01())
            {
                var result = from u in db.inv01_usuario
                             where (u.usuario.ToUpper() == username.ToUpper())
                             select u;

                if (result.Count() != 0)
                {
                    var dbuser = result.First();

                    if (SEG01_DO.Encriptor.validarPassword(password, dbuser.password))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }
        }
    }
}