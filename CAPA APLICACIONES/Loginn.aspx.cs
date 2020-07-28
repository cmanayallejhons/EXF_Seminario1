using CapaEntidades.Cache;
using CapaEntidades.DTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CAPA_APLICACIONES
{
    public partial class Loginn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtUser.Text != "")
            {
                if(txtPass.Text != "")
                {
                    N_Usuario n_usuario = new N_Usuario();
                    E_USUARIO e_usuario = new E_USUARIO(txtUser.Text, txtPass.Text);
                    var validacion = n_usuario.Login(e_usuario);
                    if(validacion == true){
                        if (UsuarioLoginCache.CN_IDCONSTANTE == 1) //ADMINISTRADOR
                        {
                            Session["abrirSesion"] = txtUser.Text;
                            Session["administrador"] = UsuarioLoginCache.CN_IDCONSTANTE;
                            Response.Redirect("FormPersona.aspx");
                        }

                        if (UsuarioLoginCache.CN_IDCONSTANTE == 2) //ALUMNO
                        {
                            Session["abrirSesion"] = txtUser.Text;
                            Session["alumno"] = UsuarioLoginCache.CN_IDCONSTANTE;
                            Response.Redirect("FormDocente.aspx");
                        }
                        Response.Redirect("datos");
                    }
                    else
                    {
                        mensajeError("Usuario y/o Contraseña incorrectos. \n Por favor intente otra vez.");
                        txtUser.Text = "";
                        txtPass.Text = "";
                        txtUser.Focus();
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