using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using SqlSugar;

namespace Luo.DAL
{
    public class Base<T> : IBase<T> where T : class, new()
    {
        /// <summary>
        /// 插入并返回实体 ,  
        /// 只是自identity 添加到 参数的实体里面并返回，
        /// 没有查2次库，所以有些默认值什么的变动是取不到的你们需要手动进行2次查询获取
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public T Add(T entity)
        {
            return Collections.DbConnect.StartSqlSugar((db) =>
            {
                 return db.Insertable(entity).ExecuteReturnEntity();
            });
        }
      
        public Int32 QueryCount(Expression<Func<T, bool>> predicate)
        {
            int queryCount = 0;
            Collections.DbConnect.StartSqlSugar((db) =>
            {
                queryCount= db.Queryable<T>().Count(predicate);
            });
            return queryCount;
        }

        public Boolean Delete(T entity)
        {
            int deleteCount = 0;
            Collections.DbConnect.StartSqlSugar((db) =>
            {
                deleteCount= db.Deleteable<T>().Where(entity).ExecuteCommand();
            });
            return deleteCount > 0;
        }

        public Boolean Exist(Expression<Func<T, bool>> anyLambda)
        {
            throw new NotImplementedException();
        }

        public T Find(Expression<Func<T, bool>> whereLambda)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindList<S>(Expression<Func<T, bool>> whereLamdba, bool isAsc, Expression<Func<T, S>> orderLamdba)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindPageList<S>(int pageIndex, int pageSize, out int totalRecord, Expression<Func<T, bool>> whereLamdba, bool isAsc, Expression<Func<T, S>> orderLamdba)
        {
            throw new NotImplementedException();
        }

        public bool Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
