using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sts_sdn.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }

        //[Required(ErrorMessage = "Please enter the customer name")]
        //[Display(Name = "Customer Name")]
        public string Name { get; set; }

        public CustomerModel(int id, string name)
        {
            Id = id;
            Name = name;
        }

       public CustomerModel()
        {
            Id = -1;
            Name = "NoName";
        }

    }




}
 



