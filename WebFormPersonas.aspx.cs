using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCapaPersonas
{
    public partial class WebFormPersonas : System.Web.UI.Page
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
                MostrarPersonas();
            }
        }

            public void MostrarPersonas()
            {
                DataSet Dts = new DataSet();
                Dts = Ws.GetListaPersonas(inputNif.Text, inputNC.Text, inputDR.Text, inputTL.Text, inputPO.Text, 
                                          inputPRO.Text, inputCDP.Text, inputNSS.Text, "S");
                GridViewPersonas.DataSource = Dts;
                GridViewPersonas.DataBind();
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            Labelmsg.Text = Ws.MantenimientoPersona(inputNif.Text, inputNC.Text, inputDR.Text, inputTL.Text, inputPO.Text,
                                                      inputPRO.Text, inputCDP.Text, inputNSS.Text, "I");
            inputNif.Text = "";
            inputNC.Text  = "";
            inputDR.Text  = "";
            inputTL.Text  = "";
            inputPO.Text  = "";
            inputPRO.Text = "";
            inputCDP.Text = "";
            inputNSS.Text = "";
            MostrarPersonas();
        }

        protected void GridViewPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridViewPersonas.SelectedRow;

            inputNif.Text = "" + row.Cells[1].Text;
            inputNC.Text  = "" + row.Cells[2].Text; 
            inputDR.Text  = "" + row.Cells[3].Text; 
            inputTL.Text  = "" + row.Cells[4].Text; 
            inputPO.Text  = "" + row.Cells[5].Text;
            inputPRO.Text = "" + row.Cells[6].Text; 
            inputCDP.Text = "" + row.Cells[7].Text;
            inputNSS.Text = "" + row.Cells[8].Text;

        }
    }
}