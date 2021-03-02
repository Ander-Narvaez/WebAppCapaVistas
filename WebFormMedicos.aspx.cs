using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCapaPersonas
{
    public partial class WebFormMedicos : System.Web.UI.Page
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
                MostrarMedicos();
            }
        }

        public DateTime Convert_Date(String pFecha)
        {
            return DateTime.Parse(pFecha);
        }

        public void MostrarMedicos()
        {
            DataSet Dts = new DataSet();
            Dts = Ws.GetListaMedicos("",DateTime.MinValue,DateTime.MinValue,"" ,"", "S");
            GridViewMedicos.DataSource = Dts;
            GridViewMedicos.DataBind();

            DropDownListNif.DataSource = Cargar_Personas();
            DropDownListNif.DataTextField = "NIF";
            //DropDownListNif.DataValueField = "Cedula";
            DropDownListNif.DataBind();
        }

        public DataSet Cargar_Personas ()
        {
            DataSet Dts = new DataSet();
            Dts = Ws.GetListaPersonas("","","","","","","","", "Q");
            
            return Dts;
        }
        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            Labelmsg.Text = Ws.MantenimientoMedico(DropDownListNif.SelectedItem.ToString(), Convert_Date(fecha_alta.Value), Convert_Date(fecha_baja.Value), inputNCO.Text, inputState.SelectedItem.ToString(), "I");
            MostrarMedicos();
        }
    }
}