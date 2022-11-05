using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POORectángulo.Entidades
{
    public class Rectangulo
    {
        public int Largo { get; set; }
        public int Alto { get; set; }

        public Rectangulo()
        {

        }
        public Rectangulo(int largo, int alto)
        {
            Largo = largo;
            Alto = alto;
        }

        public int GetArea()
        {
            return Largo * Alto;
        }
        public int GetPerimetro()
        {
            return (int)Math.Pow(Largo, 2) + (int)Math.Pow(Alto, 2);

        }
        public bool Validar()
        {
            return Largo>0 && Alto>0;
        }
    }
}
