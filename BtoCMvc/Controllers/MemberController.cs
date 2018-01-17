using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace BtoCMvc.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login()
        {
            IBLL.CreateTable createTable = new Luo.BLL.CodeFirstTable();
            //createTable.CoderCreateTable();
            return View();
        }

      

        public ActionResult Register()
        {
            return View();
        }
    }
}