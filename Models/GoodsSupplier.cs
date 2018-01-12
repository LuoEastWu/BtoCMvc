using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 商品供应商
    /// </summary>
    public class GoodsSupplier
    {
        /// <summary>
        /// 商品供应商ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsIdentity = true, IsPrimaryKey = true, ColumnDescription = "商品供应商ID")]
        public Int32 SupplierId { get; set; }

        /// <summary>
        ///供应商编码
        /// </summary>
        [SugarColumn(ColumnDescription = "供应商编码")]
        public Int32 SupplierCode { get; set; }

        /// <summary>
        ///供应商名称
        /// </summary>
        [SugarColumn(ColumnDescription = "供应商名称", Length = 100)]
        public String SupplierName { get; set; }

        /// <summary>
        ///营业执照编号
        /// </summary>
        [SugarColumn(ColumnDescription = "营业执照编号", Length = 100)]
        public String BusinessLicenseCode { get; set; }

        /// <summary>
        ///供应商类别
        /// </summary>
        [SugarColumn(ColumnDescription = "供应商类别")]
        public Int16 SupplierType { get; set; }


        /// <summary>
        ///企业类型
        /// </summary>
        [SugarColumn(ColumnDescription = "企业类型", Length = 100, IsNullable = false)]
        public String CompanyType { get; set; }



        /// <summary>
        ///行业类型
        /// </summary>
        [SugarColumn(ColumnDescription = "行业类型", Length = 100, IsNullable = false)]
        public String TradeType { get; set; }


        /// <summary>
        ///国家
        /// </summary>
        [SugarColumn(ColumnDescription = "国家", Length = 30)]
        public String Country { get; set; }

        /// <summary>
        ///省份
        /// </summary>
        [SugarColumn(ColumnDescription = "省份", Length = 30)]
        public String Province { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [SugarColumn(ColumnDescription = "城市", Length = 50)]
        public String City { get; set; }


        /// <summary>
        ///区县
        /// </summary>
        [SugarColumn(ColumnDescription = "区县", Length = 255)]
        public String Area { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [SugarColumn(ColumnDescription = "详细地址", Length = 255)]
        public String Address { get; set; }

        /// <summary>
        ///邮编
        /// </summary>
        [SugarColumn(ColumnDescription = "邮编", Length = 20)]
        public String zip { get; set; }


        /// <summary>
        ///固定电话
        /// </summary>
        [SugarColumn(ColumnDescription = "固定电话", Length = 30)]
        public String Tel { get; set; }


        /// <summary>
        ///移动电话
        /// </summary>
        [SugarColumn(ColumnDescription = "移动电话", Length = 30)]
        public String mobile { get; set; }

        /// <summary>
        ///注册金额
        /// </summary>
        [SugarColumn(ColumnDescription = "注册金额", Length = 20)]
        public Decimal RegisterMoney { get; set; }

        /// <summary>
        ///法人
        /// </summary>
        [SugarColumn(ColumnDescription = "法人", Length = 20)]
        public String Legal { get; set; }

        /// <summary>
        ///法人手机
        /// </summary>
        [SugarColumn(ColumnDescription = "法人手机", Length = 20)]
        public String LegalMobile { get; set; }

        /// <summary>
        ///法人邮箱
        /// </summary>
        [SugarColumn(ColumnDescription = "法人邮箱", Length = 20)]
        public String LegalEmail { get; set; }

        /// <summary>
        ///财务 
        /// </summary>
        [SugarColumn(ColumnDescription = "财务", Length = 20)]
        public String Finace { get; set; }

        /// <summary>
        ///财务手机
        /// </summary>
        [SugarColumn(ColumnDescription = "财务手机", Length = 20)]
        public String FinaceMobile { get; set; }

        /// <summary>
        ///财务固话
        /// </summary>
        [SugarColumn(ColumnDescription = "财务固话", Length = 20)]
        public String FinaceTel { get; set; }

        /// <summary>
        ///财务邮寄账单地址
        /// </summary>
        [SugarColumn(ColumnDescription = "财务邮寄账单地址", Length = 255)]
        public String FinaceAddress { get; set; }

        /// <summary>
        ///财务邮寄邮编
        /// </summary>
        [SugarColumn(ColumnDescription = "财务邮寄邮编", Length = 6)]
        public String FinaceZip { get; set; }


        /// <summary>
        ///财务邮箱
        /// </summary>
        [SugarColumn(ColumnDescription = "财务邮箱", Length = 20)]
        public String FinaceEmail { get; set; }


        /// <summary>
        ///财务备注
        /// </summary>
        [SugarColumn(ColumnDescription = "财务备注", Length = 255)]
        public String FinaceMemo { get; set; }

        /// <summary>
        ///开始时间
        /// </summary>
        [SugarColumn(ColumnDescription = "开始时间", ColumnDataType = "date")]
        public DateTime StartDate { get; set; }

        /// <summary>
        ///结束时间
        /// </summary>
        [SugarColumn(ColumnDescription = "结束时间", ColumnDataType = "date")]
        public DateTime EndDate { get; set; }

        /// <summary>
        ///最后更新时间
        /// </summary>
        [SugarColumn(ColumnDescription = "最后更新时间")]
        public Int32 UpdateTime { get; set; }

        /// <summary>
        /// 最后更新人
        /// </summary>
        [SugarColumn(ColumnDescription = "最后更新人")]
        public String UpdateName { get; set; }


        /// <summary>
        ///  是否删除
        /// </summary>
        private Boolean disabled = false;
        [SugarColumn(ColumnDescription = "是否删除", IsNullable = false)]
        public Boolean Disabled { get => disabled; set => disabled = value; }



    }
}
