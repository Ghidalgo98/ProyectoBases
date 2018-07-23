using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DB
    {
        public bool Iniclogin(string Usuario, string pass)
        {
            dbuasjEntities obj;
            obj = new dbuasjEntities();
            var udsuario = obj.usuario.FirstOrDefault(u => u.Nombre_de_Usuario == Usuario && u.Contraseña == pass);
            if (udsuario != null)
            {
                return true;
                
            }
            return false;

            }

            
        }
    }

