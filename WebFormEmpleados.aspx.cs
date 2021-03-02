using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCapaPersonas
{
    public partial class WebFormEmpleados : System.Web.UI.Page
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

        public void MostrarEmpleados()
        {
            DataSet Dts = new DataSet();
            Dts = Ws.GetListaEmpleados("","","S");
            GridViewEmpleados.DataSource = Dts;
            GridViewEmpleados.DataBind();

            DropDownListNif.DataSource = Cargar_Personas();
            DropDownListNif.DataTextField = "NIF";
            DropDownListNif.DataValueField = "Cedula";
            DropDownListNif.DataBind();
        }


        public DataSet Cargar_Personas()
        {
            DataSet Dts = new DataSet();
            Dts = Ws.GetListaPersonas("", "", "", "", "", "", "", "", "Q");

            return Dts;
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            Labelmsg.Text = Ws.MantenimientoEmpleados(DropDownListNif.SelectedItem.ToString(),this.DropDownListPuesto_Empleado.SelectedItem.ToString(), "I");
            MostrarEmpleados();
        }
    }
}