using UnityEngine;
using UnityEngine.SceneManagement;

public class DiffcultyChooser : MonoBehaviour
{
    [SerializeField] private string _backScene;
    
    // Difficulties
    public void Normies()
    {

    }

    public void Karbit()
    {

    }

    public void Elite()
    {

    }

    public void Acute()
    {

    }
    
    // Back to main menu
    public void Back()
    {
        SceneManager.LoadScene(_backScene);
    }
}
