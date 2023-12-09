using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Entidades.Dtos
{
    public class RangoDto: ICloneable
    {

        public int RangoId { get; set; }
        public int ExamenPruebaId { get; set; }
        public string Rango { get; set; }
       
        public string NombreTipoRango { get; set; }
        public string NombrePrueba { get; set; }
        public string NombreMedicion { get; set; }
      
        
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
