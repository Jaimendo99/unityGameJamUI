using UnityEngine;

public class QuitGame : MonoBehaviour
{
    // Function to quit the game
    public void Quit()
    {
        // This will only work in standalone builds (not in the Unity Editor)
        #if UNITY_STANDALONE
            Application.Quit();
        #endif

        // For use in the Unity Editor
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
