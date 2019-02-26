<%@ Page Title="" Language="C#" MasterPageFile="~/MuseuMaster.Master" AutoEventWireup="true" CodeBehind="Obras.aspx.cs" Inherits="WebMuseu.Obras" %>
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
            margin-left: 1px;
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
        <asp:Label ID="lblObras" runat="server" Font-Size="XX-Large" Text="Acervo - Obras" Font-Names="Segoe Print"></asp:Label>
    </p>
    <p>
        <asp:ObjectDataSource ID="ObjectObras" runat="server" DataObjectTypeName="Model.Obra" DeleteMethod="Delete" InsertMethod="Create" SelectMethod="Listar" TypeName="Bll.ObraBll" UpdateMethod="Update">
            <SelectParameters>
                <asp:Parameter Name="filtro" Type="String"  ConvertEmptyStringToNull="false" DefaultValue="" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </p>
    <asp:Panel ID="panelTable" runat="server">
        <table id="painelTable">
            <tr>
            
                <th scope="col">
                    <asp:GridView ID="GridObras" runat="server" AutoGenerateColumns="False" CssClass="auto-style7" DataSourceID="ObjectObras" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="4" AllowPaging="True" DataKeyNames="Id">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                            <asp:BoundField DataField="Titulo" HeaderText="Titulo" SortExpression="Titulo" />
                            <asp:BoundField DataField="Autor" HeaderText="Autor" SortExpression="Autor" />
                            <asp:BoundField DataField="Aquisicao" HeaderText="Aquisicao" SortExpression="Aquisicao" />
                            <asp:BoundField DataField="Local" HeaderText="Local" SortExpression="Local" />
                            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                            <asp:BoundField DataField="Condicoes" HeaderText="Condicoes" SortExpression="Condicoes" />
                            <asp:BoundField DataField="Valor" HeaderText="Valor" SortExpression="Valor" />
                            <asp:BoundField DataField="Descricao" HeaderText="Descricao" SortExpression="Descricao" />
                            <asp:CommandField ButtonType="Image" CancelImageUrl="~/Content/error_16x16.gif" DeleteImageUrl="~/Content/image_(delete)_16x16.gif" EditImageUrl="~/Content/image_(edit)_16x16.gif" HeaderText="Opções" ShowDeleteButton="True" ShowEditButton="True" UpdateImageUrl="~/Content/save_16x16.gif" />
                        </Columns>
                        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FFF1D4" />
                        <SortedAscendingHeaderStyle BackColor="#B95C30" />
                        <SortedDescendingCellStyle BackColor="#F1E5CE" />
                        <SortedDescendingHeaderStyle BackColor="#93451F" />
                    </asp:GridView>
                </th>
            </tr>
        </table>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnIncluir" runat="server" BackColor="#99CCFF" CssClass="btn btn-info" ForeColor="White" Height="36px" Text="Incluir" Width="85px" OnClick="btnIncluir_Click" />
        <br />
    </asp:Panel>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;</p>
    <asp:Panel ID="painelObras" runat="server" Height="801px" Visible="False" Font-Names="Century Gothic">
        &nbsp;
        <table>
            <thead>
                <tr>
                    <th class="auto-style5" scope="col" style="text-align: left;">
                        <br />
                        Obra:<br />
                        <br />
                    </th>
                    <th class="auto-style6" scope="col">
                        <asp:TextBox ID="txtObra" runat="server" Width="531px"></asp:TextBox>
                    </th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <th class="auto-style2" scope="row" style="text-align: left;">
                        <br />
                        Autor:<br />
                        <br />
                    </th>
                    <td>
                        <asp:TextBox ID="txtAutor" runat="server" Width="299px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th class="auto-style2" scope="row" style="text-align: left;">
                        <br />
                        Aquisição:<br />
                        <br />
                    </th>
                    <td>
                        <asp:TextBox ID="txtAquisicao" runat="server" TextMode="Date" Width="199px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th class="auto-style2" scope="row" style="text-align: left;">
                        <br />
                        Local:<br />
                        <br />
                    </th>
                    <td>
                        <asp:TextBox ID="txtLocal" runat="server" Width="160px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th class="auto-style2" scope="row" style="text-align: left;">
                        <br />
                        Status:<br />
                        <br />
                    </th>
                    <td>
                        <asp:DropDownList ID="cbxStatus" runat="server" Width="153px">
                            <asp:ListItem Value="Em exposição"></asp:ListItem>
                            <asp:ListItem Value="Disponível"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <th class="auto-style5" scope="row" style="text-align: left;">
                        <br />
                        Condições:<br />
                        <br />
                    </th>
                    <td class="auto-style6">
                        <asp:DropDownList ID="cbxCondicoes" runat="server" Width="151px">
                            <asp:ListItem Value="Perfeitas Condições"></asp:ListItem>
                            <asp:ListItem Value="Conservada"></asp:ListItem>
                            <asp:ListItem Value="Comprometida"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <th class="auto-style5" scope="row" style="text-align: left;">
                        <br />
                        Seguro:<br />
                        <br />
                    </th>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtSeguro" runat="server" Width="211px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th class="auto-style5" scope="row" style="text-align: left;">
                        <br />
                        Descrição:<br />
                        <br />
                    </th>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtDescricao" runat="server" Height="36px" TextMode="MultiLine" Width="274px"></asp:TextBox>
                    </td>
                </tr>
            </tbody>
        </table>
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancelarObra" runat="server" BackColor="#FF3300" CssClass="btn btn-danger" ForeColor="White" Height="33px" Text="Cancelar" Width="101px" OnClick="btnCancelarObra_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCadastrarObra" runat="server" BackColor="#00CC00" CssClass="btn btn-success" ForeColor="White" Height="33px" Text="Cadastrar" Width="101px" OnClick="btnCadastrarObra_Click" />
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
</asp:Content>
