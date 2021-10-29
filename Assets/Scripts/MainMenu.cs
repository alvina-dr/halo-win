using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // public Animator transition;
    // public float transitionTime = 1f;
    public GameObject noDestroy;

    public void PlayGame (){
        noDestroy = GameObject.FindGameObjectWithTag("NoDestroy");
        Destroy(noDestroy);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

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
