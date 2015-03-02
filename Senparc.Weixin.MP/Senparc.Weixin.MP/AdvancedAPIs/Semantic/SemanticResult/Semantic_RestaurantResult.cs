﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Senparc.Weixin.MP.Entities;

namespace Senparc.Weixin.MP.AdvancedAPIs
{
    /// <summary>
    /// 餐馆服务（restaurant）
    /// </summary>
    public class Semantic_RestaurantResult : BaseSemanticResultJson
    {
        public Semantic_Details_Restaurant details { get; set; }
        /// <summary>
        /// SEARCH 普通查询
        /// </summary>
        public string intent { get; set; }
    }

    public class Semantic_Details_Restaurant
    {
        /// <summary>
        /// 地点
        /// </summary>
        public Semantic_Location location { get; set; }
        /// <summary>
        /// 餐馆名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 餐馆类型/菜系
        /// </summary>
        public string category { get; set; }
        /// <summary>
        /// 菜名
        /// </summary>
        public string special { get; set; }
        /// <summary>
        /// 价格（单位元）
        /// </summary>
        public Semantic_Number price { get; set; }
        /// <summary>
        /// 距离（单位米）
        /// </summary>
        public Semantic_Number radius { get; set; }
        /// <summary>
        /// 优惠信息：0无（默认），1优惠券，2团购
        /// </summary>
        public int coupon { get; set; }
        /// <summary>
        /// 排序类型：0距离（默认），1点评高优先级，2服务质量高优先级，3环境高优
        /// </summary>
        public int sort { get; set; }
    }
}