<%@ Page Title="" Language="C#" MasterPageFile="~/MuseuMaster.Master" AutoEventWireup="true" CodeBehind="Eventos.aspx.cs" Inherits="WebMuseu.Eventos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style17 {
            width: 170px;
            height: 188px;
        }
        .auto-style39 {
            margin-left: 3px;
        }
        .auto-style40 {
            margin-left: 0px;
        }
        .auto-style41 {
            width: 120px;
            height: 11px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblEventos" runat="server" Font-Size="XX-Large" Text="Acervo - Eventos" Font-Names="Segoe Print"></asp:Label>
    </p>
    <asp:ObjectDataSource ID="ObjectEvento" runat="server" DataObjectTypeName="Model.Evento" DeleteMethod="Delete" InsertMethod="Create" SelectMethod="Listar" TypeName="Bll.EventoBll" UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="codigo" Type="Int32" />
        </DeleteParameters>
        <SelectParameters>
            <asp:Parameter Name="filtro" Type="String" ConvertEmptyStringToNull="false" DefaultValue="" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <p>
        &nbsp;</p>
    <asp:Panel ID="panelTable" runat="server" Width="1099px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:GridView ID="GridEventos" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectEvento" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" DataKeyNames="Id">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="Titulo" HeaderText="Titulo" SortExpression="Titulo" />
                <asp:BoundField DataField="Responsavel" HeaderText="Responsavel" SortExpression="Responsavel" />
                <asp:BoundField DataField="ResponsavelNome" HeaderText="ResponsavelNome" SortExpression="ResponsavelNome" />
                <asp:BoundField DataField="DataInicio" HeaderText="DataInicio" SortExpression="DataInicio" />
                <asp:BoundField DataField="DataFim" HeaderText="DataFim" SortExpression="DataFim" />
                <asp:BoundField DataField="Obra" HeaderText="Obra" SortExpression="Obra" />
                <asp:CommandField ButtonType="Image" CancelImageUrl="~/Content/error_16x16.gif" DeleteImageUrl="~/Content/flag4_(delete)_16x16.gif" EditImageUrl="~/Content/flag4_(edit)_16x16.gif" HeaderText="Opções" ShowDeleteButton="True" UpdateImageUrl="~/Content/save_16x16.gif" ShowSelectButton="True" SelectImageUrl="~/Content/flag4_16x16.gif" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnAdicionarObras" runat="server" BackColor="#99CCFF" CssClass="btn btn-info" ForeColor="White" Height="36px" OnClick="btnAdicionarObras_Click" Text="Adicionar ou Remover Obras" Width="231px" />
        &nbsp;&nbsp; &nbsp;
        <asp:Button ID="btnIncluir" runat="server" BackColor="#99CCFF" CssClass="btn btn-info" ForeColor="White" Height="36px" OnClick="btnIncluir_Click" Text="Incluir" Width="85px" />
        <br />
    </asp:Panel>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;</p>
        <asp:Panel ID="PanelEvento" runat="server" Height="299px" Width="1099px">
            <br />
            <br />
            <table>
                <thead>
                    <tr>
                        <th class="auto-style5" scope="col" style="text-align: left;">
                            <br />
                            Nome do Evento:<br /> <br /> </th>
                        <th class="auto-style6" scope="col">
                            <asp:TextBox ID="txtNomeEvento" runat="server" Width="531px"></asp:TextBox>
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th class="auto-style2" scope="row" style="text-align: left;">
                            <br />
                            Responsável:<br /> <br /> </th>
                        <td>
                            <asp:TextBox ID="txtResponsavel" runat="server" TextMode="Number" Width="299px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <th class="auto-style2" scope="row" style="text-align: left;">
                            <br />
                            Inicio:<br /> <br /> </th>
                        <td>
                            <asp:TextBox ID="txtDataInicio" runat="server" TextMode="Date" Width="206px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <th class="auto-style2" scope="row" style="text-align: left;">
                            <br />
                            Final:<br /> <br /> </th>
                        <td>
                            <asp:TextBox ID="txtDataFinal" runat="server" TextMode="Date" Width="204px"></asp:TextBox>
                        </td>
                    </tr>
                </tbody>
            </table>
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>

            <p>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancelar" runat="server" BackColor="#FF3300" CssClass="btn btn-danger" ForeColor="White" Height="33px" OnClick="btnCancelar_Click" Text="Cancelar" Width="101px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCadastrar" runat="server" BackColor="#00CC00" CssClass="btn btn-success" ForeColor="White" Height="33px" OnClick="btnCadastrar_Click" Text="Cadastrar" Width="101px" style="margin-bottom: 0" />
            </p>
            </asp:Panel>
            
            &nbsp;
            <asp:Panel ID="PanelObras" runat="server" Height="766px" Width="1099px">
                <br />
                <br />
                <br />
                <table class="auto-style40">
                    <tbody>
                        <tr>
                            <th class="auto-style34" scope="col" style="text-align: left;">&nbsp;</th>
                            <th class="auto-style39" scope="row" style="text-align: left;">Obras</th>
                            <td class="auto-style17">
                                <br />
                                <br />
                                Selecione suas Obras
                                <asp:ObjectDataSource ID="ObjectObra" runat="server" SelectMethod="Listar" TypeName="Bll.ObraBll">
                                    <SelectParameters>
                                        <asp:Parameter ConvertEmptyStringToNull="false" DefaultValue="" Name="filtro" Type="String" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>

                                <asp:DropDownList ID="cbxObra" runat="server" DataSourceID="ObjectObra" DataTextField="Titulo" DataValueField="Titulo">
                                </asp:DropDownList>

                                <asp:Button ID="btnAdicionarItem" runat="server" CssClass="btn btn-info" OnClick="btnAdicionarItem_Click" Text="Adicionar" />
                                <br />
                                
                                <asp:ObjectDataSource ID="ObjectItem" runat="server" DeleteMethod="Delete" InsertMethod="Create" SelectMethod="Listar" TypeName="Bll.ItemEventoBll" UpdateMethod="Update">
                                    <DeleteParameters>
                                        <asp:Parameter Name="codigo" Type="Int32" />
                                    </DeleteParameters>
                                    <InsertParameters>
                                        <asp:Parameter Name="idObra" Type="Int32" />
                                        <asp:Parameter Name="idEvento" Type="Int32" />
                                    </InsertParameters>
                                    <SelectParameters>
                                        <asp:Parameter Name="idEvento" Type="Int32" />
                                    </SelectParameters>
                                    <UpdateParameters>
                                        <asp:Parameter Name="id" Type="Int32" />
                                        <asp:Parameter Name="idObra" Type="Int32" />
                                        <asp:Parameter Name="idEvento" Type="Int32" />
                                    </UpdateParameters>
                                </asp:ObjectDataSource>
                                
                                <asp:GridView ID="dgvItemEventos" runat="server" AutoGenerateColumns="false" DataSourceID="ObjectItem" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" CssClass="auto-style41" style="margin-left: 2px" ViewStateMode="Enabled">
                                    <Columns>
                                        <asp:CommandField ShowDeleteButton="True" />
                                        <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                                        <asp:BoundField DataField="Titulo" HeaderText="Titulo" SortExpression="Titulo" />
                                        <asp:BoundField DataField="Autor" HeaderText="Autor" SortExpression="Autor" />
                                        <asp:BoundField DataField="Aquisicao" HeaderText="Aquisicao" SortExpression="Aquisicao" />
                                        <asp:BoundField DataField="Local" HeaderText="Local" SortExpression="Local" />
                                        <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                                        <asp:BoundField DataField="Condicoes" HeaderText="Condicoes" SortExpression="Condicoes" />
                                        <asp:BoundField DataField="Valor" HeaderText="Valor" SortExpression="Valor" />
                                        <asp:BoundField DataField="Descricao" HeaderText="Descricao" SortExpression="Descricao" />
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

                                <asp:ObjectDataSource ID="ObjectObras" runat="server" DataObjectTypeName="Model.Obra" SelectMethod="Listar" TypeName="Bll.ObraBll">
                                    <SelectParameters>
                                        <asp:Parameter Name="filtro" Type="String" ConvertEmptyStringToNull="false" DefaultValue=""/>
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                                <br />
                                &nbsp;&nbsp;&nbsp;<asp:GridView ID="GridObras" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectObras" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" CssClass="auto-style40">
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
                                        <asp:CommandField HeaderText="Selecionar" ShowSelectButton="True" />
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
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                            </td>
                        </tr>
                    </tbody>
                </table>
            </asp:Panel>
        <br />
</asp:Content>
