<%@ Page Title="" Language="C#" MasterPageFile="~/Dungeon.Master" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="cool_front.Employees" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="formo4ka" runat="server">
        <div id="table" runat="server"></div>
        <div id="add" runat="server">
            <input type="text" runat="server" placeholder="Имя" id="name">
            <input type="date" runat="server" placeholder="Дата рождения" id="bd">
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
        </div>
    </form>
</asp:Content>
