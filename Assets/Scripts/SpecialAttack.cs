using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        StartCoroutine(BombAttackCoroutine(5000));
    }

    public void IceAttack() {
        iceZone.SetActive(true);
        StartCoroutine(IceAttackCoroutine(5000));
    }

    public void ThunderAttack() {
        thunderZone.SetActive(true);
        StartCoroutine(ThunderAttackCoroutine(5000));
    }

    IEnumerator BombAttackCoroutine(int timeToWait) {
        yield return new WaitForSeconds(3); //temps de l'attaque
        Debug.Log("j'attend cinq secondes");
        bombZone.SetActive(false);

    }

    IEnumerator IceAttackCoroutine(int timeToWait) {
        yield return new WaitForSeconds(3); //temps de l'attaque
        Debug.Log("j'attend cinq secondes");
        iceZone.SetActive(false);

    }
    IEnumerator ThunderAttackCoroutine(int timeToWait) {
        yield return new WaitForSeconds(3); // temps de l'attaque
        Debug.Log("j'attend cinq secondes");
        thunderZone.SetActive(false);

    }


}
