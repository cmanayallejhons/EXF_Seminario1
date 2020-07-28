using CapaDatos;
using CapaEntidades.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_NIVEL
    {
        D_NIVELDAO nivelDAO = new D_NIVELDAO();
        public List<E_NIVEL> listarNivel()
        {
            return nivelDAO.listarNivel();
        }
    }
}
