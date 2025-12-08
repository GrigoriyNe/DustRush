using System;
using Modules.Grih.SceneChanger;

namespace Modules.Grih.SceneChanger.Public.Interfaces
{
    public interface ISceneChanger
    {
        public event Action<string> NewScene;

        public void Init(SceneChangerScript sceneChanger, string loadScene)
        {
            sceneChanger.Init(loadScene);
            sceneChanger.NewScene += OnNewScene;
        }

        public void OnNewScene(string value);
    }
}