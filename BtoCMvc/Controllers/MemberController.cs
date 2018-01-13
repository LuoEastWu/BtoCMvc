using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BtoCMvc.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Login()
        {
            IBLL.CreateTable createTable = new Luo.BLL.CodeFirstTable();
            createTable.CoderCreateTable();
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}