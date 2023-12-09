using Dapper;
using Laboratorio2023.Datos.Infertaces;
using Laboratorio2023.Entidades.Dto;
using Laboratorio2023.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Datos.Repositorios
{
    public class RepositorioResultados:IRepositorioResultados
    {
        private readonly string cadenaConexion;
        public RepositorioResultados()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
        // deberia agre
        public void Agregar(Resultado resultado)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string addQuery = @"INSERT INTO Resultados (ResultadoPrueba)
                                VALUES (@ResultadoPrueba)
                                SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(addQuery, resultado);
                resultado.ProtocoloId = id;
            }
        }

        public void Borrar(int resultadoId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string deleteQuery = "DELETE FROM Resultados WHERE ProtocoloId=@ProtocoloId";
                conn.Execute(deleteQuery);
            }
        }

        public void CrearAnalisis(int ProtocoloId, List<ExamenPrueba> examenPruebas)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();

                foreach (var examenPrueba in examenPruebas)
                {
                    foreach (var prueba in examenPrueba.Pruebas)
                    {
                        // Insertar un registro en la tabla Resultados para cada prueba
                        string insertQuery = @"INSERT INTO Resultados (ProtocoloId, ExamenesPruebasId, ResultadoPrueba)
                                       VALUES (@ProtocoloId, @ExamenesPruebasId, NULL)";
                        conn.Execute(insertQuery, new { ProtocoloId, ExamenesPruebasId = examenPrueba.ExamenPruebaId });
                    }
                }
            }
        }
        //verificar
        public void Editar(Resultado resultado)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string updateQuery = @"UPDATE Resultados SET ResultadoPrueba=@ResultadoPrueba,
                                ProtocoloId=@ProtocoloId,
								ExamenesPruebasId=@ExamenesPruebasId 
                                WHERE ResultadoId=@ResultadoId";
                conn.Execute(updateQuery, resultado);
            }
        }

        public bool Existe(Resultado resultado)
        {
            var cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (resultado.ResultadoId == 0)
                {
                    // Nuevo resultado, si existe en base a ProtocoloId y ExamenesPruebasId
                    selectQuery = @"SELECT COUNT(*) FROM Resultados
                            WHERE ProtocoloId = @ProtocoloId AND ExamenesPruebasId = @ExamenesPruebasId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, resultado);
                }
                else
                {
                    // Resultado existente, si existe otro con el mismo ProtocoloId y ExamenesPruebasId
                    selectQuery = @"SELECT COUNT(*) FROM Resultados 
                            WHERE ProtocoloId = @ProtocoloId AND ExamenesPruebasId = @ExamenesPruebasId
                                AND ResultadoId != @ResultadoId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, resultado);
                }
            }
            return cantidad > 0;
        }


        public int GetCantidad()
        {
            int cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
               
                
                    selectQuery = "SELECT COUNT(*) FROM Resultados";
                    cantidad = conn.ExecuteScalar<int>(selectQuery);
                
            }
            return cantidad;
        }

        public List<ResultadoDto> GetResultadosDtoPorPagina(int cantidadPorPagina, int paginaActual)
        {
            List<ResultadoDto> lista = new List<ResultadoDto>();

            using (var conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string selectQuery = @"SELECT p.NombrePrueba,r.ResultadoPrueba ,CONCAT(ran.RangoMinimo,', ', ran.RangoMaximo)as NombreRango
                        FROM Resultados r  
						join ExamenesPruebas e on e.ExamenPruebaId=r.ExamenesPruebasId
						join Rangos ran on ran.ExamenPruebaId=e.ExamenPruebaId
						join Pruebas p on p.PruebaId=e.PruebaId
                        ORDER BY p.NombrePrueba
                        OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY"";";
                var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                lista = conn.Query<ResultadoDto>(selectQuery, new { cantidadRegistros, cantidadPorPagina }).ToList();
            }
            return lista;
        }
    }
}
