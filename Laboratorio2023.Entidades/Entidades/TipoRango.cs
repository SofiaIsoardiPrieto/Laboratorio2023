using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Entidades.Entidades
{
    public class TipoRango:ICloneable
    {
        public int TipoRangoId { get; set; }    
        public string NombreTipoRango { get; set; }


        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
