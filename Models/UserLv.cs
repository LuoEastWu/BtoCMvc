using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 用户等级
    /// </summary>
    public class UserLv
    {
        /// <summary>
        /// 等级ID
        /// </summary>
        [SugarColumn(IsNullable =false,IsPrimaryKey =true,IsIdentity =true,ColumnDescription = "等级ID")]
        public Int16 LvId { get; set; }
        /// <summary>
        /// 等级名称
        /// </summary>
        [SugarColumn(IsNullable =false,Length =100,ColumnDescription = "等级名称")]
        public String LvName { get; set; }

        /// <summary>
        /// 折扣率
        /// </summary>
        private Decimal disCount = 1.00m;
        [SugarColumn(IsNullable =false,Length =5,DecimalDigits =2,ColumnDescription = "折扣率")]
        public Decimal DisCount1
        {
            get => disCount;
            set => disCount = value;
        }
       
        /// <summary>
        /// 是否默认等级
        /// </summary>
        private Int32 defaultLv = 0;
        [SugarColumn(IsNullable =false,ColumnDescription ="是否默认等级")]
        public int DefaultLv { get => defaultLv; set => defaultLv = value; }
        

        /// <summary>
        /// 等级所需积分
        /// </summary>
        private Int16 point = 0;
        [SugarColumn(IsNullable =false,ColumnDescription ="等级所需积分")]
        public short Point { get => point; set => point = value; }

        /// <summary>
        /// 等级类型
        /// </summary>
        private Int16 lvType = 0;
        [SugarColumn(IsNullable =false,ColumnDescription = "等级类型")]
        public short LvType { get => lvType; set => lvType = value; }
        

        /// <summary>
        /// 是否删除
        /// </summary>
        private Boolean disabled = false;
        [SugarColumn(ColumnDescription ="是否删除")]
        public bool Disabled { get => disabled; set => disabled = value; }


    }
}
