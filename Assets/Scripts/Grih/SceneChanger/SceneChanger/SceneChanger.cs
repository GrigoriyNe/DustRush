using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using YG;

public class SceneChanger : MonoBehaviour
{
    private const string Sity = "Sity";
    private const string SampleScene = "SampleScene";

    [SerializeField] private Button _changeButton;

    private void Start()
    {
        if (SceneManager.GetActiveScene().name != YG2.saves.CurrentScene)
            SceneManager.LoadScene(YG2.saves.CurrentScene);

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
            YG2.saves.CurrentScene = SampleScene;
            YG2.SaveProgress();
            SceneManager.LoadScene(SampleScene);
        }
        else if (SceneManager.GetActiveScene().name == SampleScene)
        {
            YG2.saves.CurrentScene = Sity;
            YG2.SaveProgress();
            SceneManager.LoadScene(Sity);
        }
    }
}
