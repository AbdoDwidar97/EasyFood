using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebAPI_EasyFood.Controllers
{
    public class UserController : ApiController
    {


        
        [Route("api/GetAllUser")]
        [HttpGet, HttpPost]
        public IEnumerable<User> GetAllUser()
        {
            List<User> usrs = new List<User>();

            using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                using (SqlCommand Comm = new SqlCommand("Sp_GetAllUsers", Conn))
                {
                    Comm.CommandType = CommandType.StoredProcedure;
                    Conn.Open();
                    SqlDataReader DataReader = Comm.ExecuteReader();
                    while (DataReader.Read())
                    {
                        User NewUsr = new User();
                        NewUsr.User_ID = Convert.ToUInt16(DataReader["User_ID"].ToString());
                        NewUsr.User_FullName = DataReader["User_FullName"].ToString();
                        NewUsr.UserName = DataReader["UserName"].ToString();
                        NewUsr.User_Email = DataReader["User_Email"].ToString();
                        NewUsr.User_Phone = DataReader["User_Phone"].ToString();
                        usrs.Add(NewUsr);
                    }

                    Conn.Close();
                    
                }
            }

            return usrs;
        }

        [Route("api/GetUser_FullName/{id}")]
        [HttpGet, HttpPost]
        public String GetUser_FullName(int id)
        {

            User NewUsr = new User();
            using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                using (SqlCommand Comm = new SqlCommand("Sp_GetUser", Conn))
                {
                    Comm.CommandType = CommandType.StoredProcedure;
                    Comm.Parameters.AddWithValue("@User_ID",id);
                    Conn.Open(); 
                    SqlDataReader DataReader = Comm.ExecuteReader();
                    DataReader.Read();
                    if (DataReader.HasRows)
                    {
                        NewUsr.User_ID = Convert.ToUInt16(DataReader["User_ID"].ToString());
                        NewUsr.User_FullName = DataReader["User_FullName"].ToString();
                        NewUsr.UserName = DataReader["UserName"].ToString();
                        NewUsr.User_Email = DataReader["User_Email"].ToString();
                        NewUsr.User_Phone = DataReader["User_Phone"].ToString();
                    }

                    Conn.Close();

                }
            }
            return NewUsr.User_FullName;
        }


    }
}
