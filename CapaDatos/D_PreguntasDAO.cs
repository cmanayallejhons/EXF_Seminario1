using CapaEntidades.Cache;
using CapaEntidades.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D_PreguntasDAO:Conexion
    {
        public void insertarPreguntas(E_PREGUNTA pregunta, E_EXAMEN examen)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conexion;
                    comand.CommandText = "SP_INSERTAR_PERSONA_PERSONAL";
                    comand.Parameters.AddWithValue("@PREGUNTA", pregunta.pREGUNTA);
                    comand.Parameters.AddWithValue("@EX_IDEXAMEN", examen.eX_IDEXAMEN);
                    comand.Parameters.AddWithValue("@US_IDUSUARIO", UsuarioLoginCache.US_IDUSUARIO);

                    comand.CommandType = CommandType.StoredProcedure;
                    comand.ExecuteNonQuery();
                }
            }
        }

        public void actualizarPreguntas(E_PREGUNTA pregunta, E_EXAMEN examen)
        {

            using (var conexion = GetConnection())
            {

                conexion.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conexion;
                    comand.CommandText = "SP_EDITAR_PERSONA";
                    comand.Parameters.AddWithValue("@PR_IDPREGUNTA", pregunta.pR_IDPREGUNTA);
                    comand.Parameters.AddWithValue("@PREGUNTA", pregunta.pREGUNTA);
                    comand.Parameters.AddWithValue("@EX_IDEXAMEN", examen.eX_IDEXAMEN);



                    comand.CommandType = CommandType.StoredProcedure;
                    comand.ExecuteNonQuery();
                }
            }

        }
    }
}
