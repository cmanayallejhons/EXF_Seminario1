using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.DTO
{
    public class E_USUARIO
    {
        private int US_IDUSUARIO;
        private String US_USUARIO;
        private String US_CONTRASENIA;
        private E_CONSTANTE CN_IDCONSTANTE;
        private E_PERSONA PE_IDPERSONA;
        public int uS_IDUSUARIO
        {
            get { return US_IDUSUARIO; }
            set { US_IDUSUARIO = value; }
        }
        public string uS_USUARIO
        {
            get { return US_USUARIO; }
            set { US_USUARIO = value; }
        }
        public string uS_CONTRASENIA
        {
            get { return US_CONTRASENIA; }
            set { US_CONTRASENIA = value; }
        }
        public E_CONSTANTE cN_IDCONSTANTE
        {
            get { return CN_IDCONSTANTE; }
            set { CN_IDCONSTANTE = value; }
        }
        public E_PERSONA pE_IDPERSONA
        {
            get { return PE_IDPERSONA; }
            set { PE_IDPERSONA = value; }
        }
        public E_USUARIO()
        {
        }

        public E_USUARIO(string uS_USUARIO, string uS_CONTRASENIA)
        {
            US_USUARIO = uS_USUARIO;
            US_CONTRASENIA = uS_CONTRASENIA;
        }

        public E_USUARIO(int uS_IDUSUARIO, string uS_USUARIO, string uS_CONTRASENIA, E_CONSTANTE cN_IDCONSTANTE, E_PERSONA pE_IDPERSONA)
        {
            US_IDUSUARIO = uS_IDUSUARIO;
            US_USUARIO = uS_USUARIO;
            US_CONTRASENIA = uS_CONTRASENIA;
            CN_IDCONSTANTE = cN_IDCONSTANTE;
            PE_IDPERSONA = pE_IDPERSONA;
        }
    }
}
