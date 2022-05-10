using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rectanguloSuperfiPerimGenericos.clases;

namespace rectanguloSuperfiPerimGenericos.clases
{
     partial class Rectangulo
    {
        public int lado1 { get; set; }
        public int lado2 { get; set; }

        public Rectangulo(int lado1, int lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }


    }
}
