using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.DTO
{
    public class E_EXAMEN
    {
        private int EX_IDEXAMEN;
        private String EX_CATEGORIA;
        private E_NIVEL NI_IDNIVEL;
        private E_CONSTANTE CN_IDTIPOCATEGORIA;

        public int eX_IDEXAMEN
        {
            get { return EX_IDEXAMEN; }
            set { EX_IDEXAMEN = value; }
        }
        public String eX_CATEGORIA
        {
            get { return EX_CATEGORIA; }
            set { EX_CATEGORIA = value; }
        }
        public E_NIVEL nI_IDNIVEL
        {
            get { return NI_IDNIVEL; }
            set { NI_IDNIVEL = value; }
        }
        public E_CONSTANTE cN_IDTIPOCATEGORIA
        {
            get { return CN_IDTIPOCATEGORIA; }
            set { CN_IDTIPOCATEGORIA = value; }
        }
        public E_EXAMEN()
        {
        }

        public E_EXAMEN(int eX_IDEXAMEN, string eX_CATEGORIA, E_NIVEL nI_IDNIVEL, E_CONSTANTE cN_IDTIPOCATEGORIA)
        {
            EX_IDEXAMEN = eX_IDEXAMEN;
            EX_CATEGORIA = eX_CATEGORIA;
            NI_IDNIVEL = nI_IDNIVEL;
            CN_IDTIPOCATEGORIA = cN_IDTIPOCATEGORIA;
        }

        public E_EXAMEN(int eX_IDEXAMEN)
        {
            EX_IDEXAMEN = eX_IDEXAMEN;
        }
    }
}
