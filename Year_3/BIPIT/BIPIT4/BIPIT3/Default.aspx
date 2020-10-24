<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BIPIT3.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
            <div id="table" runat="server"></div>
            <asp:Button ID="DeleteBtn" runat="server" Text="RemoveKebab" OnClick="DeleteBtn_Click" />
    </div>
        <div id="add">
        <form id="form1" runat="server">
            <input type="text" runat="server" placeholder="Название" id="name">
            <input type="text" runat="server" placeholder="Цена" id="price">
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
        </form>
    </div>
</asp:Content>
