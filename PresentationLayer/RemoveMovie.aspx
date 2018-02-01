<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RemoveMovie.aspx.cs" Inherits="PresentationLayer.RemoveMovie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
     <asp:ListBox ID="lbNames" runat="server" DataSourceID="odsMovieNames" 
         DataTextField="MovieName" DataValueField="ID"
         BackColor="silver" Font-Names="Papyrus" ForeColor="#555555" Width="215px"></asp:ListBox>
    </div>
    <asp:ObjectDataSource ID="odsMovieNames" runat="server" 
        SelectMethod="SelectMovies" TypeName="BLL.Transfer">
    </asp:ObjectDataSource>
    <asp:Label ID="lblEmpty" runat="server" forecolor="red" Text=""></asp:Label>
   <div><asp:Button ID="btnRemoveMovie" Text="Remove" runat="server" BackColor="lightgray" CausesValidation="true"
 BorderColor="gray" BorderWidth="2" ForeColor="#555555" onclick="btnRemoveMovie_Click" /></div>
      <div><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
            ControlToValidate="lbNames" Forecolor="Red" ErrorMessage="* Must select a movie to delete. <br> If there are no movies in the list, <br> click 'Create Movie' to change that.">
        </asp:RequiredFieldValidator></div>
    </asp:Content>
