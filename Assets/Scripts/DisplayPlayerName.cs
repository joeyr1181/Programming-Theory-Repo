using UnityEngine;
using TMPro;

public class DisplayPlayerName : MonoBehaviour
{
    public TMP_Text playerNameText;

    void Start()
    {
        string playerName = PlayerPrefs.GetString("PlayerName", "Player");
        playerNameText.text = $"Player: {playerName}";
    }
}
