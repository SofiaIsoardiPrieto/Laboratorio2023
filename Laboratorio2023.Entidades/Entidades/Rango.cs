using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Entidades.Entidades
{
    public class Rango:ICloneable
    {

        public int RangoId { get; set; }
        public int TipoRangoId { get; set; }
        public string RangoMinimo { get; set; }
        public string RangoMaximo { get; set; }
        public int TipoMedicionId { get; set; }
        public int PruebaId { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }


    }
}
