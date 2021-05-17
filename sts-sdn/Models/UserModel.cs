using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sts_sdn.Models
{
    public class UserModel
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the first name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter the last name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter user name")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter the password")]
        public string Password { get; set; }

        public UserModel()
        {

            Id = -1;
            FirstName = "NoFirstName";
            LastName = "NoLastName";
            UserName = "NoUserName";
            Password = "NoPassword";

        }

        public UserModel(int id, string firstName, string lastName, string userName, string password)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
        }
    }
}