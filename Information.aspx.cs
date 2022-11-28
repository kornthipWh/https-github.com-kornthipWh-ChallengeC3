using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

namespace ChallengeC3
{
    public partial class Information : System.Web.UI.Page
    {
        Connection conn = new Connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
               

                //bool isLoggedIn = HttpContext.Current.User.Identity.IsAuthenticated;

                if (!IsPostBack)
                {
                    if (null == Session["Username"])
                    {
                        Response.Redirect("Login.aspx");
                    }
                    else
                    {
                        String user = Session["Username"].ToString();
                        this.header.InnerText = "ข้อมูลสมัครสมาชิกนักพัฒนาระบบสารสนเทศ";
                        this.Label1.Text = "ชื่อ-นามสกุล";
                        this.Label2.Text = "โทรศัพท์";
                        this.Label3.Text = "รูปภาพ proflie";
                        this.Label4.Text = "ภาษา Programming";
                        this.Label5.Text = "Username";
                        this.Label6.Text = "Password";
                        this.Label7.Text = "Confirm Password";
                        this.lblComment.Text = "(รองรับ .png เท่านั้นขนาดไม่เกิน 200 KB)";

                        //DropDownList1.Items.Add(new ListItem(""));
                        //DropDownList1.Items.Add(new ListItem("C#"));
                        //DropDownList1.Items.Add(new ListItem("JAVA"));
                        //DropDownList1.Items.Add(new ListItem("PHP"));
                        //DropDownList1.Items.Add(new ListItem("Python"));
                        //DropDownList1.Items.Add(new ListItem("Javascript"));


                        DataTable dt = conn.getLang();

                        DropDownList1.DataSource = dt; // <-- Get your data from somewhere.
                        DropDownList1.DataValueField = "Lng_value";
                        DropDownList1.DataTextField = "Lng_name";
                        DropDownList1.DataBind();

                       // DropDownList1.SelectedValue = myValue.ToString();


                    }




                }

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                String error = "";
                int length = this.FileUpload1.PostedFile.ContentLength;
                string type = this.FileUpload1.PostedFile.ContentType;
                String fileName = this.FileUpload1.PostedFile.FileName;

                String name = TextBox1.Text;
                String tel = TextBox2.Text;
                String isCheck = CheckBox1.Checked ? "1" : "0";
                String lang = DropDownList1.Text;
                String userlogin = TextBox3.Text;
                String userpass = TextBox4.Text;

                //number = number / 1024;  
                length = length / 1024;
                //lblAlert
                if (!type.Contains("png"))
                {
                    this.lblAlert.Visible = true;
                    error = "รองรับ .png  เท่านั้น";
                }

                if (length>200)
                {
                    this.lblAlert.Visible = true;
                    error = error + " ขนาดภาพไม่เกิน 200 MB";
                }

                lblAlert.Text = error;



                if (error=="")
                {
                    FileUpload1.SaveAs(Server.MapPath("~/Image/"+ fileName));
                    String pathImage = "https://10.4.5.22/Image/"+fileName;
                    conn.insertData(name,tel,isCheck, pathImage, lang,userlogin,userpass);

                }

                //pass

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        public bool passwordValidates(String pass)
        {
            int count = 0;

           

            if(8 <= pass.Length && pass.Length <= 32)
            {
                if (pass.Contains(".*\\d.*"))
                    count++;
                if (pass.Contains(".*[a-z].*"))
                    count++;
                if (pass.Contains(".*[A-Z].*"))
                    count++;
                //if (pass.Contains(".*[*.!@#$%^&(){}[]:"; "<>,.?/~`_+-=|\\].*") );
                //  count++;
            }

            return count >= 3;
        }
    }
}