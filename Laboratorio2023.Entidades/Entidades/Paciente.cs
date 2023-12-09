using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Entidades
{
    public class Paciente:ICloneable
    {
        public int PacienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }


        public int GetEdad(DateTime FechaNacimiento)
        {
            var edad = DateTime.Today.Year - FechaNacimiento.Year;
            if (FechaNacimiento.AddYears(edad) > DateTime.Today)
            {
                edad--;
            }

            return edad;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

       

    }
}
