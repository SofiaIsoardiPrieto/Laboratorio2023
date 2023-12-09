using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Entidades.Entidades
{
    public class Resultado:ICloneable
    {
        public int ResultadoId { get; set; }
        public int ProtocoloId { get; set; }
        public int ExamenesPruebasId { get; set; }
        public string ResultadoPrueba { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
}
