using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellContainer : MonoBehaviour
{
    public bool isFull;
    public GameManager gameManager;
    public Image backgroundImage;


    public void OnTriggerEnter2D(Collider2D collision) 
    {
        if (gameManager.draggingObject != null && isFull == false)
        {
            gameManager.currentContainer = this.gameObject;
            backgroundImage.enabled = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision) 
    {
        gameManager.currentContainer = null;
        backgroundImage.enabled = false;
    }
}
