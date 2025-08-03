using UnityEngine;
using TMPro;

public class DisplayPlayerName : MonoBehaviour
{

    // Reference to the TextMeshPro component to display the player's name
    // This script displays the player's name on the UI
    // It retrieves the player's name from PlayerPrefs and sets it to the TextMeshPro component
    public TMP_Text playerNameText;

    // Start is called before the first frame update
    // This is where the player's name is retrieved from PlayerPrefs   
    void Start()
    {
        string playerName = PlayerPrefs.GetString("PlayerName", "Player");
        playerNameText.text = $"Player: {playerName}";
    }
}
