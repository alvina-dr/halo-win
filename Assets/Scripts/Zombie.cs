using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Zombie 
{
    public int spawnTime;
    public ZombieType zombieType;  
    public int Spawner;
    public bool RandomSpawn;
    public bool isSpawned;
}
    
public enum ZombieType
{
    Zombie_Simple,
    Zombie_Little,
    Zombie_Big
}

  
