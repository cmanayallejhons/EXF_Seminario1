

using CapaEntidades.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class D_NIVELDAO:Conexion
    {
        public List<E_NIVEL> listarNivel()
        {
            List<E_NIVEL> Lista = new List<E_NIVEL>();
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conexion;
                    comand.CommandText = "SP_MOSTRAR_NIVEL";
                    comand.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader dr = comand.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            E_NIVEL nivel = new E_NIVEL();
                            nivel.nI_IDNIVEL = Convert.ToInt32(dr["ID"]);
                            nivel.nI_NIVEL = dr["NIVEL"].ToString();

                            Lista.Add(nivel);
                        }

                    }

                }
            }
            return Lista;
        }
    }
}
