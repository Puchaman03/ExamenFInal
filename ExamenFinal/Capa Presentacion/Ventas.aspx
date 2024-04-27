<%@ Page Title="" Language="C#" MasterPageFile="~/Capa Presentacion/Menu.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="ExamenFinal.Capa_Presentacion.Ventas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        Tabla de Ventas
<asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
</asp:GridView>
<p>
</p>
</asp:Content>
