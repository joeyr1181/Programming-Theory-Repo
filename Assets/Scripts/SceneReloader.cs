using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReloader : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("StartMenu"); // Make sure your main menu scene is named exactly this
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game"); // Only shows in editor
    }
}
