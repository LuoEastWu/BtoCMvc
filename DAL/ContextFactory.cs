using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using Luo.Collections;
using Luo.Models;
using System.Web.Configuration;

namespace Luo.DAL
{
    /// <summary>
    /// 上下文简单工厂
    /// <remarks>
    /// 创建：2014.02.05
    /// </remarks>
    /// </summary>
    public class ContextFactory
    {

        /// <summary>
        /// 获取当前数据上下文
        /// </summary>
        /// <returns></returns>
        //public static T GetCurrentContext<T>()
        //{
        //    T _nContext =new  T()
        //    if (_nContext == null)
        //    {
        //        _nContext = new NineskyDbContext();
        //        CallContext.SetData("NineskyContext", _nContext);
        //    }
        //    return _nContext;
        //}
    }
}

