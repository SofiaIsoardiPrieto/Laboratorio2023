using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Entidades.Entidades
{
    public class Protocolo : ICloneable
    {
        public int ProtocoloId { get; set; }
        public int PacienteId { get; set; }
        public string NombrePaciente { get; set; }
        public DateTime FechaRealizacion { get; set; }
        public int MedicoId { get; set; }
        public string NombreMedico { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        
    }
}
