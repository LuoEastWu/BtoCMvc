using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 商品规格分类
    /// </summary>
    public class GoodsSpecificationType
    {
        /// <summary>
        /// 商品规格分类ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsIdentity = true, IsPrimaryKey = true, ColumnDescription = "商品规格分类ID")]
        public Int32 SpecTypeId { get; set; }

        /// <summary>
        ///  规格分类名称
        /// </summary>
        [SugarColumn(ColumnDescription = "规格分类名称", Length = 50, IsNullable = false)]
        public String SpecTypeName { get; set; }

        /// <summary>
        ///  规格显示方式0表示下拉显示 1表示平铺显示
        /// </summary>
        private Int16 showType = 1;
        [SugarColumn(ColumnDescription = "规格显示方式0表示下拉显示 1表示平铺显示", IsNullable = false)]
        public Int16 SpecShowType { get => showType; set => showType = value; }

        /// <summary>
        ///  规格显示类型0表示文本显示1表示图片显示
        /// </summary>
        private Int16 specType = 0;
        [SugarColumn(ColumnDescription = "规格显示类型0表示文本显示1表示图片显示", IsNullable = false)]
        public Int16 SpecType { get => showType; set => showType = value; }

        /// <summary>
        /// 规格备注
        /// </summary>
        [SugarColumn(ColumnDescription = "规格备注", Length =50,IsNullable =false)]
        public String SpecMemo { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [SugarColumn(ColumnDescription ="最后修改时间")]
        public Int32 Lastmodify { get; set; }
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
