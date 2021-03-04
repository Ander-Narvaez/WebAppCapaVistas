<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormEmpleados.aspx.cs" Inherits="WebAppCapaPersonas.WebFormEmpleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <form class="form-inline">
            <div class="row justify-content-center">
                <div class="col-md-15 col-sm-15">
                    <div class="panel panel-primary">
                        <div class="panel-heading">Registro Empleados</div>
                        <div class="panel-body">
                                <div class="row">
                                <div class="form-group col-md-6">
                                    <label for="DropDownListNif" class="form-label">Nif</label>
                                    <asp:DropDownList class="form-control" ID="DropDownListNif" runat="server">
                                        <asp:ListItem> </asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="form-group col-md-6">
                                    <label for="DropDownListPuesto_Empleado" class="form-label" align="center">Puesto Empleado</label>
                                    <asp:DropDownList class="form-select" ID="DropDownListPuesto_Empleado" runat="server">
                                        <asp:ListItem> </asp:ListItem>
                                        <asp:ListItem>ATS</asp:ListItem>
                                        <asp:ListItem>ATS DE ZONA</asp:ListItem>
                                        <asp:ListItem>AUXILIARES DE ENFERMERIA</asp:ListItem>
                                        <asp:ListItem>CELADORES</asp:ListItem>
                                        <asp:ListItem>ADMINISTRATIVOS</asp:ListItem>
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
        </form>
    </div>

    <div class="row">
        <div class="col-12 col-md-12 mx-auto">
            <asp:GridView runat="server" class="table table-hover" ID="GridViewEmpleados" OnSelectedIndexChanged="GridViewEmpleados_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
