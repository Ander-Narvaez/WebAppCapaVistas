<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormMedicos.aspx.cs" Inherits="WebAppCapaPersonas.WebFormMedicos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-15 col-sm-15">
                <div class="panel panel-primary">
                    <div class="panel-heading">Registro Medicos</div>
                    <div class="panel-body">
                        <div class="form-row">
                        </div>
                        <div class="form-row">
                            <div class="form-group col-md-6">
                                <label for="fecha_alta">Fecha Alta</label>
                                <input type="date" class="form-control" id="fecha_alta" runat="server" />
                            </div>
                            <div class="form-group col-md-6">
                                <label for="fecha_baja">Fecha Baja</label>
                                <input type="date" class="form-control" id="fecha_baja" runat="server" />
                            </div>
                        </div>
                        <div class="form-row">
                            <div class="form-group col-md-6">
                                <label for="inputNCO">Numero Colegiado</label>
                                <asp:TextBox type="text" class="form-control" ID="inputNCO" placeholder="Numero Colegiado" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="inputNCO" ForeColor="Red">Debe Ilenar el campo</asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group col-md-4">
                                <label for="inputState">Estatus</label>
                                <select id="inputState" class="form-control">
                                    <option selected>Medico Interino</option>
                                    <option selected>Medico Titular</option>
                                    <option selected>Medico Sustituto</option>
                                </select>
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
            <asp:GridView runat="server" class="table table-hover" ID="GridViewMedicos">
                <Columns>
                    <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
