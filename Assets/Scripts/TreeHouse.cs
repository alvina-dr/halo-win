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
    int levelUpCost;
    public GameObject levelUpButton;
    public Text levelUpCostText;


    //FIX TREEHOUSE
    int damageDealtTreeHouse;
    public GameObject fixButton;
    int fixTreeHouseCost = 0;
    public Text fixTreeHouseCostText;

    //GAME OVER
    public GameObject gameOverMenu;
    public GameObject thiago;
    public GameObject uiInGame;

    GameObject noDestroy;

 
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        treeHouseCurrentSprite = this.gameObject.GetComponentInChildren<SpriteRenderer>();
        noDestroy = GameObject.FindGameObjectWithTag("NoDestroy");
        levelUpCost = treehouseLevelCost[0];
    }

    void Update() {
        if (currentHealth < maxHealth) {
            fixButton.GetComponent<Button>().interactable = true;
            damageDealtTreeHouse = maxHealth - currentHealth;
            fixTreeHouseCostText.text = "" + damageDealtTreeHouse;
        } else {
            fixButton.GetComponent<Button>().interactable = false;
            fixTreeHouseCostText.text = "";

        }
        if (houseLevel == 5) {
            levelUpButton.GetComponent<Button>().interactable = false;
            levelUpCostText.text = "";         
        } else {
            levelUpCostText.text = "" + levelUpCost; 
            if (noDestroy.GetComponent<CommonVariables>().candyCount < levelUpCost) {
                levelUpButton.GetComponent<Button>().interactable = false;
            } else {
                levelUpButton.GetComponent<Button>().interactable = true;
            }
        }
    }

    public void ReceiveDamage(int damage)
    {
        currentHealth = currentHealth - damage;
         
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            gameOverMenu.SetActive(true);
            thiago.SetActive(false);
            uiInGame.SetActive(false);
            Destroy(this.gameObject);                    
        }
         
        healthBar.SetHealth(currentHealth);
    }

    public void LevelUpTreeHouse() {
        if (houseLevel <= 4) {
            if (noDestroy.GetComponent<CommonVariables>().candyCount >= levelUpCost) {
                noDestroy.GetComponent<CommonVariables>().subCandy(levelUpCost);
                treeHouseCurrentSprite.sprite = spriteArrayTreeHouse[houseLevel];
                if (houseLevel == 4) {
                    levelUpCost = treehouseLevelCost[0];    
                } else {
                    levelUpCost = treehouseLevelCost[houseLevel];
                }
                houseLevel += 1;
                if (currentHealth == maxHealth) {
                    maxHealth += houseLevel * 100;
                    currentHealth = maxHealth;
                    healthBar.SetMaxHealth(maxHealth);
                    healthBar.SetHealth(currentHealth);
                } else {
                    maxHealth += houseLevel * 100;
                    healthBar.SetMaxHealth(maxHealth);
                    healthBar.SetHealth(currentHealth);
                }

            }
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
