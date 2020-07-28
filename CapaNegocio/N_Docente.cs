using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades.DTO;

namespace CapaNegocio
{
    public class N_Docente
    {
        D_Docente docenteDao = new D_Docente();
        public void insertarDocente(E_PERSONA persona,E_NIVEL nivel)
        {
            docenteDao.insertarDocente(persona,nivel);
        }

        public List<E_PERSONA> listarDocentes()
        {
            return docenteDao.listarDocentes();
        }

        public void actualizarDocente(E_PERSONA persona)
        {
            docenteDao.actualizarDocente(persona);
        }

        //public void eliminarAlumno(E_PERSONA persona)
        //{
        //    alumnoDAO.eliminarAlumno(persona);
        //}
    }
}
