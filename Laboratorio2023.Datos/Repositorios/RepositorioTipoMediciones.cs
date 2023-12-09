using Dapper;
using Laboratorio2023.Datos.Infertaces;
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
    public class RepositorioTipoMediciones:IRepositorioTipoMediciones
    {

        private readonly string cadenaConexion;
        public RepositorioTipoMediciones()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }

        public void Agregar(TipoMedicion tipoMedicion)
        {
            //using (var conn = new SqlConnection(cadenaConexion))
            //{

            //    string addQuery = @"INSERT INTO TipoRangos (NombreRango)                                    
            //                    VALUES (@NombreRango)
            //                    SELECT SCOPE_IDENTITY()";
            //    int id = conn.QuerySingle<int>(addQuery, tipoRango);
            //    tipoRango.TipoRangoId = id;
            //}
        }

        public void Borrar(int tipoMedicionId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string deleteQuery = "DELETE FROM TipoMediciones WHERE TipoMedicionId=@TipoMedicionId";
                conn.Execute(deleteQuery);
            }
        }

        public void Editar(TipoMedicion tipoMedicion)
        {
            throw new NotImplementedException();
        }

        public bool EstaRelacionado(int tipoMedicionId)
        {
            throw new NotImplementedException();
        }

        public bool Existe(TipoMedicion tipoMedicion)
        {
            throw new NotImplementedException();
        }

        public int GetCantidad(string textoFiltro)
        {
            int cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (textoFiltro == null)
                {
                    selectQuery = "SELECT COUNT(*) FROM TipoMediciones";
                    cantidad = conn.ExecuteScalar<int>(selectQuery);
                }
                else
                {
                    selectQuery = @"SELECT COUNT(*) FROM TipoMediciones
                                    WHERE NombreMedicion LIKE @textoFiltro + '%'";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, new { textoFiltro });
                }
            }
            return cantidad;
        }

        public List<TipoMedicion> GetTipoMedicionesPorPagina(int cantidadPorPagina, int paginaActual, string textoFiltro)
        {
            List<TipoMedicion> lista = new List<TipoMedicion>();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (textoFiltro == null)
                {
                    selectQuery = @"SELECT TipoMedicionId,NombreMedicion
                                 FROM TipoMediciones
                                 ORDER BY NombreMedicion
                                 OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                    lista = conn.Query<TipoMedicion>(selectQuery, new { cantidadRegistros, cantidadPorPagina }).ToList();
                }
                else
                {
                    selectQuery = @"SELECT TipoMedicionId,NombreMedicion
                                 FROM TipoMediciones
                                 WHERE NombreMedicion like @textoFiltro + '%'
                                 ORDER BY NombreMedicion
                                 OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                    lista = conn.Query<TipoMedicion>(selectQuery, new { cantidadRegistros, cantidadPorPagina, textoFiltro }).ToList();
                }
            }
            return lista;
        }
    }
}
