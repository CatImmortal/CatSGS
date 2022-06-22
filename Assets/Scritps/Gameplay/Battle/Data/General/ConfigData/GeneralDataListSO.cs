using System.Collections.Generic;
using UnityEngine;

namespace CatSGS.Gameplay.Battle
{
    /// <summary>
    /// 武将数据列表SO
    /// </summary>
    [CreateAssetMenu]
    public class GeneralDataListSO : ScriptableObject
    {
        /// <summary>
        /// 武将数据列表
        /// </summary>
        [Header("武将数据列表")]
        public List<GeneralData> Datas;
    }
}