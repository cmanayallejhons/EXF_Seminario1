using CapaEntidades.Cache;
using CapaEntidades.DTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login
{
    public partial class FrmRegistrarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarDocente_Click1(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" || txtApePa.Text != "" || txtApeMa.Text != "" || txtNumDoc.Text != "" ||
                txtNaci.Text != "" || txtTelefono.Text != "" || txtDireccion.Text != "" || Nivel.Text != "")
            {
                N_Docente n_docente = new N_Docente();

                E_PERSONA e_persona = new E_PERSONA(txtNombre.Text, txtApePa.Text, txtApeMa.Text, txtNumDoc.Text, txtNaci.Text, txtTelefono.Text, txtDireccion.Text, Nivel.Text, "A");
                E_NIVEL e_nivel = new E_NIVEL(Convert.ToInt32(Nivel.Text));
                n_docente.insertarDocente(e_persona, e_nivel);

            }
            else
            {
                Response.Write("<script>alert('INGRESE TODOS LOS CAMPOS')</script>");
            }
        }



        //protected void btnCancelarAlumno_Click(object sender, EventArgs e)
        //{
        //    limpiarCampos();
        //}

        //public void limpiarCampos()
        //{
        //    txtNombre.Text = ""; 
        //    txtApePa.Text = ""; 
        //    txtApeMa.Text = ""; 
        //    txtNumDoc.Text = ""; 
        //    txtNaci.Text = ""; 
        //    txtTelefono.Text = ""; 
        //    txtDireccion.Text = ""; 
        //    txtSexo.Text = "";
        //}

        //protected void btnBuscarApoderado_Click(object sender, EventArgs e)
        //{
        //    if (txtApoderadoDoc.Text != "")
        //    {
        //        N_Persona n_persona = new N_Persona();
        //        E_PERSONAL e_personal = new E_PERSONAL();

        //        e_personal = n_persona.buscarPersonal(Convert.ToInt32(txtApoderadoDoc.Text));

        //        if (e_personal.pER_IDPERSONAL != 0)
        //        {
        //            txtApoderado.Text = e_personal.pER_IDPERSONAL+ "";
        //            txtApoderadoDoc.Text = "";
        //        } else {
        //            Response.Write("<script>alert('APODERADO NO ESXISTE, REGISTRE UNO')</script>");
        //        }


        //    } else
        //    {
        //        Response.Write("<script>alert('CAMPO VACIO')</script>");
        //    }
        //}

        [WebMethod]
        public static List<E_PERSONA> ListarAlumnos()
        {
            List<E_PERSONA> Lista = null;
            N_Docente n_alumno = new N_Docente();

            try
            {
                Lista = n_alumno.listarDocentes();
            }
            catch
            {
                return null;
            }
            return Lista;
        }

        //[WebMethod]
        //public static void ActualizarAlumno(String id, String nom, String pat, String mat, String dni, String fecha, String tel, String direccion)
        //{
        //    N_Alumno n_alumno = new N_Alumno();

        //    E_PERSONA e_persona = new E_PERSONA(Convert.ToInt32(id), nom, pat, mat, dni, fecha, tel, direccion, "A");

        //    n_alumno.actualizarAlumno(e_persona);

        //}

        //public static void EliminarAlumno(String id)
        //{
        //    N_Alumno n_alumno = new N_Alumno();

        //    E_PERSONA e_persona = new E_PERSONA(Convert.ToInt32(id));

        //    n_alumno.eliminarAlumno(e_persona);

        //}
    }
}