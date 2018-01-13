using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 商品分类扩展属性
    /// </summary>
    public class GoodsCategoryExpandProperty
    {
        /// <summary>
        /// 商品分类扩展属性ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsIdentity = true, IsPrimaryKey = true, ColumnDescription = "商品分类扩展属性ID")]
        public Int32 GoodsCategoryExpandPropertyId { get; set; }

        /// <summary>
        ///  类型ID
        /// </summary>
        private Int32 goodstypeId = 0;
        [SugarColumn(ColumnDescription = "类型ID", IsNullable = false)]
        public Int32 GoodsTypeId { get => goodstypeId; set => goodstypeId = value; }

        /// <summary>
        ///  属性名称
        /// </summary>
        [SugarColumn(ColumnDescription = "属性名称", Length =50,IsNullable = false)]
        public String Name { get; set; }

        /// <summary>
        ///  属性别名
        /// </summary>
        [SugarColumn(ColumnDescription = "属性别名",Length =50, IsNullable = false)]
        public String Alias { get; set; }
        /// <summary>
        ///  规格显示方式select表示下拉显示 flat表示平铺显示
        /// </summary>
        private Int16 showType = 1;
        [SugarColumn(ColumnDescription = "规格显示方式0表示下拉显示 1表示平铺显示", IsNullable = false)]
        public Int16 ShowType { get => showType; set => showType = value; }

        /// <summary>
        /// 选择项可选值以逗号隔开
        /// </summary>
        [SugarColumn(ColumnDescription = "选择项可选值以逗号隔开", ColumnDataType = "ntext")]
        public Int32 Alues { get; set; }

        /// <summary>
        ///  是否显示
        /// </summary>
        private Boolean isShow = true;
        [SugarColumn(ColumnDescription = "是否显示", IsNullable = false)]
        public Boolean IsShow { get=> isShow; set=> isShow = value; }
        /// <summary>
        ///  排序
        /// </summary>
        private Int16 orderNum = 0;
        [SugarColumn(ColumnDescription = "排序", IsNullable = false)]
        public Int16 OrderNum { get=>orderNum; set=>orderNum=value; }
        /// <summary>
        ///  是否删除
        /// </summary>
        private Boolean disabled = false;
        [SugarColumn(ColumnDescription = "是否删除", IsNullable = false)]
        public Boolean Disabled { get=>disabled; set=>disabled=value; }
    }
}
