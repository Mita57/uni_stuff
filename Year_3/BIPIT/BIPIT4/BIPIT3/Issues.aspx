<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Issues.aspx.cs" Inherits="BIPIT3.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <input type="date" id="dateLeft" runat="server">
        <input type="date" id="dateRight" runat="server">
        <asp:Button ID="sortBtn" runat="server" Text="Sort" OnClick="sortBtn_Click" />
            <div id="table" runat="server"></div>
            <asp:Button ID="DeleteBtn" runat="server" Text="RemoveKebab" OnClick="DeleteBtn_Click" />
    </div>
        <div id="add">
        <form id="form1" runat="server">
            <select id="employee" runat="server"> </select>
            <select id="equipment" runat="server"> </select>
            <input type="date" runat="server" placeholder="Выдан" id="issued">
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
        </form>
    </div>
</asp:Content>
