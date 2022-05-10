using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectanguloSuperfiPerimGenericos.clases
{
    partial class Rectangulo
    {

        public int RetornarSuperficie()
        {
            int resultadoS = lado1 * lado2;
            return resultadoS;
        }

        public int RetornarPerimetro()
        {
            int resultadoP = lado1 * 2 + lado2 * 2;
            return resultadoP;
        }
    }
}
