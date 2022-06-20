<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Gridview_AutoGenerateColumns.aspx.cs" Inherits="WebApplication1.Gridview.Gridview_AutoGenerateColumns" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Gridview (with AutoGenerateColumns)</h1>

    <h2>Gridview: Example 1 (direct List)</h2>
    <asp:GridView ID="GridView1" runat="server" 
            AutoGenerateColumns="true" 
            OnRowDataBound="GridView1_RowDataBound"></asp:GridView>


     <h2>Gridview: Example 2 (with DataTable)</h2>
     <asp:GridView ID="GridView2" runat="server" 
            AutoGenerateColumns="true"></asp:GridView>
    

     <h2>Gridview: Example 3 (Add custom columns and AutoGenerateColumns) </h2>
     <asp:GridView ID="GridView3" runat="server" 
            AutoGenerateColumns="true">

         <Columns>
             <asp:TemplateField>
                 <HeaderTemplate>
                     <strong>Seguro Inicial</strong>
                 </HeaderTemplate>
                 <ItemTemplate>
                    <%#Eval("Power")%> 
                 </ItemTemplate>
             </asp:TemplateField>
             <asp:TemplateField>
                 <ItemTemplate>
                    <%#Eval("Power", "{0:0.#00}")%> %
                 </ItemTemplate>
             </asp:TemplateField>
             <asp:TemplateField>
                 <ItemTemplate>
                    <%#Eval("Power", "{0:C2}")%>
                 </ItemTemplate>
             </asp:TemplateField>
             <asp:TemplateField>
                 <ItemTemplate>
                    <%#Eval("Power", "{0:C3}")%>
                 </ItemTemplate>
             </asp:TemplateField>             
         </Columns>         
     </asp:GridView>
</asp:Content>
