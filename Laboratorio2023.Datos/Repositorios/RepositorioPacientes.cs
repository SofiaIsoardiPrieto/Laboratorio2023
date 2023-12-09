using Dapper;
using Laboratorio2023.Datos.Infertaces;
using Laboratorio2023.Entidades;
using Laboratorio2023.Entidades.Combos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Datos.Repositorios
{
    public class RepositorioPacientes : IRepositorioPacientes
    {
        private readonly string cadenaConexion;
        public RepositorioPacientes()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
        public bool Existe(Paciente paciente)
        {
            var cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (paciente.PacienteId == 0)
                {
                    //cuando es nuevo el paciente y hay que agregar, ver si ya existe.

                    selectQuery = @"SELECT COUNT(*) FROM Pacientes 
                            WHERE Nombre=@Nombre AND Apellido=@Apellido";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, paciente);
                }
                else
                {
                    //cuando es una edicion y veo si ya existe el paciente.

                    selectQuery = @"SELECT COUNT(*) FROM Pacientes 
                           WHERE Nombre=@Nombre AND Apellido=@Apellido
                            AND PacienteId!=@PacienteId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, paciente);
                }
            }
            return cantidad > 0;
        }
        public void Agregar(Paciente paciente)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string insertQuery = @"INSERT INTO Pacientes (Nombre, Apellido, Telefono, Sexo, FechaNacimiento) 
                        VALUES(@Nombre, @Apellido, @Telefono, @Sexo, @FechaNacimiento); SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(insertQuery, paciente);
                paciente.PacienteId = id;
            }
        }

        public void Editar(Paciente paciente)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string updateQuery = @"UPDATE Pacientes SET Nombre=@Nombre,
                                Apellido=@Apellido, Telefono=@Telefono, 
                                Sexo=@Sexo, FechaNacimiento=@FechaNacimiento                                 
                                WHERE PacienteId=@PacienteId";
                conn.Execute(updateQuery, paciente);
            }
        }

      

        public int GetCantidad(string textoFiltro = null)
        {
            int cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (textoFiltro == null)
                {
                    selectQuery = @"SELECT COUNT(*) FROM Pacientes";
                    cantidad = conn.ExecuteScalar<int>(selectQuery);
                }
                else
                {
                    selectQuery = @"SELECT COUNT(*) FROM Pacientes  WHERE Apellido LIKE @textoFiltro + '%'";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, new { textoFiltro });
                }
            }
            return cantidad;
        }

        public List<Paciente> GetPacientesPorPagina(int cantidadPorPagina, int paginaActual, string textoFiltro = null)
        {
            List<Paciente> lista = new List<Paciente>();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (textoFiltro == null)
                {
                    selectQuery = @"SELECT *
                      FROM Pacientes
                      ORDER BY Apellido,Nombre
                      OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                    lista = conn.Query<Paciente>(selectQuery, new { cantidadRegistros, cantidadPorPagina }).ToList();
                }
                else
                {
                    selectQuery = @"SELECT *
                      FROM Pacientes
                      WHERE Apellido like @textoFiltro + '%'
                      ORDER BY Apellido,Nombre
                      OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                    lista = conn.Query<Paciente>(selectQuery, new { cantidadRegistros, cantidadPorPagina, textoFiltro }).ToList();
                }
            }
            return lista;
        }

        public void Borrar(int pacienteId)
        {
            using (var conn=new SqlConnection(cadenaConexion))
            {
                string deleteQuery = "DELETE FROM Pacientes WHERE PacienteId=@PacienteId";
                conn.Execute(deleteQuery, new { pacienteId });
            }
        }

        public List<PacienteCombo> GetPacientesCombo()
        {
            List<PacienteCombo> lista = new List<PacienteCombo>();

            using (var conn = new SqlConnection(cadenaConexion))
            {

                string selectQuery = @"SELECT PacienteId, CONCAT(Apellido,', ',Nombre) as NombreCompleto
                            FROM Pacientes
                            ORDER BY NombreCompleto";
                lista = conn.Query<PacienteCombo>(selectQuery).ToList();
            }
            return lista;
        }
    }
}
