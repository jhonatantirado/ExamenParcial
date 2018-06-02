using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcialADS.DirtyCode
{
    class FailFastReturnEarly
    {
        public void validarNumeroContenedor(string contenedor)
        {
            if (contenedor != null)
            {
                if (contenedor.Length == 11)
                {
                    if (contenedor.Substring(0, 4) == "MSCU")
                    {
                        Console.WriteLine("Prefijo inválido");
                    }
                    else
                    {
                        Console.WriteLine("Número de contenedor nválido");
                    }
                }
                else
                {
                    Console.WriteLine("Debe tener 11 digitos");
                }
            }
            else
            {
                Console.WriteLine("No se permite nulos");
            }
        }
    }
}
