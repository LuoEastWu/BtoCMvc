using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 商品品牌
    /// </summary>
    public class GoodsBrand
    {
        /// <summary>
        /// 品牌ID
        /// </summary>
        [SugarColumn(IsNullable =false,IsIdentity =true,IsPrimaryKey =true,ColumnDescription ="品牌ID")]
        public Int32 BrandId { get; set; }
        /// <summary>
        /// 品牌名称
        /// </summary>
        [SugarColumn(ColumnDescription ="品牌名称",IsNullable =false,Length =50)]
        public String BrandName { get; set; }
        /// <summary>
        /// 品牌网站地址
        /// </summary>
        [SugarColumn(ColumnDescription = "品牌网站地址",Length =255)]
        public String BrandUrl { get; set; }
        /// <summary>
        /// 品牌描述
        /// </summary>
        [SugarColumn(ColumnDescription = "品牌描述", ColumnDataType = "ntext")]
        public String BrandDesc { get; set; }
        /// <summary>
        /// 品牌Logo图片地址
        /// </summary>
        [SugarColumn(ColumnDescription = "品牌Logo图片地址",Length =255)]
        public String BrandLogo { get; set; }
        /// <summary>
        /// 品牌关键字
        /// </summary>
        [SugarColumn(ColumnDescription = "品牌关键字", ColumnDataType = "ntext")]
        public String BrandKeywords { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        private Int16 orderNum = 0;
        [SugarColumn(IsNullable = false, ColumnDescription = "排序")]
        public Int16 OrderNum { get => orderNum; set => orderNum = value; }

        /// <summary>
        /// 是否删除
        /// </summary>
        private Boolean disabled = false;
        [SugarColumn(ColumnDescription = "是否删除")]
        public Boolean Disabled { get => disabled; set => disabled = value; }


    }
}
