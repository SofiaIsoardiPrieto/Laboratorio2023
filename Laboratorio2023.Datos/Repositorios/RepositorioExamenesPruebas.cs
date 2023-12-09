using Dapper;
using Laboratorio2023.Datos.Infertaces;
using Laboratorio2023.Entidades.Entidades;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace Laboratorio2023.Datos.Repositorios
{
    public class RepositorioExamenesPruebas : IRepositorioExamenesPruebas
    {
        private readonly string cadenaConexion;
        public RepositorioExamenesPruebas()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
        public List<Examen> GetExamenes()
        {
            List<Examen> lista = new List<Examen>();
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string selectQuery = @"SELECT DISTINCT e.ExamenId, e.NombreExamen
                                        FROM Examenes e
                                        RIGHT JOIN ExamenesPruebas ep ON e.ExamenId = ep.ExamenId
                                        WHERE ep.ExamenPruebaId IS NOT NULL
                                        ORDER BY e.NombreExamen";
                lista = conn.Query<Examen>(selectQuery).ToList();
            }
            return lista;
        }
        public ExamenPrueba AddExamenPrueba(int examenId)
        {
            ExamenPrueba examenPrueba;

            using (var conn = new SqlConnection(cadenaConexion))
            {
                var query = @"
            SELECT 
                ep.ExamenPruebaId,
                ep.ExamenId,
                e.NombreExamen,
                p.PruebaId,
                p.NombrePrueba
            FROM ExamenesPruebas ep
             JOIN Examenes e ON ep.ExamenId = e.ExamenId
            LEFT JOIN Pruebas p ON ep.PruebaId = p.PruebaId
            WHERE ep.ExamenId = @examenId
            ORDER BY p.NombrePrueba";

                var examenesPruebaDict = new Dictionary<int, ExamenPrueba>();

                // Utilizamos Dapper para mapear los resultados a objetos
                var resultados = conn.Query<ExamenPrueba, Prueba, ExamenPrueba>(
                    query, (examenprueba, prueba) =>
                    {
                        ExamenPrueba examenPruebaEntry;
                        if (!examenesPruebaDict.TryGetValue(examenprueba.ExamenPruebaId, out examenPruebaEntry))
                        {
                            examenPruebaEntry = examenprueba;
                            examenPruebaEntry.Pruebas = new List<Prueba>();
                            examenesPruebaDict.Add(examenPruebaEntry.ExamenPruebaId, examenPruebaEntry);
                        }

                        if (prueba != null)
                        {
                            examenPruebaEntry.Pruebas.Add(prueba);
                        }

                        return examenPruebaEntry;
                    },
                    new { examenId },
                    splitOn: "PruebaId"  // Indica la columna en la que dividir los resultados
                );

                // Recuperamos la entidad ExamenPrueba resultante
                examenPrueba = resultados.FirstOrDefault();
            }

            return examenPrueba;

        }



        public ExamenPrueba GetExamenEditado(int examenId, List<Prueba> listaPrueba)
        {
            ExamenPrueba examenPrueba;

            using (var conn = new SqlConnection(cadenaConexion))
            {
                var query = @"
            SELECT 
                ep.ExamenPruebaId,
                ep.ExamenId,
                e.NombreExamen,
                p.PruebaId,
                p.NombrePrueba
            FROM ExamenesPruebas ep
             JOIN Examenes e ON ep.ExamenId = e.ExamenId
            LEFT JOIN Pruebas p ON ep.PruebaId = p.PruebaId
            WHERE ep.ExamenId = @examenId
            ORDER BY p.NombrePrueba";

                var examenesPruebaDict = new Dictionary<int, ExamenPrueba>();

                // Utilizamos Dapper para mapear los resultados a objetos
                var resultados = conn.Query<ExamenPrueba, Prueba, ExamenPrueba>(
                    query, (examenprueba, prueba) =>
                    {
                        ExamenPrueba examenPruebaEntry;
                        if (!examenesPruebaDict.TryGetValue(examenprueba.ExamenPruebaId, out examenPruebaEntry))
                        {
                            examenPruebaEntry = examenprueba;
                            examenPruebaEntry.Pruebas = new List<Prueba>();
                            examenesPruebaDict.Add(examenPruebaEntry.ExamenPruebaId, examenPruebaEntry);
                        }

                        if (prueba != null)
                        {
                            examenPruebaEntry.Pruebas.Add(prueba);
                        }

                        return examenPruebaEntry;
                    },
                    new { examenId },
                    splitOn: "PruebaId"  // Indica la columna en la que dividir los resultados
                );

                // Recuperamos la entidad ExamenPrueba resultante
                examenPrueba = resultados.FirstOrDefault();
                examenPrueba.Pruebas = listaPrueba;
            }

            return examenPrueba;
        }
    }
}
