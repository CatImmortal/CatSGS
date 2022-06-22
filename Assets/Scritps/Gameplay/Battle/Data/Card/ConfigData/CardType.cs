namespace CatSGS.Gameplay.Battle
{
    /// <summary>
    /// 卡牌类型
    /// </summary>
    public enum CardType
    {
        /// <summary>
        /// 基本牌
        /// </summary>
        Fundamental = 100,
        
        /// <summary>
        /// 非延时锦囊牌
        /// </summary>
        NonDelayingStrategy = 200,
        
        /// <summary>
        /// 延时锦囊牌
        /// </summary>
        DelayingStrategy = 201,
        
        /// <summary>
        /// 武器牌
        /// </summary>
        Weapon = 300,
        
        /// <summary>
        /// 防具牌
        /// </summary>
        Defensive = 301,
        
        /// <summary>
        /// 进攻坐骑
        /// </summary>
        OffensiveMount = 310,
        
        /// <summary>
        /// 防御坐骑
        /// </summary>
        DefensiveMount = 311,
    }
}