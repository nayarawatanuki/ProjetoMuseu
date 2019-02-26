<%@ Page Title="" Language="C#" MasterPageFile="~/MuseuMaster.Master" AutoEventWireup="true" CodeBehind="Funcionario.aspx.cs" Inherits="WebMuseu.Funcionario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 87px;
        }
        .auto-style5 {
            width: 87px;
            height: 62px;
        }
        .auto-style6 {
            height: 62px;
        }
        .auto-style7 {
            margin-left: 2px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblFuncionario" runat="server" Font-Size="XX-Large" Text="Acervo - Funcionário" Font-Names="Segoe Print"></asp:Label>
    </p>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Model.Funcionario" DeleteMethod="Delete" InsertMethod="Create" SelectMethod="Listar" TypeName="Bll.FuncionarioBll" UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="codigo" Type="Int32" />
        </DeleteParameters>
        <SelectParameters>
            <asp:Parameter  Name="filtro" Type="String"  ConvertEmptyStringToNull="false" DefaultValue="" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:Panel ID="paneldgvFuncionario" runat="server">
        <table id="painelTable">
            <tr>
            
                <th scope="col">
                    <asp:GridView ID="GridFuncionario" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="ObjectDataSource1" Height="165px" Width="670px" OnRowEditing="GridFuncionario_RowEditing" CssClass="auto-style7" DataKeyNames="Id">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                            <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                            <asp:BoundField DataField="Login" HeaderText="Login" SortExpression="Login" />
                            <asp:BoundField DataField="Senha" HeaderText="Senha" SortExpression="Senha" />
                            <asp:BoundField DataField="Tipo" HeaderText="Tipo" SortExpression="Tipo" />
                            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                            <asp:BoundField DataField="Telefone" HeaderText="Telefone" SortExpression="Telefone" />
                            <asp:CommandField ButtonType="Image" CancelImageUrl="~/Content/error_16x16.gif" DeleteImageUrl="~/Content/user2_(delete)_16x16.gif" EditImageUrl="~/Content/user2_(edit)_16x16.gif" HeaderText="Opções" ShowDeleteButton="True" ShowEditButton="True" UpdateImageUrl="~/Content/save_16x16.gif" />
                        </Columns>
                        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                        <RowStyle BackColor="White" ForeColor="#330099" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                        <SortedAscendingCellStyle BackColor="#FEFCEB" />
                        <SortedAscendingHeaderStyle BackColor="#AF0101" />
                        <SortedDescendingCellStyle BackColor="#F6F0C0" />
                        <SortedDescendingHeaderStyle BackColor="#7E0000" />
                    </asp:GridView>
                </th>
            </tr>
        </table>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnIncluir" runat="server" BackColor="#99CCFF" CssClass="btn btn-info" ForeColor="White" Height="36px" OnClick="btnIncluir_Click" Text="Incluir" Width="85px" />
        <br />
    </asp:Panel>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;</p>
&nbsp;<asp:Panel ID="painelFucionario" runat="server" Height="580px" Visible="False" Font-Names="Century Gothic">
        <br />
        <table>
            <thead>
                <tr>
                    <th class="auto-style5" scope="col" style="text-align: left;">
                        <br />
                        Nome:<br />
                        <br />
                    </th>
                    <th class="auto-style6" scope="col">
                        <asp:TextBox ID="txtNome" runat="server" Width="531px"></asp:TextBox>
                    </th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <th class="auto-style2" scope="row" style="text-align: left;">
                        <br />
                        E-mail:<br />
                        <br />
                    </th>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" Width="299px" TextMode="Email"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th class="auto-style2" scope="row" style="text-align: left;">
                        <br />
                        Telefone:<br />
                        <br />
                    </th>
                    <td>
                        <asp:TextBox ID="txtTelefone" runat="server" Width="160px" TextMode="Phone"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th class="auto-style2" scope="row" style="text-align: left;">
                        <br />
                        Login:<br />
                        <br />
                    </th>
                    <td>
                        <asp:TextBox ID="txtLogin" runat="server" Width="160px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th class="auto-style2" scope="row" style="text-align: left;">
                        <br />
                        Senha:<br />
                        <br />
                    </th>
                    <td>
                        <asp:TextBox ID="txtSenha" runat="server" Width="160px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th class="auto-style2" scope="row" style="text-align: left;">
                        <br />
                        <asp:RadioButton ID="rbCurador" runat="server" Text="Curador" />
                        <br />
                        <br />
                    </th>
                    <td>
                        <asp:RadioButton ID="rbFuncionario" runat="server" Text="Funcionário" />
                    </td>
                </tr>
            </tbody>
        </table>
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnCancelar" runat="server" BackColor="#FF3300" CssClass="btn btn-danger" ForeColor="White" Height="33px" OnClick="btnCancelar_Click" Text="Cancelar" Width="101px" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCadastrar" runat="server" BackColor="#00CC00" CssClass="btn btn-success" ForeColor="White" Height="33px" OnClick="btnCadastrar_Click" Text="Cadastrar" Width="101px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
    </asp:Panel>
    <br />
</asp:Content>
