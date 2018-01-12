using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 物流公司表
    /// </summary>
    public class LogisticsCorp
    {
        /// <summary>
        /// 物流公司ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsIdentity = true, IsPrimaryKey = true, ColumnDescription = "物流公司ID")]
        public Int32 LogisticsCorpId { get; set; }


        /// <summary>
        /// 公司名称
        /// </summary>
        [SugarColumn(ColumnDescription = "公司名称",Length =200)]
        public String LogisticsCorpName { get; set; }


        /// <summary>
        ///  排序
        /// </summary>
        private Int16 orderNum = 0;
        [SugarColumn(ColumnDescription = "排序", IsNullable = false)]
        public Int16 OrderNum { get => orderNum; set => orderNum = value; }


        /// <summary>
        ///  是否删除
        /// </summary>
        private Boolean disabled = false;
        [SugarColumn(ColumnDescription = "是否删除", IsNullable = false)]
        public Boolean Disabled { get => disabled; set => disabled = value; }


        /// <summary>
        ///公司网址
        /// </summary>
        [SugarColumn(ColumnDescription = "公司网址",Length =200)]
        public String Website { get; set; }
    
    }
}
