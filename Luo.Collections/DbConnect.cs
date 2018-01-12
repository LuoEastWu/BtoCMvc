using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;
using System.Diagnostics;

namespace Luo.Collections
{
    public class DbConnect
    {
        /// <summary>
        /// SqlSugar静态执行方法
        /// </summary>
        public static T StartSqlSugar<T>(Func<SqlSugarClient, T> func)
        {
            using (SqlSugarClient db = new SqlSugarClient(new ConnectionConfig
            {
                ConnectionString = Config.ConnectionString, //连接字符串
                DbType = DbType.SqlServer, // 数据库类型
                IsAutoCloseConnection = true, //默认false,是否自动释放数据库，设为true我们不需要close或者Using的操作，比较推荐
                InitKeyType = InitKeyType.Attribute//初始化主键和自增列信息的方式,SystemTable表示自动从数据库读取主键自增列的信息.Attribute 表示从属性中读取 主键和自增列的信息
            }))
            {
                return func(db);
            }
        }
        /// <summary>
        /// SqlSugar静态执行方法
        /// </summary>
        public static void StartSqlSugar(Action<SqlSugarClient> func)
        {
            using (SqlSugarClient db = new SqlSugarClient(new ConnectionConfig
            {
                ConnectionString = Config.ConnectionString, //必填
                DbType = DbType.SqlServer, //必填
                IsAutoCloseConnection = true, //默认false
                InitKeyType = InitKeyType.Attribute
            }))
            {
                try
                {
                    func(db);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }
        public static SqlSugarClient GetInstance()
        {
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = Config.ConnectionString,
                DbType = DbType.SqlServer,
                IsAutoCloseConnection = true
            });
            db.Ado.IsEnableLogEvent = true;
            db.Ado.LogEventStarting = (sql, pars) =>
            {
                Console.WriteLine(sql + "\r\n" + db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
                Console.WriteLine();
            };
            return db;
        }
    }
}
