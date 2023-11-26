<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET Webforms experiments</h1>
        <p class="lead">Code Kata with ASP.NET Webforms (practices, explorations, experiments, tests or just playing with code)</p>
        <p><a href="https://github.com/fernandezja/aspnet-webforms-experiments" class="btn btn-primary btn-lg">https://github.com/fernandezja/aspnet-webforms-experiments</a></p>
    </div>

    <div class="row">
        <div class="col-md-6">
            <h2>Gridview</h2>
            <ul>
                <li><a href="Gridview/Gridview_AutoGenerateColumns.aspx">Gridview (with AutoGenerateColumns)</a></li>
                <li><a href="Gridview/Gridview_SelectRow.aspx">Gridview (SelectRow)</a></li>
            </ul>
        </div>
        
    </div>

</asp:Content>
