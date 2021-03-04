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
            Dts = Ws.GetListaPacientes("", "", "S");
            GridViewPacientes.DataSource = Dts;
            GridViewPacientes.DataBind();

            DropDownListNif_Paciente.DataSource = Cargar_Personas();
            DropDownListNif_Paciente.DataTextField = "NIF";
            DropDownListNif_Paciente.DataBind();

            DropDownListNif_Medico.DataSource = Cargar_Medicos();
            DropDownListNif_Medico.DataTextField = "NIF_MEDICO";
            DropDownListNif_Medico.DataBind();
        }


        public DataSet Cargar_Personas()
        {
            DataSet Dts = new DataSet();
            Dts = Ws.GetListaPersonas("", "", "", "", "", "", "", "", "Q");

            return Dts;
        }

        public DataSet Cargar_Medicos()
        {
            DataSet Dts = new DataSet();
            Dts = Ws.GetListaMedicos("", "", "", "", "", "S");
            return Dts;
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            Labelmsg.Text = Ws.MantenimientoPacientes(DropDownListNif_Paciente.SelectedItem.ToString(), this.DropDownListNif_Medico.SelectedItem.ToString(), "I");
            MostrarPacientes();
        }

        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            Labelmsg.Text = Ws.MantenimientoPacientes(DropDownListNif_Paciente.SelectedItem.ToString(), this.DropDownListNif_Medico.SelectedItem.ToString(), "U");
            MostrarPacientes();
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            Labelmsg.Text = Ws.MantenimientoPacientes(DropDownListNif_Paciente.SelectedItem.ToString(), this.DropDownListNif_Medico.SelectedItem.ToString(), "D");
            MostrarPacientes();
        }

        protected void GridViewPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridViewPacientes.SelectedRow;

            DropDownListNif_Paciente.Items.Add(new ListItem("" + row.Cells[1].Text));
            DropDownListNif_Paciente.SelectedIndex = (DropDownListNif_Paciente.Items.Count) - 1;
            this.DropDownListNif_Medico.SelectedValue = "" + row.Cells[6].Text;
        }
    }
}