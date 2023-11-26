<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Gridview_SelectRow.aspx.cs" Inherits="WebApplication1.Gridview.Gridview_SelectRow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <h1>Gridview (SelectRow)</h1>

    <h2>Gridview: Example 1 (...)</h2>
    <asp:GridView ID="GridView1" runat="server" 
            AutoGenerateColumns="true">

          <Columns>
             <asp:TemplateField>
                 <HeaderTemplate>
                     <strong>Acciones</strong>
                 </HeaderTemplate>
                 <ItemTemplate>
                    <asp:LinkButton ID="jediSelectLink" runat="server" 
                        DataTextField="Id" 
                        CommandArgument='<%# Eval("Id")%>'> 
                        Seleccionar
                        </asp:LinkButton>
                 </ItemTemplate>
             </asp:TemplateField>          
         </Columns>       


    </asp:GridView>


</asp:Content>
