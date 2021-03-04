<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormPacientes.aspx.cs" Inherits="WebAppCapaPersonas.WebFormPacientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row justify-content-center">
            <div class="col-md-15 col-sm-15">
                <div class="panel panel-primary">
                    <div class="panel-heading">Registro Pacientes</div>
                    <div class="panel-body">
                        <div class="row">
                            <div class="form-group col-md-6">
                                <label for="DropDownListNif_Paciente" class"form-label">Nif Paciente</label>
                                <asp:DropDownList class="form-select" ID="DropDownListNif_Paciente" runat="server" AppendDataBoundItems="True">
                                 <asp:ListItem Value=""> </asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="form-group col-md-6">
                                <label for="DropDownListNif_Medico" class="form-label">Nif Medico</label>
                                <asp:DropDownList class="form-select" ID="DropDownListNif_Medico" runat="server" AppendDataBoundItems="True">
                                 <asp:ListItem Value=""> </asp:ListItem>
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
            <asp:GridView runat="server" class="table table-hover" ID="GridViewPacientes" OnSelectedIndexChanged="GridViewPacientes_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
