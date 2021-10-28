using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetPlayerName : MonoBehaviour
{
    public TMP_InputField PlayerNameText;

    // Start is called before the first frame update
    void Start()
    {
        // SetString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setName(){

        var nameKey = "";
        PlayerPrefs.SetString(nameKey, PlayerNameText.text);
    }



    // void GetString(string PlayerNameText, value Thiago)
    // {
    //     PlayerNameSelector.text = PlayerPrefs.GetString(PlayerNameText);
    //     Debug.Log (PlayerNameText);
    // }

    // public void SetString(string PlayerNameText, value Thiago)
    // {
    //     PlayerPrefs.SetString(PlayerNameText, PlayerNameSelector.text);
    //     Debug.Log (PlayerNameText);
    // }
}
