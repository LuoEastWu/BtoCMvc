using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Luo.Models;
using System.Linq.Expressions;

namespace IDAL
{
    public partial interface IUserDal
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="entity">模型</param>
        /// <returns>模型</returns>
        User Add(User entity);
        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="anyLambda">查询表达式</param>
        /// <returns>布尔值</returns>
        Boolean Exist(Expression<Func<User, bool>> anyLambda);

        
    }
}
