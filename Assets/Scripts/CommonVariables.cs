using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommonVariables : MonoBehaviour
{

    public int candyCount = 0;
    public Text candyCountText;
    public GameObject treeHouse;
    public Text candyBonusText;

    public int score;
    public string scoreString;
    public Text scoreTextWin;
    public Text scoreTextLose;
    
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        candyCountText.text = "" + candyCount;   
        scoreTextWin.text = "" + score;
        scoreTextLose.text = "" + score;
        candyBonusText.text = "" + GameObject.FindGameObjectWithTag("Spawner").GetComponent<ZombiesSpawner>().levelCandyBonus;

    }

    public void addCandy(int number) {
        candyCount += number;
    }

    public void subCandy(int number) {
        candyCount -= number;
    }

    public void addScore(int number) {
        score += number;
    }
    
    public void SetScore() {
        scoreString = "" + score;
        PlayerPrefs.SetString("_scoreImput", scoreString);
    }

    public void GetLevelBonus() {
        addCandy(GameObject.FindGameObjectWithTag("Spawner").GetComponent<ZombiesSpawner>().levelCandyBonus);
    }
}
