using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    public void OnBackToMenuClicked()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
