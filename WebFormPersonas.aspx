<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormPersonas.aspx.cs" Inherits="WebAppCapaPersonas.WebFormPersonas" %>
   

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row justify-content-center">
            <div class="col-md-15 col-sm-15">
                <div class="panel panel-primary">
                    <div class="panel-heading">Registro Personas</div>
                    <div class="panel-body">
                        <div class="row">
                            <div class="form-group col-md-6">
                                <label for="inputNif" class"form-label">Nif</label>
                                <asp:TextBox class="form-control" ID="inputNif" placeholder="Nif" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="inputNif" ForeColor="Red">Debe Ilenar el campo</asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group col-md-6">
                                <label for="inputNC" class"form-label">Nombre Completo</label>
                                <asp:TextBox type="text" class="form-control" ID="inputNC" placeholder="Nombre Completo" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="inputNC" ForeColor="Red">Debe Ilenar el campo</asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="row">
                            <div class="form-group col-md-6">
                                <label for="inputDR">Dirección</label>
                                <asp:TextBox class="form-control" ID="inputDR" placeholder="Dirección" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="inputDR" ForeColor="Red">Debe Ilenar el campo</asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group col-md-6">
                                <label for="inputTL" class"form-label">Teléfono</label>
                                <asp:TextBox type="text" class="form-control" ID="inputTL" placeholder="Teléfono" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="inputTL" ForeColor="Red">Debe Ilenar el campo</asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="row">
                            <div class="form-group col-md-6">
                                <label for="inputPO" class"form-label">Población</label>
                                <asp:TextBox type="text" class="form-control" ID="inputPO" placeholder="Población" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="inputPO" ForeColor="Red">Debe Ilenar el campo</asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group col-md-6">
                                <label for="inputPRO" class"form-label">Provincia</label>
                                <asp:TextBox type="text" class="form-control" ID="inputPRO" placeholder="Provincia" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="inputPRO" ForeColor="Red">Debe Ilenar el campo</asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="row">
                            <div class="form-group col-md-6">
                                <label for="inputCDP" class"form-label">Codigo Postal</label>
                                <asp:TextBox type="text" class="form-control" ID="inputCDP" placeholder="Codigo Postal" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="inputCDP" ForeColor="Red">Debe Ilenar el campo</asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group col-md-6">
                                <label for="inputNSS" class"form-label">Numero de Seguridad Social</label>
                                <asp:TextBox type="text" class="form-control" ID="inputNSS" placeholder="Numero de Seguridad Social" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="inputNSS" ForeColor="Red">Debe Ilenar el campo</asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="form-group col-md-6">
                                <asp:Button class="btn btn-outline-success" ID="BtnAgregar" runat="server" Text="Agregar" OnClick="BtnAgregar_Click" />
                                <asp:Button class="btn btn-outline-info" ID="BtnActulizar" runat="server" Text="Actualizar" OnClick="BtnActualizar_Click" />
                                <asp:Button class="btn btn-outline-danger" ID="BtnEliminar" runat="server" Text="Eliminar" OnClick="BtnEliminar_Click" />
                        </div>
                        <div class="form-group col-md-6">
                            <asp:Label ID="msg"  runat="server"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-12 col-md-12 mx-auto">
            <asp:GridView runat="server" class="table table-hover" ID="GridViewPersonas"
                OnSelectedIndexChanged="GridViewPersonas_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
