using System.Threading.Tasks;
using UnityEngine;

namespace CatSGS.Framework.UI
{
    /// <summary>
    /// 可等待扩展
    /// </summary>
    public static class AwaitableExtension
    {
        /// <summary>
        /// 打开UI（可等待）
        /// </summary>
        public static Task<T> AwaitOpenUIPanel<T>(this UIManager self) where T : BaseUIPanel
        {
            TaskCompletionSource<T> tcs = new TaskCompletionSource<T>();
            self.OpenUIPanel<T>(uiPanel => tcs.SetResult(uiPanel));
            return tcs.Task;
        }

        /// <summary>
        /// 使用预制体名获取UIItem（可等待）
        /// </summary>
        public static Task<T> AwaitGetUIItem<T>(this UIManager self, string prefabName, Transform parent) where T : BaseUIItem
        {
            TaskCompletionSource<T> tcs = new TaskCompletionSource<T>();
            self.GetUIItem<T>(prefabName, parent, item => tcs.SetResult(item));
            return tcs.Task;
        }

        /// <summary>
        /// 使用模板获取UIItem（可等待）
        /// </summary>
        public static Task<T> AwaitGetUIItem<T>(this UIManager self, GameObject template, Transform parent) where T : BaseUIItem
        {
            TaskCompletionSource<T> tcs = new TaskCompletionSource<T>();
            self.GetUIItem<T>(template, parent, item => tcs.SetResult(item));
            return tcs.Task;
        }
    }
}
