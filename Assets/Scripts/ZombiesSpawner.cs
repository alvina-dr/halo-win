using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiesSpawner : MonoBehaviour
{
    public List<GameObject> zombiesPrefabs;
    public List<Zombie> zombies;
    public int numberZombieDead = -10;
    public int numberAllZombie;
    public float time;

    void Start() {
        numberAllZombie = zombies.Count;
        numberZombieDead = 0;
    }

    private void Update() 
    {
        time = Time.timeSinceLevelLoad;
        foreach (Zombie zombie in zombies)    
        {
            if (zombie.isSpawned == false && zombie.spawnTime <= time)
            {
                zombie.Spawner = Random.Range(0, 3);
                GameObject zombieInstance = Instantiate(zombiesPrefabs[(int)zombie.zombieType], transform.GetChild(zombie.Spawner).transform);
                transform.GetChild(zombie.Spawner).GetComponent<SpawnPoint>().zombies.Add(zombieInstance);
                zombie.isSpawned = true;
                Debug.Log("Zombie spawn" + time);
            } 
        }
    }
}



