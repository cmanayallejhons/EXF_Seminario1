using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.DTO
{
    public class E_NIVEL
    {
        private int NI_IDNIVEL;
        private String NI_NIVEL;
        
        public int nI_IDNIVEL
        {
            get { return NI_IDNIVEL; }
            set { NI_IDNIVEL = value; }
        }
        public string nI_NIVEL
        {
            get { return NI_NIVEL; }
            set { NI_NIVEL = value; }
        }
        public E_NIVEL(int nI_IDNIVEL, string nI_NIVEL)
        {
            NI_IDNIVEL = nI_IDNIVEL;
            NI_NIVEL = nI_NIVEL;
        }

        public E_NIVEL(int nI_IDNIVEL)
        {
            NI_IDNIVEL = nI_IDNIVEL;
        }
    }
}
