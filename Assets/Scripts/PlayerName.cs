using UnityEngine;
using System.Collections;
using TMPro;

public class PlayerName : MonoBehaviour
{

    public TMP_InputField PlayerNameText;
    private string Name;
    public TMP_Text PlayerTitle;

    void Start()
    {
        //Fetch the PlayerPref settings
        // SetPlayerNameTitle();
    }

    void SetPlayerNameTitle()
    {
        //Fetch name (string) from the PlayerPrefs (set these Playerprefs in another script). If no string exists, the default is "No Name"
        Name = PlayerNameText.text;
        PlayerPrefs.SetString("_nameImput", Name);
        
    }

    void GetPlayerNameTitle()
    {
        PlayerTitle.text = PlayerPrefs.GetString("_nameImput");
    }
}
