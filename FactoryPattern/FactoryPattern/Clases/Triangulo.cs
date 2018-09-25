using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Clases
{
    public class Triangulo : IForma
    {
        public void Pintar()
        {
            Console.WriteLine("Triangulo");
        }
    }
}
