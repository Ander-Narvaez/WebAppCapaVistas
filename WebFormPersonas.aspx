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
                                    <input type="text" class="form-control" id="inputNif" placeholder="Nif">
                                </div>
                                <div class="form-group col-md-6">
                                    <label for="inputNC">Nombre Completo</label>
                                    <input type="text" class="form-control" id="inputNC" placeholder="Nombre Completo">
                                </div>
                            </div>
                            <div class="form-row">
                                <div class="form-group col-md-6">
                                    <label for="inputDR">Dirección</label>
                                    <input type="text" class="form-control" id="inputDR" placeholder="Dirección">
                                </div>
                                <div class="form-group col-md-6">
                                    <label for="inputTL">Teléfono</label>
                                    <input type="text" class="form-control" id="inputTL" placeholder="Teléfono">
                                </div>
                            </div>
                            <div class="form-row">
                                <div class="form-group col-md-6">
                                    <label for="inputPO">Población</label>
                                    <input type="text" class="form-control" id="inputPO" placeholder="Población">
                                </div>
                                <div class="form-group col-md-6">
                                    <label for="inputPRO">Provincia</label>
                                    <input type="text" class="form-control" id="inputPRO" placeholder="Provincia">
                                </div>
                            </div>
                            <div class="form-row">
                                <div class="form-group col-md-6">
                                    <label for="inputCDP">Codigo Postal</label>
                                    <input type="text" class="form-control" id="inputCDP" placeholder="Codigo Postal">
                                </div>
                                <div class="form-group col-md-6">
                                    <label for="inputNSS">Numero de Seguridad Social</label>
                                    <input type="text" class="form-control" id="inputNSS" placeholder="Numero de Seguridad Social">
                                </div>
                            </div>
                            <div class="form-group col-md-6">
                                <div class="btn-group" role="group" aria-label="Basic example">
                                    <button type="button" class="btn btn-success">Guardar</button>
                                    <button type="button" class="btn btn-info">Modificar</button>
                                    <button type="button" class="btn btn-danger">Eliminar</button>
                                </div>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
