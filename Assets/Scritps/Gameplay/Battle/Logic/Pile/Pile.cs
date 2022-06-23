using System.Collections.Generic;

namespace CatSGS.Gameplay.Battle
{
    /// <summary>
    /// 牌堆
    /// </summary>
    public class Pile
    {
        /// <summary>
        /// 一组牌
        /// </summary>
        private List<Card> cards = new List<Card>();

        /// <summary>
        /// 类型
        /// </summary>
        public PileType Type { get; }

        /// <summary>
        /// 持有者，若为空则是牌桌
        /// </summary>
        public BasePlayer Owner { get; }
        
        /// <summary>
        /// 数量
        /// </summary>
        public int Count => cards.Count;
        
        /// <summary>
        /// 是否为空牌堆
        /// </summary>
        public bool IsEmpty => cards.Count == 0;
        
        public Pile(PileType type,BasePlayer owner = null)
        {
            Type = type;
            Owner = owner;
        }
        
        /// <summary>
        /// 添加牌到牌堆顶端
        /// </summary>
        public void PushCard(Card card)
        {
            card.Pile = this;
            cards.Add(card);
        }
        
        /// <summary>
        /// 取走牌堆顶端的牌
        /// </summary>
        public Card PopCard()
        {
            return GetCard(Count - 1);
        }

        
        /// <summary>
        /// 查看牌堆的指定位置的牌
        /// </summary>
        public Card LookCard(int index)
        {
            return cards[index];
        }
        
        /// <summary>
        /// 从牌堆的指定位置取走牌
        /// </summary>
        public Card GetCard(int index)
        {
            Card card = cards[index];
            cards.RemoveAt(index);
            card.Pile = null;
            return card;
        }
        
        /// <summary>
        /// 插入牌到牌堆的指定位置
        /// </summary>
        public void InsertCard(int index,Card card)
        {
            card.Pile = this;
            cards.Insert(index,card);
        }

        /// <summary>
        /// 洗牌
        /// </summary>
        public void ShuffleCards()
        {
            
        }
    }
}