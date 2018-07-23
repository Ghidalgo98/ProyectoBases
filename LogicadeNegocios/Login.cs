using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace LogicadeNegocios
{
    public class Login
    {
        Datos.DB data;
       public bool loggin(String login, string pass)
        {
            try
            {
                data = new DB();
                data.Iniclogin(login, pass);

                if (data.Iniclogin(login, pass) == false)
                {
                    return true;

                }
                else
                    return false;


            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
