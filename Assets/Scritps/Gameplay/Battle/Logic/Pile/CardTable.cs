using System.Collections.Generic;

namespace CatSGS.Gameplay.Battle
{
    /// <summary>
    /// 牌桌
    /// </summary>
    public class CardTable
    {
        /// <summary>
        /// 牌堆字典
        /// </summary>
        private Dictionary<PileType, Pile> pileDict = new Dictionary<PileType, Pile>()
        {
            {PileType.Draw,new Pile(PileType.Draw)},
            {PileType.Discard,new Pile(PileType.Discard)},
            {PileType.Process,new Pile(PileType.Process)},
        };

        /// <summary>
        /// 添加牌到指定牌堆顶端
        /// </summary>
        public void PushCard(PileType type, Card card)
        {
            pileDict[type].PushCard(card);
        }
    }
}