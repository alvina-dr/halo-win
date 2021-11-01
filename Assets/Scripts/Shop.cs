using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    GameObject noDestroy;
    public GameObject bombButton;
    public GameObject thunderButton;
    public GameObject iceButton;
    public bool bombActivated;
    public bool thunderActivated;
    public bool iceActivated;

    public int bombPrice;
    public int thunderPrice;
    public int icePrice;


    public int candyCount;
    


    void Start() 
    {
        noDestroy = GameObject.FindGameObjectWithTag("NoDestroy");
    }
    

    void Update()
    {
        candyCount = noDestroy.GetComponent<CommonVariables>().candyCount;
        
        if (bombActivated) {
            bombButton.GetComponent<Button>().interactable = false;
        } else if (noDestroy.GetComponent<CommonVariables>().candyCount < bombPrice) {
            bombButton.GetComponent<Button>().interactable = false;
        } else {
            bombButton.GetComponent<Button>().interactable = true;
        }

        if (thunderActivated) {
            thunderButton.GetComponent<Button>().interactable = false;
        } else if (noDestroy.GetComponent<CommonVariables>().candyCount < thunderPrice) {
            thunderButton.GetComponent<Button>().interactable = false;
        } else {
            thunderButton.GetComponent<Button>().interactable = true;
        }

        if (iceActivated) {
            iceButton.GetComponent<Button>().interactable = false;
        } else if (noDestroy.GetComponent<CommonVariables>().candyCount < icePrice) {
            iceButton.GetComponent<Button>().interactable = false;
        } else {
            iceButton.GetComponent<Button>().interactable = true;
        }
    }
    
    public void BuyBomb()
    {
        noDestroy.GetComponent<CommonVariables>().subCandy(bombPrice);
        bombButton.GetComponent<Button>().interactable = false;
        bombActivated = true;
    }

    public void BuyThunder()
    {
        noDestroy.GetComponent<CommonVariables>().subCandy(thunderPrice);
        thunderButton.GetComponent<Button>().interactable = false;
        thunderActivated = true;
    }

    public void BuyIce()
    {
        noDestroy.GetComponent<CommonVariables>().subCandy(icePrice);
        iceButton.GetComponent<Button>().interactable = false;
        iceActivated = true;
    }












    // public bool buyItem;
    // public string Bomb;

    // public bool itemCollected;


    // void OnInputBuyItem(string itemName)
    // {
    //     if (buyItem == true)
    //     {
    //         switch(itemName) 
    //         {
    //             case Item.Bomb:
    //                 ReduceCandy();
    //                 break;
                    
    //             case Item.Thunder:
    //                 ReduceCandy();
    //                 break;

    //             case Item.Ice:
    //                 ReduceCandy();
    //                 break;

    //             default:
    //                 Debug.Log("Item non sélectionné.");
    //                 break;
    //         }
    //     }
    //     else 
    //     {

    //     }
    // }

    // void ReduceCandy()
    // {
    //     if (Item = Item.Bomb)
    //     {
    //         itemCollected = true;
    //         GetComponent<CommonVariables>().transform.candyCount(-500); 
    //     }
    //     else if (Item.Thunder)
    //     {
    //         itemCollected = true;
    //         GetComponent<CommonVariables>().transform.candyCount(-1500); 
    //     }
    //     else
    //     {
    //         itemCollected = true;
    //         GetComponent<CommonVariables>().transform.candyCount(-3000); 
    //     }
    // }


}
