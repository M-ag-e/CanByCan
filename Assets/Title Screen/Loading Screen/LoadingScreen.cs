using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadingScreen : MonoBehaviour
{
    public GameObject loadingScreenObject;
    public Image loadingBarFill;
    public Image loadingSpinner;

    void Update()
    {
        loadingSpinner.transform.Rotate(0, 0, 420 * Time.deltaTime);
    }
    public void LoadScene(int SceneID)
    {
        StartCoroutine(LoadSceneAsync(SceneID));
    }
    IEnumerator LoadSceneAsync(int SceneID)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneID);
        loadingScreenObject.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress);
            loadingBarFill.fillAmount = progress;
            yield return null;
        }
    }
}
