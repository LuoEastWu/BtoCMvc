using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 商品类型和品牌关联
    /// </summary>
    public class Goods_Type_Brand
    {
        /// <summary>
        /// 商品类型和品牌关联ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsIdentity = true, IsPrimaryKey = true, ColumnDescription = "商品类型和品牌关联ID")]
        public Int32 Goods_Type_BrandId { get; set; }

        /// <summary>
        ///  类型ID
        /// </summary>
        private Int32 goodstypeId = 0;
        [SugarColumn(ColumnDescription = "类型ID", IsNullable = false)]
        public Int32 GoodsTypeId { get=> goodstypeId; set=> goodstypeId = value; }
        /// <summary>
        ///  品牌Id
        /// </summary>
        private Int32 brandId = 0;
        [SugarColumn(ColumnDescription = "品牌Id", IsNullable = false)]
        public Int32 BrandId { get=>brandId; set=> brandId=value; }
    }
}
