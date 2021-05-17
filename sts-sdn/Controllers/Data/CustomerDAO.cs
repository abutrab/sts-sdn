using sts_sdn.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace sts_sdn.Controllers.Data

{
    public class CustomerDAO
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB-STS-SDN;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
      
        
            public List<CustomerModel> FetchCustomer()
        {
              List<CustomerModel> customersList = new List<CustomerModel>();


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = @"select* from [dbo].[CUSTOMER]";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                //open connection
                connection.Open();

                //save the query to a reader to return it back later on
                SqlDataReader reader = command.ExecuteReader();


                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        CustomerModel customer = new CustomerModel();
                        customer.Id = reader.GetInt32(0);
                        customer.Name = reader.GetString(1);

                        customersList.Add(customer);
                    }
                }
                 
                    
            }

            return customersList;
        
        }

      

        public CustomerModel FetchOneCustomer(int id)
        {


            CustomerModel customer = new CustomerModel();   
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = @"select* from [dbo].[CUSTOMER] WHERE [ID]=@Id";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                //associate int id with @Id
                command.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = id;

                //open connection
                connection.Open();

                //save the query to a reader to return it back later on
                SqlDataReader reader = command.ExecuteReader();

               
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        
                        customer.Id = reader.GetInt32(0);
                        customer.Name = reader.GetString(1);

                       
                    }
                }


            }

            return customer;

        }

//hello world

        public int CreatNewCustomer(CustomerModel customerModel)
        {
            CustomerModel customer = new CustomerModel();
           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuerry = @"INSERT INTO [dbo].[CUSTOMER] ([NAME]) VALUES (@Name)";

                SqlCommand command = new SqlCommand(sqlQuerry, connection);

                command.Parameters.Add("@Name", System.Data.SqlDbType.VarChar, 50).Value = customerModel.Name;

                connection.Open();

               int newID= command.ExecuteNonQuery();

                return newID;

            }

           

        }





    }
}