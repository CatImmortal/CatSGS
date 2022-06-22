using CatSGS.Gameplay.Battle;

namespace CatSGS.Gameplay.Battle
{
    /// <summary>
    /// 卡牌运行时数据，代表游戏中的一张牌的实例
    /// </summary>
    public class Card
    {
        /// <summary>
        /// 卡牌数据
        /// </summary>
        public CardData Data;
        
        /// <summary>
        /// 花色
        /// </summary>
        public SuitType SuitType;
        
        /// <summary>
        /// 点数
        /// </summary>
        public int Point;

        /// <summary>
        /// 持有者
        /// </summary>
        public BasePlayer Owner;

        /// <summary>
        /// 所在牌堆
        /// </summary>
        public Pile Pile;

        /// <summary>
        /// 是否为虚拟牌
        /// </summary>
        public bool IsVirtual;
        
        /// <summary>
        /// 虚拟牌对应的实体牌来源
        /// </summary>
        public Card VirtualSource;
        
        public Card(CardData data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}