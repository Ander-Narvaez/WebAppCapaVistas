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
            Dts = Ws.GetListaMedicos("","","","" ,"", "S");
            GridViewMedicos.DataSource = Dts;
            GridViewMedicos.DataBind();

            DropDownListNif.DataSource = Cargar_Personas();
            DropDownListNif.DataTextField = "NIF";
            DropDownListNif.DataBind();
        }

        public DataSet Cargar_Personas ()
        {
            DataSet Dts = new DataSet();
            Dts = Ws.GetListaPersonas("","","","","","","","", "Q");
            
            return Dts;
        }

        public void Limpiar_Campos()
        {
            this.DropDownListNif.SelectedIndex = 0;
            this.fecha_alta.Value = "";
            this.fecha_baja.Value = "";
            this.inputNCO.Text = "";
            this.inputState.SelectedIndex = 0;
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            Labelmsg.Text = Ws.MantenimientoMedico(DropDownListNif.SelectedItem.ToString(), fecha_alta.Value, fecha_baja.Value, inputNCO.Text, inputState.SelectedItem.ToString(), "I");
              Limpiar_Campos();
            MostrarMedicos();
        }

        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            Labelmsg.Text = Ws.MantenimientoMedico(DropDownListNif.SelectedItem.ToString(), fecha_alta.Value, fecha_baja.Value, inputNCO.Text, inputState.SelectedItem.ToString(), "U");
            Limpiar_Campos();
            MostrarMedicos();
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            Labelmsg.Text = Ws.MantenimientoMedico(DropDownListNif.SelectedItem.ToString(), fecha_alta.Value, fecha_baja.Value, inputNCO.Text, inputState.SelectedItem.ToString(), "D");
            Limpiar_Campos();
            MostrarMedicos();
        }

        protected void GridViewMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridViewMedicos.SelectedRow;
            
            DropDownListNif.Items.Add(new ListItem("" + row.Cells[1].Text)) ;
            DropDownListNif.SelectedIndex = (DropDownListNif.Items.Count)-1 ;
            this.fecha_alta.Value = Convert.ToDateTime(row.Cells[5].Text).ToString("yyyy-MM-dd");
            this.fecha_baja.Value = Convert.ToDateTime(row.Cells[6].Text).ToString("yyyy-MM-dd");
            this.inputNCO.Text = "" + row.Cells[7].Text;
            this.inputState.SelectedItem.Value = "" + row.Cells[8].Text;
            
        }
    }
}