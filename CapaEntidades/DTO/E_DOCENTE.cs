using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.DTO
{
    public class E_DOCENTE
    {
        private int DO_IDDOCENTE;
        private E_PERSONA PE_IDPERSONA;
        private E_NIVEL NI_IDNIVEL;

        public int dO_IDDOCENTE
        {
            get { return DO_IDDOCENTE; }
            set { DO_IDDOCENTE = value; }
        }
        public E_PERSONA pE_IDPERSONA
        {
            get { return PE_IDPERSONA; }
            set { PE_IDPERSONA = value; }
        }
        public E_NIVEL nI_IDNIVEL
        {
            get { return NI_IDNIVEL; }
            set { NI_IDNIVEL = value; }
        }
        public E_DOCENTE(int dO_IDDOCENTE, E_PERSONA pE_IDPERSONA, E_NIVEL nI_IDNIVEL)
        {
            DO_IDDOCENTE = dO_IDDOCENTE;
            PE_IDPERSONA = pE_IDPERSONA;
            NI_IDNIVEL = nI_IDNIVEL;
        }

        public E_DOCENTE(int dO_IDDOCENTE)
        {
            DO_IDDOCENTE = dO_IDDOCENTE;
        }
    }
}
