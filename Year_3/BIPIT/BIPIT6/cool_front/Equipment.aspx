<%@ Page Title="" Language="C#" MasterPageFile="~/Dungeon.Master" AutoEventWireup="true" CodeBehind="Equipment.aspx.cs" Inherits="cool_front.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="formo4ka" runat="server">
        <div>
            <div id="table" runat="server"></div>
        </div>
        <div id="add" runat="server">
            <input type="text" runat="server" placeholder="Название" id="name">
            <input type="text" runat="server" placeholder="Цена" id="price">
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
        </div>
    </form>
</asp:Content>
