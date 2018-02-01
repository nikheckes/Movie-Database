<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateMovie.aspx.cs" Inherits="PresentationLayer.CreateMovie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">       
    <div>
    <span class="createLabels">
    <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
    </span>
    <asp:TextBox ID="txtName" runat="server" BackColor="lightgray" 
  BorderColor="#ccbbbb" ForeColor="#555555" Font-Names="Papyrus"></asp:TextBox>
  <asp:RequiredFieldValidator ID="rfvdisplay" runat="server"
            ControlToValidate="txtName" Forecolor="Red" ErrorMessage="* Name field required">
        </asp:RequiredFieldValidator>
    <br />
    <Span class="createLabels">
       <asp:Label ID="lblDirector" class="createLabels" runat="server" Text="Director:"></asp:Label>
       </Span>
       <asp:TextBox ID="txtDirector" runat="server" BackColor="lightgray" 
  BorderColor="#ccbbbb" ForeColor="#555555" Font-Names="Papyrus"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
            ControlToValidate="txtDirector" Forecolor="Red" ErrorMessage="* Director field required">
        </asp:RequiredFieldValidator>
  <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" BackColor="lightgrey"
 BorderColor="gray" BorderWidth="2" ForeColor="#555555" Font-Names="Papyrus" onclick="btnSubmit_Click" 
            />
    </div>

       </asp:Content>

