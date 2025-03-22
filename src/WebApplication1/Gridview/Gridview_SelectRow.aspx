<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Gridview_SelectRow.aspx.cs" Inherits="WebApplication1.Gridview.Gridview_SelectRow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <h1>Gridview (SelectRow)</h1>

    <h2>Gridview: Example 1 (...)</h2>
    <asp:GridView ID="GridView1" runat="server" 
            AutoGenerateColumns="true" 
            OnSelectedIndexChanged="GridView1_SelectedIndexChanged">

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


    <strong>Selected Row</strong>
    <ul>
        <li>Index:
            <asp:Label ID="Index" runat="server" Text="Label"></asp:Label></li>
        <li>JediId:
            <asp:Label ID="JediId" runat="server" Text="Label"></asp:Label></li>
        <li>Name:
            <asp:Label ID="JediName" runat="server" Text="Label"></asp:Label></li>
    </ul>
  
</asp:Content>
