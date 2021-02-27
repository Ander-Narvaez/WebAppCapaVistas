<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormPersonas.aspx.cs" Inherits="WebAppCapaPersonas.WebFormPersonas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-15 col-sm-15">
                <div class="panel panel-primary">
                    <div class="panel-heading">Registro Personas</div>
                    <div class="panel-body">
                        <form>
                            <div class="form-row">
                                <div class="form-group col-md-6">
                                    <label for="inputNif">Nif</label>
                                    <asp:TextBox type="text" class="form-control" id="inputNif" placeholder="Nif" runat="server" ></asp:TextBox>
                                </div>
                                <div class="form-group col-md-6">
                                    <label for="inputNC">Nombre Completo</label>
                                     <asp:TextBox type="text" class="form-control" id="inputNC" placeholder="Nombre Completo" runat="server" ></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-row">
                                <div class="form-group col-md-6">
                                    <label for="inputDR">Dirección</label>
                                    <asp:TextBox type="text" class="form-control" id="inputDR" placeholder="Dirección" runat="server" ></asp:TextBox>
                                </div>
                                <div class="form-group col-md-6">
                                    <label for="inputTL">Teléfono</label>
                                    <asp:TextBox type="text" class="form-control" id="inputTL" placeholder="Teléfono" runat="server" ></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-row">
                                <div class="form-group col-md-6">
                                    <label for="inputPO">Población</label>
                                    <asp:TextBox type="text" class="form-control" id="inputPO" placeholder="Población" runat="server" ></asp:TextBox>
                                </div>
                                <div class="form-group col-md-6">
                                    <label for="inputPRO">Provincia</label>
                                    <asp:TextBox  type="text" class="form-control" id="inputPRO" placeholder="Provincia" runat="server" ></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-row">
                                <div class="form-group col-md-6">
                                    <label for="inputCDP">Codigo Postal</label>
                                    <asp:TextBox type="text" class="form-control" id="inputCDP" placeholder="Codigo Postal" runat="server" ></asp:TextBox>
                                </div>
                                <div class="form-group col-md-6">
                                    <label for="inputNSS">Numero de Seguridad Social</label>
                                    <asp:TextBox type="text" class="form-control" id="inputNSS" placeholder="Numero de Seguridad Social" runat="server" ></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group col-md-6">
                                <div class="btn-group" role="group" aria-label="Basic example">
                                    <button type="button" class="btn btn-success">Guardar</button>
                                </div>
                            </div>
                        </form>
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
