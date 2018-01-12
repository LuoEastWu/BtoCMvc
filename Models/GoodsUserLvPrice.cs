using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 商品会员价
    /// </summary>
    public class GoodsUserLvPrice
    {
        /// <summary>
        /// 商品会员价ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsIdentity = true, IsPrimaryKey = true, ColumnDescription = "商品会员价ID")]
        public Int32 GoodsUserLvPriceId { get; set; }

        /// <summary>
        /// 用户等级ID
        /// </summary>
        private Int32 userLvId = 0;
        [SugarColumn(IsNullable = false,  ColumnDescription = "商品会员价ID")]
        public Int32 UserLvId { get=>userLvId; set=>userLvId=value; }

        /// <summary>
        /// 商品ID
        /// </summary>
        private Int32 goodsId = 0;
        [SugarColumn(IsNullable = false, ColumnDescription = "商品ID")]
        public Int32 GoodsId { get => goodsId; set => goodsId = value; }

        /// <summary>
        /// 商品价格
        /// </summary>
        [SugarColumn(ColumnDescription = "商品价格",DecimalDigits =3)]
        public Decimal Price { get; set; }
    }
}
