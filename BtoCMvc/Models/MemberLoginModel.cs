using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;

namespace BtoCMvc.Models
{
    public class MemberLoginModel
    {
        [Display(Name = "邮箱/手机/用户名")]
        public String User { get; set; }
        [Display(Name = "登录密码")]
        public String Password { get; set; }
    }
}