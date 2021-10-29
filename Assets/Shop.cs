using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public GameObject noDestroy;
    public GameObject bombButton;
    public GameObject thunderButton;
    public GameObject iceButton;
    public bool bombActivated;
    public bool thunderActivated;
    public bool iceActivated;
    public int candyCount;


    void Start() 
    {
        noDestroy = GameObject.FindGameObjectWithTag("NoDestroy");
    }
    

    void Update()
    {
        candyCount = noDestroy.GetComponent<CommonVariables>().candyCount;
        if (noDestroy.GetComponent<CommonVariables>().candyCount < 1000)
        {
            bombButton.GetComponent<Button>().interactable = false;
        }
        if (noDestroy.GetComponent<CommonVariables>().candyCount < 3000)
        {
            thunderButton.GetComponent<Button>().interactable = false;
        }
        if (noDestroy.GetComponent<CommonVariables>().candyCount < 10000)
        {
            iceButton.GetComponent<Button>().interactable = false;
        }
    }
    public void BuyBomb()
    {
        if (noDestroy.GetComponent<CommonVariables>().candyCount >= 1000)
        {
            noDestroy.GetComponent<CommonVariables>().subCandy(1000);
            bombButton.GetComponent<Button>().interactable = false;
            bombActivated = true;
        } 
        
        else if (noDestroy.GetComponent<CommonVariables>().candyCount < 1000)
        {
            bombButton.GetComponent<Button>().interactable = false;
        }
    }

    public void BuyThunder()
    {
        if (noDestroy.GetComponent<CommonVariables>().candyCount >= 3000)
        {
            noDestroy.GetComponent<CommonVariables>().subCandy(3000);
            thunderButton.GetComponent<Button>().interactable = false;
            thunderActivated = true;
        } 
    }

    public void BuyIce()
        {
            if (noDestroy.GetComponent<CommonVariables>().candyCount >= 10000)
            {
                noDestroy.GetComponent<CommonVariables>().subCandy(10000);
                iceButton.GetComponent<Button>().interactable = false;
                iceActivated = true;
            } 
            
            else if (noDestroy.GetComponent<CommonVariables>().candyCount < 10000)
            {
                iceButton.GetComponent<Button>().interactable = false;
            }
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
