using UnityEngine;
using UnityEngine.SceneManagement;

public class Title_ButtonManager : MonoBehaviour
{
    public string StartScene;

    public void StartButton()
    {
        SceneManager.LoadScene(StartScene);
    }

    public void QuitButton()
    {
        Debug.Log("Application Quitting...");
        Application.Quit();
    }

}
