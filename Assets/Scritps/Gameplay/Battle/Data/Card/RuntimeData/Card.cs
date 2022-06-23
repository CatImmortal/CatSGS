using System.Drawing;
using CatSGS.Gameplay.Battle;

namespace CatSGS.Gameplay.Battle
{
    /// <summary>
    /// 卡牌运行时数据，代表游戏中的一张牌的实例
    /// </summary>
    public class Card
    {
        
        private static int guidFactory = 0;
        
        /// <summary>
        /// 全局唯一id
        /// </summary>
        public int GUID { get; }
        
        /// <summary>
        /// 卡牌数据
        /// </summary>
        public CardData Data{ get; }
        
        /// <summary>
        /// 花色
        /// </summary>
        public SuitType SuitType{ get; }
        
        /// <summary>
        /// 点数
        /// </summary>
        public int Point{ get; }
        
        /// <summary>
        /// 所在牌堆
        /// </summary>
        public Pile Pile{ get; set; }

        public Card(CardData data,SuitType suitType,int point)
        {
            GUID = guidFactory;
            guidFactory++;
            
            Data = data;
            SuitType = suitType;
            Point = point;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}