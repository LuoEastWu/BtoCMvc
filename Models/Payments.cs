using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 收退款记录
    /// </summary>
    public class Payments
    {

        /// <summary>
        /// 收退款记录ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsIdentity = true, IsPrimaryKey = true, ColumnDescription = "收退款记录ID")]
        public Int32 PaymentId { get; set; }

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
        ///用户名 
        /// </summary>
        [SugarColumn(ColumnDescription = "用户名", Length = 50)]
        public String Account { get; set; }




        /// <summary>
        ///银行
        /// </summary>
        [SugarColumn(ColumnDescription = "银行", Length = 50)]
        public String Bank { get; set; }




        /// <summary>
        ///付款金额
        /// </summary>
        [SugarColumn(ColumnDescription = "付款金额", Length = 50)]
        public String PayAccount { get; set; }




        /// <summary>
        ///币种
        /// </summary>
        [SugarColumn(ColumnDescription = "币种", Length = 10)]
        public String Currency { get; set; }




        /// <summary>
        ///金额
        /// </summary>
        /// 
        private Decimal money = 0.000m;
        [SugarColumn(ColumnDescription = "金额", DecimalDigits = 3)]
        public Decimal Money { get => money; set => money = value; }




        /// <summary>
        ///汇率
        /// </summary>
        [SugarColumn(ColumnDescription = "汇率", DecimalDigits = 3)]
        public Decimal Paycost { get; set; }

        /// <summary>
        ///实际付款金额
        /// </summary>
        /// 
        private Decimal curMoney = 0.000m;
        [SugarColumn(ColumnDescription = "金额", DecimalDigits = 3, IsIdentity = false)]
        public Decimal CurMoney { get => curMoney; set => curMoney = value; }


        /// <summary>
        ///支付方式
        /// </summary>
        [SugarColumn(ColumnDescription = "支付方式", Length = 100)]
        public String Paymethod { get; set; }




        /// <summary>
        ///收/付款
        /// </summary>
        /// 
        private Boolean paymentsType = false;
        [SugarColumn(ColumnDescription = "收/付款", IsNullable = false)]
        public Boolean PaymentsType { get => paymentsType; set => paymentsType = value; }




        /// <summary>
        ///状态
        /// </summary>
        /// 
        private Int16 status = 0;
        [SugarColumn(ColumnDescription = "状态", IsNullable = false)]
        public Int16 Status { get => status; set => status = value; }




        /// <summary>
        ///备注 
        /// </summary>
        [SugarColumn(ColumnDescription = "备注", ColumnDataType = "ntext")]
        public String Memo { get; set; }









        /// <summary>
        ///单据编码
        /// </summary>
        [SugarColumn(ColumnDescription = "单据编码", Length = 30)]
        public String TradNo { get; set; }



        /// <summary>
        ///  是否删除
        /// </summary>
        private Boolean disabled = false;
        [SugarColumn(ColumnDescription = "是否删除", IsNullable = false)]
        public Boolean Disabled { get => disabled; set => disabled = value; }


    }
}
