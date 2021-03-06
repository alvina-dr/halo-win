using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpecialAttack : MonoBehaviour
{
    public GameObject shop;

    public GameObject bombZone; 
    public int bombDamage;
    public GameObject bombButton;

    public GameObject iceZone;
    public int iceDamage;
    public GameObject iceButton;

    public GameObject thunderZone;
    public int thunderDamage;
    public GameObject thunderButton;

    void Start () {
        bombZone.SetActive(false);
        iceZone.SetActive(false);
        thunderZone.SetActive(false);

        bombButton.SetActive(false);
        iceButton.SetActive(false);
        thunderButton.SetActive(false);

    }

    void Update() {
        if (shop.GetComponent<Shop>().bombActivated) {
            bombButton.SetActive(true);
        }
        if (shop.GetComponent<Shop>().iceActivated) {
            iceButton.SetActive(true);
        }
        if (shop.GetComponent<Shop>().thunderActivated) {
            thunderButton.SetActive(true);
        }
    }

        
    public void BombAttack() {
        bombZone.SetActive(true);
        StartCoroutine(BombAttackCoroutine());
    }

    public void IceAttack() {
        iceZone.SetActive(true);
        StartCoroutine(IceAttackCoroutine());
    }

    public void ThunderAttack() {
        thunderZone.SetActive(true);
        StartCoroutine(ThunderAttackCoroutine());
    }

    IEnumerator BombAttackCoroutine() {
        bombButton.GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(1); //temps de l'attaque
        bombZone.SetActive(false);
        yield return new WaitForSeconds(20); // temps de rechargement de l'attaque
        bombButton.GetComponent<Button>().interactable = true;



    }

    IEnumerator IceAttackCoroutine() {
        iceButton.GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(3); //temps de l'attaque
        iceZone.SetActive(false);
        yield return new WaitForSeconds(30); // temps de rechargement de l'attaque
        iceButton.GetComponent<Button>().interactable = true;


    }
    IEnumerator ThunderAttackCoroutine() {
        thunderButton.GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(3); // temps de l'attaque
        thunderZone.SetActive(false);
        yield return new WaitForSeconds(40); // temps de rechargement de l'attaque
        thunderButton.GetComponent<Button>().interactable = true;


    }


}
