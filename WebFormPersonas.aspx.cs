﻿using System;
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
                //Se ejecuta cada vez que se refresca un objecto con auto -posback
            }
            else
            {
                MostrarPersonas();
                //Solo se ejecuta unavez 
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
            MostrarPersonas();
        }
    }
}