using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiesSpawner : MonoBehaviour
{
    public List<GameObject> zombiesPrefabs;
    public List<Zombie> zombies;
    public int numberZombieDead = -10;
    public int numberAllZombie;

    void Start() {
        numberAllZombie = zombies.Count;
        numberZombieDead = 0;
    }

    private void Update() 
    {
        foreach (Zombie zombie in zombies)    
        {
            if (zombie.isSpawned == false && zombie.spawnTime <= Time.time)
            {
                zombie.Spawner = Random.Range(0, 3);
                GameObject zombieInstance = Instantiate(zombiesPrefabs[(int)zombie.zombieType], transform.GetChild(zombie.Spawner).transform);
                transform.GetChild(zombie.Spawner).GetComponent<SpawnPoint>().zombies.Add(zombieInstance);
                zombie.isSpawned = true;
            } 
        }
    }
}



