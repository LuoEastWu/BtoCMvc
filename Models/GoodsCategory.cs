using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 商品分类
    /// </summary>
    public class GoodsCategory
    {
        /// <summary>
        /// 商品分类ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsIdentity = true, IsPrimaryKey = true, ColumnDescription = "商品分类ID")]
        public Int32 CategoryId { get; set; }


        /// <summary>
        /// 父类id
        /// </summary>
        [SugarColumn(ColumnDescription = "父类id")]
        public Int32 ParentId { get; set; }

        /// <summary>
        /// 树状字符
        /// </summary>
        [SugarColumn(ColumnDescription = "树状字符",Length =100)]
        public String CategoryPath { get; set; }

        /// <summary>
        ///是否是子节点
        /// </summary>
        private Boolean isLeaf = false;
        [SugarColumn(ColumnDescription = "是否是子节点",IsNullable =false)]
        public Boolean IsLeaf { get=>isLeaf; set=>isLeaf=value; }

        /// <summary>
        ///  商品类型ID
        /// </summary>
        private Int32 goodstypeId = 0;
        [SugarColumn(ColumnDescription = "商品类型ID", IsNullable = false)]
        public Int32 GoodsTypeId { get => goodstypeId; set => goodstypeId = value; }

        /// <summary>
        /// 分类名称
        /// </summary>
        [SugarColumn(ColumnDescription = "分类名称",IsNullable =false,Length =100)]
        public String CategoryName { get; set; }

        /// <summary>
        /// 产品数量
        /// </summary>
        [SugarColumn(ColumnDescription = "产品数量")]
        public Int32 GoodsCount   { get; set; }


        /// <summary>
        ///  子节点数
        /// </summary>
        private Int32 childCount = 0;
        [SugarColumn(ColumnDescription = "子节点数", IsNullable = false)]
        public Int32 ChildCount { get => childCount; set => childCount = value; }

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
