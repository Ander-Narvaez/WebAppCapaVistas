using System;
using System.Collections.Generic;
using System.Data;
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
                //Se ejecuta cada vez que se refresca un objecto con auto -posback
            }
            else
            {
                //MostrarMedicos();
                //Solo se ejecuta unavez 
            }
        }


        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
           // Labelmsg.Text = Ws.MantenimientoMedico(DropDownListNifMedico.SelectedItem, fecha_alta. , fecha_baja. , inputNCO.Text, inputState.SelectedIndex, "I");
            //MostrarMedicos();
        }
    }
}