using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Clases;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos factory que se encargara de la creacion de otros objetos
            FormaFactory formaFactory = new FormaFactory();

            //Instanciamos un objeto pasandole el string del objeto que queremos crear al factory
            //Es de tipo IForma porque los objetos de forma implementan esa interfaz
            IForma cuadrado = formaFactory.ObtenerForma("CUADRADO");
            //llamamos al metodo pintar creado en el contrato del interfaz e implementado en la clase
            cuadrado.Pintar();
            
            IForma circulo = formaFactory.ObtenerForma("CIRCULO");
            circulo.Pintar();

            
            IForma triangulo = formaFactory.ObtenerForma("TRIANGULO");
            triangulo.Pintar();
        }
    }
}
