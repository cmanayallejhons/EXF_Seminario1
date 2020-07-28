using CapaEntidades.Cache;
using CapaEntidades.DTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                if (txtContrasenia.Text != "")
                {
                    N_Usuario n_usuario = new N_Usuario();
                    E_USUARIO e_usuario = new E_USUARIO(txtUsuario.Text, txtContrasenia.Text);
                    var validacion = n_usuario.Login(e_usuario);
                    
                    if (validacion == true)
                    {

                        if (UsuarioLoginCache.CN_IDCONSTANTE == 1) //ADMINISTRADOR
                        {
                            Session["abrirSesion"] = txtUsuario.Text;
                            Session["administrador"] = UsuarioLoginCache.CN_IDCONSTANTE;
                            Response.Redirect("Formularios/FormAdministrador.aspx");
                        }

                        if (UsuarioLoginCache.CN_IDCONSTANTE == 2) //ALUMNO
                        {
                            Session["abrirSesion"] = txtUsuario.Text;
                            Session["alumno"] = UsuarioLoginCache.CN_IDCONSTANTE;
                            Response.Redirect("Formularios/FormAlumno.aspx");
                        }

                    }
                    else
                    {
                        mensajeError("Usuario y/o Contraseña incorrectos. \n Por favor intente otra vez.");
                        txtUsuario.Text = "";
                        txtContrasenia.Text = "";
                        txtUsuario.Focus();
                    }
                }
                else
                {                    
                    mensajeError("Por favor ingrese una contraseña");
                }
            }
            else
            {                
                mensajeError("Por favor ingrese un usuario");
            }
            
            
        }
        public void mensajeError(String msg)
        {
            lblError.Text = " " + msg;
        }

    }
}