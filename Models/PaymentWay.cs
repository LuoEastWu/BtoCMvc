using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 支付方式
    /// </summary>
    public class PaymentWay
    {
        /// <summary>
        /// 支付方式ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsIdentity = true, IsPrimaryKey = true, ColumnDescription = "支付方式ID")]
        public Int32 PaymentWayId { get; set; }

        /// <summary>
        ///支付方式的名称
        /// </summary>
        [SugarColumn(ColumnDescription = "支付方式的名称", Length = 100)]
        public String CustomName { get; set; }

        /// <summary>
        ///支付方式
        /// </summary>
        [SugarColumn(ColumnDescription = "支付方式", IsNullable = false)]
        public String PayType { get; set; }

        /// <summary>
        ///配置信息
        /// </summary>
        [SugarColumn(ColumnDescription = "配置信息", ColumnDataType = "ntext")]
        public String Config { get; set; }


        /// <summary>
        ///支付利率
        /// </summary>
        /// 
        private Decimal fee = 0.00000m;
        [SugarColumn(ColumnDescription = "支付利率", DecimalDigits = 5, IsNullable = false)]
        public Decimal Fee { get => fee; set => fee = value; }

        /// <summary>
        ///描述
        /// </summary>
        [SugarColumn(ColumnDescription = "描述", ColumnDataType = "ntext")]
        public String Des { get; set; }


        /// <summary>
        ///客户号
        /// </summary>
        /// 
        private String memberId = "0";
        [SugarColumn(ColumnDescription = "客户号", ColumnDataType = "ntext")]
        public String MemberId { get => memberId; set => memberId = value; }

        /// <summary>
        ///密匙
        /// </summary>
        /// 
        private String privateKey = "0";
        [SugarColumn(ColumnDescription = "客户号", ColumnDataType = "ntext")]
        public String PrivateKey { get => privateKey; set => privateKey = value; }


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
    }
}
