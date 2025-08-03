using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{

    // This method is called when the "Play" button is clicked
    // It loads the game scene to start the game
    public void OnBackToMenuClicked()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
