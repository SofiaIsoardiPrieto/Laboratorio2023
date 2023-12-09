using Dapper;
using Laboratorio2023.Datos.Infertaces;
using Laboratorio2023.Entidades.Entidades;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Laboratorio2023.Datos.Repositorios
{
    public class RepositorioExamenes : IRepositorioExamenes
    {

        private readonly string cadenaConexion;
        public RepositorioExamenes()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }

        public void Agregar(Examen examen)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string addQuery = @"INSERT INTO Examenes (NombreExamen)                                    
                                VALUES (@NombreExamen)
                                SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(addQuery, examen);
                examen.ExamenId = id;
            }
        }

        public void Borrar(int examenId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string deleteQuery = @"DELETE FROM Examenes 
                        WHERE ExamenId=@ExamenId";

                conn.Execute(deleteQuery, examenId);

            }
        }

        public void Editar(Examen examen)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string updateQuery = @"UPDATE Examenes SET NombreExamen=@NombreExamen                                  
                                WHERE ExamenId=@ExamenId";
                conn.Execute(updateQuery, examen);
            }
        }

        public bool EstaRelacionado(int examenId)
        {
            int cantidad = 0;
            using (IDbConnection conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = "SELECT COUNT(*) FROM ExamenesPruebas WHERE ExamenId=@ExamenId";
                cantidad = conn.QuerySingle<int>(selectQuery, examenId);
            }
            return cantidad > 0;
        }

        public bool Existe(Examen examen)
        {
            var cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (examen.ExamenId == 0)
                {
                    selectQuery = @"SELECT COUNT(*) FROM Examenes 
                            WHERE NombreExamen=@NombreExamen";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, examen);
                }
                else
                {
                    selectQuery = @"SELECT COUNT(*) FROM Examenes 
                           WHERE NombreExamen=@NombreExamen 
                            AND ExamenId!=@ExamenId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, examen);
                }
            }
            return cantidad > 0;
        }

        public int GetCantidad(string textoFiltro)
        {
            int cantidad = 0;

            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (textoFiltro != null)
                {
                    selectQuery = @"SELECT COUNT(*) 
                    FROM Examenes 
                    WHERE NombreExamen LIKE @textoFiltro + '%'";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, new { textoFiltro });
                }
                else
                {
                    selectQuery = @"SELECT COUNT(*) FROM Examenes";
                    cantidad = conn.ExecuteScalar<int>(selectQuery);
                }

            }
            return cantidad;
        }

        public List<Examen> GetExamenesPorPagina(int cantidadPorPagina, int paginaActual, string textoFiltro)
        {
            List<Examen> lista = new List<Examen>();

            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (textoFiltro == null)
                {
                    selectQuery = @"SELECT e.NombreExamen,p.NombrePrueba,CONCAT(r.RangoMinimo,', ', r.RangoMaximo)as NombreRango, t.NombreTipoRango
                            FROM Pruebas p join ExamenesPruebas ep on p.PruebaId=ep.PruebaId
                            join Examenes e on e.ExamenId=ep.ExamenId
                            join Rangos r on r.ExamenPruebaId=ep.ExamenPruebaId
                            join TipoRangos t on t.TipoRangoId=r.TipoRangoId
                            ORDER BY NombrePrueba	
                            OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                    lista = conn.Query<Examen>(selectQuery, new { cantidadRegistros, cantidadPorPagina }).ToList();
                }
                else
                {
                    selectQuery = @"SELECT e.NombreExamen,p.NombrePrueba,CONCAT(r.RangoMinimo,', ', r.RangoMaximo)as NombreRango, t.NombreTipoRango
                            FROM Pruebas p join ExamenesPruebas ep on p.PruebaId=ep.PruebaId
                            join Examenes e on e.ExamenId=ep.ExamenId
                            join Rangos r on r.ExamenPruebaId=ep.ExamenPruebaId
                            join TipoRangos t on t.TipoRangoId=r.TipoRangoId
                            WHERE e.NombreExamen like @textoFiltro + '%'
                            ORDER BY e.NombreExamen
                            OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                    lista = conn.Query<Examen>(selectQuery, new { cantidadRegistros, cantidadPorPagina, textoFiltro }).ToList();
                }
            }
            return lista;
        }
    }
}
