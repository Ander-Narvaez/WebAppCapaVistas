using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCapaPersonas
{
    public partial class WebFormVacaciones : System.Web.UI.Page
    {
        ServiceReference.WebServiceSoapClient Ws = new ServiceReference.WebServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            String vResfrescarObjeto;
            if (IsPostBack)
            {
                vResfrescarObjeto = "nueva";
            }
            else
            {
                MostrarEmpleados();
            }     
        }

        public DataSet Cargar_Personas()
        {
            DataSet Dts = new DataSet();
            Dts = Ws.GetListaPersonas("", "", "", "", "", "", "", "", "Q");

            return Dts;
        }


        public void MostrarEmpleados()
        {
            DataSet Dts = new DataSet();
            Dts = Ws.GetListaVacaciones("","S");
            GridViewVacaciones.DataSource = Dts;
            GridViewVacaciones.DataBind();

            DropDownListNif_Empleados.DataSource = Cargar_Personas();
            DropDownListNif_Empleados.DataTextField = "NIF";
            DropDownListNif_Empleados.DataBind();
        }

        protected void GridViewVacaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}