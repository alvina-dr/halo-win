using UnityEngine;
using System.Collections;
using TMPro;

public class PlayerName : MonoBehaviour
{

    public TMP_Text PlayerNameText;

    void Start()
    {
        //Fetch the PlayerPref settings
        SetPlayerNameTitle();
    }

    void SetPlayerNameTitle()
    {
        //Fetch name (string) from the PlayerPrefs (set these Playerprefs in another script). If no string exists, the default is "No Name"
        PlayerNameText.text = PlayerPrefs.GetString("Name", "Thiago");
    }
}
