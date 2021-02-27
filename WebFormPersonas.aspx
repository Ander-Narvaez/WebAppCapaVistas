<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormPersonas.aspx.cs" Inherits="WebAppCapaPersonas.WebFormPersonas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-15 col-sm-15">
                <div class="panel panel-primary">
                    <div class="panel-heading">Registro Personas</div>
                    <div class="panel-body">
                            <div class="form-row">
                                <div class="form-group col-md-6">
                                    <label for="inputNif">Nif</label>
                                    <asp:TextBox type="text" class="form-control" ID="inputNif" placeholder="Nif" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="inputNif" ForeColor="Red">Debe Ilenar el campo</asp:RequiredFieldValidator>
                                </div>
                                <div class="form-group col-md-6">
                                    <label for="inputNC">Nombre Completo</label>
                                    <asp:TextBox type="text" class="form-control" ID="inputNC" placeholder="Nombre Completo" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="inputNC" ForeColor="Red">Debe Ilenar el campo</asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="form-row">
                                <div class="form-group col-md-6">
                                    <label for="inputDR">Dirección</label>
                                    <asp:TextBox type="text" class="form-control" ID="inputDR" placeholder="Dirección" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="inputDR" ForeColor="Red">Debe Ilenar el campo</asp:RequiredFieldValidator>
                                </div>
                                <div class="form-group col-md-6">
                                    <label for="inputTL">Teléfono</label>
                                    <asp:TextBox type="text" class="form-control" ID="inputTL" placeholder="Teléfono" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="inputTL" ForeColor="Red">Debe Ilenar el campo</asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="form-row">
                                <div class="form-group col-md-6">
                                    <label for="inputPO">Población</label>
                                    <asp:TextBox type="text" class="form-control" ID="inputPO" placeholder="Población" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="inputPO" ForeColor="Red">Debe Ilenar el campo</asp:RequiredFieldValidator>
                                </div>
                                <div class="form-group col-md-6">
                                    <label for="inputPRO">Provincia</label>
                                    <asp:TextBox type="text" class="form-control" ID="inputPRO" placeholder="Provincia" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="inputPRO" ForeColor="Red">Debe Ilenar el campo</asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="form-row">
                                <div class="form-group col-md-6">
                                    <label for="inputCDP">Codigo Postal</label>
                                    <asp:TextBox type="text" class="form-control" ID="inputCDP" placeholder="Codigo Postal" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="inputCDP" ForeColor="Red">Debe Ilenar el campo</asp:RequiredFieldValidator>
                                </div>
                                <div class="form-group col-md-6">
                                    <label for="inputNSS">Numero de Seguridad Social</label>
                                    <asp:TextBox type="text" class="form-control" ID="inputNSS" placeholder="Numero de Seguridad Social" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="inputNSS" ForeColor="Red">Debe Ilenar el campo</asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="form-group col-md-6">
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
            <asp:GridView runat="server" class="table table-hover" ID="GridViewPersonas">
            </asp:GridView>
        </div>
    </div>
</asp:Content>
