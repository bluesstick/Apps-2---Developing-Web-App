<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IntroToCss.aspx.cs" Inherits="WebApplication1.IntroToCss" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<style>body {
    color: orange;
    font-size: 20px;
    font-weight: 800;
    background-color: lightblue;
}

h1 {
    color: red;
    font-family:Symbol;
    font-size: 40px;
}

.special {
    color: black;
    font-size: 16px;
}
</style>
<head runat="server">
    <title></title>
    
</head>
<body>
    <h1> Introduccion to CSS</h1>
    I am test text
    <div class="special">
        And I am special text!
    </div>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
