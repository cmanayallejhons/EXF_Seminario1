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
    class D_ConstanteDAO : Conexion
    {
        public void insertarConstante(E_CONSTANTE constante)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conexion;
                    comand.CommandText = "SP_INSERTAR_CONSTANTE";
                    comand.Parameters.AddWithValue("@CN_NOMBRE", constante.cN_NOMBRE);
                    comand.Parameters.AddWithValue("@CN_CATEGORIA", constante.cN_CATEGORIA);
                  
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.ExecuteNonQuery();
                }
            }
        }
    }
}
