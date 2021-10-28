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
>>>>>>> ea3125e1d06584106414231536a554e922e47e6e
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
