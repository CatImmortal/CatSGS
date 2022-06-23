using System.Collections.Generic;
using System.Threading.Tasks;
using CatSGS.Framework;
using CatSGS.Framework.Asset;

namespace CatSGS.Gameplay.Battle
{
    /// <summary>
    /// 对局数据模块
    /// </summary>
    public class BattleModule : BaseDataModule
    {
        private string cardDataListName;
        private Dictionary<string,CardData> cardDataDict = new Dictionary<string, CardData>();
        
        public override void OnInit()
        {
            cardDataListName = "Assets/BundleRes/ScriptObjects/CardDataList.asset";
        }

        /// <summary>
        /// 加载对局相关数据文件
        /// </summary>
        public async Task LoadDataFile()
        {
            CardDataListSO cardDataListSO = await GameRoot.Asset.AwaitLoadAsset<CardDataListSO>(cardDataListName);
            cardDataDict.Clear();
            foreach (CardData data in cardDataListSO.Datas)
            {
                cardDataDict.Add(data.InnerName,data);
            }
        }
        
        /// <summary>
        /// 获取卡牌数据
        /// </summary>
        public CardData GetCardData(string innerName)
        {
            return cardDataDict[innerName];
        }
        
        
    }
}