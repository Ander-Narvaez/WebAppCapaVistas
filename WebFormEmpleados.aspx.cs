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
            DropDownListNif.DataBind();
        }


        public DataSet Cargar_Personas()
        {
            DataSet Dts = new DataSet();
            Dts = Ws.GetListaPersonas("", "", "", "", "", "", "", "", "S");

            return Dts;
        }

        public void Limpiar_Campos()
        {
            this.DropDownListNif.SelectedIndex = 0;
            this.DropDownListPuesto_Empleado.SelectedIndex = 0;
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            Labelmsg.Text = Ws.MantenimientoEmpleados(DropDownListNif.SelectedItem.ToString(),this.DropDownListPuesto_Empleado.SelectedItem.ToString(), "I");
            Limpiar_Campos();
            MostrarEmpleados();
        }

        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            Labelmsg.Text = Ws.MantenimientoEmpleados(DropDownListNif.SelectedItem.ToString(), this.DropDownListPuesto_Empleado.SelectedItem.ToString(), "U");
            Limpiar_Campos();
            MostrarEmpleados();
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            Labelmsg.Text = Ws.MantenimientoEmpleados(DropDownListNif.SelectedItem.ToString(), this.DropDownListPuesto_Empleado.SelectedItem.ToString(), "D");
            Limpiar_Campos();
            MostrarEmpleados();
        }
      
        protected void GridViewEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridViewEmpleados.SelectedRow;

            //DropDownListNif.Items.Add(new ListItem("" + row.Cells[1].Text));
            //DropDownListNif.SelectedIndex = (DropDownListNif.Items.Count) - 1;
            this.DropDownListNif.SelectedValue = "" + row.Cells[1].Text;
            this.DropDownListPuesto_Empleado.SelectedItem.Value = "" + row.Cells[6].Text;
        }
    }
} 