using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades.DTO;
using CapaEntidades.Cache;

namespace CapaDatos
{
    public class D_UsuarioDAO:Conexion 
    {

        public bool Login(E_USUARIO usuario)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comand =  new SqlCommand())
                {
                    comand.Connection = conexion;
                    comand.CommandText = "SP_VALIDAR_USUARIO";
                    comand.Parameters.AddWithValue("@USUARIO", usuario.uS_USUARIO);
                    comand.Parameters.AddWithValue("@CONTRASENIA", usuario.uS_CONTRASENIA);
                    comand.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = comand.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UsuarioLoginCache.US_IDUSUARIO = reader.GetInt32(0);
                            UsuarioLoginCache.US_USUARIO = reader.GetString (1);
                            UsuarioLoginCache.CN_IDCONSTANTE = reader.GetInt32(3);
                            UsuarioLoginCache.PE_IDPERSONA = reader.GetInt32(4);
                        }
                        return true;
                    } 
                    else
                        return false;
                }
            }
        }

    }
}
