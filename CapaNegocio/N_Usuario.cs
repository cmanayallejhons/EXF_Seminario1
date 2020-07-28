using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades.DTO;

namespace CapaNegocio
{
    public class N_Usuario
    {

        D_UsuarioDAO usuarioDAO = new D_UsuarioDAO();

        public bool Login(E_USUARIO usuario)
        {
            return usuarioDAO.Login(usuario);  
        } 


    }
}
