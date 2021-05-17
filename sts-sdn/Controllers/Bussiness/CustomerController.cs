using sts_sdn.Controllers.Data;
using sts_sdn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sts_sdn.Controllers.Bussiness
{
    public class CustomerController : Controller
    {
        

        // GET: Customer
        public ActionResult Index()
        {
            CustomerDAO customerDAO = new CustomerDAO();

            List<CustomerModel> customer = customerDAO.FetchCustomer();

            return View("Index",customer);
        }


        //show details action
        public ActionResult Details (int id)
        {
            CustomerDAO customerDAO = new CustomerDAO();
            CustomerModel customerModel = customerDAO.FetchOneCustomer(id);

            return View("Details", customerModel);
        }



        //create new customer
        public ActionResult ProcessCreate (CustomerModel customerModel)
        {
            CustomerDAO customerDAO = new CustomerDAO();
  
           customerDAO.CreatNewCustomer(customerModel);

            return View(customerModel);
        }

    }
}