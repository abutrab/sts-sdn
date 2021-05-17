using sts_sdn.Controllers.Data;
using sts_sdn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sts_sdn.Controllers.Bussiness
{
    public class SecurityService : Controller
    {
        // GET: SecurityService
        SecurityDAO securityDAO = new SecurityDAO();

        public bool Authenticate(UserModel user)
        {
            return securityDAO.FindByUser(user);
        }
    }
}