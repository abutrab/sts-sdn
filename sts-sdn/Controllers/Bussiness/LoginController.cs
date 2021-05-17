using sts_sdn.Controllers.Bussiness;
using sts_sdn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace sts_sdn.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public string ProcessLogin(UserModel userModel)
        {
            SecurityService securityService = new SecurityService();
          
            Boolean success = securityService.Authenticate(userModel);
            if (success)
            {
                return "Success Login";

            }
            else
            {
                return "Failure. not logged in";
            }
        }
    }
}