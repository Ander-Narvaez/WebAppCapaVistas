<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormMedicos.aspx.cs" Inherits="WebAppCapaPersonas.WebFormMedicos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row justify-content-center">
            <div class="col-md-15 col-sm-15">
                <div class="panel panel-primary">
                    <div class="panel-heading">Registro Medicos</div>
                    <div class="panel-body">
                        <div class="row">
                            <div class="form-group col-md-6">
                                 <label for="DropDownListNif" class"form-label">Nif</label>
                                <asp:DropDownList class="form-select" ID="DropDownListNif" runat="server" OnSelectedIndexChanged="DropDownListNif_SelectedIndexChanged" AutoPostBack="True" AppendDataBoundItems="True">
                                </asp:DropDownList>
                            </div>
                            <div class="form-group col-md-6">
                                <label for="NC" class"form-label"></label>
                                <asp:TextBox class="form-control disabled text-success" ID="NC"  runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="form-group col-md-6">
                                <label class"form-label" for="fecha_alta" >Fecha Alta</label>
                                <input type="date" class="form-control" id="fecha_alta" runat="server" />
                            </div>
                            <div class="form-group col-md-6">
                                <label for="fecha_baja" class"form-label">Fecha Baja</label>
                                <input type="date" class="form-control" id="fecha_baja" runat="server" />
                            </div>
                        </div>
                        <div class="row">
                            <div class="form-group col-md-6">
                                <label for="inputNCO" class"form-label">Numero Colegiado</label>
                                <asp:TextBox type="text" class="form-control" ID="inputNCO" placeholder="Numero Colegiado" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="inputNCO" ForeColor="Red">Debe Ilenar el campo</asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group col-md-6">
                                <label for="inputState" class"form-label">Estatus</label>
                                <asp:DropDownList class="form-select" ID="inputState" runat="server">
                                    <asp:ListItem>SELECCIONE UNO</asp:ListItem>
                                    <asp:ListItem>MEDICO INTERINO</asp:ListItem>
                                    <asp:ListItem>MEDICO TITULAR</asp:ListItem>
                                    <asp:ListItem>MEDICO SUSTITUTO</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group col-md-8">
                                <asp:Button class="btn btn-outline-success" ID="BtnAgregar" runat="server" Text="Agregar" OnClick="BtnAgregar_Click" />
                                <asp:Button class="btn btn-outline-info" ID="BtnActulizar" runat="server" Text="Actualizar" OnClick="BtnActualizar_Click" />
                                <asp:Button class="btn btn-outline-danger" ID="BtnEliminar" runat="server" Text="Eliminar" OnClick="BtnEliminar_Click" />
                        </div>
                        <div class="form-group col-md-6">
                            <asp:Label ID="Labelmsg" runat="server"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-12 col-md-12 mx-auto">
            <asp:GridView runat="server" class="table table-hover" ID="GridViewMedicos" OnSelectedIndexChanged="GridViewMedicos_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
