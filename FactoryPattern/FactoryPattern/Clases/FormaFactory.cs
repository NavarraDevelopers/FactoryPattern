using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Clases
{
    public class FormaFactory
    {
        public IForma ObtenerForma(string tipoForma)
        {
            if(tipoForma == null)
            {
                return null;
            }

            if(tipoForma.Equals("CUADRADO", StringComparison.CurrentCultureIgnoreCase))
            {
                return new Cuadrado();
            }

            else if(tipoForma.Equals("TRIANGULO", StringComparison.CurrentCultureIgnoreCase))
            {
                return new Triangulo();
            }

            else if(tipoForma.Equals("CIRCULO", StringComparison.CurrentCultureIgnoreCase))
            {
                return new Circulo();
            }

            return null;
        }
    }
}
