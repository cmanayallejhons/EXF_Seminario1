using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.DTO
{
    public class E_PREGUNTA
    {
        private int PR_IDPREGUNTA;
        private String PREGUNTA;
        private E_EXAMEN EX_IDEXAMEN;

        public int pR_IDPREGUNTA
        {
            get { return PR_IDPREGUNTA; }
            set { PR_IDPREGUNTA = value; }
        }
        public String pREGUNTA
        {
            get { return PREGUNTA; }
            set { PREGUNTA = value; }
        }
        public E_EXAMEN eX_IDEXAMEN
        {
            get { return EX_IDEXAMEN; }
            set { EX_IDEXAMEN = value; }
        }
        public E_PREGUNTA(int pR_IDPREGUNTA, String pREGUNTA, E_EXAMEN eX_IDEXAMEN)
        {
            PR_IDPREGUNTA = pR_IDPREGUNTA;
            PREGUNTA = pREGUNTA;
            EX_IDEXAMEN = eX_IDEXAMEN;
        }

        public E_PREGUNTA(int pR_IDPREGUNTA)
        {
            PR_IDPREGUNTA = pR_IDPREGUNTA;
        }
    }
}
