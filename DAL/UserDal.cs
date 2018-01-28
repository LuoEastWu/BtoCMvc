using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Luo.Models;

namespace Luo.DAL
{
    public partial class UserDal : IUserDal
    {
        public User Add(User entity)
        {
            return Collections.DbConnect.StartSqlSugar<User>((db) =>
            {
                return db.Insertable<User>(entity).ExecuteReturnEntity();
            });
        }

        public bool Exist(Expression<Func<Models.User, bool>> anyLambda)
        {
            throw new NotImplementedException();
        }

       
    }
}
