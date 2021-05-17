using sts_sdn.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sts_sdn.Controllers.Data
{
    
    public class RegistrationDAO : Controller
    {
        public SqlCommand SqlCommand { get; private set; }

        public int CreateRegistration (UserModel userModel)
        {
            
            //connecting to db
            string conncectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB-STS-SDN;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            
          

            using (SqlConnection connection = new SqlConnection(conncectionString))
            {
                string saveRegistrationQuery = @"INSERT INTO [dbo].[USER] ([FIRST_NAME],[LAST_NAME],[USERNAME],[PASSWORD]) VALUES (@FirstName,@LastName,@UserName,@Password)";

                SqlCommand command = new SqlCommand(saveRegistrationQuery, connection);

                //a
             
                command.Parameters.Add("@FirstName", System.Data.SqlDbType.VarChar, 50).Value = userModel.FirstName;
                command.Parameters.Add("@LastName", System.Data.SqlDbType.VarChar, 50).Value = userModel.LastName;
                command.Parameters.Add("@UserName", System.Data.SqlDbType.VarChar, 50).Value = userModel.UserName;
                command.Parameters.Add("@Password", System.Data.SqlDbType.VarChar, 50).Value = userModel.Password;


                //if (the user exist in db)
                //open db and exsute 
                connection.Open();
                int newID=command.ExecuteNonQuery();
                return newID;



            }
             
                
            }

      
    }
       
    }




                //if (reader.HasRows)
                //{

                //    while (reader.Read())
                //    {

                //        //create new user and add it into list to return
                //        user.Id = reader.GetInt32(0);
                //        user.FirstName = reader.GetString(1);
                //        user.LastName = reader.GetString(2);
                //        user.UserName = reader.GetString(3);
                //        user.Password = reader.GetString(4);
                //    }
                    