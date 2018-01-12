using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 商品
    /// </summary>
    public class Goods
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsIdentity = true, IsPrimaryKey = true, ColumnDescription = "商品ID")]
        public Int32 GoodsId { get; set; }

        /// <summary>
        ///  商品分类id
        /// </summary>
        private Int32 categoryId = 0;
        [SugarColumn(ColumnDescription = "商品分类id", IsNullable = false)]
        public Int32 CategoryId { get => categoryId; set => categoryId = value; }

        /// <summary>
        ///  商品类型ID
        /// </summary>
        private Int32 goodsTypeId = 0;
        [SugarColumn(ColumnDescription = "商品类型ID", IsNullable = false)]
        public Int32 GoodsTypeId { get => goodsTypeId; set => goodsTypeId = value; }
        /// <summary>
        /// 商品类别0 正常
        /// </summary>
        private Int32 goodsType = 0;
        [SugarColumn(ColumnDescription = "商品类别", IsNullable = false)]
        public Int32 GoodsType { get => goodsType; set => goodsType = value; }

        /// <summary>
        ///  商品品牌编号
        /// </summary>
        [SugarColumn(ColumnDescription = "商品品牌编号")]
        public Int32 BrandId { get; set; }

        /// <summary>
        ///商品品牌名称 
        /// </summary>
        [SugarColumn(ColumnDescription = "商品品牌名称", Length = 100)]
        public String BrandName { get; set; }

        /// <summary>
        ///  供应商Id
        /// </summary>
        private Int32 supplierId = 0;
        [SugarColumn(ColumnDescription = "供应商ID", IsNullable = false)]
        public Int32 SupplierId { get => supplierId; set => supplierId = value; }


        /// <summary>
        ///对应使用主图片在gimages中的编号
        /// </summary>
        [SugarColumn(ColumnDescription = "对应使用主图片在gimages中的编号", ColumnDataType = "ntext")]
        public String ImageDefault { get; set; }


        /// <summary>
        ///小图片路径
        /// </summary>
        [SugarColumn(ColumnDescription = "小图片路径", Length = 255)]
        public String SmallPic { get; set; }
        /// <summary>
        /// 大图路径
        /// </summary>
        [SugarColumn(ColumnDescription = "大图片路径", Length = 255)]
        public String BigPic { get; set; }
        /// <summary>
        /// 商品简介
        /// </summary>
        [SugarColumn(ColumnDescription = "商品简介", Length = 255)]
        public String Brief { get; set; }


        /// <summary>
        /// 商品详细介绍
        /// </summary>
        [SugarColumn(ColumnDescription = "商品简介", ColumnDataType = "ntext")]
        public String Intro { get; set; }
        /// <summary>
        /// 市场价格
        /// </summary>
        [SugarColumn(ColumnDescription = "市场价格", DecimalDigits = 3)]
        public Decimal Mktprice { get; set; }

        /// <summary>
        /// 成本价格
        /// </summary>
        private Decimal cost = 0.000m;
        [SugarColumn(ColumnDescription = "成本价格", DecimalDigits = 3, IsNullable = false)]
        public Decimal Cost { get => cost; set => cost = value; }
        /// <summary>
        /// 销售价格
        /// </summary>
        private Decimal price = 0.000m;
        [SugarColumn(ColumnDescription = "销售价格", DecimalDigits = 3, IsNullable = false)]
        public Decimal Price { get => price; set => price = value; }
        /// <summary>
        /// 商品编号
        /// </summary>
        [SugarColumn(ColumnDescription = "商品编号", Length = 200)]
        public String GoodsBn { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        [SugarColumn(ColumnDescription = "商品名称", Length = 200)]
        public String GoodsName { get; set; }
        /// <summary>
        /// 是否上架true上架/false下架
        /// </summary>
        private Boolean marketable = true;
        [SugarColumn(ColumnDescription = "是否上架true上架/false下架", IsNullable = false)]
        public Boolean Marketable { get => marketable; set => marketable = value; }
        /// <summary>
        /// 重量
        /// </summary>
        [SugarColumn(ColumnDescription = "重量", DecimalDigits = 3)]
        public Decimal Weight { get; set; }
        /// <summary>
        /// 计量单位
        /// </summary>
        [SugarColumn(ColumnDescription = "计量单位", Length = 20)]
        public String Unit { get; set; }
        /// <summary>
        /// 库存
        /// </summary>
        [SugarColumn(ColumnDescription = "库存")]
        public Int16 Store { get; set; }
        /// <summary>
        /// 库存地址
        /// </summary>
        [SugarColumn(ColumnDescription = "库存地址", Length = 255)]
        public String StorePlace { get; set; }
        /// <summary>
        /// 商品对应使用的规格字符串
        /// </summary>
        [SugarColumn(ColumnDescription = "商品对应使用的规格字符串", ColumnDataType = "ntext")]
        public String Spec { get; set; }

        /// <summary>
        ///  排序
        /// </summary>
        private Int16 orderNum = 0;
        [SugarColumn(ColumnDescription = "排序", IsNullable = false)]
        public Int16 OrderNum { get => orderNum; set => orderNum = value; }

        /// <summary>
        /// 上架时间
        /// </summary>
        [SugarColumn(ColumnDescription ="上架时间")]
        public Int32 Uptime { get; set; }
        /// <summary>
        /// 下架时间
        /// </summary>
        [SugarColumn(ColumnDescription = "下架时间")]
        public Int32 Downtime { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        [SugarColumn(ColumnDescription ="更新时间")]
        public Int32 LastModify { get; set; }

        /// <summary>
        ///  是否删除
        /// </summary>
        private Boolean disabled = false;
        [SugarColumn(ColumnDescription = "是否删除", IsNullable = false)]
        public Boolean Disabled { get => disabled; set => disabled = value; }


    }
}
