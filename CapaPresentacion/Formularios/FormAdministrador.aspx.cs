using CapaEntidades.DTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login
{
    public partial class FormAdministrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        public void cargarDatos()
        {
            N_Persona n_persona = new N_Persona();
            E_PERSONA e_persona = new E_PERSONA();

            e_persona = n_persona.perfilPersona();

            txtNombres.Text = e_persona.pE_NOMBRE;
            txtApellidos.Text = e_persona.pE_APELLIDOPAT + " " + e_persona.pE_APELLIDOMAT;
            txtNumDoc.Text = e_persona.pE_IDENTIFICACION + "";
            txtFechaNaci.Text = e_persona.pE_FECHANAC + "";
            txtTelefono.Text = e_persona.pE_TELEFONO + "";
            txtDireccion.Text = e_persona.pE_DIRECCION;
        }
    }
}