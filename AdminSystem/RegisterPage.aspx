<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegisterPage.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            border: hidden;
            height : max-content;
            background-image: url('https://thesuperleague.com/assets/images/slider/bg/01_Hero8_Chelsea.jpg');
            background-repeat: no-repeat;
            background-attachment: fixed;
            background-size: cover;
        }
    img {
  display: block;
  margin-left: auto;
  margin-right: auto;
  width: 80%;
  height: 30%;
}

  h1 {text-align: center}
  h3 {text-align: center}

  .btn5 {
    border-radius: 5px;
    border: 0;
    border-radius: 5px;
    box-shadow: 1px 2px 5px #666;
 }

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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <img src="https://i.imgur.com/SphRQzL.png" alt="Logo"/>
            <h1 style="color:white;">Register</h1>
            <h3 style="color:white;">Username<asp:TextBox CssClass="Txtstyle4" ID="txtUsername" runat="server" Style="margin-left:auto; display:block; margin-right: auto;"></asp:TextBox>
            </h3>
            <h3 style="color:white;">Password<asp:TextBox CssClass="Txtstyle4" ID="txtPassword" runat="server" TextMode="Password" Style="margin-left:auto; display:block; margin-right: auto;"></asp:TextBox>
            </h3>
            <h3 style="color:white;">Confirm Password<asp:TextBox CssClass="Txtstyle4" ID="txtCPassword" runat="server" TextMode="Password" Style="margin-left:auto; display:block; margin-right: auto;"></asp:TextBox>
            </h3>
            <br />
            <asp:Button CssClass="btn5" ID="btnRegister0" runat="server" OnClick="btnRegister_Click" Text="Register" Style="margin-left:auto; display:block; margin-right: auto;  font-size: large; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF; background-color: #000000;" Height="33px" Width="120px"/> 
            <br />
            <asp:Label ID="lblError" runat="server" Text="" Style="margin-left:auto; display:block; margin-right: auto; text-align:center; color:white; font-size:medium"></asp:Label>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
