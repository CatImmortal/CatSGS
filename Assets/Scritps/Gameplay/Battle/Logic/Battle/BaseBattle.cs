using System.Collections.Generic;
using CatSGS.Framework;
using UnityEngine;

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
            Table.ShuffleCards(PileType.Draw);
            Debug.Log("摸牌堆初始化并洗牌完毕");
            
            AllocIdentity();
            SelectGeneral();
            InitHandCard();
        }

        /// <summary>
        /// 初始化摸牌堆
        /// </summary>
        protected abstract void InitDrawPile();

        /// <summary>
        /// 分配身份
        /// </summary>
        protected abstract void AllocIdentity();

        /// <summary>
        /// 选择武将
        /// </summary>
        protected abstract void SelectGeneral();

        /// <summary>
        /// 分发起始手牌
        /// </summary>
        protected abstract void InitHandCard();
    }
}