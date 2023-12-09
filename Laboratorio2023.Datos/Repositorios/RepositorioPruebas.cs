using Dapper;
using Laboratorio2023.Datos.Infertaces;
using Laboratorio2023.Entidades.Combos;
using Laboratorio2023.Entidades.Dtos;
using Laboratorio2023.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2023.Datos.Repositorios
{
    public class RepositorioPruebas:IRepositorioPruebas
    {

        private readonly string cadenaConexion;
        public RepositorioPruebas()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }

        public void Borrar(int pruebaId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string deleteQuery = @"DELETE FROM Pruebas 
                        WHERE PruebaId=@PruebaId";

                conn.Execute(deleteQuery, pruebaId);

            }
        }

      

        public bool EstaRelacionado(int pruebaId)
        {
             int cantidad = 0;
            using (IDbConnection conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = "SELECT COUNT(*) FROM ExamenesPruebas WHERE PruebaId=@PruebaId";
                cantidad = conn.QuerySingle<int>(selectQuery, pruebaId);
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
                    FROM Pruebas 
                    WHERE NombrePrueba LIKE @textoFiltro + '%'";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, new { textoFiltro });
                }
                else 
                {

                    selectQuery = @"SELECT COUNT(*) FROM Pruebas";
                    cantidad = conn.ExecuteScalar<int>(selectQuery);
                }

            }
            return cantidad;
        }

        public List<PruebaCombo> GetPruebaCombo(int? examenId)
        {
            List<PruebaCombo> lista = new List<PruebaCombo>();

            using (var conn = new SqlConnection(cadenaConexion))
            {

                string selectQuery = @"SELECT p.PruebaId, p.NombrePrueba 
                            FROM Pruebas p join ExamenesPruebas e on p.PruebaId=e.PruebaId
							WHERE ExamenId=@examenId
                            ORDER BY NombrePrueba";
                lista = conn.Query<PruebaCombo>(selectQuery, new {examenId}).ToList();
            }
            return lista;
        }

        public List<PruebaDto> GetPruebaDtosPorPagina(int cantidadPorPagina, int paginaActual, string textoFiltro=null)
        {
            List<PruebaDto> lista = new List<PruebaDto>();

            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (textoFiltro == null )
                {
                    selectQuery = @"SELECT p.PruebaId,p.NombrePrueba,e.NombreExamen,CONCAT(r.RangoMaximo,'-',r.RangoMinimo )as Rango , t.NombreMedicion
                            FROM Pruebas p join ExamenesPruebas ep on p.PruebaId=ep.PruebaId
                            join Examenes e on e.ExamenId=ep.ExamenId
                            join Rangos r on r.ExamenPruebaId=ep.ExamenPruebaId
                            join TipoMediciones t on t.TipoMedicionId=ep.ExamenPruebaId
                            ORDER BY NombrePrueba		
                            OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                    lista = conn.Query<PruebaDto>(selectQuery, new { cantidadRegistros, cantidadPorPagina }).ToList();
                }
                else 
                {
                    selectQuery = @"SELECT p.PruebaId,p.NombrePrueba,e.NombreExamen,CONCAT(r.RangoMaximo,'-',r.RangoMinimo )as Rango , t.NombreMedicion
                            FROM Pruebas p join ExamenesPruebas ep on p.PruebaId=ep.PruebaId
                            join Examenes e on e.ExamenId=ep.ExamenId
                            join Rangos r on r.ExamenPruebaId=ep.ExamenPruebaId
                            join TipoMediciones t on t.TipoMedicionId=ep.ExamenPruebaId
                            WHERE p.NombrePrueba like @textoFiltro + '%'
                            ORDER BY NombrePrueba
                            OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                    lista = conn.Query<PruebaDto>(selectQuery, new { cantidadRegistros, cantidadPorPagina, textoFiltro }).ToList();
                }              
            }
            return lista;
        }
    }
}
