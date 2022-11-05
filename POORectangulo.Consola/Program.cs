using POORectángulo.Datos;
using POORectángulo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POORectangulo.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositorioDeRectangulos repo = new RepositorioDeRectangulos();
            var rectangulo = new Rectangulo(2,4);

            if (rectangulo.Validar())
            {
                repo.Agregar(rectangulo);
                Console.WriteLine($"La cantidad de Rectangulos es {repo.GatCantidad()}");
                Console.WriteLine($"El area del rectángulo es {rectangulo.GetArea().ToString("N2")}");
                Console.WriteLine($"El Perimetro del rectángulo es {rectangulo.GetPerimetro().ToString("N2")}");
            }
            else
            {
                Console.WriteLine("La base y la altura debe ser mayor a 0");
            }
            var lista = repo.GetLista();
            MostrarLista(lista);
            Console.ReadLine();
        }

        private static void MostrarLista(List<Rectangulo> lista)
        {
            foreach (var Rect in lista)
            {
                Console.WriteLine($"El alto es de {Rect.Alto}");
                Console.WriteLine($"El largo es de {(Rect.Largo)}");
            }
        }
    }
}
