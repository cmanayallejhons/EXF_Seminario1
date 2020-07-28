using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.DTO
{
    public class E_PERSONAL
    {
        private int PER_IDPERSONAL;
        private int PE_IDPERSONA;
        private int CN_IDTIPOPERSONA;
        public int pER_IDPERSONAL
        {
            get { return PER_IDPERSONAL; }
            set { PER_IDPERSONAL = value; }
        }
        public int pE_IDPERSONA
        {
            get { return PE_IDPERSONA; }
            set { PE_IDPERSONA = value; }
        }
        public int cN_IDTIPOPERSONA
        {
            get { return CN_IDTIPOPERSONA; }
            set { CN_IDTIPOPERSONA = value; }
        }
    }
}
