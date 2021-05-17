using sts_sdn.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace sts_sdn.Controllers.Data
{
    public class SecurityDAO : Controller
    {
     
 
        internal bool FindByUser(UserModel userModel)
        {

            //connecting to db
            string conncectingString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = DB - STS - SDN; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            //write the sql expression
            string queryString = @"SELECT * FROM [dbo].[USER] WHERE [USERNAME] = @UserName AND [PASSWORD] = @Password";

            //start bu assuming no thing found in the query 

            bool success = false;
           
            //Console.WriteLine(queryString);

            //create and open db connection in using block

            //this ensure that all recources are closed correctly when query is done and prevent sql injection

            using (SqlConnection connection = new SqlConnection(conncectingString))
            {
                //create the command and parameter object
                SqlCommand command = new SqlCommand(queryString, connection);

                //associate @UserName with userModel.UserName
                command.Parameters.Add("@UserName", System.Data.SqlDbType.VarChar, 50).Value = userModel.UserName;
                command.Parameters.Add("@Password", System.Data.SqlDbType.VarChar, 50).Value = userModel.Password;

                //open the db and run the command
                
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        success = true;
                    }
                    else
                    {
                        success = false;
                    }
                    reader.Close();

                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                    
            }

            return success;

        }

      
    }


}