<%@ Page Title="" Language="C#" MasterPageFile="~/Dungeon.Master" AutoEventWireup="true" CodeBehind="Issues.aspx.cs" Inherits="cool_front.Issues" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="formo4ka" runat="server">

        <div id="table" runat="server"></div>
        <div id="add" runat="server">
            <asp:DropDownList runat="server" ID="equipments" />
            <asp:DropDownList runat="server" ID="employees" />
            <input type="date" runat="server" placeholder="Выдан" id="issued">
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
        </div>
    </form>
</asp:Content>
