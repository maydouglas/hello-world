<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Celulares.aspx.cs" Inherits="BrasilNegocios.Celulares.Celulares" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="IdProduto" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="IdProduto" HeaderText="IdProduto" SortExpression="IdProduto" />
            <asp:BoundField DataField="Produto" HeaderText="Produto" SortExpression="Produto" />
            <asp:BoundField DataField="Valor" HeaderText="Valor" SortExpression="Valor" />
            <asp:BoundField DataField="IdCategoriaProduto" HeaderText="IdCategoriaProduto" SortExpression="IdCategoriaProduto" />
            <asp:BoundField DataField="IdFornecedor" HeaderText="IdFornecedor" SortExpression="IdFornecedor" />
            <asp:BoundField DataField="St" HeaderText="St" SortExpression="St" />
            <asp:BoundField DataField="Dsy" HeaderText="Dsy" SortExpression="Dsy" />
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
    <br />
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" CellPadding="4" DataSourceID="ObjectDataSource1" DefaultMode="Insert" ForeColor="#333333" GridLines="None" Height="50px" Width="125px">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
        <EditRowStyle BackColor="#999999" />
        <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
        <Fields>
            <asp:BoundField DataField="IdProduto" HeaderText="IdProduto" InsertVisible="false" SortExpression="IdProduto" />
            <asp:BoundField DataField="Produto" HeaderText="Produto" SortExpression="Produto" />
            <asp:BoundField DataField="Valor" HeaderText="Valor" SortExpression="Valor" />
            <asp:BoundField DataField="IdCategoriaProduto" HeaderText="IdCategoriaProduto" SortExpression="IdCategoriaProduto" />
            <asp:BoundField DataField="IdFornecedor" HeaderText="IdFornecedor" SortExpression="IdFornecedor" />
            <asp:BoundField DataField="St" HeaderText="St" SortExpression="St" />
            <asp:BoundField DataField="Dsy" HeaderText="Dsy" SortExpression="Dsy" />
            <asp:CommandField ShowInsertButton="True" />
        </Fields>
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
    </asp:DetailsView>
    <br />
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="BrasilNegocios.Entidades.Produtos" DeleteMethod="DeleteProdutos" InsertMethod="InsertProdutos" SelectMethod="GetProdutos" TypeName="BrasilNegocios.Entidades.RepositorioProdutos" UpdateMethod="UpdateProdutos"></asp:ObjectDataSource>
</asp:Content>
