<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Information.aspx.cs" Inherits="ChallengeC3.Information" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css" />
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Kanit:wght@200&display=swap" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />


      <link rel="stylesheet" href="css/animate.min.css">
    <link href="css/aos.css" rel="stylesheet">
      
     <link rel="stylesheet" href="css/w3.css">
</head>
<body  onload="myFunction();">
     <div class="w3-purple">
            <button title="logout"  onclick="logout()"> Logout</button>
     </div>
    <form id="form1" runat="server">
       
        <%-- <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate> <div class="w3-row"></div>--%>
                <br />
                <div class="w3-row">
                  <div class="w3-col m3  w3-center"><p>left</p></div>
                  <div class="w3-col m6 w3-dark-grey w3-center">
                      <table>
                          <tr>
                              <td colspan="2"><label runat="server" id="header"></label></td>
                              
                          </tr>

                           <tr>
                              <td style="text-align:left"><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
                              <td><asp:TextBox ID="TextBox1" runat="server" required></asp:TextBox></td>
                          </tr>
                           <tr>
                              <td style="text-align:left"><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
                              <td><asp:TextBox ID="TextBox2" runat="server" required></asp:TextBox> <asp:CheckBox ID="CheckBox1" runat="server" /> </td>
                          </tr>
                           <tr>
                              <td style="text-align:left"><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
                              <td>
                                  
                                  <asp:FileUpload ID="FileUpload1"  accept=".png"    runat="server" required />
                                  <%--<input id="oFile" type="file" runat="server" name="oFile" required />--%>
                                  <asp:Label ID="lblComment" runat="server" Text="Label"></asp:Label>

                               <asp:Label ID="lblAlert" runat="server"  CssClass="w3-red" Text="Label"  Visible="false"></asp:Label>

                                  </td>

                          </tr>
                           <tr>
                              <td style="text-align:left">
                                  <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></td>
                              <td> <asp:DropDownList ID="DropDownList1" runat="server" required>
                                  
                                   </asp:DropDownList></td>
                          </tr>
                           <tr>
                              <td style="text-align:left">
                                  <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></td>
                              <td><asp:TextBox ID="TextBox3" runat="server"     required></asp:TextBox></td>
                          </tr>
                           <tr>
                              <td style="text-align:left">
                                  <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></td>
                              <td><asp:TextBox ID="TextBox4" runat="server" onchange="CheckPassword()"   required></asp:TextBox></td>
                          </tr>
                           <tr>
                              <td style="text-align:left">
                                  <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label></td>
                              <td> <asp:TextBox ID="TextBox5" runat="server" required></asp:TextBox></td>
                          </tr>
                           <tr>
                              <td></td>
                              <td><asp:Button ID="Button1" runat="server" CssClass="w3-btn w3-red" Text="Reset" OnClientClick="location.reload();" />   <asp:Button ID="Button2" runat="server" CssClass="w3-btn w3-green" Text="Submit"  OnClick="Button2_Click" /></td>
                          </tr>
                      </table>
                  </div>
                      


                  <div class="w3-col m3  w3-center"><p>right</p></div>

              </div>
           <%-- </ContentTemplate>
        </asp:UpdatePanel>--%>

    </form>

<script type="text/javascript">
    function logout() {
        window.location.replace("Login.aspx");
    }

    function CheckPassword() {

        var inputtxt = document.getElementById("TextBox4").value;
       // alert(inputtxt);
        
        var decimal = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z0-9])(?!.*\s).{8,15}$/;
        if (inputtxt.match(decimal)) {
            alert('Correct, try another...');
            return true;
        }
        else {
            alert('Wrong...!')
            return false;
        }
    } 
</script>

</body>
</html>
