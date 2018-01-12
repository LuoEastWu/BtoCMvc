using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 配送方式
    /// </summary>
    public class DistributionType
    {
        /// <summary>
        /// 配送方式ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsIdentity = true, IsPrimaryKey = true, ColumnDescription = "配送方式ID")]
        public Int32 DistributionTypeId { get; set; }


        /// <summary>
        ///配送方式名称
        /// </summary>
        [SugarColumn(ColumnDescription = "配送方式名称", Length = 50)]
        public String DistributionTypeName { get; set; }


        /// <summary>
        ///首重重量
        /// </summary>
        [SugarColumn(ColumnDescription = "首重重量")]
        public String Firstunit { get; set; }


        /// <summary>
        ///续重重量
        /// </summary>
        [SugarColumn(ColumnDescription = "续重重量")]
        public String Continueunit { get; set; }


        /// <summary>
        ///配送方式介绍
        /// </summary>
        [SugarColumn(ColumnDescription = "配送方式介绍")]
        public String Detail { get; set; }


        /// <summary>
        ///首重费用
        /// </summary>
        [SugarColumn(ColumnDescription = "首重费用", IsNullable = false)]
        public String Firstprice { get; set; }


        /// <summary>
        ///续重费用
        /// </summary>
        [SugarColumn(ColumnDescription = "续重费用", IsNullable = false)]
        public String Continueprice { get; set; }


        /// <summary>
        ///地区费用类型
        /// </summary>
        private Int32 type = 1;
        [SugarColumn(ColumnDescription = "地区费用类型")]
        public Int32 Type { get => type; set => type = value; }


        /// <summary>
        ///是否支持物流保价0不支持1
        /// </summary>
        private Int16 protect = 0;
        [SugarColumn(ColumnDescription = "")]
        public String Protect { get; set; }


        /// <summary>
        ///费率 保价费用为实际运输费用*费率
        /// </summary>
        [SugarColumn(ColumnDescription = "费率 保价费用为实际运输费用*费率", DecimalDigits = 3)]
        public float ProtectRate { get; set; }


        /// <summary>
        ///支持货到付款 0不支持1支持
        /// </summary>
        private Int16 hasCod = 0;
        [SugarColumn(ColumnDescription = "支持货到付款 0不支持1支持", IsNullable = false)]
        public Int16 HasCod { get => hasCod; set => hasCod = value; }


        /// <summary>
        ///最低报价费
        /// </summary>
        /// 
        private float minprice = 0.00f;
        [SugarColumn(ColumnDescription = "最低报价费", IsNullable = false)]
        public float Minprice { get => minprice; set => minprice = value; }

        /// <summary>
        ///物流公司ID
        /// </summary>
        private Int32 logisticsCorpId = 0;
        [SugarColumn(ColumnDescription = "物流公司ID", IsNullable = false)]
        public Int32 LogisticsCorpId { get => logisticsCorpId; set => logisticsCorpId = value; }


        /// <summary>
        ///是否启用
        /// </summary>
        private Int32 dtStatus = 1;
        [SugarColumn(ColumnDescription = "是否启用", IsNullable = false)]
        public Int32 DtStatus { get => dtStatus; set => dtStatus = value; }


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
