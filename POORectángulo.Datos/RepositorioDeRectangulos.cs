using POORectángulo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POORectángulo.Datos
{
    public class RepositorioDeRectangulos
    {
        private List<Rectangulo> Listarectangulo;

        public RepositorioDeRectangulos()
        {
            Listarectangulo = new List<Rectangulo>();
            Listarectangulo = ManejadorArchivosSecuencial.LeerArchivoSecuencial();
        }
        public void Agregar(Rectangulo rectangulo)
        {
            Listarectangulo.Add(rectangulo);
        }
        public List<Rectangulo> GetLista()
        {
            return Listarectangulo;
        }
        public int GatCantidad()
        {
            return Listarectangulo.Count();
        }

        public bool Borrar(Rectangulo rect)
        {
            if (Listarectangulo.Contains(rect))
            {
                Listarectangulo.Remove(rect);
                return true;
            }
            return false;
        }

        public List<Rectangulo> FiltrarDatos(int rectFiltro)
        {
            return Listarectangulo.Where(c => c.GetPerimetro() > rectFiltro).ToList();
                        
        }

        public int GatCantidadFiltrada(int rectFiltro)
        {
            return Listarectangulo.Count(c => c.GetPerimetro() > rectFiltro);
        }
    }
}
