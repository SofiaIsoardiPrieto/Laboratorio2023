using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Entidades.Entidades
{
    public class TipoMedicion:ICloneable
    {
        public int TipoMedicionId { get; set; }
        public string NombreMedicion { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
