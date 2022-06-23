namespace CatSGS.Gameplay.Battle
{
    /// <summary>
    /// 标准身份对局
    /// </summary>
    public class StandardBattle : BaseBattle
    {
        protected override void InitDrawPile()
        {
            //30张杀
            for (int i = 0; i < 30; i++)
            {
                CardData data = battleModule.GetCardData("sha");
                Card card = new Card(data,default,default);
                Table.PushCard(PileType.Draw,card);
            }
            
            //24张闪
            for (int i = 0; i < 24; i++)
            {
                CardData data = battleModule.GetCardData("shan");
                Card card = new Card(data,default,default);
                Table.PushCard(PileType.Draw,card);
            }
            
            //12张桃
            for (int i = 0; i < 12; i++)
            {
                CardData data = battleModule.GetCardData("tao");
                Card card = new Card(data,default,default);
                Table.PushCard(PileType.Draw,card);
            }
        }
    }
}