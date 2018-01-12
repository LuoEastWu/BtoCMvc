using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 用户收货地址
    /// </summary>
    public class UserAddress
    {
        /// <summary>
        /// 收货地址ID
        /// </summary>
        [SugarColumn(IsNullable =false,IsPrimaryKey =true,IsIdentity =true,ColumnDescription ="收货地址ID")]
        public Int16 AddrId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        private Int64 userId = 0;
        [SugarColumn(IsNullable =false,ColumnDescription ="用户ID")]
        public Int64 UserId { get=>userId; set=>userId=value; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [SugarColumn(Length =50,ColumnDescription ="用户名称")]
        public String UserName { get; set; }
        /// <summary>
        /// 国家
        /// </summary>
        [SugarColumn(Length =30,ColumnDescription ="国家")]
        public String Country { get; set; }
        /// <summary>
        /// 省份
        /// </summary>
        [SugarColumn(Length =30,ColumnDescription ="省份")]
        public String Province { get; set; }
        /// <summary>
        /// 城市
        /// </summary>
        [SugarColumn(Length =50,ColumnDescription ="城市")]
        public String City { get; set; }
        /// <summary>
        /// 区县
        /// </summary>
        [SugarColumn(Length =255,ColumnDescription ="区县")]
        public String Area { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary>
        [SugarColumn(Length =255,ColumnDescription ="详细地址")]
        public String Address { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        [SugarColumn(Length =20,ColumnDescription ="邮编")]
        public String Zip { get; set; }
        /// <summary>
        /// 固定电话
        /// </summary>
        [SugarColumn(Length =30,ColumnDescription ="固定电话")]
        public String Tel { get; set; }
        /// <summary>
        /// 移动电话
        /// </summary>
        [SugarColumn(Length =30,ColumnDescription ="移动电话")]
        public String Mobile { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        private Boolean disabled = false;
        [SugarColumn(ColumnDescription ="是否删除")]
        public Boolean Disabled { get=>disabled; set=>disabled=value; }





    }
}
