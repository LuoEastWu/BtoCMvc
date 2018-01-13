using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 用户角色
    /// </summary>
    public class UserRoles
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        [SugarColumn(IsNullable =false,IsPrimaryKey =true,IsIdentity =true,ColumnDescription ="角色ID")]
        public Int16 RolesId { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        [SugarColumn(Length =100,IsNullable =false,ColumnDescription ="角色名称")]
        public String RolesName { get; set; }
        /// <summary>
        /// 角色编码
        /// </summary>
        [SugarColumn(Length = 100,IsNullable =false,ColumnDescription = "角色编码")]
        public String RolesCode { get; set; }
        /// <summary>
        /// 角色说明
        /// </summary>
        [SugarColumn(ColumnDataType = "text",ColumnDescription ="角色说明")]
        public String RolesMemo { get; set; }



        /// <summary>
        /// 是否删除
        /// </summary>
        private Boolean disabled=false;
        [SugarColumn(ColumnDataType = "bit", IsNullable = false, ColumnDescription = "是否删除")]
        public Boolean Disabled
        {
            get => disabled;
            set => disabled = value;
        }
       
       
    }
}