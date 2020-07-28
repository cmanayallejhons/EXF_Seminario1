using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class Home : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["abrirSesion"] == null)
                {
                    if (Session["administrador"] == null)
                    {
                        Response.Redirect("/login.aspx");
                    }
                }
            }

        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            Session.Remove("abrirSesion");
            Session.RemoveAll();
            Response.Redirect("/login.aspx");

        }
    }
}