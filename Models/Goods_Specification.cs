using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 商品和规格关联
    /// </summary>
    public class Goods_Specification
    {
        /// <summary>
        /// 商品和规格关联ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsIdentity = true, IsPrimaryKey = true, ColumnDescription = "商品和规格关联ID")]
        public Int32 Goods_SpecId { get; set; }

        /// <summary>
        ///  商品类型ID
        /// </summary>
        private Int32 goodsTypeId = 0;
        [SugarColumn(ColumnDescription = "商品类型ID", IsNullable = false)]
        public Int32 GoodsTypeId { get => goodsTypeId; set => goodsTypeId = value; }

        /// <summary>
        ///  商品规格类别ID
        /// </summary>
        private Int32 specTypeId = 0;
        [SugarColumn(ColumnDescription = "商品规格类别ID", IsNullable = false)]
        public Int32 SpecTypeId { get => specTypeId; set => specTypeId = value; }

        /// <summary>
        ///  商品规格明细ID
        /// </summary>
        private Int32 specDetailsId = 0;
        [SugarColumn(ColumnDescription = "商品规格明细ID", IsNullable = false)]
        public Int32 SpecDetailsId { get => specDetailsId; set => specDetailsId = value; }

        /// <summary>
        ///  规格分类名称
        /// </summary>
        [SugarColumn(ColumnDescription = "规格分类名称", Length = 50)]
        public String SpecTypeName { get; set; }

        /// <summary>
        ///  商品ID
        /// </summary>
        private Int32 goodsId = 0;
        [SugarColumn(ColumnDescription = "商品ID", IsNullable = false)]
        public Int32 GoodsId { get => goodsId; set => goodsId = value; }
    }
}
