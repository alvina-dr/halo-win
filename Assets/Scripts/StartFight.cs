using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFight : MonoBehaviour
{

    Camera cameraObject;

    public GameObject phase1UI;
    public GameObject phase2UI;
    public GameObject spawner;

    public bool fight = false;
    
    void Start() {
        cameraObject = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        cameraObject.transform.position = new Vector3(-165, -20, -1);
        cameraObject.orthographicSize = 180f;
    }

    void Update() 
    {
        if (fight) {
            cameraObject.orthographicSize = Mathf.Lerp(cameraObject.orthographicSize, 270, 0.01f);
            cameraObject.transform.position = Vector3.MoveTowards(cameraObject.transform.position, new Vector3(0, 0, -1), 0.7f);
        } 
    }

    public void StartFightFunction()
    {
        fight = true;
        phase1UI.SetActive(false);
        phase2UI.SetActive(true);
        spawner.SetActive(true);




    }
}
