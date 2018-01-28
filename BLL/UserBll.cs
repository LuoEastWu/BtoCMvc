using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using Luo.Models;

namespace Luo.BLL
{
    public class UserBll : IUserBll
    {
        IDAL.IUserDal userDal = new DAL.UserDal();
        public User Add(User entity)
        {
           return userDal.Add(entity);
        }

        public void Login(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}
