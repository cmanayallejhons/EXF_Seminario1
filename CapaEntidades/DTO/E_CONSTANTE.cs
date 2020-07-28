using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.DTO
{
    public class E_CONSTANTE
    {
        private int CN_IDCONSTANTE;
        private String CN_NOMBRE;
        private String CN_CATEGORIA;
        public int cN_IDCONSTANTE
        {
            get { return CN_IDCONSTANTE; }
            set { CN_IDCONSTANTE = value; }
        }
        public String cN_NOMBRE
        {
            get { return CN_NOMBRE; }
            set { CN_NOMBRE = value; }
        }
        public String cN_CATEGORIA
        {
            get { return CN_CATEGORIA; }
            set { CN_CATEGORIA = value; }
        }
        public E_CONSTANTE()
        {
        }

        public E_CONSTANTE(int cN_IDCONSTANTE, string cN_NOMBRE, string cN_CATEGORIA)
        {
            CN_IDCONSTANTE = cN_IDCONSTANTE;
            CN_NOMBRE = cN_NOMBRE;
            CN_CATEGORIA = cN_CATEGORIA;
        }

        public E_CONSTANTE(int cN_IDCONSTANTE)
        {
            CN_IDCONSTANTE = cN_IDCONSTANTE;
        }
    }
}
