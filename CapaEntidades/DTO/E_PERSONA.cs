using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.DTO
{
    public class E_PERSONA
    {
        private int PE_IDPERSONA;
        private String PE_NOMBRE;
        private String PE_APELLIDOPAT;
        private String PE_APELLIDOMAT;
        private String PE_IDENTIFICACION;
        private String PE_FECHANAC;
        private String PE_TELEFONO;
        private String PE_DIRECCION;
        private String PE_SEXO;
        private String PE_ESTADO;
        public int pE_IDPERSONA
        {
            get { return PE_IDPERSONA; }
            set { PE_IDPERSONA = value; }
        }
        public string pE_NOMBRE
        {
            get { return PE_NOMBRE; }
            set { PE_NOMBRE = value; }
        }
        public string pE_APELLIDOPAT
        {
            get { return PE_APELLIDOPAT; }
            set { PE_APELLIDOPAT = value; }
        }
        public string pE_APELLIDOMAT
        {
            get { return PE_APELLIDOMAT; }
            set { PE_APELLIDOMAT = value; }
        }
        public string pE_IDENTIFICACION
        {
            get { return PE_IDENTIFICACION; }
            set { PE_IDENTIFICACION = value; }
        }
        public string pE_FECHANAC
        {
            get { return PE_FECHANAC; }
            set { PE_FECHANAC = value; }
        }
        public string pE_TELEFONO
        {
            get { return PE_TELEFONO; }
            set { PE_TELEFONO = value; }
        }
        public string pE_DIRECCION
        {
            get { return PE_DIRECCION; }
            set { PE_DIRECCION = value; }
        }
        public string pE_SEXO
        {
            get { return PE_SEXO; }
            set { PE_SEXO = value; }
        }
        public string pE_ESTADO
        {
            get { return PE_ESTADO; }
            set { PE_ESTADO = value; }
        }
        public E_PERSONA()
        {

        }
        public E_PERSONA(string pE_NOMBRE, string pE_APELLIDOPAT, string pE_APELLIDOMAT, string pE_IDENTIFICACION, String pE_FECHANAC, string pE_TELEFONO, string pE_DIRECCION, string pE_SEXO, string pE_ESTADO)
        {
            PE_NOMBRE = pE_NOMBRE;
            PE_APELLIDOPAT = pE_APELLIDOPAT;
            PE_APELLIDOMAT = pE_APELLIDOMAT;
            PE_IDENTIFICACION = pE_IDENTIFICACION;
            PE_FECHANAC = pE_FECHANAC;
            PE_TELEFONO = pE_TELEFONO;
            PE_DIRECCION = pE_DIRECCION;
            PE_SEXO = pE_SEXO;
            PE_ESTADO = pE_ESTADO;
        }

        public E_PERSONA(int pE_IDPERSONA, string pE_NOMBRE, string pE_APELLIDOPAT, string pE_APELLIDOMAT, string pE_IDENTIFICACION, string pE_FECHANAC, string pE_TELEFONO, string pE_DIRECCION, string pE_ESTADO)
        {
            PE_IDPERSONA = pE_IDPERSONA;
            PE_NOMBRE = pE_NOMBRE;
            PE_APELLIDOPAT = pE_APELLIDOPAT;
            PE_APELLIDOMAT = pE_APELLIDOMAT;
            PE_IDENTIFICACION = pE_IDENTIFICACION;
            PE_FECHANAC = pE_FECHANAC;
            PE_TELEFONO = pE_TELEFONO;
            PE_DIRECCION = pE_DIRECCION;
            PE_ESTADO = pE_ESTADO;
        }

        public E_PERSONA(int pE_IDPERSONA)
        {
            PE_IDPERSONA = pE_IDPERSONA;
        }
    }
}
