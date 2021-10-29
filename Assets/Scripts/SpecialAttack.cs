using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpecialAttack : MonoBehaviour
{
    public GameObject bombZone; 
    public int bombDamage;
    public GameObject bombButton;

    public GameObject iceZone;
    public int iceDamage;
    public GameObject iceButton;

    public GameObject thunderZone;
    public int thunderDamage;
    public GameObject thunderButton;

        
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
        yield return new WaitForSeconds(3); //temps de l'attaque
        bombZone.SetActive(false);
        yield return new WaitForSeconds(30); // temps de rechargement de l'attaque
        bombButton.GetComponent<Button>().interactable = false;



    }

    IEnumerator IceAttackCoroutine() {
        iceButton.GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(3); //temps de l'attaque
        iceZone.SetActive(false);
        yield return new WaitForSeconds(70); // temps de rechargement de l'attaque
        iceButton.GetComponent<Button>().interactable = false;


    }
    IEnumerator ThunderAttackCoroutine() {
        thunderButton.GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(3); // temps de l'attaque
        thunderZone.SetActive(false);
        yield return new WaitForSeconds(100); // temps de rechargement de l'attaque
        thunderButton.GetComponent<Button>().interactable = false;


    }


}
