<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BIPIT3.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="formo4ka" runat="server">
        <div runat="server">
            <input type="date" id="dateLeft" runat="server">
            <input type="date" id="dateRight" runat="server">
            <asp:Button ID="sortBtn" runat="server" Text="Sort" OnClick="sortBtn_Click" />
            <asp:Button ID="DeleteBtn" runat="server" Text="RemoveKebab" onclick="DeleteBtn_Click" />
        </div>
        <asp:GridView ID="Table1" 
                           HorizontalAlign="Center" 
                            Font-Names="Verdana" 
                            Font-Size="8pt" 
                            CellPadding="15" 
                            runat = "server">
                <Columns>
                    <asp:TemplateField HeaderText="Выбрать">
                        <ItemTemplate>
                            <asp:CheckBox ID="ch" runat="server" AutoPostBack="true" Checked="false" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        <div id="add" runat="server">
            <input type="text" runat="server" placeholder="Название" id="name">
            <input type="text" runat="server" placeholder="Цена" id="price">
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
        </div>
        <div id="deb" runat="server"></div>
    </form>
</asp:Content>
