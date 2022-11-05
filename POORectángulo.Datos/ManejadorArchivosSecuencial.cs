using POORectángulo.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POORectángulo.Datos
{
    public static class ManejadorArchivosSecuencial
    {
        public static void GuardarEnArchivosSecuencial(List<Rectangulo> lista)
        {
            //Creo el objeto que va a escribir en el archivo secuencial
            using (var escritor = new StreamWriter("Archivo.txt"))
            {
                //Recorro la lista de circunferencial
                foreach (var rect in lista)
                {
                    //Creo la linea
                    string linea = ConstruirLinea(rect);
                    escritor.WriteLine(linea);
                }
            }
        }
        public static List<Rectangulo> LeerArchivoSecuencial()
        {
            List<Rectangulo> lista = new List<Rectangulo>();
            using (var lector = new StreamReader("Archivo.txt"))
            {
                while (!lector.EndOfStream)//Mientras no sea fin de archivo, va a continuar leyendo
                {
                    string linea = lector.ReadLine();
                    Rectangulo rect = ConstruirRectangulo(linea);
                    lista.Add(rect);
                }
                
            }
            return lista;
        }

        private static Rectangulo ConstruirRectangulo(string linea)
        {
            //Descompongo la linea en un array de strings con los campos
            return new Rectangulo() { Alto = int.Parse(linea) };
            //var campos = linea.Split(linea, separator:);
            //PERDÓN PROFE, NO LO LOGRE HACER CON EL SPLIT
            
        }

        private static string ConstruirLinea(Rectangulo rect)
        {
            return $"{rect.Alto} ";
        }
    }
}
