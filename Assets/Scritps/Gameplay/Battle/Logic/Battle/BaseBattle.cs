using System.Collections.Generic;
using CatSGS.Framework;

namespace CatSGS.Gameplay.Battle
{
    /// <summary>
    /// 对局基类
    /// </summary>
    public abstract class BaseBattle
    {
        /// <summary>
        /// 对局数据模块
        /// </summary>
        protected BattleModule battleModule = GameRoot.GetDataModule<BattleModule>();

        /// <summary>
        /// 牌桌
        /// </summary>
        protected CardTable Table = new CardTable();
        
        /// <summary>
        /// 玩家列表
        /// </summary>
        protected List<BasePlayer> Players;

        /// <summary>
        /// 开始对局
        /// </summary>
        public void Start(List<BasePlayer> players)
        {
            Players = players;
            
            InitDrawPile();
        }

        /// <summary>
        /// 初始化摸牌堆
        /// </summary>
        protected abstract void InitDrawPile();


    }
}