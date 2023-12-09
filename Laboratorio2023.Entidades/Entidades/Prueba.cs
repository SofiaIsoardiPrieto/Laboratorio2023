using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Entidades.Entidades
{
    public class Prueba:ICloneable
    {
        public int PruebaId { get; set; }
        public string NombrePrueba { get; set; }
        public string Caracteristicas { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
}
