<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminRegister.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            border: hidden;
            height : max-content;
            background-image: url('../images/StadiumMono.jpg');
            background-repeat: no-repeat;
            background-attachment: fixed;
            background-size: cover;
        }
  img {
  display: block;
  margin-left: auto;
  margin-right: auto;
}

  h1 {text-align: center}
  h3 {text-align: center}

    .Txtstyle4 {         
        border: 1px solid #c4c4c4;                 
        border-radius: 4px;         
        box-shadow: 0px 0px 8px #d9d9d9;         
        background-color: #F0F0FF;         
   }         
   .Txtstyle4:focus {         
        outline: none;         
        border: 1px solid #7bc1f7;         
        box-shadow: 0px 0px 8px #7bc1f7;         
        background-color: #FFF2FF;         
   }
   .btn5:hover{
    
    transform:scale(1.1);
    
}

     .btn5 {
    border-radius: 5px;
    border: 0;
    border-radius: 5px;
    box-shadow: 1px 2px 5px #666;
 }
         img {
  display: block;
  margin-left: auto;
  margin-right: auto;
  width: 80%;
  height: 40%;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <img src="../images/Logo.png" alt="Logo" />
            <h1 style="color:white;">Register</h1>
            <h3 style="color:white;">First Name<asp:TextBox CssClass="Txtstyle4" ID="txtFName" runat="server" Style="margin-left:auto; display:block; margin-right: auto;"></asp:TextBox>
            </h3>
            <h3 style="color:white;">Last Name<asp:TextBox CssClass="Txtstyle4" ID="txtName" runat="server" Style="margin-left:auto; display:block; margin-right: auto;"></asp:TextBox>
            </h3>
            <h3 style="color:white;">Password<asp:TextBox CssClass="Txtstyle4" ID="txtPassword" TextMode="Password" runat="server" Style="margin-left:auto; display:block; margin-right: auto;"></asp:TextBox>
            </h3>
            <h3 style="color:white;">Confirm Password<asp:TextBox CssClass="Txtstyle4" ID="txtCPassword" TextMode="Password" runat="server" Style="margin-left:auto; display:block; margin-right: auto;"></asp:TextBox>
            </h3>
            <h3 style="color:white;">AdminCode<asp:TextBox CssClass="Txtstyle4" ID="txtAdminCode" runat="server" Style="margin-left:auto; display:block; margin-right: auto;"></asp:TextBox>
            </h3>
            <br />
            <asp:Button CssClass="btn5" ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" Style="margin-left:auto; display:block; margin-right: auto;  font-size: large; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; background-color: #000000;" Height="33px"/> 
            <br />
            <asp:Button CssClass="btn5" ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login Instead" Style="margin-left:auto; display:block; margin-right: auto;  font-size: large; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; background-color: #000000;" Height="33px" /> 
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text="" Style="margin-left:auto; display:block; margin-right: auto; text-align:center; color:white; font-size:medium"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
