<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms.Master" AutoEventWireup="true" CodeBehind="ManageItem.aspx.cs" Inherits="WebApplication1.Admin.ManageItem" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <head>
        <title></title>
        <link href="../Content/RentMyWrox.css" rel="stylesheet" type="text/css" />
        <meta name="keywords" content="Tools, Lending Library, Manage Items,
actual useful keywords here" />
        <meta name="description" content="Manage the items that are available to be
checked out from the library" />
    </head>
    <div>
        <div class="dataentry">
            <asp:Label runat="server" Text="Name" AssociatedControlID="tbName" />
            <asp:TextBox runat="server" ID="tbName" />
        </div>
    </div>
    <div class="dataentry">
        <asp:Label runat="server" Text="Description"
            AssociatedControlID="tbDescription" />
        <asp:TextBox runat="server" ID="tbDescription"
            TextMode="MultiLine" Rows="5" />
    </div>
    <div class="dataentry">
        <asp:Label runat="server" Text="Cost"
            AssociatedControlID="tbCost" />
        <asp:TextBox runat="server" ID="tbCost" />
    </div>
    <style>
    </style>
    <div class="dataentry">
        <asp:Label runat="server" Text="Item Number"
            AssociatedControlID="tbItemNumber" />
        <asp:TextBox runat="server" ID="tbItemNumber" />
    </div>
    <div class="dataentry">
        <asp:Label runat="server" Text="Picture" AssociatedControlID="fuPicture" />
        <asp:FileUpload ID="fuPicture" ClientIDMode="Static" runat="server" />
    </div>
    <div class="dataentry">
        <asp:Label runat="server" Text="Acquired Date"
            AssociatedControlID="tbAcquiredDate" />
        <asp:TextBox runat="server" ID="tbAcquiredDate" />
    </div>
    <asp:Button Text="Save Item" runat="server" OnClick="Unnamed_Click" />
</asp:Content>

