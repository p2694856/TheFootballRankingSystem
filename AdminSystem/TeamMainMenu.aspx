<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Page</title>
    <style>

body {
    height : max-content;
  background-image: url('../images/Stadium.jpg');
  background-repeat: no-repeat;
  background-attachment: fixed;
  background-size: cover;
}
p {text-align: center;}
  img {
  display: block;
  margin-left: auto;
  margin-right: auto;
  width: 80%;
  height: 40%;
}
div {align-self: center;
     margin-left: auto;
     margin-right: auto;
     margin-top: auto;
     margin-bottom: auto;
}
h1 {text-align: center}

.btn5 {
    border-radius: 5px;
    border: 0;
    border-radius: 5px;
    box-shadow: 1px 2px 5px #666;
 }

.btn5:hover{
    
    transform:scale(1.1);
    
}

 

</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <br />
 <br />
 <br />
 <br />
            
                <h1 style="color:white;">Welcome to</h1>
                <img src="../images/Logo.png" alt="Logo"/>
                <p style="color:white;">Login Or Register Here</p>
                <asp:Button CssClass="btn5" ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" Style="margin-left:auto; display:block; margin-right: auto; font-size: large; font-family: Arial, Helvetica, sans-serif; font-style: normal; color: #FFFFFF; background-color: #000000; " Height="33px" Width="78px"/>
            <br />
                <asp:Button CssClass="btn5" ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" Style="margin-left:auto; display:block; margin-right: auto;  font-size: large; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; background-color: #000000;" Height="33px" Width="120px"/>
        <br />
    <asp:Button CssClass="btn5" ID="btnAdmin" runat="server" OnClick="btnAdmin_Click" Text="Admin" Style="margin-left:auto; display:block; margin-right: auto;  font-size: large; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; background-color: #000000;" Height="33px" Width="120px"/>
        
        </div>
    </form>
</body>
</html>
