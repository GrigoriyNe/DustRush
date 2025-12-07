using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Modules.Grih.SceneChanger
{
    public class SceneChangerScript : MonoBehaviour
    {
        private const string Sity = "Sity";
        private const string SampleScene = "SampleScene";

        [SerializeField] private Button _changeButton;

        private string _loadScene;

        public event Action<string> NewScene;

        public void Init(string loadScene)
        {
            _loadScene = loadScene; 
            
            if (SceneManager.GetActiveScene().name != _loadScene)
                SceneManager.LoadScene(_loadScene);

            
        }

        private void OnEnable()
        {
            _changeButton.onClick.AddListener(OnSceneChange);
        }

        private void OnDisable()
        {
            _changeButton.onClick.RemoveListener(OnSceneChange);
        }

        private void OnSceneChange()
        {
            if (SceneManager.GetActiveScene().name == Sity)
            {
                NewScene?.Invoke(SampleScene);
                SceneManager.LoadScene(SampleScene);
            }
            else if (SceneManager.GetActiveScene().name == SampleScene)
            {
                NewScene?.Invoke(Sity);
                SceneManager.LoadScene(Sity);
            }
        }

    }
}