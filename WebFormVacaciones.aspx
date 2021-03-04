<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormVacaciones.aspx.cs" Inherits="WebAppCapaPersonas.WebFormVacaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="container">
        <div class="row justify-content-center">
            <div class="col-md-15 col-sm-15">
                <div class="panel panel-primary">
                    <div class="panel-heading">Registro Medicos</div>
                    <div class="panel-body">
                        <div class="row">
                            <div class="form-group col-md-8">
                                 <label for="DropDownListNif_Empleados" class="form-label">Nif Empleados</label>
                                <asp:DropDownList class="form-select" ID="DropDownListNif_Empleados" runat="server" AppendDataBoundItems="True">
                                <asp:ListItem Value=""> </asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>         
                        <div class="form-group col-md-8">
                            <div class="btn-group" role="group" aria-label="Basic example">
                                
                            </div>
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
            <asp:GridView runat="server" class="table table-hover" ID="GridViewVacaciones" OnSelectedIndexChanged="GridViewVacaciones_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </div>

</asp:Content>
