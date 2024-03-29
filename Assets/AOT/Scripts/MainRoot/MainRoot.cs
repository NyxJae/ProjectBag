using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using YooAsset;

namespace NFramework
{
    /// <summary>
    ///     主入口 包含资源系统初始化 热更新初始化
    /// </summary>
    public class MainRoot : MonoBehaviour
    {
        private async void Start()
        {
            // 开始更新资源流程
            var operation = new PatchOperation();
            YooAssets.StartOperation(operation);
            await operation;

            Debug.Log("资源更新完毕");
            // 定义场景资源的路径
            var location = "Scenes_Bag";
            // 设置场景加载模式为单一模式，只有一个场景会被加载
            var sceneMode = LoadSceneMode.Single;
            // 定义一个标志位，用来决定是否加载进度到90%自动挂起，默认为false即不挂起
            var suspendLoad = false;
            // 调用加载场景的异步方法，传入场景路径、加载模式、是否暂停加载，返回一个场景句柄用于跟踪加载过程
            var handle = YooAssets.LoadSceneAsync(location, sceneMode, suspendLoad);
            // 等待场景加载完成
            await handle.ToUniTask();
            // 场景加载完成
            Debug.Log($"场景: {location} 加载完成");
        }
    }
}