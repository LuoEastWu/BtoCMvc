using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 用户
    /// </summary>
    public class User
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, IsNullable = false, ColumnDescription = "用户ID")]
        public Int64 UserId { get; set; }
        /// <summary>
        /// 用户角色
        /// </summary>
        [SugarColumn(IsNullable = false, ColumnDescription = "用户角色")]
        public Int16 UserRolesId { get; set; }

        /// <summary>
        /// 用户等级
        /// </summary>
        private Int16 userLvId = 0;
        [SugarColumn(IsNullable =false,ColumnDescription ="用户等级")]
        public Int16 UserLvId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [SugarColumn(IsNullable =false,Length =50,ColumnDescription ="用户名")]
        public String UserName { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [SugarColumn(Length =50,ColumnDescription ="用户姓名")]
        public String Name { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        [SugarColumn(Length =32,ColumnDescription ="密码")]
        public String Password { get; set; }
        /// <summary>
        /// 移动电话
        /// </summary>
        [SugarColumn(Length =30,ColumnDescription ="移动电话")]
        public String Mobile { get; set; }

        /// <summary>
        /// 固定电话
        /// </summary>
        [SugarColumn(Length =30,ColumnDescription ="固定电话")]
        public String Tel { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        [SugarColumn(Length =200,IsNullable =false,ColumnDescription ="邮箱")]
        public String Email { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        [SugarColumn(Length =20,ColumnDescription ="邮编")]
        public String Zip { get; set; }
        /// <summary>
        /// 国家
        /// </summary>
        [SugarColumn(Length =30,ColumnDescription ="国家")]
        public String Country { get; set; }
        /// <summary>
        /// 省份
        /// </summary>
        [SugarColumn(Length =20,ColumnDescription ="省份")]
        public String Province { get; set; }
        /// <summary>
        /// 城市
        /// </summary>
        [SugarColumn(Length =20,ColumnDescription ="城市")]
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
        /// 出生年月日
        /// </summary>
        [SugarColumn(ColumnDescription ="出生年月日")]
        public DateTime BornYMD { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        private Int16 sex = 0;
        [SugarColumn(IsNullable =false,ColumnDescription ="性别")]
        public Int16 Sex { get=>sex; set=>sex=value; }

        /// <summary>
        /// 用户积分
        /// </summary>
        private Int64 point = 0;
        [SugarColumn(IsNullable =false,ColumnDescription ="用户积分")]
        public Int64 Point { get=>point; set=>point=value; }
        /// <summary>
        /// 注册IP
        /// </summary>
        [SugarColumn(Length =16,ColumnDescription ="注册Ip")]
        public String RegIp { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        [SugarColumn(Length =10,ColumnDescription ="注册时间")]
        public Int32 RegTime { get; set; }
        /// <summary>
        /// 密码问题答案
        /// </summary>
        [SugarColumn(Length =250,ColumnDescription ="密码问题答案")]
        public String PasswordAnswer { get; set; }
        /// <summary>
        /// 密码问题
        /// </summary>
       [SugarColumn(Length =250,ColumnDescription ="密码问题")]
        public String PasswordQuestion { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        private Int16 orderNum = 0;
        [SugarColumn(IsNullable = false, ColumnDescription = "排序")]
        public Int16 OrderNum { get => orderNum; set => orderNum = value; }
        /// <summary>
        /// 备注
        /// </summary>
        [SugarColumn(ColumnDataType ="text",ColumnDescription ="备注")]
        public String Remark { get; set; }

        /// <summary>
        /// 登录次数
        /// </summary>
        private Int32 loginCount = 0;
        [SugarColumn(IsNullable =false,ColumnDescription ="登录次数")]
        public Int32 LoginCount { get => loginCount; set => loginCount = value; }

        /// <summary>
        /// 是否删除
        /// </summary>
        private Boolean disabled = false;
        [SugarColumn(ColumnDescription = "是否删除")]
        public Boolean Disabled { get => disabled; set => disabled = value; }


    }
}
