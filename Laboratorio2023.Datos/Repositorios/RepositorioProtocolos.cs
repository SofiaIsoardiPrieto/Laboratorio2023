using Laboratorio2023.Datos.Infertaces;
using Laboratorio2023.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Laboratorio2023.Datos.Repositorios
{
    public class RepositorioProtocolos:IRepositorioProtocolos
    {
        private readonly string cadenaConexion;
        public RepositorioProtocolos()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
        public void Agregar(Protocolo protocolo)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string addQuery = @"INSERT INTO Protocolos(PacienteId, FechaRealizacion, MedicoId)
                                VALUES (@PacienteId, @FechaRealizacion, @MedicoId)
								SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(addQuery, protocolo);
                protocolo.ProtocoloId = id;
            }
        }
        public void Editar(Protocolo protocolo)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string updateQuery = @"UPDATE Protocolos SET PacienteId=@PacienteId,
						FechaRealizacion=@FechaRealizacion, MedicoId=@MedicoId                                                              
						WHERE ProtocoloId=@ProtocoloId";
                conn.Execute(updateQuery, protocolo);
            }
        }
        public void Borrar(int protocoloId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                
                string deleteQuery = @"DELETE FROM Protocolos 
                        WHERE ProtocoloId=@ProtocoloId";

                conn.Execute(deleteQuery, protocoloId);
                
            }
        }
        public int GetCantidad(string textoFiltro, DateTime? fechaFiltro)
        {
            int cantidad = 0;
            
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (textoFiltro != null)
                {
                    selectQuery = @"SELECT COUNT(*) 
                    FROM Protocolos pr join Pacientes pa on pr.PacienteId=pa.PacienteId
                    WHERE CONCAT(pa.Apellido,', ', pa.Nombre) LIKE @textoFiltro + '%'";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, new { textoFiltro });
                }
                else if (fechaFiltro!=null)
                {
                    
                    selectQuery = @"SELECT COUNT(*)
                    FROM Protocolos 
                    WHERE CAST(FechaRealizacion AS DATE) = CAST(@fechaFiltro AS DATE)";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, new { fechaFiltro });
                }
                else if (textoFiltro == null && fechaFiltro == null)
                {

                    selectQuery = @"SELECT COUNT(*) FROM Protocolos";
                    cantidad = conn.ExecuteScalar<int>(selectQuery);
                }
                
                    
                
            }
            return cantidad;
        }
        
        public List<Protocolo> GetProtocolosPorPagina(int cantidadPorPagina, int paginaActual, string textoFiltro, DateTime? fechaFiltro)
        {
            List<Protocolo> lista = new List<Protocolo>();
            
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (textoFiltro == null && fechaFiltro==null)
                {
                    selectQuery = @"SELECT  pr.ProtocoloId, pa.PacienteId, 
                      CONCAT(pa.Apellido,', ', pa.Nombre) as NombrePaciente,
                        pr.FechaRealizacion,m.MedicoId,m.NombreMedico
                      FROM Protocolos pr join Pacientes pa on pr.PacienteId=pa.PacienteId
                      join Medicos m on pr.MedicoId=m.MedicoId
					  ORDER BY NombrePaciente
                      OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                    lista = conn.Query<Protocolo>(selectQuery, new { cantidadRegistros, cantidadPorPagina }).ToList();
                }
                else if (textoFiltro != null)
                {
                    selectQuery = @"SELECT  pr.ProtocoloId,CONCAT(pa.Apellido,', ', pa.Nombre) as NombrePaciente,pr.FechaRealizacion,m.NombreMedico
                      FROM Protocolos pr join Pacientes pa on pr.PacienteId=pa.PacienteId
                      join Medicos m on pr.MedicoId=m.MedicoId
                      WHERE pa.Apellido like @textoFiltro + '%'
                      ORDER BY NombrePaciente
                      OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                    lista = conn.Query<Protocolo>(selectQuery, new { cantidadRegistros, cantidadPorPagina, textoFiltro }).ToList();
                }
                else if (fechaFiltro != null)
                {
                    selectQuery = @"SELECT  pr.ProtocoloId,CONCAT(pa.Apellido,', ', pa.Nombre) as NombrePaciente,pr.FechaRealizacion,m.NombreMedico
                      FROM Protocolos pr join Pacientes pa on pr.PacienteId=pa.PacienteId 
                        join Medicos m on pr.MedicoId=m.MedicoId
                      WHERE CAST(pr.FechaRealizacion AS DATE) =  CAST(@fechaFiltro AS DATE)
                      ORDER BY NombrePaciente
                      OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                    lista = conn.Query<Protocolo>(selectQuery, new { cantidadRegistros, cantidadPorPagina, fechaFiltro }).ToList();
                }
                
            }
            return lista;
        }

        public bool Existe(Protocolo protocolo)
        {
            var cantidad = 0;
            protocolo.FechaRealizacion = protocolo.FechaRealizacion.Date;
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string selectQuery;
                if (protocolo.ProtocoloId == 0)
                {
                    selectQuery = @"SELECT COUNT(*) FROM Protocolos
                        WHERE PacienteId=@PacienteId AND CAST(FechaRealizacion AS DATE) =@FechaRealizacion AND MedicoId=@MedicoId ";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, protocolo);
                }
                else
                {
                    //que tenga distinto id de proveedor
                    selectQuery = @"SELECT COUNT(*) FROM Protocolos 
                        WHERE PacienteId=@PacienteId AND CAST(FechaRealizacion AS DATE) =@FechaRealizacion AND MedicoId=@MedicoId AND ProtocoloId!=@ProtocoloId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, protocolo);
                }
            }
            return cantidad > 0;
        }

        public bool EstaRelacionado(int protocoloId)
        {
            int cantidad = 0;
            using (IDbConnection conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = "SELECT COUNT(*) FROM Resultados WHERE protocoloId=@protocoloId";
                cantidad = conn.QuerySingle<int>(selectQuery, protocoloId);
            }
            return cantidad > 0;
        }

        
    }
}
