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
    public partial class Details : System.Web.UI.Page
    {

        Connection conn = new Connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                //bool isLoggedIn = HttpContext.Current.User.Identity.IsAuthenticated;
                //if (!isLoggedIn)
                //{
                //    Response.Redirect("Login.aspx");
                //}
                //else
                //{
                    if (!IsPostBack)
                    {

                    if (null == Session["Username"])
                    {
                        Response.Redirect("Login.aspx");
                    }
                    else
                    {
                        this.Label1.Text = "ชื่อ-นามสกุล";
                        this.Label2.Text = "ภาษา Programming";



                        DataTable dt = conn.getLanuge();

                        DropDownList1.DataSource = dt; // <-- Get your data from somewhere.
                        DropDownList1.DataValueField = "Lng_value";
                        DropDownList1.DataTextField = "Lng_name";
                        DropDownList1.DataBind();
                    }


                    }
                //}
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {

                String user = TextBox1.Text;
                String lang = DropDownList1.SelectedValue;

                DataTable dt = conn.selectDetails(user,lang);

                GridView1.DataSource = dt;

                GridView1.DataBind();
            }
            catch (Exception ex)
            {

            }
        }
    }
}