using System.Collections.Generic;
using UnityEngine;

namespace CatSGS.Gameplay.Battle
{
    /// <summary>
    /// 卡牌数据列表SO
    /// </summary>
    [CreateAssetMenu]
    public class CardDataListSO : ScriptableObject
    {
        /// <summary>
        /// 卡牌数据列表
        /// </summary>
        [Header("卡牌数据列表")]
        public List<CardData> Datas;
    }
}