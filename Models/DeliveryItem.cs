using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 发货单明细
    /// </summary>
    public class DeliveryItem
    {
        /// <summary>
        /// 发货单明细ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsIdentity = true, IsPrimaryKey = true, ColumnDescription = "发货单明细ID")]
        public Int32 DeliveryItemId { get; set; }

        /// <summary>
        /// 发货单Id
        /// </summary>
        private Int32 deliveryId = 0;
        [SugarColumn(ColumnDescription = "发货单Id", IsNullable = false)]
        public Int32 DeliveryId { get => deliveryId; set => deliveryId = value; }

        /// <summary>
        /// 货物类型 0一般货物 1礼品
        /// </summary>
        private Int32 deliveryItemType = 0;
        [SugarColumn(ColumnDescription = "货物类型 0一般货物 1礼品", IsNullable = false)]
        public Int32 DeliveryItemType { get => deliveryItemType; set => deliveryItemType = value; }

        /// <summary>
        /// 商品ID
        /// </summary>
        private Int32 goodsId = 0;
        [SugarColumn(ColumnDescription = "商品ID", IsNullable = false)]
        public Int32 GoodsId { get => goodsId; set => goodsId = value; }

        /// <summary>
        /// 商品编码
        /// </summary>
        [SugarColumn(ColumnDescription = "商品编码", Length = 40)]
        public String GoodsBn { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [SugarColumn(ColumnDescription = "商品名称", Length = 200)]
        public String GoodsName { get; set; }

        /// <summary>
        /// 发货数量
        /// </summary>
        private Int32 number = 0;
        [SugarColumn(ColumnDescription = "发货数量", IsNullable = false)]
        public Int32 Number { get => number; set => number = value; }

    }
}
