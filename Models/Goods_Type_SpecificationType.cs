using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 商品类型和规格联系
    /// </summary>
    public class Goods_Type_SpecificationType
    {
        /// <summary>
        /// 商品类型和规格联系ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsIdentity = true, IsPrimaryKey = true, ColumnDescription = "商品类型和规格联系ID")]
        public Int32 SpecTypeDetailsId { get; set; }

        /// <summary>
        ///  商品类型ID
        /// </summary>
        private Int32 goodstypeId = 0;
        [SugarColumn(ColumnDescription = "商品类型ID", IsNullable = false)]
        public Int32 GoodsTypeId { get => goodstypeId; set => goodstypeId = value; }

        /// <summary>
        /// 商品规格Id
        /// </summary>
        private Int32 specTypeId = 0;
        [SugarColumn(ColumnDescription = "商品规格Id", IsNullable = false)]
        public Int32 SpecTypeId { get => specTypeId; set => specTypeId = value; }

        /// <summary>
        ///  规格显示方式0表示下拉显示 1表示平铺显示
        /// </summary>
        private Int16 showType = 1;
        [SugarColumn(ColumnDescription = "规格显示方式0表示下拉显示 1表示平铺显示", IsNullable = false)]
        public Int16 SpecShowType { get => showType; set => showType = value; }
    }
}
