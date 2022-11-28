using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeC3
{
    public partial class Login : System.Web.UI.Page
    {
        Connection conn = new Connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();

            Session["Username"] = "";

            this.Label1.Text = "ชื่อผู้ใช้งาน";
            this.Label2.Text = "รหัสผ่าน";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String result = "";
            try
            {
                String user = "";
                String pass = "";
                user = txtU.Text;
                pass = txtP.Text;

                DataTable dt = conn.checkLogin(user, pass);

                if (dt.Rows.Count>0)
                {
                    String chk = RadioButtonList1.SelectedValue;
                        Session["Username"] = user;

                    if (chk=="0")
                    {
                        Response.Redirect("Information.aspx");
                    }
                    else
                    {
                        Response.Redirect("Details.aspx");
                    }
                       
                   
                }
                else
                {
                    result = "ไม่สามารถเข้าสู่ระบบได้";

                    this.Label3.Text =  result;
                }
                
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}