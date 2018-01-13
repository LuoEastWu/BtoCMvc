using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 订单商品明细
    /// </summary>
    public class OrderItems
    {
        /// <summary>
        /// 订单商品明细ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsIdentity = true, IsPrimaryKey = true, ColumnDescription = "订单商品明细ID")]
        public Int32 OrderItemsId { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        private Int32 orderId = 0;
        [SugarColumn(ColumnDescription = "订单ID", IsNullable =false)]
        public Int32 OrderId { get => orderId; set => orderId = value; }

        /// <summary>
        /// 商品ID
        /// </summary>
        private Int32 goodsId = 0;
        [SugarColumn(ColumnDescription = "商品ID", IsNullable = false)]
        public Int32 GoodsId { get => goodsId; set => goodsId = value; }

        /// <summary>
        /// 单据状态
        /// </summary>
        private Int32 dlyStatus = 0;
        [SugarColumn(ColumnDescription = "单据状态", IsNullable = false)]
        public Int32 DlyStatus { get => dlyStatus; set => dlyStatus = value; }
        /// <summary>
        /// 商品编码
        /// </summary>
        [SugarColumn(ColumnDescription ="商品编码",Length =40)]
        public String GoodsBn { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [SugarColumn(ColumnDescription = "商品名称", Length = 200)]
        public String GoodsName { get; set; }


        /// <summary>
        /// 价格合计
        /// </summary>
        [SugarColumn(ColumnDescription = "价格合计",DecimalDigits =3)]
        public Decimal Cost { get; set; }


        /// <summary>
        /// 商品单价
        /// </summary>
        private Decimal price = 0.000m;
        [SugarColumn(ColumnDescription = "商品单价", IsNullable = false)]
        public Decimal Price { get => price; set => price = value; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [SugarColumn(ColumnDescription = "商品数量", DecimalDigits = 3)]
        public Decimal Amount { get; set; }

        /// <summary>
        /// 商品类别
        /// </summary>
        private Int32 goodsTypeId=0;
        [SugarColumn(ColumnDescription = "商品类别")]
        public Int32 GoodsTypeId { get=> goodsTypeId; set=> goodsTypeId=value; }

        /// <summary>
        /// 积分数
        /// </summary>
        [SugarColumn(ColumnDescription = "积分数")]
        public Int16 Point { get; set; }


    }
}
