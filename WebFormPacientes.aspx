<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormPacientes.aspx.cs" Inherits="WebAppCapaPersonas.WebFormPacientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-10 col-sm-10">
                <div class="panel panel-primary">
                    <div class="panel-heading">Registro Pacientes</div>
                    <div class="panel-body">
                        <div class="form-row">
                            <div class="form-group col-md-6">
                                <label for="DropDownListNif_Paciente">Nif Paciente</label>
                                <asp:DropDownList class="form-control" ID="DropDownListNif_Paciente" runat="server">
                                </asp:DropDownList>
                            </div>
                            <div class="form-group col-md-6">
                                <label for="DropDownListNif_Medico">Nif Medico</label>
                                <asp:DropDownList class="form-control" ID="DropDownListNif_Medico" runat="server">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group col-md-8">
                            <div class="btn-group" role="group" aria-label="Basic example">
                                <asp:Button class="btn btn-success" ID="BtnAgregar" runat="server" Text="Agregar" OnClick="BtnAgregar_Click" />
                            </div>
                        </div>
                        <div class="form-group col-md-6">
                            <asp:Label ID="Labelmsg" runat="server"></asp:Label>
                            <div id="msg" runat="server" class="alert alert-warning alert-dismissible fade show" role="alert">
                                <strong>Holy guacamole!</strong> You should check in on some of those fields below.
                                    <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                                        <span aria-hidden="true">&times;</span>
                                    </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-12 col-md-12 mx-auto">
            <asp:GridView runat="server" class="table table-hover" ID="GridViewPacientes" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                <Columns>
                    <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
        </div>
    </div>
</asp:Content>
