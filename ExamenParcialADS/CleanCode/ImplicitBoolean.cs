using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcialADS.CleanCode
{
    class User
    {
        string userName;
        string password;
        bool isLoggedIn;

        public void  validarLogin()
        {
            if (isLoggedIn)
            {
                Console.WriteLine("Sí está logeado");                
            }
            else
            {
                Console.WriteLine("No está logeado");
            }

        }
    }
}
