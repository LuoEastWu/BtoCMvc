using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;
using System.Reflection;


namespace Luo.DAL
{
    public partial class CodeFirstTable : IDAL.CodeFirstTable
    {
        public  void Create()
        {
            Collections.DbConnect.StartSqlSugar(db =>
            {
                db.CodeFirst.BackupTable().InitTables("Luo.Models");
            });
           
        }
    }
}
