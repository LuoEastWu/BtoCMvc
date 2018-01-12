using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 地理信息
    /// </summary>
    public class Regions
    {
        /// <summary>
        /// 地理信息ID
        /// </summary>
        [SugarColumn(IsNullable =false,IsPrimaryKey =true,Length =10,IsIdentity =true,ColumnDescription ="地理信息ID")]
        public int RegionsId { get; set; }
        /// <summary>
        /// 父级地理信息ID
        /// </summary>
        [SugarColumn(Length =10,ColumnDescription ="父级地理信息ID")]
        public int ParentRegionsId { get; set; }
        /// <summary>
        /// 树状字符
        /// </summary>
        [SugarColumn(Length =255,ColumnDescription ="树状字符")]
        public String RegionPath { get; set; }
        /// <summary>
        /// 地区等级
        /// </summary>
        [SugarColumn(Length =8,ColumnDescription ="地区等级")]
        public Int16 RegionGrade { get; set; }

        /// <summary>
        /// 中文名称
        /// </summary>
        [SugarColumn(IsNullable =false,Length =50,ColumnDescription ="中文名称")]
        public String CN_Name { get; set; }
        /// <summary>
        /// 英文名称
        /// </summary>
        [SugarColumn(Length =50,ColumnDescription ="英文名称")]
        public String En_Name { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        [SugarColumn(ColumnDescription ="排序")]
        public Int16 OrderNum { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        private Boolean disabled = false;
        [SugarColumn(ColumnDescription ="是否删除")]
        public Boolean Disabled { get=>disabled; set=> disabled=value; }
    }
}
