using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 订单
    /// </summary>
    public class Orders
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsIdentity = true, IsPrimaryKey = true, ColumnDescription = "订单ID")]
        public Int32 OrdersId { get; set; }



        /// <summary>
        ///会员ID
        /// </summary>
        [SugarColumn(ColumnDescription = "会员ID")]
        public Int64 UserId { get; set; }


        /// <summary>
        ///订单状态
        /// </summary>
        /// 
        private String status = "活动";
        [SugarColumn(ColumnDescription = "订单状态", IsNullable = false)]
        public String Status { get => status; set => status = value; }


        /// <summary>
        ///是否付款
        /// </summary>
        /// 
        private Boolean payStatus = false;
        [SugarColumn(ColumnDescription = "是否付款", IsNullable = false)]
        public Boolean PayStatus { get => payStatus; set => payStatus = value; }


        /// <summary>
        ///是否发货
        /// </summary>
        /// 
        private Boolean shipStatus = false;
        [SugarColumn(ColumnDescription = "是否发货", IsNullable = false)]
        public Boolean ShipStatus { get => shipStatus; set => shipStatus = value; }


        /// <summary>
        ///用户状态
        /// </summary>
        /// 
        private String userStatus = "无";
        [SugarColumn(ColumnDescription = "用户状态", IsNullable = false)]
        public String UserStatus { get => userStatus; set => userStatus = value; }


        /// <summary>
        ///是否交货
        /// </summary>
        /// 
        private Boolean isDelivery = false;
        [SugarColumn(ColumnDescription = "")]
        public Boolean IsDelivery { get => isDelivery; set => isDelivery = value; }

        /// <summary>
        ///配送方式的ID
        /// </summary>
        [SugarColumn(ColumnDescription = "配送方式的ID")]
        public Int32 DistributionTypeId { get; set; }


        /// <summary>
        ///配送名称
        /// </summary>
        [SugarColumn(ColumnDescription = "配送名称", Length = 50)]
        public String DistributionTypeName { get; set; }


        /// <summary>
        ///配送区域
        /// </summary>
        [SugarColumn(ColumnDescription = "配送区域")]
        public String ShippingArea { get; set; }


        /// <summary>
        ///付款金额
        /// </summary>
        [SugarColumn(ColumnDescription = "付款金额")]
        public Decimal Payment { get; set; }


        /// <summary>
        ///重量
        /// </summary>
        [SugarColumn(ColumnDescription = "重量", DecimalDigits = 3)]
        public String Weight { get; set; }


        /// <summary>
        ///商品属性如:商品名称+颜色+尺寸 商品与商品之间用逗号分隔
        /// </summary>
        [SugarColumn(ColumnDescription = "商品属性如:商品名称+颜色+尺寸 商品与商品之间用逗号分隔", ColumnDataType = "ntext")]
        public String Tostr { get; set; }


        /// <summary>
        ///购买商品总数量
        /// </summary>
        [SugarColumn(ColumnDescription = "购买商品总数量")]
        public Int32 Itemnum { get; set; }


        /// <summary>
        ///创建时间
        /// </summary>
        [SugarColumn(ColumnDescription = "创建时间")]
        public Int32 Createtime { get; set; }


        /// <summary>
        ///生成订单的Ip
        /// </summary>
        [SugarColumn(ColumnDescription = "生成订单的Ip", Length = 15)]
        public String Ip { get; set; }


        /// <summary>
        ///收货人姓名
        /// </summary>
        [SugarColumn(ColumnDescription = "收货人姓名", Length = 50)]
        public String shipName { get; set; }


        /// <summary>
        ///收货人地区
        /// </summary>
        [SugarColumn(ColumnDescription = "收货人地区", Length = 255)]
        public String shipArea { get; set; }


        /// <summary>
        ///收货人详细地址
        /// </summary>
        [SugarColumn(ColumnDescription = "收货人详细地址", Length = 100)]
        public String shipAddress { get; set; }


        /// <summary>
        ///收货人邮编
        /// </summary>
        [SugarColumn(ColumnDescription = "收货人邮编", Length = 20)]
        public String shipZip { get; set; }


        /// <summary>
        ///收货人电话
        /// </summary>
        [SugarColumn(ColumnDescription = "收货人电话", Length = 30)]
        public String shipTel { get; set; }


        /// <summary>
        ///收货人Email
        /// </summary>
        [SugarColumn(ColumnDescription = "收货人Email", Length = 150)]
        public String shipEmail { get; set; }


        /// <summary>
        ///收货时间
        /// </summary>
        [SugarColumn(ColumnDescription = "收货时间")]
        public DateTime shipTime { get; set; }


        /// <summary>
        ///收货人手机
        /// </summary>
        [SugarColumn(ColumnDescription = "收货人手机", Length = 50)]
        public String shipMobile { get; set; }


        /// <summary>
        ///商品总共花费金额
        /// </summary>
        /// 
        private Decimal costItem = 0.000m;
        [SugarColumn(ColumnDescription = "商品总共花费金额", IsNullable = false, DecimalDigits = 3)]
        public Decimal CostItem { get => costItem; set => costItem = value; }


        /// <summary>
        ///是否开发票
        /// </summary>
        /// 
        private Boolean isTax = false;
        [SugarColumn(ColumnDescription = "是否开发票", IsNullable = false)]
        public Boolean IsTax { get => isTax; set => isTax = value; }


        /// <summary>
        ///发票税率
        /// </summary>
        /// 
        private Decimal costTax = 0.000m;
        [SugarColumn(ColumnDescription = "发票税率", IsNullable = false)]
        public Decimal CostTax { get => costTax; set => costTax = value; }


        /// <summary>
        ///汇率成本
        /// </summary>
        [SugarColumn(ColumnDescription = "汇率成本", Length = 255)]
        public String TaxCompany { get; set; }


        /// <summary>
        ///货运汇率
        /// </summary>
        /// 
        private Decimal costFreight = 0.000m;
        [SugarColumn(ColumnDescription = "货运汇率", IsNullable = false, DecimalDigits = 3)]
        public Decimal CostFreight { get => costFreight; set => costFreight = value; }


        /// <summary>
        ///是否选择保价费率
        /// </summary>
        /// 
        private Boolean isProtect = false;
        [SugarColumn(ColumnDescription = "是否选择保价费率")]
        public Boolean IsProtect { get => isProtect; set => isProtect = value; }


        /// <summary>
        ///保险率
        /// </summary>
        /// 
        private Decimal costProtect = 0.000m;
        [SugarColumn(ColumnDescription = "保险率", DecimalDigits = 3, IsNullable = false)]
        public Decimal CostProtect { get => costProtect; set => costProtect = value; }




        /// <summary>
        ///货币
        /// </summary>
        [SugarColumn(ColumnDescription = "货币", Length = 8)]
        public String Currency { get; set; }
        /// <summary>
        ///货币汇率
        /// </summary>
        /// 
        private Decimal curRate = 1.0000m;
        [SugarColumn(ColumnDescription = "货币汇率", DecimalDigits = 4, IsNullable = false)]
        public Decimal CurRate { get => curRate; set => curRate = value; }


        /// <summary>
        ///折扣
        /// </summary>
        /// 
        private Decimal discount = 0.000m;
        [SugarColumn(ColumnDescription = "折扣", DecimalDigits = 3, IsNullable = false)]
        public Decimal Discount { get => discount; set => discount = value; }



        /// <summary>
        ///货币结算金额
        /// </summary>
        /// 
        private Decimal totalAmount = 0.000m;
        [SugarColumn(ColumnDescription = "货币结算金额", IsNullable = false, DecimalDigits = 3)]
        public Decimal TotalAmount { get => totalAmount; set => totalAmount = value; }


        /// <summary>
        ///订单总金额
        /// </summary>
        /// 
        private Decimal finalAmount = 0.000m;
        [SugarColumn(ColumnDescription = "订单总金额", IsNullable = false, DecimalDigits = 3)]
        public Decimal FinalAmount { get => finalAmount; set => finalAmount = value; }


        /// <summary>
        ///已付款金额
        /// </summary>
        /// 
        private Decimal payed = 0.000m;
        [SugarColumn(ColumnDescription = "已付款金额", DecimalDigits = 3)]
        public Decimal Payed { get => payed; set => payed = value; }


        /// <summary>
        ///记要
        /// </summary>
        [SugarColumn(ColumnDescription = "记要", ColumnDataType = "ntext")]
        public String Memo { get; set; }





        /// <summary>
        ///最后修改时间
        /// </summary>
        /// 
        private Int32 lastChangeTime = 0;
        [SugarColumn(ColumnDescription = "最后修改时间")]
        public Int32 LastChangeTime { get => lastChangeTime; set => lastChangeTime = value; }

        /// <summary>
        ///  是否删除
        /// </summary>
        private Boolean disabled = false;
        [SugarColumn(ColumnDescription = "是否删除", IsNullable = false)]
        public Boolean Disabled { get => disabled; set => disabled = value; }



    }
}
