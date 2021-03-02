using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCapaPersonas
{
    public partial class WebFormPacientes : System.Web.UI.Page
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
                MostrarPacientes();
            }
        }

        public void MostrarPacientes()
        {
            DataSet Dts = new DataSet();
            Dts = Ws.MantenimientoPacientes("", "", "S");
            GridViewPacientes.DataSource = Dts;
            GridViewPacientes.DataBind();

            DropDownListNif_Paciente.DataSource = Cargar_Personas();
            DropDownListNif_Paciente.DataTextField = "NIF";
            //DropDownListNif.DataValueField = "Cedula";
            DropDownListNif_Medico.DataBind();
        }


        public DataSet Cargar_Personas()
        {
            DataSet Dts = new DataSet();
            Dts = Ws.GetListaPersonas("", "", "", "", "", "", "", "", "Q");

            return Dts;
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            Labelmsg.Text = Ws.MantenimientoEmpleados(DropDownListNif_Paciente.SelectedItem.ToString(), this.DropDownListNif_Medico.SelectedItem.ToString(), "I");
            MostrarPacientes();
        }
    }
}