using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sts_sdn.Models
{
    public class ContactPersonModel : CustomerModel
    {

        public new int Id { get; set; }

        public string PersonName { get; set; }
        public string Mobile { get; set; }
        public string Landline { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }


        //public ContactPersonModel(int id, string Name, string mobile, string landline, string email, string position)
        //{
        //    Id = id;
        //    Name = name;
        //    Mobile = mobile;
        //    Landline = landline;
        //    email = email;
        //    position = position;


        //}

        //public ContactPersonModel()
        //{
        //    Id = -1;
        //    FirstName = "firstName";
        //    LastName = "lastName";
        //    Mobile = "mobile";
        //    Landline = "landline";
        //    this.email = "email";
        //    this.position = "position";

        //}   


    }
}






