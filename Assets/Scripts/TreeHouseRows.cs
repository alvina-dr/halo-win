using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeHouseRows : MonoBehaviour
{
    public GameObject bullet;
    public GameObject toAttack;
    public float attackCooldown;
    private float attackTime;
    public GameManager gameManager;
    public SpawnPoint spawnPoint;
    public List<GameObject> zombies;

    private void Update()
    {
        zombies = spawnPoint.getZombies();
        
        if (zombies.Count > 0)
        {
            float distance = 999;
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
                Instantiate(bullet, transform);
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
