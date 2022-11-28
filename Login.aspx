<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ChallengeC3.Login" %>

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
    <form id="form1" runat="server">
         <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate> <div class="w3-row"></div>
                <br />
                <div class="w3-row">
                  <div class="w3-col m3  w3-center"><p></p></div>
                  <div class="w3-col m6 w3-dark-grey w3-center">
                      
                      <div class="w3-row">
                          <div class="column"><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></div>
                           <div class="column">
                               <asp:TextBox ID="txtU" runat="server"></asp:TextBox>
                           </div>
                      </div>

                      <div class="w3-row">
                          <div class="column"><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></div>
                           <div class="column">
                               <asp:TextBox ID="txtP" runat="server"></asp:TextBox>
                           </div>
                      </div>
                      <br />

                      <div class="w3-row">
                          <div class="column">
                              <asp:Label ID="Label3" runat="server" CssClass="w3-text-red"  Text=""></asp:Label></div>
                        </div>

                        <br />
                       <div class="w3-row"  style="margin-left:15%">
                            <div class="column">
                                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                    <asp:ListItem Text="เพิ่มข้อมูล"  Value="0"></asp:ListItem>
                                    <asp:ListItem Text="ค้นหาข้อมูล"  Value="1" ></asp:ListItem>
                                </asp:RadioButtonList>
                            </div>
                        </div>
                      <br />

                       <div class="w3-row">
                          <div class="column"></div>
                           <div class="column">
                               <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                           </div>
                      </div>
                      
                  </div>


                  <div class="w3-col m3  w3-center"><p></p></div>

              </div>
            </ContentTemplate>
        </asp:UpdatePanel>

    </form>

<script type="text/javascript">
    function myFunction() {
        var x = document.getElementById("txtP");
        if (x.type === "password") {
            x.type = "text";
        } else {
            x.type = "password";
        }
    }
</script>

</body>
</html>
