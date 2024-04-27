<%@ Page Title="" Language="C#" MasterPageFile="~/Capa Presentacion/Menu.Master" AutoEventWireup="true" CodeBehind="Agente.aspx.cs" Inherits="ExamenFinal.Capa_Presentacion.Agente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    TABLA DE AGENTES

    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
    </asp:GridView>

</asp:Content>
