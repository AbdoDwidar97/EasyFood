using DataModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_EasyFood.Controllers
{
    public class AuthController : ApiController
    {

        [Route("api/UserRegister/{User_FullName}/{UserName}/{User_Email}/{User_Phone}/{Pwd}")]
        [HttpGet, HttpPost]
        public bool UserRegister(String User_FullName, String UserName, String User_Email, String User_Phone, String Pwd)
        {
            using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                using (SqlCommand Comm = new SqlCommand("Sp_UserRegister", Conn))
                {
                    Comm.CommandType = CommandType.StoredProcedure;

                    Comm.Parameters.AddWithValue("@User_FullName", User_FullName);
                    Comm.Parameters.AddWithValue("@UserName", UserName);
                    Comm.Parameters.AddWithValue("@User_Email", User_Email);
                    Comm.Parameters.AddWithValue("@User_Phone", User_Phone);
                    Comm.Parameters.AddWithValue("@Pwd", Pwd);

                    Conn.Open();
                    int ExcutionTask = Comm.ExecuteNonQuery();
                    Conn.Close();
                    if (ExcutionTask != 0) return true;
                    else return false;
                }
            }

        }


        [Route("api/UserLogin/{Un}/{Pwd}")]
        [HttpGet, HttpPost]
        public bool UserLogin(String Un, String Pwd)
        {

            using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                using (SqlCommand Comm = new SqlCommand("Sp_UserLogin", Conn))
                {
                    Comm.CommandType = CommandType.StoredProcedure;
                    Comm.Parameters.AddWithValue("@UserName", Un);
                    Comm.Parameters.AddWithValue("@Pwd", Pwd);
                    Conn.Open();
                    SqlDataReader DataReader = Comm.ExecuteReader();
                    DataReader.Read();
                    if (DataReader.HasRows)
                    {
                        Conn.Close();
                        return true;
                    }
                    else
                    {
                        Conn.Close();
                        return false;
                    }

                }
            }
        }


    }
}
