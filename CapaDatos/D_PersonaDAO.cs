using CapaEntidades.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidades.Cache;

namespace CapaDatos
{
    public class D_PersonaDAO : Conexion
    {

        public E_PERSONA perfilPersona()
        {
            E_PERSONA persona = new E_PERSONA();

            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conexion;
                    comand.CommandText = "SP_MOSTRAR_PERSONA";
                    comand.Parameters.AddWithValue("@PE_IDPERSONA", UsuarioLoginCache.PE_IDPERSONA);
                    comand.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = comand.ExecuteReader();

                    while (reader.Read())
                    {
                        persona.pE_NOMBRE = reader.GetString(0);
                        persona.pE_APELLIDOPAT = reader.GetString(1);
                        persona.pE_APELLIDOMAT = reader.GetString(2);
                        persona.pE_IDENTIFICACION = reader.GetString(3);
                        persona.pE_FECHANAC = reader.GetDateTime(4) + "";
                        persona.pE_TELEFONO = reader.GetString(5);
                        persona.pE_DIRECCION = reader.GetString(6);
                    }
                    return persona;

                }
            }
        }

        public E_PERSONAL buscarPersonal(int documento)
        {
            //E_PERSONA persona = new E_PERSONA();
            E_PERSONAL personal = new E_PERSONAL();


            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conexion;
                    comand.CommandText = "SP_BUSCAR_PERSONA";
                    comand.Parameters.AddWithValue("@PE_IDENTIFICACION", documento);
                    comand.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = comand.ExecuteReader();

                    while (reader.Read())
                    {
                        /*persona.PE_IDPERSONA= reader.GetInt32(0);
                        persona.PE_NOMBRE = reader.GetString(1);
                        persona.PE_APELLIDOPAT = reader.GetString(2);
                        persona.PE_APELLIDOMAT = reader.GetString(3);
                        persona.PE_IDENTIFICACION = reader.GetString(4);
                        persona.PE_FECHANAC = reader.GetDateTime(5) + "";
                        persona.PE_TELEFONO = reader.GetString(6);
                        persona.PE_DIRECCION = reader.GetString(7);*/
                        personal.pER_IDPERSONAL = reader.GetInt32(8);

                    }
                    return personal;

                }
            }
        }

        public E_PERSONA buscarAlumno(int documento)
        {
            E_PERSONA persona = new E_PERSONA();

            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conexion;
                    comand.CommandText = "SP_BUSCAR_ALUMNO";
                    comand.Parameters.AddWithValue("@PE_IDENTIFICACION", documento);
                    comand.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = comand.ExecuteReader();

                    while (reader.Read())
                    {
                        persona.pE_IDPERSONA = reader.GetInt32(0);
                        persona.pE_NOMBRE = reader.GetString(1);
                        persona.pE_APELLIDOPAT = reader.GetString(2);
                        persona.pE_APELLIDOMAT = reader.GetString(3);

                    }
                    return persona;

                }
            }
        }

    }
}
