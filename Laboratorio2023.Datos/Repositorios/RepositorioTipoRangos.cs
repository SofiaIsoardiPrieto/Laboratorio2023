using Dapper;
using Laboratorio2023.Datos.Infertaces;
using Laboratorio2023.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Laboratorio2023.Datos.Repositorios
{
    public class RepositorioTipoRangos : IRepositorioTipoRangos
    {
        private readonly string cadenaConexion;
        public RepositorioTipoRangos()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
        public void Agregar(TipoRango tipoRango)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string addQuery = @"INSERT INTO TipoRangos (NombreRango)                                    
                                VALUES (@NombreRango)
                                SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(addQuery, tipoRango);
                tipoRango.TipoRangoId = id;
            }
        }
        public void Borrar(int tipoRangoId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string deleteQuery = "DELETE FROM TipoRangos WHERE TipoRangoId=@TipoRangoId";
                conn.Execute(deleteQuery);
            }
        }
        public void Editar(TipoRango tipoRango)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string updateQuery = @"UPDATE TipoRangos SET NombreTipoRango=@NombreTipoRango,
                                       WHERE TipoRangoId=@TipoRangoId";
                conn.Execute(updateQuery, tipoRango);
            }
        }

        public bool EstaRelacionado(int tipoRangoId)
        {
            int cantidad = 0;
            using (IDbConnection conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = "SELECT COUNT(*) FROM Rangos WHERE tipoRangoId=@tipoRangoId";
                cantidad = conn.QuerySingle<int>(selectQuery, tipoRangoId);
            }
            return cantidad > 0;
        }

        public bool Existe(TipoRango tipoRango)
        {
            var cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (tipoRango.TipoRangoId == 0)
                {
                    selectQuery = @"SELECT COUNT(*) FROM TipoRangos
                        WHERE NombreTipoRango=@NombreTipoRango ";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, tipoRango);
                }
                else
                {
                    //que tenga distinto id de proveedor
                    selectQuery = @"SELECT COUNT(*) FROM TipoRangos 
                        WHERE NombreTipoRango=@NombreTipoRango AND TipoRangoId=@TipoRangoId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, tipoRango);
                }
            }
            return cantidad > 0;
        }
        public int GetCantidad(string textoFiltro = null)
        {
            int cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (textoFiltro == null)
                {
                    selectQuery = "SELECT COUNT(*) FROM TipoRangos";
                    cantidad = conn.ExecuteScalar<int>(selectQuery);
                }
                else
                {
                    selectQuery = @"SELECT COUNT(*) FROM TipoRangos
                                    WHERE NombreTipoRango LIKE @textoFiltro + '%'";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, new { textoFiltro });
                }
            }
            return cantidad;
        }

        public List<TipoRango> GetTipoRangosPorPagina(int cantidadPorPagina, int paginaActual, string textoFiltro = null)
        {
            List<TipoRango> lista = new List<TipoRango>();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (textoFiltro == null)
                {
                    selectQuery = @"SELECT TipoRangoId,NombreTipoRango
                                 FROM TipoRangos
                                 ORDER BY NombreTipoRango
                                 OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                    lista = conn.Query<TipoRango>(selectQuery, new { cantidadRegistros, cantidadPorPagina }).ToList();
                }
                else
                {
                    selectQuery = @"SELECT TipoRangoId,NombreTipoRango
                                 FROM TipoRangos
                                 WHERE NombreProveedor like @textoFiltro + '%'
                                 ORDER BY NombreTipoRango
                                 OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                    lista = conn.Query<TipoRango>(selectQuery, new { cantidadRegistros, cantidadPorPagina, textoFiltro }).ToList();
                }
            }
            return lista;
        }
    }


}
