using sts_sdn.Controllers.Data;
using sts_sdn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sts_sdn.Controllers.Bussiness
{
    public class RegistrationController : Controller
    {
        
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProcessRegistration(UserModel userModel)
        {
            //save to db
            if (userModel!=null)
            {
                RegistrationDAO registraionDAO = new RegistrationDAO();
                registraionDAO.CreateRegistration(userModel);
                return View("ProcessRegistration", userModel);
            }
            else
            {
                return View("no value added");
            }
            
        }






    }
}