using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Entidades.Dtos
{
    public class PruebaDto:ICloneable
    {


        public int PruebaId { get; set; }
        public string NombrePrueba { get; set; }
        public string NombreExamen { get; set; }
        public string Rango { get; set; }
        public string TipoRango { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
