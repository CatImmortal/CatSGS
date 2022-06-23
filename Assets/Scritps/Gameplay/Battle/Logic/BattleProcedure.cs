using System.Collections.Generic;
using CatSGS.Framework.FSM;
using UnityEngine;

namespace CatSGS.Gameplay.Battle
{
    /// <summary>
    /// 对局流程
    /// </summary>
    [ProcedureState]
    public class BattleProcedure : BaseState
    {

        public override void OnEnter()
        {
            StandardBattle battle = new StandardBattle();

            int playerNum = 10;
            List<BasePlayer> players = new List<BasePlayer>(playerNum);
            //随机抽一个本地玩家的牌桌序号
            int localPlayerIndex = Random.Range(0, playerNum);
            
            for (int i = 0; i < playerNum; i++)
            {
                if (i == localPlayerIndex)
                {
                    players.Add(new LocalPlayer());
                }
                else
                {
                    players.Add(new AIPlayer());
                }
                
             
            }
            battle.Start(players);
        }

        public override void OnUpdate(float deltaTime)
        {
        }

        public override void OnExit()
        {
        }
    }
}