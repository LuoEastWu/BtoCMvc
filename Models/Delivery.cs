using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 发货单
    /// </summary>
    public class Delivery
    {
        /// <summary>
        /// 发货单ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsIdentity = true, IsPrimaryKey = true, ColumnDescription = "发货单ID")]
        public Int32 DeliveryId { get; set; }

        /// <summary>
        ///订单ID
        /// </summary>
        [SugarColumn(ColumnDescription = "订单ID")]
        public Int32 OrderId { get; set; }

        /// <summary>
        ///用户ID
        /// </summary>
        [SugarColumn(ColumnDescription = "用户ID")]
        public Int64 UserId { get; set; }





        /// <summary>
        /// 运费
        /// </summary>
        private Decimal money = 0.000m;
        [SugarColumn(ColumnDescription = "运费", IsNullable = false)]
        public Decimal Money { get => money; set => money = value; }



        /// <summary>
        /// 配送类别
        /// </summary>
        private Int16 type = 0;
        [SugarColumn(ColumnDescription = "配送类别", IsNullable = false)]
        public Int16 Type { get => type; set => type = value; }

        /// <summary>
        /// 是否保单
        /// </summary>
        /// 
        private Boolean isProtect = false;
        [SugarColumn(ColumnDescription = "是否保单", IsNullable = false)]
        public Boolean IsProtect { get => isProtect; set => isProtect = value; }


        /// <summary>
        ///配送方式
        /// </summary>
        [SugarColumn(ColumnDescription = "配送方式", Length = 20)]
        public String DeliveryType { get; set; }


        /// <summary>
        ///物流
        /// </summary>
        [SugarColumn(ColumnDescription = "物流")]
        public Int32 LogisticsCorpId { get; set; }

        /// <summary>
        ///物流公司名
        /// </summary>
        [SugarColumn(ColumnDescription = "物流公司名", Length = 100)]
        public String LogisticsCorpName { get; set; }

        /// <summary>
        ///物流公司名
        /// </summary>
        [SugarColumn(ColumnDescription = "物流编码", Length = 50)]
        public String LogisticsCorpNo { get; set; }

        /// <summary>
        ///收货人 
        /// </summary>
        [SugarColumn(ColumnDescription = "收货人", Length = 50)]
        public String ShipName { get; set; }

        /// <summary>
        ///收货地区
        /// </summary>
        [SugarColumn(ColumnDescription = "收货地区", Length = 255)]
        public String ShipArea { get; set; }

        /// <summary>
        ///收货地址
        /// </summary>
        [SugarColumn(ColumnDescription = "收货地址", Length = 100)]
        public String ShipAddress { get; set; }

        /// <summary>
        ///收货邮编
        /// </summary>
        [SugarColumn(ColumnDescription = "收货邮编", Length = 20)]
        public String ShipZip { get; set; }

        /// <summary>
        ///收货固定电话
        /// </summary>
        [SugarColumn(ColumnDescription = "收货固定电话", Length = 30)]
        public String ShipTel { get; set; }

        /// <summary>
        ///收货移动电话
        /// </summary>
        [SugarColumn(ColumnDescription = "收货移动电话", Length = 30)]
        public String shipMobile { get; set; }

        /// <summary>
        ///收货邮箱
        /// </summary>
        [SugarColumn(ColumnDescription = "收货邮箱", Length = 150)]
        public String ShipEmail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [SugarColumn(ColumnDescription = "")]
        public String t_begin { get; set; }

        /// <summary>
        ///开始时间
        /// </summary>
        [SugarColumn(ColumnDescription = "开始时间")]
        public Int32 BeginTime { get; set; }

        /// <summary>
        ///结束时间
        /// </summary>
        [SugarColumn(ColumnDescription = "结束时间")]
        public Int32 EndTime { get; set; }

        /// <summary>
        ///制单人员
        /// </summary>
        [SugarColumn(ColumnDescription = "制单人员", Length = 50)]
        public Int32 OperatorName { get; set; }


        /// <summary>
        ///单据状态
        /// </summary>
        /// 
        private Int16 status = 0;
        [SugarColumn(ColumnDescription = "单据状态", IsNullable = false)]
        public Int16 Status { get => status; set => status = value; }

        /// <summary>
        ///备注
        /// </summary>
        [SugarColumn(ColumnDescription = "备注", ColumnDataType = "ntext")]
        public Int32 Memo { get; set; }

        /// <summary>
        ///  是否删除
        /// </summary>
        private Boolean disabled = false;
        [SugarColumn(ColumnDescription = "是否删除", IsNullable = false)]
        public Boolean Disabled { get => disabled; set => disabled = value; }
    }
}
