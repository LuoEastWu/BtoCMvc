using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Luo.Models;

namespace IBLL
{
    public partial interface IUserBll
    {
        /// <summary>
        /// 添加会员
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        User Add(User entity);
        
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">用户密码</param>
        void Login(String userName, String password);

       

    }
}
