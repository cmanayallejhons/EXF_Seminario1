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
    public partial class Home_Master : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" || txtApePa.Text != "" || txtApeMa.Text != "" || txtNumDoc.Text != "" ||
                txtNaci.Text != "" || txtTelefono.Text != "" || txtDireccion.Text != "")
            {
                N_Docente n_docente = new N_Docente();

                E_PERSONA e_persona = new E_PERSONA(txtNombre.Text, txtApePa.Text, txtApeMa.Text, txtNumDoc.Text, txtNaci.Text, txtTelefono.Text, txtDireccion.Text, txtSexo.Text, "A");
                E_NIVEL e_nivel= new E_NIVEL(Convert.ToInt32(txtNivel.Text));
                n_docente.insertarDocente(e_persona,e_nivel);

            }
            else
            {
                Response.Write("<script>alert('INGRESE TODOS LOS CAMPOS')</script>");
            }
        }
    }
}