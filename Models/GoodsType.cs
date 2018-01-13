using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 商品类型
    /// </summary>
    public class GoodsType
    {
        /// <summary>
        /// 类型ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsIdentity = true, IsPrimaryKey = true, ColumnDescription = "类型ID")]
        public Int32 GoodsTypeId { get; set; }

        /// <summary>
        ///  类型名称
        /// </summary>
        [SugarColumn(ColumnDescription = "类型名称",Length =100,IsNullable =false)]
        public String GoodsTypeName { get; set; }

        /// <summary>
        /// 类型别名
        /// </summary>
        [SugarColumn(ColumnDescription = "类型别名",ColumnDataType ="ntext")]
        public String GoodsTypeAlias { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        private Boolean disabled = false;
        [SugarColumn(ColumnDescription = "是否删除")]
        public Boolean Disabled { get => disabled; set => disabled = value; }


    }
}
