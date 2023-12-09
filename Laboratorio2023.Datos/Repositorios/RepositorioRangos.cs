using Dapper;
using Laboratorio2023.Datos.Infertaces;
using Laboratorio2023.Entidades.Dtos;
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
    public class RepositorioRangos:IRepositorioRangos
    {
        private readonly string cadenaConexion;
        public RepositorioRangos()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }

        public void Agregar(Rango rango)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string addQuery = @"INSERT INTO Rangos (TipoRangoId,                                      
                                RangoMinimo, RangoMaximo, ExamenPruebaId)
                                VALUES (@TipoRangoId, @RangoMinimo,
                                @RangoMaximo, @ExamenPruebaId)
                                SELECT SCOPE_IDENTITY()";

                int id = conn.QuerySingle<int>(addQuery, rango);
                rango.RangoId = id;
            }
        }

        public void Borrar(int rangoId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string deleteQuery = "DELETE FROM Rangos WHERE RangoId=@RangoId";
                conn.Execute(deleteQuery);
            }
        }

        public void Editar(Rango rango)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string updateQuery = @"UPDATE Rangos SET NombreProveedor=@NombreProveedor,
                                Direccion=@Direccion, 
                                CodigoPostal=@CodigoPostal, CiudadId=@CiudadId,PaisId=@PaisId, 
                                Email=@Email , TelefonoFijo=@TelefonoFijo , TelefonoMovil=@TelefonoMovil                    
                                WHERE ProovedorId=@ProovedorId";
                conn.Execute(updateQuery, rango);
            }
        }

        public bool Existe(Rango rango)
        {
            var cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (rango.RangoId == 0)
                {
  
                    selectQuery = @"SELECT COUNT(*) FROM Rangos
                            WHERE TipoRangoId = @TipoRangoId 
                                AND RangoMinimo = @RangoMinimo 
                                AND RangoMaximo = @RangoMaximo
                                AND ExamenPruebaId = @ExamenPruebaId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, rango);
                }
                else
                {
                  
                    selectQuery = @"SELECT COUNT(*) FROM Rangos 
                            WHERE TipoRangoId = @TipoRangoId 
                                AND RangoMinimo = @RangoMinimo 
                                AND RangoMaximo = @RangoMaximo
                                AND ExamenPruebaId = @ExamenPruebaId
                                AND RangoId != @RangoId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, rango);
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
                    selectQuery = "SELECT COUNT(*) FROM Rangos";
                    cantidad = conn.ExecuteScalar<int>(selectQuery);
                }
                else
                {
                    selectQuery = @"SELECT COUNT(*) FROM Rangos";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, new { textoFiltro });
                }
            }
            return cantidad;
        }

        public Rango GetRangoPorId(int rangoId)
        {
            Rango rango = null;
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string selectQuery = @"SELECT RangoId,TipoRangoId, RangoMinimo, RangoMaximo, ExamenPruebaId 
                        FROM Rangos WHERE RangoId=@RangoId";
                rango = conn.QuerySingle<Rango>(selectQuery, new { RangoId = rangoId });
            }
            return rango;
        }

        public List<RangoDto> GetRangosPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro = null)
        {
            List<RangoDto> lista = new List<RangoDto>();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                if (textoFiltro==null)
                {
                    conn.Open();
                    string selectQuery = @"SELECT r.RangoId, ep.ExamenPruebaId, CONCAT(r.RangoMinimo,', ', r.RangoMaximo)as NombreRango,
                            ep.ExamenPruebaId, tr.NombreTipoRango,p.NombrePrueba,t.NombreMedicion
                            FROM Pruebas p 
							join ExamenesPruebas ep on p.PruebaId=ep.PruebaId
                            join Rangos r on r.ExamenPruebaId=ep.ExamenPruebaId
                            join TipoMediciones t on t.TipoMedicionId=ep.ExamenPruebaId
							join TipoRangos tr on tr.TipoRangoId=r.TipoRangoId
                            ORDER BY p.NombrePrueba	";
                    lista = conn.Query<RangoDto>(selectQuery).ToList();
                }
                else
                {
                    conn.Open();
                    string selectQuery = @"SELECT r.RangoId, ep.ExamenPruebaId, CONCAT(r.RangoMinimo,', ', r.RangoMaximo)as NombreRango,
                            ep.ExamenPruebaId, tr.NombreTipoRango,p.NombrePrueba,t.NombreMedicion
                            FROM Pruebas p 
							join ExamenesPruebas ep on p.PruebaId=ep.PruebaId
                            join Rangos r on r.ExamenPruebaId=ep.ExamenPruebaId
                            join TipoMediciones t on t.TipoMedicionId=ep.ExamenPruebaId
							join TipoRangos tr on tr.TipoRangoId=r.TipoRangoId
                            WHERE p.NombrePrueba like @textoFiltro + '%'
                            ORDER BY p.NombrePrueba	";
                    lista = conn.Query<RangoDto>(selectQuery).ToList();
                }
            }
            return lista;
        }
    }
}
