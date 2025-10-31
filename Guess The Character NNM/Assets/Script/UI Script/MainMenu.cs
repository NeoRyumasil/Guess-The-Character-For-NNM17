using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    [SerializeField] private string _playScene;
    [SerializeField] private string _optionScene;

    public void Play()
    {
        SceneManager.LoadScene(_playScene);
    }

    public void Option()
    {
        SceneManager.LoadScene(_optionScene);
    }

    public void Exit()
    {
        Application.Quit();
    }

}
