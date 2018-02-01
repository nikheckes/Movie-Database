<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateMovie.aspx.cs" Inherits="PresentationLayer.UpdateMovie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">       
    <div>
    <asp:Label ID="lblName" class="createLabels" runat="server" Text="Name:"></asp:Label>
    <asp:TextBox ID="txtName" runat="server" BackColor="lightgray" 
  BorderColor="#ccbbbb" ForeColor="#555555" Font-Names="Papyrus"></asp:TextBox>
    <br />
       <asp:Label ID="lblDirector" class="createLabels" runat="server" Text="Director:"></asp:Label>
       <asp:TextBox ID="txtDirector" runat="server" BackColor="lightgray" 
  BorderColor="#ccbbbb" ForeColor="#555555" Font-Names="Papyrus"></asp:TextBox>
  <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" BackColor="lightgrey"
 BorderColor="gray" BorderWidth="2" ForeColor="#555555" Font-Names="Papyrus" onclick="btnSubmit_Click" 
            />
        <br />
        <asp:HiddenField ID="hfID" runat="server" />
    </div>

       </asp:Content>

