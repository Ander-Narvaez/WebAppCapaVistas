using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCapaPersonas
{
    public partial class WebFormHorarios : System.Web.UI.Page
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
                MostrarHorarios();
            }
        }

        public void MostrarHorarios()
        {
            DataSet Dts = new DataSet();
            Dts = Ws.GetListaHorarios("","", "", "", "S");
            GridViewHorarios.DataSource = Dts;
            GridViewHorarios.DataBind();

            DropDownListNif_Medico.DataSource = Cargar_Medicos();
            DropDownListNif_Medico.DataTextField = "NIF_MEDICO";
            DropDownListNif_Medico.DataBind();
        }

        public DataSet Cargar_Medicos()
        {
            DataSet Dts = new DataSet();
            Dts = Ws.GetListaMedicos("", "", "", "", "", "Q");
            return Dts;
        }

        public void Limpiar_Campos()
        {
            this.inputCodigoH.Text = "";
            this.inputDia.Text = "";
            this.DropDownListJornada.SelectedIndex = 0;
            this.DropDownListNif_Medico.SelectedIndex = 0;
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            Labelmsg.Text = Ws.MantenimientoHorarios(this.inputCodigoH.Text, this.inputDia.Text, this.DropDownListJornada.SelectedItem.ToString(), DropDownListNif_Medico.SelectedItem.ToString(), "I");
            Limpiar_Campos();
            MostrarHorarios();
        }

        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            Labelmsg.Text = Ws.MantenimientoHorarios(this.inputCodigoH.Text, this.inputDia.Text, this.DropDownListJornada.SelectedItem.ToString(), DropDownListNif_Medico.SelectedItem.ToString(), "U");
            Limpiar_Campos();
            MostrarHorarios();
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            Labelmsg.Text = Ws.MantenimientoHorarios(this.inputCodigoH.Text, this.inputDia.Text, this.DropDownListJornada.SelectedItem.ToString(), DropDownListNif_Medico.SelectedItem.ToString(), "D");
            Limpiar_Campos();
            MostrarHorarios();
        }

        protected void GridViewHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridViewHorarios.SelectedRow;

            this.inputCodigoH.Text = "" + row.Cells[1].Text;
            this.inputDia.Text = "" + row.Cells[2].Text;
            this.DropDownListJornada.SelectedItem.Value = "" + row.Cells[3].Text;
            this.DropDownListNif_Medico.SelectedValue = "" + row.Cells[4].Text;
        }
    }
}