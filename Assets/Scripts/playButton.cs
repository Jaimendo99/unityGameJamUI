using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string sceneToLoad = "Game";

    // Function to change the scene
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
