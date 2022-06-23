
using System.Collections.Generic;
using UnityEngine;

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

        protected override void AllocIdentity()
        {
            int playerNum = Players.Count;
            
            List<IdentityType> identityTypes = new List<IdentityType>();
            
            //主公固定一位
            identityTypes.Add(IdentityType.Monarch);

            //忠臣
            identityTypes.Add(IdentityType.Minister);
            if (playerNum >= 7)
            {
                identityTypes.Add(IdentityType.Minister);
            }
            if (playerNum >= 9)
            {
                identityTypes.Add(IdentityType.Minister);
            }
            
            //反贼
            identityTypes.Add(IdentityType.Rebel);
            if (playerNum >= 5)
            {
                identityTypes.Add(IdentityType.Rebel);
            }
            if (playerNum >= 6)
            {
                identityTypes.Add(IdentityType.Rebel);
            }
            if (playerNum >= 8)
            {
                identityTypes.Add(IdentityType.Rebel);
            }
            
            //内奸
            identityTypes.Add(IdentityType.TurnCoat);
            if (playerNum >= 10)
            {
                identityTypes.Add(IdentityType.TurnCoat);
            }
            
            //分配身份
            int monarchIndex = 0;  //主公索引
            for (int i = 0; i < playerNum; i++)
            {
                int randomIndex = Random.Range(0, identityTypes.Count);
                Players[i].IdentityType = identityTypes[randomIndex];
                identityTypes.RemoveAt(randomIndex);

                if (Players[i].IdentityType == IdentityType.Monarch)
                {
                    monarchIndex = i;
                }
            }
        }

        protected override void SelectGeneral()
        {
            
        }

        protected override void InitHandCard()
        {
           
        }
    }
}