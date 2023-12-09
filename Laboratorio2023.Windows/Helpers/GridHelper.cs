using Laboratorio2023.Entidades;
using Laboratorio2023.Entidades.Combos;
using Laboratorio2023.Entidades.Dto;
using Laboratorio2023.Entidades.Dtos;
using Laboratorio2023.Entidades.Entidades;
using System.Windows.Forms;

namespace Laboratorio2023.Windows.Helpers
{
    public static class GridHelper
    {
        public static void LimpiarGrilla(DataGridView grilla)
        {
            grilla.Rows.Clear();
        }
        public static DataGridViewRow ConstruirFila(DataGridView grilla)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(grilla);
            return r;
        }
        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case Paciente paciente:
                    r.Cells[0].Value = $"{paciente.Apellido}, {paciente.Nombre}";
                    //r.Cells[0].Value = paciente.ToString();
                    r.Cells[1].Value = paciente.Telefono;
                    r.Cells[2].Value = paciente.Sexo;
                    r.Cells[3].Value = $"{paciente.FechaNacimiento.Day}/{paciente.FechaNacimiento.Month}/{paciente.FechaNacimiento.Year}";
                    break;
                case ResultadoDto resultadoDto:
                    r.Cells[0].Value = resultadoDto.NombrePrueba;
                    r.Cells[1].Value = resultadoDto.ResultadoPrueba;
                    r.Cells[2].Value = resultadoDto.NombreRango;
                    break;
                case Examen examen:
                    r.Cells[0].Value = examen.NombreExamen;
                    break;
                case Protocolo protocolo:
                    r.Cells[0].Value = protocolo.NombrePaciente;
                    r.Cells[1].Value = $"{protocolo.FechaRealizacion.Day}/{protocolo.FechaRealizacion.Month}/{protocolo.FechaRealizacion.Year}";
                    r.Cells[2].Value = protocolo.NombreMedico;
                    break;
                case PruebaCombo prueba:
                    r.Cells[0].Value = prueba.NombrePrueba;
                    break;               
                case PruebaDto pruebaDto:
                    r.Cells[0].Value = pruebaDto.NombrePrueba;
                    r.Cells[1].Value = pruebaDto.NombreExamen;
                    r.Cells[2].Value = pruebaDto.Rango;
                    r.Cells[3].Value = pruebaDto.TipoRango;
                    break;
                case TipoRango tipoRango:
                    r.Cells[0].Value = tipoRango.NombreTipoRango;
                    break;
                case TipoMedicion tipoMedicion:
                    r.Cells[0].Value = tipoMedicion.NombreMedicion;
                    break;
                case RangoDto rangoDto:
                    r.Cells[0].Value = rangoDto.Rango;
                    r.Cells[1].Value = rangoDto.NombreTipoRango;
                    r.Cells[2].Value = rangoDto.NombrePrueba;
                    r.Cells[3].Value = rangoDto.NombreMedicion;
                    break;     
            }
            r.Tag = obj;
        }
        internal static void AgregarFila(DataGridView grilla, DataGridViewRow r)
        {
            grilla.Rows.Add(r);
        }
        public static void QuitarFila(DataGridView grilla, DataGridViewRow r)
        {
            grilla.Rows.Remove(r);
        }
    }
}
