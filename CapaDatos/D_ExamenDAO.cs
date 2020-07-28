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
    class D_ExamenDAO : Conexion
    {
        public void insertarExamen(E_NIVEL nivel , E_CONSTANTE constante)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conexion;
                    comand.CommandText = "SP_INSERTAR_EXAMEN";
                    comand.Parameters.AddWithValue("@NI_IDNIVEL", nivel.nI_IDNIVEL);
                    comand.Parameters.AddWithValue("@CN_IDTIPOCATEGORIA", constante.cN_IDCONSTANTE );
                    comand.CommandType = CommandType.StoredProcedure;
                    comand.ExecuteNonQuery();
                }
            }
        }
    }
}
