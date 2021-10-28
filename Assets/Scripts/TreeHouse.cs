using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeHouse : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    SpriteRenderer threeHouseCurrentSprite;
    public Sprite[] spriteArrayTreeHouse;
    public int houseLevel = 1;
 
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        threeHouseCurrentSprite = this.gameObject.GetComponentInChildren<SpriteRenderer>();
    }


    public void ReceiveDamage(int damage)
    {
        currentHealth = currentHealth - damage;
         
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Destroy(this.gameObject);                    
        }
         
        healthBar.SetHealth(currentHealth);
    }

    public void LevelUpTreeHouse() {
        if (houseLevel <= 4) {
            threeHouseCurrentSprite.sprite = spriteArrayTreeHouse[houseLevel];
            houseLevel += 1;
        }
    }
}
