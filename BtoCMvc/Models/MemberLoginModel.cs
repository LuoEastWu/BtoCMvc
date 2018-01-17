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
        [Required(ErrorMessage = "请您填写会员名称！")]
        [Display(Name = "邮箱/手机/用户名")]
        public String User { get; set; }
        [Required(ErrorMessage ="请您填写密码！")]
        [Display(Name = "登录密码")]
        public String Password { get; set; }

        [Display(Name = "记住我?")]
        public bool RememberMe { get; set; }
    }
}