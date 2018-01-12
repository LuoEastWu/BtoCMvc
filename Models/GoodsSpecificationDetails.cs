using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 商品规格明细
    /// </summary>
    public class GoodsSpecificationDetails
    {
        /// <summary>
        /// 商品规格明细ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsIdentity = true, IsPrimaryKey = true, ColumnDescription = "商品规格明细ID")]
        public Int32 SpecDetailsId { get; set; }

        /// <summary>
        /// 规格分类的Id
        /// </summary>
        private Int32 specTypeId = 0;
        [SugarColumn(ColumnDescription = "规格分类的Id",IsNullable =false)]
        public Int32 SpecTypeId { get=>specTypeId; set=>specTypeId=value; }

        /// <summary>
        /// 规格名称
        /// </summary>
        [SugarColumn(ColumnDescription = "规格名称",Length =100)]
        public String SpecTypeName  { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        [SugarColumn(ColumnDescription = "图片")]
        public String SpecTypeImage  { get; set; }

        /// <summary>
        ///  排序
        /// </summary>
        private Int16 orderNum = 0;
        [SugarColumn(ColumnDescription = "排序", IsNullable = false)]
        public Int16 OrderNum { get => orderNum; set => orderNum = value; }
     


    }
}
