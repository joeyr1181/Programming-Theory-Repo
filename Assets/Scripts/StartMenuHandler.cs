using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StartMenuHandler : MonoBehaviour
{
    public TMP_InputField nameInputField;
    private string playerName;

    public void OnStartButtonClicked()
    {
        playerName = nameInputField.text;

        if (string.IsNullOrEmpty(playerName))
        {
            Debug.LogWarning("Please enter your name!");
            return;
        }

        PlayerPrefs.SetString("PlayerName", playerName);
        PlayerPrefs.Save();

        SceneManager.LoadScene("Main");
    }

    public void OnExitButtonClicked()
    {
        Debug.Log("Exiting the game...");
        Application.Quit();
    }
}
