using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommonVariables : MonoBehaviour
{

    public int candyCount = 0;
    public Text candyCountText;
    public GameObject treeHouse;

    public int score = 0;
    //public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        candyCountText.text = "" + candyCount;        
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
}
