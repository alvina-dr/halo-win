using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiesSpawner : MonoBehaviour
{
    public List<GameObject> zombiesPrefabs;
    public List<Zombie> zombies;

    private void Update() 
    {
        foreach (Zombie zombie in zombies)    
        {
            if (zombie.isSpawned == false && zombie.spawnTime <= Time.time)
            {
                GameObject zombieInstance = Instantiate(zombiesPrefabs[(int)zombie.zombieType], transform.GetChild(zombie.Spawner).transform);
                transform.GetChild(zombie.Spawner).GetComponent<SpawnPoint>().zombies.Add(zombieInstance);
                zombie.isSpawned = true;
            }
        }
    }
}



