using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcialADS.DirtyCode
{
    class User
    {
        string userName;
        string password;
        bool isLoggedIn;

        public void  validarLogin()
        {
            if (!this.isLoggedIn)
            {
                Console.WriteLine("No está logeado");
            }
            else
            {
                Console.WriteLine("Sí está logeado");
            }
        }
    }
}
