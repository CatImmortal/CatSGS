using System.Collections.Generic;

namespace CatSGS.Gameplay.Battle
{
    /// <summary>
    /// 玩家基类
    /// </summary>
    public abstract class BasePlayer
    {
        /// <summary>
        /// 玩家类型
        /// </summary>
        public PlayerType PlayerType { get; }
        
        /// <summary>
        /// 身份类型
        /// </summary>
        public IdentityType IdentityType { get; set; }
        
        /// <summary>
        /// 武将数据
        /// </summary>
        public GeneralData General { get;}
        
        /// <summary>
        /// 当前体力
        /// </summary>
        public int CurrentHP { get; private set; }
        
        /// <summary>
        /// 最大体力
        /// </summary>
        public IntNumeric MaxHP { get; private set; } = new IntNumeric();
        
        /// <summary>
        /// 最大手牌数
        /// </summary>
        public IntNumeric MaxHandCardNum { get; private set; } = new IntNumeric();

        /// <summary>
        /// 摸牌阶段的摸牌数
        /// </summary>
        public IntNumeric DrawCardNum { get; private set; } = new IntNumeric();

        /// <summary>
        /// 牌堆字典
        /// </summary>
        private Dictionary<PileType, Pile> pileDict = new Dictionary<PileType, Pile>();

        public BasePlayer(PlayerType playerType)
        {
            PlayerType = playerType;

            //摸牌阶段默认摸2张牌
            DrawCardNum.BaseValue = 2;
            
            pileDict.Add(PileType.Hand,new Pile(PileType.Hand,this));
            pileDict.Add(PileType.Judge,new Pile(PileType.Judge,this));
            pileDict.Add(PileType.Weapon,new Pile(PileType.Weapon,this));
            pileDict.Add(PileType.Defensive,new Pile(PileType.Defensive,this));
            pileDict.Add(PileType.OffensiveMount,new Pile(PileType.OffensiveMount,this));
            pileDict.Add(PileType.DefensiveMount,new Pile(PileType.DefensiveMount,this));
        }
        
        
    }
}