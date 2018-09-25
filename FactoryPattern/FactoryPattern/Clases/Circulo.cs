using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Clases
{
    public class Circulo : IForma
    {
        public void Pintar()
        {
            Console.WriteLine("Circulo.");
        }
    }
}
