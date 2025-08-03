using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReloader : MonoBehaviour
{

    // This method reloads the current scene
    // It is useful for restarting the game or level
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // This method loads the main menu scene
    // It is called when the player wants to return to the main menu
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    // This method quits the game
    // It is called when the player wants to exit the game
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game"); // Only shows in editor
    }
}
