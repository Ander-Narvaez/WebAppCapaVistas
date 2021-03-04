<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormHorarios.aspx.cs" Inherits="WebAppCapaPersonas.WebFormHorarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="container">
        <div class="row justify-content-center">
            <div class="col-md-15 col-sm-15">
                <div class="panel panel-primary">
                    <div class="panel-heading">Registro Medicos</div>
                    <div class="panel-body">
                        <div class="row">
                            <div class="form-group col-md-6">
                                <label for="inputCodigoH" class="form-label">Codigo Horario</label>
                                <asp:TextBox class="form-control" ID="inputCodigoH" placeholder="Codigo Horario" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="inputCodigoH" ForeColor="Red">Debe Ilenar el campo</asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group col-md-6">
                                <label for="inputDia" class="form-label">Dia Horario</label>
                                <asp:TextBox type="text" class="form-control" ID="inputDia" placeholder="Dia Horario" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="inputDia" ForeColor="Red">Debe Ilenar el campo</asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="row">
                            <div class="form-group col-md-6">
                                <label for="DropDownListJornada">Jornada</label>
                                <asp:DropDownList class="form-select" ID="DropDownListJornada" runat="server">
                                    <asp:ListItem> </asp:ListItem>
                                    <asp:ListItem>DIA</asp:ListItem>
                                    <asp:ListItem>TARDE</asp:ListItem>
                                    <asp:ListItem>NOCHE</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="form-group col-md-6">
                                <label for="DropDownListNif_Medico" class="form-label">Nif Medico</label>
                                <asp:DropDownList class="form-select" ID="DropDownListNif_Medico" runat="server" AppendDataBoundItems="True">
                                 <asp:ListItem Value=""> </asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group col-md-6">
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
            <asp:GridView runat="server" class="table table-hover" ID="GridViewHorarios" OnSelectedIndexChanged="GridViewHorarios_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </div>

</asp:Content>
