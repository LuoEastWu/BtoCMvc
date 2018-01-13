using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 用户操作历史记录
    /// </summary>
    public class UserOperationHistory
    {
        /// <summary>
        /// 用户操作记录ID
        /// </summary>
        [SugarColumn(IsNullable =false,IsIdentity =true,IsPrimaryKey =true,ColumnDescription ="用户操作记录ID")]
        public Int64 OhId { get; set; }
        /// <summary>
        /// 用户操作记录ID
        /// </summary>
        [SugarColumn(IsNullable = false, ColumnDescription = "用户操作记录ID")]
        public Int64 UserId { get; set; }
        /// <summary>
        /// 用户名称
        /// </summary>
        [SugarColumn(IsNullable =false,Length =20,ColumnDescription ="用户名称")]
        public String UserName { get; set; }

        /// <summary>
        /// 操作项目
        /// </summary>
        [SugarColumn(Length =800,ColumnDescription ="操作项目")]
        public String Project { get; set; }
        /// <summary>
        /// 操作动作
        /// </summary>
        [SugarColumn(Length =800,ColumnDescription ="操作动作")]
        public String Action { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        [SugarColumn(ColumnDescription = "操作时间")]
        public Int32 OhOperation { get; set; }

        /// <summary>
        /// 操作是否成功
        /// </summary>
        private Boolean status = true;
        [SugarColumn(IsNullable =false,ColumnDescription ="操作是否成功")]
        public Boolean Status { get => status; set => status = value; }

    }
}
