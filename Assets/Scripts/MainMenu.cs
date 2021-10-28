using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    // public Animator transition;
    // public float transitionTime = 1f;


    public void PlayGame (){
<<<<<<< HEAD
        
        //StartCoroutine(SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
=======
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
>>>>>>> 4aa768a20c18f2dc520f7ac7b57172b07c3c3cd8
    }

    // IEnumerator LoadScene(int levelIndex){
    //     transition.SetTrigger("Start");

    //     yield return new WaitForSeconds(transitionTime);

    //     SceneManager.LoadScene(levelIndex);
    // }


    public void QuitGame (){

        Debug.Log ("QUITTER");
        Application.Quit();
    }
}
