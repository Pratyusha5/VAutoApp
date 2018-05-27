<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SortForm.aspx.cs" Inherits="VAutoApp.SortForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VAuto Code Challenge:</title>
    <link rel="stylesheet" type="text/css" href="~/scripts/VAutoStyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server" >
       
    <div id="mat">
         <fieldset>
    <legend>VAuto </legend>
        <asp:Label ID="Label2" runat="server" Text="PLEASE ENTER THE WORDS TO BE SORTED:"></asp:Label><br /><br />           
        <asp:TextBox ID="txtWords" runat="server" TextMode="MultiLine" Rows="6" Columns="32" ReadOnly="false" ></asp:TextBox><br />&nbsp;&nbsp;&nbsp;
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtWords" ErrorMessage="You need to enter the words to be sorted." ForeColor="Red"></asp:RequiredFieldValidator><br />
             <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtWords" ValidationExpression="^[a-zA-Z ]*$" ForeColor="Red" ErrorMessage="Enter Valid Data. Ideally It should be text seperated with spaces."></asp:RegularExpressionValidator><br />
             <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Clear" OnClick="Button2_Click" CausesValidation="false"/><br /><br />
        <asp:Label ID="Label1" runat="server" Text="SORT MATRIX OF WORDS:"></asp:Label><br /><br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" visible="false"></asp:GridView>
             </fieldset>
    </div>
            
    </form>
</body>
</html>
