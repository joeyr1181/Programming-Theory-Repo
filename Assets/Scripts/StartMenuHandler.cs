using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StartMenuHandler : MonoBehaviour
{

    // This script handles the start menu functionality
    // It allows the player to enter their name and start the game or exit the application
    // Reference to the TextMeshPro input field for player name input
    // It retrieves the player's name from the input field when the start button is clicked
    public TMP_InputField nameInputField;
    private string playerName;


    // This method is called when the "Start" button is clicked
    // It retrieves the player's name from the input field and saves it to PlayerPrefs
    // If the name is empty, it displays a warning in the console
    // If the name is valid, it saves the name and loads the main game scene
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


    // This method is called when the "Exit" button is clicked
    // It logs a message to the console and exits the application
    // This is useful for debugging purposes, as the message will only appear in the editor
    public void OnExitButtonClicked()
    {
        Debug.Log("Exiting the game...");
        Application.Quit();
    }
}
