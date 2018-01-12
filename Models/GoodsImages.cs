using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Luo.Models
{
    /// <summary>
    /// 商品图片
    /// </summary>
    public class GoodsImages
    {
        /// <summary>
        /// 商品图片ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsIdentity = true, IsPrimaryKey = true, ColumnDescription = "商品图片ID")]
        public Int32 GoodsImagesId { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        private Int32 goodsId = 0;
        [SugarColumn(IsNullable = false, ColumnDescription = "商品ID")]
        public Int32 GoodsId { get => goodsId; set => goodsId = value; }


        /// <summary>
        ///图像原图
        /// </summary>
        [SugarColumn(ColumnDescription = "图像原图",Length =255,IsNullable =false)]
        public String Source { get; set; }

        /// <summary>
        ///  排序
        /// </summary>
        private Int16 orderNum = 0;
        [SugarColumn(ColumnDescription = "排序", IsNullable = false)]
        public Int16 OrderNum { get => orderNum; set => orderNum = value; }

        /// <summary>
        ///  宽
        /// </summary>
        private Int16 srcSizeWidth = 0;
        [SugarColumn(ColumnDescription = "宽", IsNullable = false)]
        public Int16 SrcSizeWidth { get => srcSizeWidth; set => srcSizeWidth = value; }

        /// <summary>
        ///  高
        /// </summary>
        private Int16 srcSizeHeight = 0;
        [SugarColumn(ColumnDescription = "宽", IsNullable = false)]
        public Int16 SrcSizeHeight { get => srcSizeHeight; set => srcSizeHeight = value; }

        /// <summary>
        /// 小图
        /// </summary>
        [SugarColumn(ColumnDescription = "小图", Length = 255)]
        public String Small { get; set; }

        /// <summary>
        /// 大图
        /// </summary>
        [SugarColumn(ColumnDescription = "大图", Length = 255)]
        public String Big { get; set; }

        /// <summary>
        /// 缩略图路径
        /// </summary>
        [SugarColumn(ColumnDescription = "缩略图路径", Length = 255)]
        public String Thumbnail { get; set; }

        /// <summary>
        ///  上传时间
        /// </summary>
        private Int16 upTime = 0;
        [SugarColumn(ColumnDescription = "上传时间", IsNullable = false)]
        public Int16 UpTime { get => upTime; set => upTime = value; }

        /// <summary>
        ///  最新更新时间
        /// </summary>
        private Int16 syncTime = 0;
        [SugarColumn(ColumnDescription = "最新更新时间", IsNullable = false)]
        public Int16 SyncTime { get => syncTime; set => syncTime = value; }


    }
}
