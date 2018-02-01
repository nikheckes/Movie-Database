<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Display1.aspx.cs" Inherits="PresentationLayer.Display" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">       
    
       <asp:ListBox ID="lbDisplay" runat="server" 
       DataSourceID="odsDisplay1" DataTextField="MovieName" DataValueField="MovieName"
       BackColor="silver" Font-Names="Papyrus" ForeColor="#555555" 
    Width="215px"></asp:ListBox>

       <br />


        <asp:Button ID="btnUpdate" runat="server" Text="Update" BackColor="lightgray" CausesValidation="true"
 BorderColor="gray" BorderWidth="2" ForeColor="#555555" 
           onclick="btnUpdate_Click" />

    

       <br />

       <asp:RequiredFieldValidator ID="rfvdisplay" runat="server"
            ControlToValidate="lbDisplay" Forecolor="Red" ErrorMessage="* Must select a movie. <br> If there are no movies in the list, <br> click 'Create Movie' to change that.">
        </asp:RequiredFieldValidator>

    <asp:ObjectDataSource ID="odsDisplay1" runat="server" 
        SelectMethod="SelectMovies" TypeName="BLL.Transfer">
    </asp:ObjectDataSource>



    <div style="font-weight: 700">

     

    </div>
    </asp:Content>

