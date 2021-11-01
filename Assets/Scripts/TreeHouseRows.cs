using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeHouseRows : MonoBehaviour
{
    public GameObject bullet;
    public GameObject toAttack;
    public float attackCooldown;
    public int damageValue;
    private float attackTime;
    public GameManager gameManager;
    public SpawnPoint spawnPoint;
    public List<GameObject> zombies;

    private void FixedUpdate()
    {
        damageValue = GameObject.FindGameObjectWithTag("Treehouse").GetComponent<TreeHouse>().treeHouseDamageValue;

        zombies = spawnPoint.getZombies();
        
        if (zombies.Count > 0)
        {
            float distance = 700;
            foreach (GameObject zombie in zombies)
            {
                float zombieDistance = Vector3.Distance(transform.position, zombie.transform.position);
                if (zombieDistance < distance)
                {
                    toAttack = zombie;
                    distance = zombieDistance;
                }
            }
        }
        else
        {
            toAttack = null;
        }

        if (toAttack != null)
        {
            if (attackTime <= Time.time)
            {
                GameObject bulletInstance = Instantiate(bullet);
                bulletInstance.transform.position = this.transform.position;
                bulletInstance.GetComponent<Bullets>().DamageValue = damageValue;
                attackTime = Time.time + attackCooldown;
            }
        }
    }

    public void RegisterNewZombie(GameObject newZombie) {
        zombies.Add(newZombie);
    }

    // public void zombieDetection()
    // {
    //     zombies = spawnPoint.zombies;
    // }
}
