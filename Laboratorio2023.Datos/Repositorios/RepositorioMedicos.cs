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
    public class RepositorioMedicos:IRepositorioMedicos
    {
        private readonly string cadenaConexion;
        public RepositorioMedicos()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }

        public void Agregar(MedicoCombo medico)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string insertQuery = @"INSERT INTO Medicos (NombreMedico) 
                        VALUES(@NombreMedico); SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(insertQuery, medico);
                medico.MedicoId = id;
            }
        }

        public void Editar(MedicoCombo medico)
        {
            
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string updateQuery = @"UPDATE Medicos SET NombreMedico=@NombreMedico                                  
                                WHERE MedicoId=@MedicoId";
                conn.Execute(updateQuery, medico);
            }
        }

        public bool Existe(MedicoCombo medico)
        {
            var cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (medico.MedicoId == 0)
                {
                    //cuando es nuevo el medico y hay que agregar, ver si ya existe.

                    selectQuery = @"SELECT COUNT(*) FROM Medicos 
                            WHERE NombreMedico=@NombreMedico";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, medico);
                }
                else
                {
                    //cuando es una edicion y veo si ya existe el medico.

                    selectQuery = @"SELECT COUNT(*) FROM Medicos 
                           WHERE NombreMedico=@NombreMedico 
                            AND MedicoId!=@MedicoId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, medico);
                }
            }
            return cantidad > 0;
        }

        public List<MedicoCombo> GetMedicosCombo()
        {
            List<MedicoCombo> lista = new List<MedicoCombo>();

            using (var conn = new SqlConnection(cadenaConexion))
            {

                string selectQuery = @"SELECT MedicoId, NombreMedico
                            FROM Medicos
                            ORDER BY NombreMedico";
                lista = conn.Query<MedicoCombo>(selectQuery).ToList();
            }
            return lista;
        }
    }
}
