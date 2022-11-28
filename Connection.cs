using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace ChallengeC3
{
    public class Connection
    {

        private string connectDB = WebConfigurationManager.ConnectionStrings["ConnectDB"].ToString();
        SqlConnection objConn = null;
        public DataTable getLang()
        {
            DataTable dt = null;
            try
            {

                string strStoreprocedure = "spDevInformation_SelectLng";
                string strParameter = "";

                webservice.WeSafeWebServiceSoapClient service = new webservice.WeSafeWebServiceSoapClient("WeSafeWebServiceSoap");

                service.Open();
                String stringJson = service.ExecProcedure("61E4E815-3B02-433F-9700-8B1988ASKILL", strStoreprocedure, strParameter);

                if (stringJson != "")
                {


                    dt = JsonConvert.DeserializeObject<DataTable>(stringJson);

                }


            }
            catch (Exception ex)
            {

            }
            return dt;
        }

        public DataTable getLanuge()
        {
            SqlCommand sqlCmd = null;
            DataTable dt = null;
            try
            {


                sqlCmd = new SqlCommand();
                sqlCmd.CommandText = "spDevInformation_SelectLng";

                objConn = new SqlConnection(connectDB);
                objConn.Open();

                sqlCmd.Connection = objConn;
                sqlCmd.CommandType = CommandType.StoredProcedure;





                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                dt = new DataTable("tbl");
                da.Fill(dt);

                sqlCmd.Dispose();
                objConn.Close();



            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dt;

        }//selectData



        public DataTable insertData(String username , String tel ,String isShowTel , String Image , String languge , String userLogin ,String userPass)
        {
            SqlCommand sqlCmd = null;
            DataTable dt = null;
            try
            {


                sqlCmd = new SqlCommand();
                sqlCmd.CommandText = "spDevInformation_UpdateInsert";

                objConn = new SqlConnection(connectDB);
                objConn.Open();

                sqlCmd.Connection = objConn;
                sqlCmd.CommandType = CommandType.StoredProcedure;


                sqlCmd.Parameters.Add(new SqlParameter("@User_Name", SqlDbType.VarChar));
                sqlCmd.Parameters["@User_Name"].Value = username;

                sqlCmd.Parameters.Add(new SqlParameter("@Tel_Number", SqlDbType.VarChar));
                sqlCmd.Parameters["@Tel_Number"].Value = tel;


                sqlCmd.Parameters.Add(new SqlParameter("@Tel_Flax", SqlDbType.VarChar));
                sqlCmd.Parameters["@Tel_Flax"].Value = isShowTel;


                sqlCmd.Parameters.Add(new SqlParameter("@User_Image", SqlDbType.VarChar));
                sqlCmd.Parameters["@User_Image"].Value = Image;


                sqlCmd.Parameters.Add(new SqlParameter("@Dev_Lng", SqlDbType.VarChar));
                sqlCmd.Parameters["@Dev_Lng"].Value = languge;


                sqlCmd.Parameters.Add(new SqlParameter("@User_Login", SqlDbType.VarChar));
                sqlCmd.Parameters["@User_Login"].Value = userLogin;


                sqlCmd.Parameters.Add(new SqlParameter("@User_Pass", SqlDbType.VarChar));
                sqlCmd.Parameters["@User_Pass"].Value = userPass;






                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                dt = new DataTable("tbl");
                da.Fill(dt);

                sqlCmd.Dispose();
                objConn.Close();



            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dt;

        }//selectData



        public DataTable selectDetails(String username, String lang)
        {
            SqlCommand sqlCmd = null;
            DataTable dt = null;
            try
            {


                sqlCmd = new SqlCommand();
                sqlCmd.CommandText = "spDevInformation_SelectDetals";

                objConn = new SqlConnection(connectDB);
                objConn.Open();

                sqlCmd.Connection = objConn;
                sqlCmd.CommandType = CommandType.StoredProcedure;


                sqlCmd.Parameters.Add(new SqlParameter("@User_Name", SqlDbType.VarChar));
                sqlCmd.Parameters["@User_Name"].Value = username;

                sqlCmd.Parameters.Add(new SqlParameter("@lang", SqlDbType.VarChar));
                sqlCmd.Parameters["@lang"].Value = lang;


                






                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                dt = new DataTable("tbl");
                da.Fill(dt);

                sqlCmd.Dispose();
                objConn.Close();



            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dt;

        }//selectData


        public DataTable checkLogin(String username, String pass)
        {
            SqlCommand sqlCmd = null;
            DataTable dt = null;
            try
            {


                sqlCmd = new SqlCommand();
                sqlCmd.CommandText = "spDevInformation_CheckUsers";

                objConn = new SqlConnection(connectDB);
                objConn.Open();

                sqlCmd.Connection = objConn;
                sqlCmd.CommandType = CommandType.StoredProcedure;


                sqlCmd.Parameters.Add(new SqlParameter("@User_Login", SqlDbType.VarChar));
                sqlCmd.Parameters["@User_Login"].Value = username;

                sqlCmd.Parameters.Add(new SqlParameter("@User_Pass", SqlDbType.VarChar));
                sqlCmd.Parameters["@User_Pass"].Value = pass;



                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                dt = new DataTable("tbl");
                da.Fill(dt);

                sqlCmd.Dispose();
                objConn.Close();



            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dt;

        }//selectData

    }
}