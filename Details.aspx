<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="ChallengeC3.Details" %>

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
            <button title="logout"  onclick="logout()">Logout</button>
     </div>
    <form id="form1" runat="server">
         <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate> <div class="w3-row"></div>
                <br />
                <div class="w3-row">
                  <div class="w3-col m3  w3-center"><p></p></div>
                  <div class="w3-col m6 w3-grayscale w3-center">
                      <table>
                          <tr>
                              <td>
                                  <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
                              <td>
                                  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                              </td>
                          </tr>

                           <tr>
                              <td>
                                  <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
                              <td>
                                  <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></td>
                          </tr>

                           <tr>
                              <td></td>
                              <td>
                                  <td><asp:Button ID="Button1" runat="server" CssClass="w3-btn w3-red" Text="Reset" OnClientClick="location.reload();" />   <asp:Button ID="Button2" runat="server" CssClass="w3-btn w3-green" Text="Submit"  OnClick="Button2_Click" /></td>
                          </tr>
                      </table>

                  <div class="w3-col m3  w3-center"><p></p></div>

              </div>
                      
                    <br />
<hr />

            <div class="w3-row"  style="margin-left:10%">
                
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" >
                    <Columns>  
                          <asp:ImageField DataImageUrlField="User_Image" HeaderText="Image"></asp:ImageField>   
                    <asp:BoundField DataField="User_Name" HeaderText="ชื่อ-สกุล" />  
                    <asp:BoundField DataField="Dev_Lng" HeaderText="ภาษา Programmin" />  
                              <asp:BoundField DataField="Tel_Number" HeaderText="เบอร์โทร" />        
                </Columns>  
                  <%--  <Columns>
                                 <asp:TemplateField HeaderText="" ItemStyle-Width="1%" >
                                    <ItemTemplate >                                        
                                      <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("User_Image") %>' />
                                    </ItemTemplate>
                                    <ItemStyle Width="1%" />
                                </asp:TemplateField>
                  <asp:BoundField DataField="User_Name"  ItemStyle-Width="9%"  HeaderText="=ชื่อ-สกุล" ControlStyle-CssClass="myfont" ><ItemStyle Width="9%" /></asp:BoundField>
                         <asp:BoundField DataField="Dev_Lng"  ItemStyle-Width="9%"  HeaderText="ภาษา Programmin" ControlStyle-CssClass="myfont" ><ItemStyle Width="9%" /></asp:BoundField>
                         <asp:BoundField DataField="Tel_Number"  ItemStyle-Width="9%"  HeaderText="เบอร์โทร" ControlStyle-CssClass="myfont" ><ItemStyle Width="9%" /></asp:BoundField>
               </Columns>
                        --%>
                        </asp:GridView>
            </div>
         </ContentTemplate>
        </asp:UpdatePanel> 

    </form>

<script type="text/javascript">
    function logout() {
        window.location.replace("Login.aspx");
    }
</script>

</body>
</html>