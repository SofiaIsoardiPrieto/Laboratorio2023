using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Entidades.Entidades
{
    public class Examen:ICloneable
    {
        public int ExamenId { get; set; }
        public string NombreExamen { get; set; }
       


        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
