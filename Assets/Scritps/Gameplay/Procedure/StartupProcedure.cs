using CatSGS.Framework;
using CatSGS.Framework.FSM;
using CatSGS.Framework.Asset;
using CatSGS.Gameplay.Battle;

namespace CatSGS.Gameplay
{
    /// <summary>
    /// 启动流程
    /// </summary>
    [ProcedureState(true)]
    public class StartupProcedure : BaseState
    {
        public override async void OnEnter()
        {
#if UNITY_EDITOR
            if (GameRoot.Asset.IsEditorMode)
            {
                //编辑器下并且开启了编辑器资源模式 直接切换到主界面流程
                await GameRoot.GetDataModule<BattleModule>().LoadDataFile();
                GameRoot.ChangeProcedure<MainHomeProcedure>();
                return;
            }
#endif
            //否则需要先检查资源清单
            bool success = await GameRoot.Asset.AwaitCheckPackageManifest();
            if (success)
            {
                await GameRoot.GetDataModule<BattleModule>().LoadDataFile();
                GameRoot.ChangeProcedure<MainHomeProcedure>();
            }
        }

        public override void OnUpdate(float deltaTime)
        {
        }

        public override void OnExit()
        {
        }
    }
}
