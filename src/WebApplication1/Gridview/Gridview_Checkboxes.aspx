<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Gridview_Checkboxes.aspx.cs" Inherits="WebApplication1.Gridview.Gridview_Checkboxes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <h1>Gridview (Checkboxes)</h1>

 <h2>Gridview: Checkboxes Example 1</h2>

    <asp:GridView ID="GridView1" runat="server"
        AutoGenerateColumns="false" 
        OnRowUpdated="GridView1_RowUpdated" 
        OnRowUpdating="GridView1_RowUpdating"
        OnRowCancelingEdit="GridView1_RowCancelingEdit"
        OnRowEditing="GridView1_RowEditing">

       <Columns>
           <asp:BoundField DataField="Id" HeaderText="Id" Visible="False" ReadOnly="True" />
           <asp:TemplateField HeaderText="Name">
            <ItemTemplate>
                <asp:TextBox runat="server" ID="txtName"  Text='<%# Bind("Name") %>' />
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox runat="server" ID="txtName" Text='<%# Bind("Name") %>' />
            </EditItemTemplate>
        </asp:TemplateField>

           <asp:TemplateField HeaderText="IsEnabled">
            <ItemTemplate>
                <asp:CheckBox runat="server" ID="chkIsEnabled" Enabled="false" Checked='<%# Bind("IsEnabled") %>' />
            </ItemTemplate>
            <EditItemTemplate>
                <asp:CheckBox runat="server" ID="chkIsEnabled" Checked='<%# Bind("IsEnabled") %>' />
            </EditItemTemplate>
        </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnEdit" runat="server" Text="Edit" CommandName="Edit" />
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" CommandName="Update"/>
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" CommandName="Cancel"/>
                </EditItemTemplate>
            </asp:TemplateField>
      </Columns>       


 </asp:GridView>

</asp:Content>
