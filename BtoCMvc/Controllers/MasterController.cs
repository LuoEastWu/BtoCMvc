using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BtoCMvc.Controllers
{
    public class MasterController : Controller
    {
        // GET: Master
        public PartialViewResult Top()
        {
            return PartialView();
        }

        public PartialViewResult ShopNav()
        {
            return PartialView();
        }
        public PartialViewResult Footer()
        {
            return PartialView();
        }
    }
}