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
                        personal.pER_IDPERSONAL = reader.GetInt32(8);

                    }
                    return personal;

                }
            }
        }
        public void insertarPersonal(E_PERSONA persona)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conexion;
                    comand.CommandText = "SP_INSERTAR_PERSONA";
                    comand.Parameters.AddWithValue("@PE_NOMBRE", persona.pE_NOMBRE);
                    comand.Parameters.AddWithValue("@PE_APELLIDOPAT", persona.pE_APELLIDOPAT);
                    comand.Parameters.AddWithValue("@PE_APELLIDOMAT", persona.pE_APELLIDOMAT);
                    comand.Parameters.AddWithValue("@PE_IDENTIFICACION", persona.pE_IDENTIFICACION);
                    comand.Parameters.AddWithValue("@PE_FECHANAC", Convert.ToDateTime(persona.pE_FECHANAC));
                    comand.Parameters.AddWithValue("@PE_TELEFONO", persona.pE_TELEFONO);
                    comand.Parameters.AddWithValue("@PE_DIRECCION", persona.pE_DIRECCION);
                    comand.Parameters.AddWithValue("@PE_SEXO", persona.pE_SEXO);
                    comand.Parameters.AddWithValue("@PE_ESTADO", persona.pE_ESTADO);
                    //comand.Parameters.AddWithValue("@US_IDUSUARIO", UsuarioLoginCache.US_IDUSUARIO);

                    comand.CommandType = CommandType.StoredProcedure;
                    comand.ExecuteNonQuery();
                }
            }
        }
    }
}
