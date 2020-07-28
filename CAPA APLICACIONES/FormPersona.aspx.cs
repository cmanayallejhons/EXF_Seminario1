using CapaEntidades.DTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CAPA_APLICACIONES
{
    public partial class HOME_MASTER : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            N_Persona n_persona = new N_Persona();

            E_PERSONA e_persona = new E_PERSONA(txtNombre.Text, txtApellidoPat.Text, txtApellidoMat.Text, txtdni.Text, txtFecha.Text, txtTelefono.Text, txtDireccion.Text, txtSexo.Text, "A");
       

            n_persona.insertarPersona(e_persona);
        }
    }
}