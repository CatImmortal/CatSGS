using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CatSGS.Gameplay.Battle
{
    /// <summary>
    /// 卡牌数据
    /// </summary>
    [Serializable]
    public class CardData
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
        /// 类型
        /// </summary>
        [Header("类型")]
        public CardType Type;

        /// <summary>
        /// 技能名
        /// </summary>
        [Header("技能名")]
        public string SkillName;

        public override string ToString()
        {
            return DisplayName;
        }
    }
}

