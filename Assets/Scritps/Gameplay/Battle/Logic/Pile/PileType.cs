namespace CatSGS.Gameplay.Battle
{
    /// <summary>
    /// 牌堆类型
    /// </summary>
    public enum PileType
    {
        None,
        
        /// <summary>
        /// 摸牌堆
        /// </summary>
        Draw,
        
        /// <summary>
        /// 弃牌堆
        /// </summary>
        Discard,
        
        /// <summary>
        /// 处理区
        /// </summary>
        Process,
        
        /// <summary>
        /// 手牌区
        /// </summary>
        Hand,
        
        /// <summary>
        /// 判定区
        /// </summary>
        Judge,
        
        /// <summary>
        /// 武器牌区
        /// </summary>
        Weapon,
        
        /// <summary>
        /// 防具牌区
        /// </summary>
        Defensive,
        
        /// <summary>
        /// 进攻坐骑牌区
        /// </summary>
        OffensiveMount,
        
        /// <summary>
        /// 防御坐骑牌区
        /// </summary>
        DefensiveMount,
    }
}