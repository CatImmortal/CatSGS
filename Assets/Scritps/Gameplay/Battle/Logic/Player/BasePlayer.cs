using System.Collections.Generic;

namespace CatSGS.Gameplay.Battle
{
    /// <summary>
    /// 玩家基类
    /// </summary>
    public abstract class BasePlayer
    {
        /// <summary>
        /// 牌堆字典
        /// </summary>
        private Dictionary<PileType, Pile> pileDict = new Dictionary<PileType, Pile>();

        public BasePlayer()
        {
            pileDict.Add(PileType.Hand,new Pile(PileType.Hand,this));
            pileDict.Add(PileType.Judge,new Pile(PileType.Judge,this));
            pileDict.Add(PileType.Weapon,new Pile(PileType.Weapon,this));
            pileDict.Add(PileType.Defensive,new Pile(PileType.Defensive,this));
            pileDict.Add(PileType.OffensiveMount,new Pile(PileType.OffensiveMount,this));
            pileDict.Add(PileType.DefensiveMount,new Pile(PileType.DefensiveMount,this));
        }
        
        
    }
}