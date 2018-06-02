using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcialADS.CleanCode
{
    class FailFastReturnEarly
    {
        public void validarNumeroContenedor(string contenedor)
        {
            if (contenedor == null)
            {
                Console.WriteLine("No se permite nulos");
                return;
            }

            if (contenedor.Length != 11)
            {
                Console.WriteLine("Debe tener 11 digitos");
                return;
            }

            if (contenedor.Substring(0, 4) == "MSCU")
            {
                Console.WriteLine("Número de contenedor inválido");
                return;
            }

            Console.WriteLine("Número de contenedor válido");

        }
    }
}
