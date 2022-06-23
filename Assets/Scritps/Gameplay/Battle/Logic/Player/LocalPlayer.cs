namespace CatSGS.Gameplay.Battle
{
    /// <summary>
    /// 本地玩家
    /// </summary>
    public class LocalPlayer : BasePlayer
    {
        public override PlayerType PlayerType => PlayerType.Local;
    }
}