using System;
using System.Collections.Generic;
using UnityEngine;

namespace CatSGS.Gameplay.Battle
{
    /// <summary>
    /// 武将数据
    /// </summary>
    [Serializable]
    public class GeneralData
    {
        /// <summary>
        /// 显示名称
        /// </summary>
        [Header("显示名称")]
        public string DisplayName;
        
        /// <summary>
        /// 内部名称
        /// </summary>
        [Header("内部名称")]
        public string InnerName;

        /// <summary>
        /// 性别
        /// </summary>
        [Header("性别")]
        public GenderType Gender;
        
        /// <summary>
        /// 势力
        /// </summary>
        [Header("势力")]
        public KingdomType kingdom;

        /// <summary>
        /// 体力上限
        /// </summary>
        [Header("体力上限")]
        public int MaxHP;
        
        /// <summary>
        /// 武将技能
        /// </summary>
        [Header("武将技能")]
        public List<string> Skills;
    }
}