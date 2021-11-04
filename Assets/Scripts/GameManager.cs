using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject draggingObject;
    public GameObject currentContainer;

    public static GameManager instance;

    private void Awake() 
    {
        instance = this;
    }
    public void PlaceObject()
    {
        // GetComponent<TreeHouseRows>().zombies = GetComponent<TreeHouseRows>().spawnPoint.zombies;
        
        if (draggingObject != null && currentContainer != null)
        {
            Instantiate(draggingObject.GetComponent<ObjectDragging>().spell.object_Game, currentContainer.transform);
            currentContainer.GetComponent<SpellContainer>().isFull = true;
        }
    }
}
