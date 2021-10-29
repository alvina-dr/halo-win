using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeHouse : MonoBehaviour
{

    //HEALTH OF TREEHOUSE
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    //LEVEL UP TREEHOUSE
    SpriteRenderer treeHouseCurrentSprite;
    public Sprite[] spriteArrayTreeHouse;
    public int houseLevel = 1;
    public int[] treehouseLevelCost;
    int levelUpCost = 500;
    public GameObject levelUpButton;

    //FIX TREEHOUSE
    int damageDealtTreeHouse;
    public GameObject fixButton;
    int fixTreeHouseCost = 0;

    //GAME OVER
    public GameObject gameOverMenu;

    GameObject noDestroy;
 
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        treeHouseCurrentSprite = this.gameObject.GetComponentInChildren<SpriteRenderer>();
        noDestroy = GameObject.FindGameObjectWithTag("NoDestroy");

    }

    void Update() {
        if (currentHealth < maxHealth) {
            fixButton.GetComponent<Button>().interactable = true;
        } else {
            fixButton.GetComponent<Button>().interactable = false;
        }
        if (noDestroy.GetComponent<CommonVariables>().candyCount < levelUpCost) {
            levelUpButton.GetComponent<Button>().interactable = false;
        } else {
            levelUpButton.GetComponent<Button>().interactable = true;
        }
    }

    public void ReceiveDamage(int damage)
    {
        currentHealth = currentHealth - damage;
         
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            gameOverMenu.SetActive(true);
            Destroy(this.gameObject);                    
        }
         
        healthBar.SetHealth(currentHealth);
    }

    public void LevelUpTreeHouse() {
        if (houseLevel <= 4) {
            if (noDestroy.GetComponent<CommonVariables>().candyCount >= levelUpCost) {
                noDestroy.GetComponent<CommonVariables>().subCandy(levelUpCost);
                treeHouseCurrentSprite.sprite = spriteArrayTreeHouse[houseLevel];
                levelUpCost = treehouseLevelCost[houseLevel-1];
                houseLevel += 1;
                maxHealth += houseLevel + 400;
                currentHealth = maxHealth;
                healthBar.SetMaxHealth(maxHealth);


            } else {
                //le joueur doit savoir qu'il n'a pas assez de bonbons
            }
        }
        if (houseLevel == 5){
            levelUpButton.GetComponent<Button>().interactable = false;
            levelUpCost = treehouseLevelCost[0];
            //activation de la mention max
        }

    }

    public void FixTreeHouse() {
        damageDealtTreeHouse = maxHealth - currentHealth;
        fixTreeHouseCost = damageDealtTreeHouse;
        if (noDestroy.GetComponent<CommonVariables>().candyCount >= fixTreeHouseCost) {
            currentHealth = maxHealth;
            noDestroy.GetComponent<CommonVariables>().subCandy(fixTreeHouseCost);
        }
    }
}
