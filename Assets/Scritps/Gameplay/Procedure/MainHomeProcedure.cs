using CatSGS.Framework;
using CatSGS.Framework.FSM;
using CatSGS.Gameplay.Battle;

namespace CatSGS.Gameplay
{
    /// <summary>
    /// 主界面流程
    /// </summary>
    [ProcedureState]
    public class MainHomeProcedure : BaseState
    {
        public override void OnEnter()
        {
            GameRoot.ChangeProcedure<BattleProcedure>();
        }

        public override void OnUpdate(float deltaTime)
        {
        }

        public override void OnExit()
        {
        }
    }
}
