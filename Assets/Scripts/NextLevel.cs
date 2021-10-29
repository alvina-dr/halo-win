using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevel : MonoBehaviour
{

    GameObject noDestroy;
    public void goToNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void goToMainMenu() {
        noDestroy = GameObject.FindGameObjectWithTag("NoDestroy");
        Destroy(noDestroy);
        SceneManager.LoadScene("MainMenu");
    }
    
}
