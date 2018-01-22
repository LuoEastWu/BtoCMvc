using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BtoCMvc.App_Start
{
    public class AuthorizeCheckAttribute : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            base.HandleUnauthorizedRequest(filterContext);
            if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                try
                {
                    filterContext.Controller.TempData.Add("Alert", new Alert { Type = AlertType.Error, Message = "请登录后访问" });
                }
                catch { }
                filterContext.Result = new ViewResult
                {
                    TempData = filterContext.Controller.TempData,
                    ViewName = "~/Views/Shared/Error.cshtml"
                };
                //new RedirectResult("~/error/httperror401");
            }
        }
    }
    public class Alert
    {
        public AlertType Type { get; set; }
        public string Message { get; set; }
    }
    public enum AlertType
    {
        Success,
        Info,
        Warning,
        Error
    }
}