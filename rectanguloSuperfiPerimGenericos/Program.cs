using System;
using rectanguloSuperfiPerimGenericos.clases;

namespace rectanguloSuperfiPerimGenericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangulo r = new Rectangulo(2,4);
            int area = r.RetornarSuperficie();
            Console.Write(area);

            int perimetro = r.RetornarPerimetro();
            Console.WriteLine(perimetro);
            
        }
    }
}
